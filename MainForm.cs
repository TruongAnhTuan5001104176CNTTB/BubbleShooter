using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace BubbleShooter
{
    public partial class MainForm : Form
    {
        // THÔNG TIN NHÓM (sửa lại cho đúng nhóm của bạn)
        internal const string GroupName = "HACKER";
        internal static readonly string[] Members =
        {
            "Lương Trường Thành - MSSV: 50.01.104.048",
            "Trương Anh Tuấn - MSSV: 50.01.104.176",
            "Trần Trọng Đức Huy - MSSV: 51.01.104.036",
            "Đoàn Quang Vinh - MSSV: 51.01.104.119"
        };

        // Hằng số
        private const int R = 20;
        private const int Cols = 12;
        private const int MaxRows = 14;
        private const int LoseRow = 12;
        private const int BoardW = Cols * 2 * R + R;   // 500
        private const int BoardH = 600;
        private const float Speed = 16f;
        private const int WinW = 900, WinH = 720;
        private static readonly float RowH = (float)(R * Math.Sqrt(3));

        internal static readonly Color[] Palette =
        {
            Color.FromArgb(240, 70, 70),   // đỏ
            Color.FromArgb(60, 130, 250),  // xanh dương
            Color.FromArgb(70, 200, 100),  // xanh lá
            Color.FromArgb(255, 205, 50),  // vàng
            Color.FromArgb(170, 100, 230), // tím
            Color.FromArgb(255, 145, 50)   // cam
        };
        internal static readonly string[] DiffName = { "Dễ", "Trung bình", "Khó" };
        internal static readonly string[] DiffDesc =
        {
            "4 màu bóng. Thanh thời gian 20 giây. Bắn trượt 8 lần thì lưới tụt.",
            "5 màu bóng. Thanh thời gian 15 giây. Bắn trượt 6 lần thì lưới tụt.",
            "6 màu bóng. Thanh thời gian 11 giây. Bắn trượt 4 lần thì lưới tụt."
        };

        // Font (đơn vị pixel để không lệch khi máy scale DPI)
        internal static readonly Font FTitle = new Font("Segoe UI", 52f, FontStyle.Bold, GraphicsUnit.Pixel);
        internal static readonly Font FH1 = new Font("Segoe UI", 30f, FontStyle.Bold, GraphicsUnit.Pixel);
        internal static readonly Font FMed = new Font("Segoe UI", 30f, FontStyle.Bold, GraphicsUnit.Pixel);
        internal static readonly Font FBody = new Font("Segoe UI", 16f, FontStyle.Regular, GraphicsUnit.Pixel);
        internal static readonly Color Dim = Color.FromArgb(185, 190, 225);

        // Màn hình
        private enum Scene { Menu, Playing, Settings, Scores, Help, About }
        private Scene scene = Scene.Menu;

        // Trạng thái
        private readonly int[,] grid = new int[MaxRows, Cols];
        private int parity;
        private int curColor, nextColor;
        private double angle = 90;
        private bool flying;
        private float fx, fy, vx, vy;
        private int flyColor;
        private int score, level, missCount, high;
        private int nColors, shotsPerRow, initRows, baseShotsPerRow, baseInitRows;
        private bool running, paused, gameOver, soundOn = true;
        private int diff = 0;
        private int dropMs, dropLeft, baseDropMs; // thanh thời gian: tối đa / còn lại / theo độ khó (ms)
        private int playMs;                        // tổng thời gian đã chơi (ms), dùng để tăng tốc độ rút giờ
        private string playerName = "Player";
        private string status = "";
        private int shownNext = -2;   // bóng tiếp theo đang hiện trong picNext (để chỉ vẽ lại khi đổi)
        private readonly Timer timer = new Timer { Interval = 16 };
        private readonly Random rnd = new Random();
        private static readonly Dictionary<int, Bitmap> sprites = new Dictionary<int, Bitmap>();
        private PointF Shooter { get { return new PointF(BoardW / 2f, BoardH - 45); } }

        public MainForm()
        {
            InitializeComponent();   // giao diện nằm trong MainForm.Designer.cs
            // ép đúng kích thước cửa sổ, phòng khi designer lưu lệch hoặc máy bị scale DPI
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(WinW, WinH);
            // cho phép phóng to: nội dung giữ nguyên 900 x 720 và được canh giữa màn hình
            MinimumSize = SizeFromClientSize(new Size(WinW, WinH));
            MaximizeBox = true;
            BackColor = Color.FromArgb(10, 6, 30);
            SizeChanged += (s, e) => CenterContent();
            Text = "Bubble Pop - " + GroupName;
            DoubleBuffered = true;
            timer.Tick += Timer_Tick;
            ClearGrid();
            high = ScoreManager.HighScore();
            WireScreens();
            ShowScene(Scene.Menu);
            UpdateHud();
            CenterContent();
        }

        // canh giữa các màn khi cửa sổ lớn hơn 900 x 720 (phóng to)
        private void CenterContent()
        {
            int x = Math.Max(0, (ClientSize.Width - WinW) / 2);
            int y = Math.Max(0, (ClientSize.Height - WinH) / 2);
            foreach (Control c in new Control[] { pnlStage, menuScreen, settingsScreen, scoresScreen, helpScreen, aboutScreen })
                c.Location = new Point(x, y);
        }

        private void WireScreens()
        {
            menuScreen.PlayClicked += (s, e) => StartFromMenu();
            menuScreen.ScoresClicked += (s, e) => ShowScores();
            menuScreen.SettingsClicked += (s, e) => ShowScene(Scene.Settings);
            menuScreen.HelpClicked += (s, e) => ShowScene(Scene.Help);
            menuScreen.AboutClicked += (s, e) => ShowScene(Scene.About);
            settingsScreen.BackClicked += (s, e) => ShowScene(Scene.Menu);
            settingsScreen.DiffChosen += d => SetDiff(d);
            settingsScreen.SoundToggled += (s, e) => ToggleSound(true);
            scoresScreen.BackClicked += (s, e) => ShowScene(Scene.Menu);
            helpScreen.BackClicked += (s, e) => ShowScene(Scene.Menu);
            aboutScreen.BackClicked += (s, e) => ShowScene(Scene.Menu);
        }

        // mỗi màn là một UserControl riêng, chỉ hiện màn đang dùng
        private void ShowScene(Scene s)
        {
            scene = s;
            menuScreen.Visible = s == Scene.Menu;
            settingsScreen.Visible = s == Scene.Settings;
            scoresScreen.Visible = s == Scene.Scores;
            helpScreen.Visible = s == Scene.Help;
            aboutScreen.Visible = s == Scene.About;
            bool play = s == Scene.Playing;
            pnlStage.Visible = play;

            if (!play) timer.Stop();
            UpdateSettingButtons();
        }

        private void ShowScores()
        {
            scoresScreen.ShowScores(ScoreManager.Load());
            ShowScene(Scene.Scores);
        }

        private void SetDiff(int d)
        {
            diff = d;
            UpdateSettingButtons();
        }

        private void UpdateSettingButtons()
        {
            settingsScreen.Diff = diff;
            settingsScreen.SoundOn = soundOn;
        }

        private void ToggleSound(bool click)
        {
            soundOn = !soundOn;
            UpdateSettingButtons();
            if (click) Beep("click");
        }


        //  VẼ NỀN / THẺ / MENU / HUD
        // vẽ chữ trong một khung (dùng cho lớp phủ TẠM DỪNG / GAME OVER trên bàn chơi)
        internal static void TextIn(Graphics g, string s, Font f, Color c, RectangleF r,
            StringAlignment h = StringAlignment.Near, StringAlignment v = StringAlignment.Near)
        {
            using (var sf = new StringFormat { Alignment = h, LineAlignment = v })
            using (var br = new SolidBrush(c))
                g.DrawString(s, f, br, r, sf);
        }

        // cập nhật các nhãn / thanh thời gian ở khung thông tin bên phải
        private void UpdateHud()
        {
            lblPlayer.Text = "Người chơi: " + playerName;
            lblScore.Text = score.ToString("N0");
            lblLevel.Text = level.ToString();
            lblHigh.Text = Math.Max(high, score).ToString("N0");
            lblDiff.Text = "ĐỘ KHÓ: " + DiffName[diff].ToUpper();
            lblStatus.Text = status;

            if (running)
            {
                lblTime.Text = "THỜI GIAN " + Math.Max(0, (dropLeft + 999) / 1000) + "s   RÚT x" + DrainRate().ToString("0.0");
                double ratio = dropMs > 0 ? Math.Max(0.0, Math.Min(1.0, (double)dropLeft / dropMs)) : 0.0;
                barTime.Value = ratio;
                barTime.BarColor = ratio < 0.3 ? Color.FromArgb(255, 90, 110) : Color.FromArgb(255, 165, 60);
            }
            else
            {
                lblTime.Text = "";
                barTime.Value = 0;
            }
            int wantNext = running ? nextColor : -1;
            if (wantNext != shownNext)
            {
                shownNext = wantNext;
                picNext.Invalidate();
            }
        }

        // bóng tiếp theo
        private void picNext_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                using (var br = new SolidBrush(Color.FromArgb(60, 255, 255, 255)))
                    g.FillEllipse(br, 1, 1, picNext.Width - 3, picNext.Height - 3);
                if (running) DrawBubble(g, picNext.Width / 2f, picNext.Height / 2f, nextColor, 26);
            }
            catch (Exception) { }
        }

        //  VẼ BÓNG (có cache sprite cho mượt)
        private static Bitmap GetSprite(int color, int radius)
        {
            int key = color * 1000 + radius;
            Bitmap bmp;
            if (sprites.TryGetValue(key, out bmp)) return bmp;

            int size = radius * 2 + 2;
            bmp = new Bitmap(size, size, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                float c = size / 2f;
                var rect = new RectangleF(c - radius + 1, c - radius + 1, radius * 2 - 2, radius * 2 - 2);
                Color baseC = Palette[color];
                using (var path = new GraphicsPath())
                {
                    path.AddEllipse(rect);
                    using (var pg = new PathGradientBrush(path))
                    {
                        pg.CenterPoint = new PointF(c - radius * 0.3f, c - radius * 0.35f);
                        pg.CenterColor = Gfx.Mix(baseC, Color.White, 0.55f);
                        pg.SurroundColors = new[] { Gfx.Mix(baseC, Color.Black, 0.3f) };
                        g.FillPath(pg, path);
                    }
                    using (var pen = new Pen(Color.FromArgb(90, 255, 255, 255), 1.2f)) g.DrawPath(pen, path);
                }
                using (var hl = new SolidBrush(Color.FromArgb(170, 255, 255, 255)))
                    g.FillEllipse(hl, c - radius * 0.55f, c - radius * 0.62f, radius * 0.5f, radius * 0.32f);
            }
            sprites[key] = bmp;
            return bmp;
        }

        internal static void DrawBubble(Graphics g, float x, float y, int color, int radius = R)
        {
            Bitmap bmp = GetSprite(color, radius);
            g.DrawImage(bmp, new Rectangle((int)Math.Round(x - bmp.Width / 2f), (int)Math.Round(y - bmp.Height / 2f),
                bmp.Width, bmp.Height));
        }

        private PointF CellPos(int r, int c)
        {
            return new PointF(R + c * 2 * R + (((r + parity) % 2 == 1) ? R : 0), R + r * RowH);
        }

        private void Board_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
                Rectangle rc = board.ClientRectangle;


                // vạch thua
                float loseY = CellPos(LoseRow, 0).Y - R;
                using (var pen = new Pen(Color.FromArgb(170, 255, 90, 110), 2) { DashStyle = DashStyle.Dash })
                    g.DrawLine(pen, 0, loseY, BoardW, loseY);

                // lưới bóng
                for (int r = 0; r < MaxRows; r++)
                    for (int c = 0; c < Cols; c++)
                        if (grid[r, c] >= 0)
                        {
                            PointF p = CellPos(r, c);
                            DrawBubble(g, p.X, p.Y, grid[r, c]);
                        }

                PointF s = Shooter;

                // tia ngắm
                if (running && !paused && !gameOver && !flying)
                {
                    double rad = angle * Math.PI / 180;
                    using (var pen = new Pen(Color.FromArgb(150, 255, 255, 255), 2.5f) { DashStyle = DashStyle.Dot })
                        g.DrawLine(pen, s.X, s.Y, s.X + (float)Math.Cos(rad) * 170, s.Y - (float)Math.Sin(rad) * 170);
                }

                // bệ bắn
                using (var br = new SolidBrush(Color.FromArgb(30, 255, 255, 255)))
                    g.FillEllipse(br, s.X - 34, s.Y - 34, 68, 68);
                using (var pen = new Pen(Color.FromArgb(80, 255, 255, 255), 1.5f))
                    g.DrawEllipse(pen, s.X - 34, s.Y - 34, 68, 68);

                if (running && !gameOver && !flying) DrawBubble(g, s.X, s.Y, curColor);
                if (flying) DrawBubble(g, fx, fy, flyColor);

                // lớp phủ tạm dừng / game over
                if (paused || gameOver)
                {
                    using (var br = new SolidBrush(Color.FromArgb(150, 10, 6, 30)))
                        g.FillRectangle(br, rc);
                    if (paused)
                        TextIn(g, "TẠM DỪNG", FH1, Color.White, new RectangleF(0, 0, BoardW, BoardH),
                            StringAlignment.Center, StringAlignment.Center);
                    else
                    {
                        TextIn(g, "GAME OVER", FTitle, Color.FromArgb(255, 110, 140),
                            new RectangleF(0, 190, BoardW, 70), StringAlignment.Center);
                        TextIn(g, "Điểm: " + score.ToString("N0"), FMed, Color.White,
                            new RectangleF(0, 275, BoardW, 44), StringAlignment.Center);
                        TextIn(g, "Bấm \"Chơi lại\" để thử lần nữa", FBody, Dim,
                            new RectangleF(0, 335, BoardW, 28), StringAlignment.Center);
                    }
                }
            }
            catch (Exception)
            {
                // tránh crash khi vẽ
            }
        }

        //  LOGIC GAME
        private void ClearGrid()
        {
            for (int r = 0; r < MaxRows; r++)
                for (int c = 0; c < Cols; c++)
                    grid[r, c] = -1;
        }

        private void StartFromMenu()
        {
            playerName = string.IsNullOrWhiteSpace(menuScreen.PlayerName) ? "Player" : menuScreen.PlayerName.Trim();
            ShowScene(Scene.Playing);
            StartGame();
        }

        private void StartGame()
        {
            try
            {
                switch (diff)
                {
                    case 0: nColors = 4; baseShotsPerRow = 8; baseInitRows = 4; baseDropMs = 20000; break;
                    case 1: nColors = 5; baseShotsPerRow = 6; baseInitRows = 5; baseDropMs = 15000; break;
                    default: nColors = 6; baseShotsPerRow = 4; baseInitRows = 6; baseDropMs = 11000; break;
                }
                score = 0; level = 1; playMs = 0;
                high = ScoreManager.HighScore();
                BuildLevel();
                running = true; paused = false; gameOver = false; flying = false;
                SetPauseButton("Tạm dừng");
                status = "Di chuột để ngắm, click để bắn.";
                timer.Start();
                Focus();
                board.Invalidate();
                UpdateHud();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể bắt đầu game: " + ex.Message);
            }
        }

        private void BuildLevel()
        {
            ClearGrid();
            parity = 0;
            missCount = 0;
            // vào màn mới thì thanh thời gian đầy lại
            dropMs = baseDropMs;
            dropLeft = dropMs;
            initRows = Math.Min(8, baseInitRows + (level - 1));
            shotsPerRow = Math.Max(3, baseShotsPerRow - (level - 1) / 2);
            for (int r = 0; r < initRows; r++)
                for (int c = 0; c < Cols; c++)
                    grid[r, c] = rnd.Next(nColors);
            curColor = PickColor();
            nextColor = PickColor();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                // thanh thời gian: chơi càng lâu càng rút nhanh, về 0 thì lưới tụt xuống 1 hàng
                if (running && !paused && !gameOver)
                {
                    playMs += timer.Interval;
                    dropLeft -= (int)(timer.Interval * DrainRate());
                    if (dropLeft <= 0)
                    {
                        if (!AddRow()) return;
                        status = "Hết giờ! Lưới bị đẩy xuống.";
                        if (IsLost()) { GameOver(); return; }
                        board.Invalidate();
                        UpdateHud();
                    }
                    UpdateHud();
                }

                if (!flying || paused) return;

                for (int i = 0; i < 4 && flying; i++)
                {
                    fx += vx / 4; fy += vy / 4;
                    if (fx < R) { fx = R; vx = -vx; }
                    else if (fx > BoardW - R) { fx = BoardW - R; vx = -vx; }

                    if (fy <= R) { fy = R; Land(); break; }

                    bool hit = false;
                    for (int r = 0; r < MaxRows && !hit; r++)
                        for (int c = 0; c < Cols; c++)
                        {
                            if (grid[r, c] < 0) continue;
                            PointF p = CellPos(r, c);
                            float dx = p.X - fx, dy = p.Y - fy;
                            if (dx * dx + dy * dy < (2 * R * 0.9f) * (2 * R * 0.9f)) { hit = true; break; }
                        }
                    if (hit) { Land(); break; }
                }
                board.Invalidate();
            }
            catch (Exception ex)
            {
                timer.Stop();
                running = false;
                MessageBox.Show("Lỗi trong vòng lặp game: " + ex.Message);
            }
        }

        private void Shoot()
        {
            if (!running || paused || gameOver || flying) return;
            double rad = angle * Math.PI / 180;
            fx = Shooter.X; fy = Shooter.Y;
            vx = (float)Math.Cos(rad) * Speed;
            vy = -(float)Math.Sin(rad) * Speed;
            flyColor = curColor;
            flying = true;
            Beep("shoot");
        }

        private void Land()
        {
            flying = false;
            int br = -1, bc = -1;
            float best = float.MaxValue;
            for (int r = 0; r < MaxRows; r++)
                for (int c = 0; c < Cols; c++)
                {
                    if (grid[r, c] >= 0) continue;
                    PointF p = CellPos(r, c);
                    float d = (p.X - fx) * (p.X - fx) + (p.Y - fy) * (p.Y - fy);
                    if (d < best) { best = d; br = r; bc = c; }
                }
            if (br < 0) { GameOver(); return; }

            grid[br, bc] = flyColor;
            int popped = PopMatches(br, bc);
            if (popped > 0)
            {
                // nổ bóng được hồi thời gian: mỗi bóng +0,4 giây (không vượt quá mức tối đa)
                dropLeft = Math.Min(dropMs, dropLeft + popped * 400);
                status = "Nổ " + popped + " bóng! +" + (popped * 4 / 10.0).ToString("0.0") + "s";
            }

            if (popped == 0)
            {
                missCount++;
                if (missCount >= shotsPerRow)
                {
                    missCount = 0;
                    if (!AddRow()) return;
                }
            }

            if (IsLost()) { GameOver(); return; }

            if (IsEmpty())
            {
                score += 200 * level;
                level++;
                Beep("level");
                BuildLevel();
                status = "Qua màn! Lên màn " + level;
                UpdateHud();
                return;
            }

            curColor = nextColor;
            nextColor = PickColor();
            UpdateHud();
        }

        private static readonly int[][] NeighborsEven = { new[] { 0, -1 }, new[] { 0, 1 }, new[] { -1, -1 }, new[] { -1, 0 }, new[] { 1, -1 }, new[] { 1, 0 } };
        private static readonly int[][] NeighborsOdd = { new[] { 0, -1 }, new[] { 0, 1 }, new[] { -1, 0 }, new[] { -1, 1 }, new[] { 1, 0 }, new[] { 1, 1 } };

        // lay cac o ke ben (X = cot, Y = hang)
        private List<Point> Neighbors(int r, int c)
        {
            List<Point> result = new List<Point>();
            int[][] offs;
            if ((r + parity) % 2 == 1) offs = NeighborsOdd;
            else offs = NeighborsEven;

            for (int i = 0; i < offs.Length; i++)
            {
                int nr = r + offs[i][0];
                int nc = c + offs[i][1];
                if (nr >= 0 && nr < MaxRows && nc >= 0 && nc < Cols)
                    result.Add(new Point(nc, nr));
            }
            return result;
        }

        private int PopMatches(int r, int c)
        {
            int color = grid[r, c];
            var group = new List<Point>();
            var seen = new bool[MaxRows, Cols];
            var stack = new Stack<Point>();
            stack.Push(new Point(c, r));
            seen[r, c] = true;
            while (stack.Count > 0)
            {
                Point p = stack.Pop();
                group.Add(p);
                foreach (Point n in Neighbors(p.Y, p.X))
                    if (!seen[n.Y, n.X] && grid[n.Y, n.X] == color)
                    {
                        seen[n.Y, n.X] = true;
                        stack.Push(n);
                    }
            }

            if (group.Count < 3) return 0;

            foreach (Point p in group) grid[p.Y, p.X] = -1;
            score += group.Count * 10;

            var connected = new bool[MaxRows, Cols];
            var st = new Stack<Point>();
            for (int cc = 0; cc < Cols; cc++)
                if (grid[0, cc] >= 0) { connected[0, cc] = true; st.Push(new Point(cc, 0)); }
            while (st.Count > 0)
            {
                Point p = st.Pop();
                foreach (Point n in Neighbors(p.Y, p.X))
                    if (!connected[n.Y, n.X] && grid[n.Y, n.X] >= 0)
                    {
                        connected[n.Y, n.X] = true;
                        st.Push(n);
                    }
            }
            int fallen = 0;
            for (int rr = 0; rr < MaxRows; rr++)
                for (int cc = 0; cc < Cols; cc++)
                    if (grid[rr, cc] >= 0 && !connected[rr, cc])
                    {
                        grid[rr, cc] = -1;
                        fallen++;
                    }
            score += fallen * 20;

            Beep(fallen > 0 ? "fall" : "pop");
            return group.Count + fallen;
        }

        private bool AddRow()
        {
            for (int c = 0; c < Cols; c++)
                if (grid[MaxRows - 1, c] >= 0) { GameOver(); return false; }

            for (int r = MaxRows - 1; r >= 1; r--)
                for (int c = 0; c < Cols; c++)
                    grid[r, c] = grid[r - 1, c];
            parity ^= 1;
            for (int c = 0; c < Cols; c++)
                grid[0, c] = rnd.Next(nColors);

            status = "Lưới bị đẩy xuống 1 hàng!";
            dropLeft = dropMs;
            Beep("drop");
            return true;
        }

        private bool IsLost()
        {
            for (int r = LoseRow; r < MaxRows; r++)
                for (int c = 0; c < Cols; c++)
                    if (grid[r, c] >= 0) return true;
            return false;
        }

        private bool IsEmpty()
        {
            for (int r = 0; r < MaxRows; r++)
                for (int c = 0; c < Cols; c++)
                    if (grid[r, c] >= 0) return false;
            return true;
        }

        private int PickColor()
        {
            var present = new List<int>();
            for (int r = 0; r < MaxRows; r++)
                for (int c = 0; c < Cols; c++)
                {
                    int v = grid[r, c];
                    if (v >= 0 && !present.Contains(v)) present.Add(v);
                }
            if (present.Count == 0) return rnd.Next(nColors);
            return present[rnd.Next(present.Count)];
        }

        private void GameOver()
        {
            timer.Stop();
            running = false; flying = false; gameOver = true;
            SetPauseButton("Chơi lại");
            status = "Game over! Điểm: " + score;
            Beep("over");
            SaveScore();
            board.Invalidate();
            UpdateHud();
        }

        private void SaveScore()
        {
            try
            {
                if (score <= 0) return;
                ScoreManager.Save(new ScoreEntry
                {
                    Name = playerName,
                    Score = score,
                    Difficulty = DiffName[diff],
                    Date = DateTime.Now.ToString("dd/MM/yy")
                });
                high = ScoreManager.HighScore();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu điểm: " + ex.Message);
            }
        }

        //  ÂM THANH
        // phát âm thanh theo tên (xem SoundFx.cs), chỉ phát khi đang bật âm thanh
        private void Beep(string name)
        {
            if (soundOn) SoundFx.Play(name);
        }


        //  SỰ KIỆN
        private void BtnPause_Click(object sender, EventArgs e)
        {
            if (gameOver) StartGame();
            else TogglePause();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            if (running)
            {
                timer.Stop();
                running = false;
                SaveScore();
            }
            ShowScene(Scene.Menu);
        }

        // Tốc độ rút thời gian: 1 lúc đầu, tăng dần theo thời gian chơi và theo màn (tối đa 4 lần)
        private double DrainRate()
        {
            double rate = 1 + playMs / 40000.0 + (level - 1) * 0.15;
            return Math.Min(rate, 4.0);
        }

        private void SetPauseButton(string text)
        {
            btnPause.Text = text;
            btnPause.Icon = text == "Tiếp tục" ? "play" : (text == "Chơi lại" ? "restart" : "pause");
        }

        private void TogglePause()
        {
            if (!running || gameOver) return;
            paused = !paused;
            SetPauseButton(paused ? "Tiếp tục" : "Tạm dừng");
            status = paused ? "Đang tạm dừng" : "Đang chơi...";
            board.Invalidate();
            UpdateHud();
        }

        private void SwapBubbles()
        {
            if (!running || paused || gameOver || flying) return;
            int t = curColor; curColor = nextColor; nextColor = t;
            board.Invalidate();
            UpdateHud();
        }

        private void Board_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (!running || paused || gameOver) return;
                double dx = e.X - Shooter.X, dy = Shooter.Y - e.Y;
                SetAngle(Math.Atan2(dy, dx) * 180 / Math.PI);
            }
            catch (Exception) { }
        }

        private void Board_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) Shoot();
            else if (e.Button == MouseButtons.Right) SwapBubbles();
        }

        private void SetAngle(double a)
        {
            angle = Math.Max(10, Math.Min(170, a));
            board.Invalidate();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            try
            {
                if (scene == Scene.Menu && keyData == Keys.Enter)
                {
                    StartFromMenu();
                    return true;
                }
                if (scene != Scene.Menu && scene != Scene.Playing && keyData == Keys.Escape)
                {
                    ShowScene(Scene.Menu);
                    return true;
                }
                if (scene == Scene.Playing)
                {
                    switch (keyData)
                    {
                        case Keys.Left: if (running && !paused) SetAngle(angle + 3); return true;
                        case Keys.Right: if (running && !paused) SetAngle(angle - 3); return true;
                        case Keys.Space:
                        case Keys.Up: Shoot(); return true;
                        case Keys.Down: SwapBubbles(); return true;
                        case Keys.P: TogglePause(); return true;
                        case Keys.M:
                            ToggleSound(false);
                            status = soundOn ? "Âm thanh: BẬT" : "Âm thanh: TẮT";
                            UpdateHud();
                            return true;
                    }
                }
            }
            catch (Exception) { }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
