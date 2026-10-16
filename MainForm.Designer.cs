namespace BubbleShooter
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlStage = new BubbleShooter.BackdropPanel();
            this.pnlBoardCard = new BubbleShooter.GlassPanel();
            this.board = new BubbleShooter.GamePanel();
            this.pnlHud = new BubbleShooter.GlassPanel();
            this.lblHudTitle = new BubbleShooter.GradientLabel();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblScoreCap = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblLevelCap = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblHighCap = new System.Windows.Forms.Label();
            this.lblHigh = new System.Windows.Forms.Label();
            this.lblDiff = new System.Windows.Forms.Label();
            this.lblNextCap = new System.Windows.Forms.Label();
            this.picNext = new System.Windows.Forms.PictureBox();
            this.barTime = new BubbleShooter.BarControl();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnPause = new BubbleShooter.GlowButton();
            this.btnMenu = new BubbleShooter.GlowButton();
            this.menuScreen = new BubbleShooter.MenuScreen();
            this.settingsScreen = new BubbleShooter.SettingsScreen();
            this.scoresScreen = new BubbleShooter.ScoresScreen();
            this.helpScreen = new BubbleShooter.HelpScreen();
            this.aboutScreen = new BubbleShooter.AboutScreen();
            this.SuspendLayout();
            //
            // pnlStage
            //
            this.pnlStage.Name = "pnlStage";
            this.pnlStage.Location = new System.Drawing.Point(0, 0);
            this.pnlStage.Size = new System.Drawing.Size(900, 720);
            //
            // pnlBoardCard
            //
            this.pnlBoardCard.Name = "pnlBoardCard";
            this.pnlBoardCard.Location = new System.Drawing.Point(28, 48);
            this.pnlBoardCard.Size = new System.Drawing.Size(524, 624);
            this.pnlBoardCard.Radius = 22;
            //
            // board
            //
            this.board.Name = "board";
            this.board.BackColor = System.Drawing.Color.FromArgb(24, 14, 60);
            this.board.Location = new System.Drawing.Point(12, 12);
            this.board.Size = new System.Drawing.Size(500, 600);
            this.board.TabIndex = 0;
            this.board.Paint += new System.Windows.Forms.PaintEventHandler(this.Board_Paint);
            this.board.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Board_MouseDown);
            this.board.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Board_MouseMove);
            //
            // pnlHud
            //
            this.pnlHud.Name = "pnlHud";
            this.pnlHud.Location = new System.Drawing.Point(570, 48);
            this.pnlHud.Size = new System.Drawing.Size(300, 624);
            this.pnlHud.Radius = 22;
            //
            // lblHudTitle
            //
            this.lblHudTitle.Name = "lblHudTitle";
            this.lblHudTitle.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblHudTitle.Location = new System.Drawing.Point(0, 14);
            this.lblHudTitle.Size = new System.Drawing.Size(300, 44);
            this.lblHudTitle.Text = "Bubble Pop";
            //
            // lblPlayer
            //
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.AutoSize = false;
            this.lblPlayer.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPlayer.ForeColor = System.Drawing.Color.FromArgb(185, 190, 225);
            this.lblPlayer.Location = new System.Drawing.Point(10, 62);
            this.lblPlayer.Size = new System.Drawing.Size(280, 22);
            this.lblPlayer.Text = "Người chơi: Player";
            this.lblPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lblScoreCap
            //
            this.lblScoreCap.Name = "lblScoreCap";
            this.lblScoreCap.AutoSize = false;
            this.lblScoreCap.BackColor = System.Drawing.Color.Transparent;
            this.lblScoreCap.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblScoreCap.ForeColor = System.Drawing.Color.FromArgb(185, 190, 225);
            this.lblScoreCap.Location = new System.Drawing.Point(0, 108);
            this.lblScoreCap.Size = new System.Drawing.Size(300, 18);
            this.lblScoreCap.Text = "ĐIỂM";
            this.lblScoreCap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lblScore
            //
            this.lblScore.Name = "lblScore";
            this.lblScore.AutoSize = false;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI", 46F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(0, 126);
            this.lblScore.Size = new System.Drawing.Size(300, 60);
            this.lblScore.Text = "0";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lblLevelCap
            //
            this.lblLevelCap.Name = "lblLevelCap";
            this.lblLevelCap.AutoSize = false;
            this.lblLevelCap.BackColor = System.Drawing.Color.Transparent;
            this.lblLevelCap.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblLevelCap.ForeColor = System.Drawing.Color.FromArgb(185, 190, 225);
            this.lblLevelCap.Location = new System.Drawing.Point(10, 200);
            this.lblLevelCap.Size = new System.Drawing.Size(135, 18);
            this.lblLevelCap.Text = "MÀN";
            this.lblLevelCap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lblLevel
            //
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.AutoSize = false;
            this.lblLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblLevel.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblLevel.ForeColor = System.Drawing.Color.White;
            this.lblLevel.Location = new System.Drawing.Point(10, 218);
            this.lblLevel.Size = new System.Drawing.Size(135, 42);
            this.lblLevel.Text = "1";
            this.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lblHighCap
            //
            this.lblHighCap.Name = "lblHighCap";
            this.lblHighCap.AutoSize = false;
            this.lblHighCap.BackColor = System.Drawing.Color.Transparent;
            this.lblHighCap.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblHighCap.ForeColor = System.Drawing.Color.FromArgb(185, 190, 225);
            this.lblHighCap.Location = new System.Drawing.Point(155, 200);
            this.lblHighCap.Size = new System.Drawing.Size(135, 18);
            this.lblHighCap.Text = "KỶ LỤC";
            this.lblHighCap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lblHigh
            //
            this.lblHigh.Name = "lblHigh";
            this.lblHigh.AutoSize = false;
            this.lblHigh.BackColor = System.Drawing.Color.Transparent;
            this.lblHigh.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblHigh.ForeColor = System.Drawing.Color.FromArgb(255, 215, 0);
            this.lblHigh.Location = new System.Drawing.Point(155, 218);
            this.lblHigh.Size = new System.Drawing.Size(135, 42);
            this.lblHigh.Text = "0";
            this.lblHigh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lblDiff
            //
            this.lblDiff.Name = "lblDiff";
            this.lblDiff.AutoSize = false;
            this.lblDiff.BackColor = System.Drawing.Color.Transparent;
            this.lblDiff.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblDiff.ForeColor = System.Drawing.Color.FromArgb(185, 190, 225);
            this.lblDiff.Location = new System.Drawing.Point(0, 276);
            this.lblDiff.Size = new System.Drawing.Size(300, 18);
            this.lblDiff.Text = "ĐỘ KHÓ: DỄ";
            this.lblDiff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lblNextCap
            //
            this.lblNextCap.Name = "lblNextCap";
            this.lblNextCap.AutoSize = false;
            this.lblNextCap.BackColor = System.Drawing.Color.Transparent;
            this.lblNextCap.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblNextCap.ForeColor = System.Drawing.Color.FromArgb(185, 190, 225);
            this.lblNextCap.Location = new System.Drawing.Point(0, 322);
            this.lblNextCap.Size = new System.Drawing.Size(300, 18);
            this.lblNextCap.Text = "BÓNG TIẾP THEO";
            this.lblNextCap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // picNext
            //
            this.picNext.Name = "picNext";
            this.picNext.BackColor = System.Drawing.Color.Transparent;
            this.picNext.Location = new System.Drawing.Point(112, 344);
            this.picNext.Size = new System.Drawing.Size(76, 76);
            this.picNext.TabStop = false;
            this.picNext.Paint += new System.Windows.Forms.PaintEventHandler(this.picNext_Paint);
            //
            // barTime
            //
            this.barTime.Name = "barTime";
            this.barTime.Location = new System.Drawing.Point(30, 456);
            this.barTime.Size = new System.Drawing.Size(240, 10);
            //
            // lblTime
            //
            this.lblTime.Name = "lblTime";
            this.lblTime.AutoSize = false;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(185, 190, 225);
            this.lblTime.Location = new System.Drawing.Point(0, 432);
            this.lblTime.Size = new System.Drawing.Size(300, 18);
            this.lblTime.Text = "THỜI GIAN 20s   RÚT x1.0";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lblStatus
            //
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.AutoSize = false;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(255, 190, 110);
            this.lblStatus.Location = new System.Drawing.Point(10, 478);
            this.lblStatus.Size = new System.Drawing.Size(280, 40);
            this.lblStatus.Text = "";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // btnPause
            //
            this.btnPause.Name = "btnPause";
            this.btnPause.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnPause.Location = new System.Drawing.Point(20, 522);
            this.btnPause.Size = new System.Drawing.Size(260, 44);
            this.btnPause.Text = "Tạm dừng";
            this.btnPause.Icon = "pause";
            this.btnPause.Filled = true;
            this.btnPause.Click += new System.EventHandler(this.BtnPause_Click);
            //
            // btnMenu
            //
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnMenu.Location = new System.Drawing.Point(20, 574);
            this.btnMenu.Size = new System.Drawing.Size(260, 38);
            this.btnMenu.Text = "Về menu";
            this.btnMenu.Icon = "home";
            this.btnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            //
            // menuScreen
            //
            this.menuScreen.Name = "menuScreen";
            this.menuScreen.Location = new System.Drawing.Point(0, 0);
            this.menuScreen.Size = new System.Drawing.Size(900, 720);
            //
            // settingsScreen
            //
            this.settingsScreen.Name = "settingsScreen";
            this.settingsScreen.Location = new System.Drawing.Point(0, 0);
            this.settingsScreen.Size = new System.Drawing.Size(900, 720);
            //
            // scoresScreen
            //
            this.scoresScreen.Name = "scoresScreen";
            this.scoresScreen.Location = new System.Drawing.Point(0, 0);
            this.scoresScreen.Size = new System.Drawing.Size(900, 720);
            //
            // helpScreen
            //
            this.helpScreen.Name = "helpScreen";
            this.helpScreen.Location = new System.Drawing.Point(0, 0);
            this.helpScreen.Size = new System.Drawing.Size(900, 720);
            //
            // aboutScreen
            //
            this.aboutScreen.Name = "aboutScreen";
            this.aboutScreen.Location = new System.Drawing.Point(0, 0);
            this.aboutScreen.Size = new System.Drawing.Size(900, 720);
            // gắn control con vào pnlStage
            this.pnlStage.Controls.Add(this.pnlBoardCard);
            this.pnlStage.Controls.Add(this.pnlHud);
            // gắn control con vào pnlBoardCard
            this.pnlBoardCard.Controls.Add(this.board);
            // gắn control con vào pnlHud
            this.pnlHud.Controls.Add(this.lblHudTitle);
            this.pnlHud.Controls.Add(this.lblPlayer);
            this.pnlHud.Controls.Add(this.lblScoreCap);
            this.pnlHud.Controls.Add(this.lblScore);
            this.pnlHud.Controls.Add(this.lblLevelCap);
            this.pnlHud.Controls.Add(this.lblLevel);
            this.pnlHud.Controls.Add(this.lblHighCap);
            this.pnlHud.Controls.Add(this.lblHigh);
            this.pnlHud.Controls.Add(this.lblDiff);
            this.pnlHud.Controls.Add(this.lblNextCap);
            this.pnlHud.Controls.Add(this.picNext);
            this.pnlHud.Controls.Add(this.barTime);
            this.pnlHud.Controls.Add(this.lblTime);
            this.pnlHud.Controls.Add(this.lblStatus);
            this.pnlHud.Controls.Add(this.btnPause);
            this.pnlHud.Controls.Add(this.btnMenu);
            //
            // MainForm
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(14, 8, 40);
            this.ClientSize = new System.Drawing.Size(900, 720);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.KeyPreview = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bubble Pop";
            this.Controls.Add(this.pnlStage);
            this.Controls.Add(this.menuScreen);
            this.Controls.Add(this.settingsScreen);
            this.Controls.Add(this.scoresScreen);
            this.Controls.Add(this.helpScreen);
            this.Controls.Add(this.aboutScreen);
            this.Name = "MainForm";
            this.ResumeLayout(false);
        }

        #endregion

        private BubbleShooter.BackdropPanel pnlStage;
        private BubbleShooter.GlassPanel pnlBoardCard;
        private BubbleShooter.GamePanel board;
        private BubbleShooter.GlassPanel pnlHud;
        private BubbleShooter.GradientLabel lblHudTitle;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblScoreCap;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblLevelCap;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblHighCap;
        private System.Windows.Forms.Label lblHigh;
        private System.Windows.Forms.Label lblDiff;
        private System.Windows.Forms.Label lblNextCap;
        private System.Windows.Forms.PictureBox picNext;
        private BubbleShooter.BarControl barTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblStatus;
        private BubbleShooter.GlowButton btnPause;
        private BubbleShooter.GlowButton btnMenu;
        private BubbleShooter.MenuScreen menuScreen;
        private BubbleShooter.SettingsScreen settingsScreen;
        private BubbleShooter.ScoresScreen scoresScreen;
        private BubbleShooter.HelpScreen helpScreen;
        private BubbleShooter.AboutScreen aboutScreen;
    }
}
