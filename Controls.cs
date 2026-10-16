using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace BubbleShooter
{
    // Các control tự làm (kéo từ Toolbox vào form giống control thường).
    // Phần vẽ nằm trong từng class, còn bố cục các màn nằm trong file .Designer.cs.

    public static class Gfx
    {
        public static GraphicsPath RoundRect(RectangleF r, float rad)
        {
            float d = Math.Min(rad * 2, Math.Min(r.Width, r.Height));
            var p = new GraphicsPath();
            if (d <= 0) { p.AddRectangle(r); return p; }
            p.AddArc(r.X, r.Y, d, d, 180, 90);
            p.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            p.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            p.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            p.CloseFigure();
            return p;
        }

        // Chiều rộng của icon (icon sao có 1-3 ngôi nên rộng hơn)
        public static float IconWidth(string name, float s)
        {
            if (name == "star1") return s * 0.9f;
            if (name == "star2") return s * 1.8f;
            if (name == "star3") return s * 2.7f;
            return s;
        }

        public static void Star(Graphics g, float cx, float cy, float r, Brush br)
        {
            PointF[] pts = new PointF[10];
            for (int i = 0; i < 10; i++)
            {
                double a = -Math.PI / 2 + i * Math.PI / 5;
                float rr = (i % 2 == 0) ? r : r * 0.45f;
                pts[i] = new PointF(cx + (float)Math.Cos(a) * rr, cy + (float)Math.Sin(a) * rr);
            }
            g.FillPolygon(br, pts);
        }

        // Vẽ icon bằng hình vẽ (không dùng emoji để khỏi lỗi font) trong ô vuông cạnh s tại (x, y)
        public static void DrawIcon(Graphics g, string name, float x, float y, float s, Color c)
        {
            float cx = x + s / 2, cy = y + s / 2;
            using (var br = new SolidBrush(c))
            using (var pen = new Pen(c, Math.Max(1.6f, s * 0.11f)))
            {
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;
                pen.LineJoin = LineJoin.Round;
                switch (name)
                {
                    case "play":
                    {
                        g.FillPolygon(br, new[] {
                            new PointF(x + s * 0.22f, y + s * 0.12f),
                            new PointF(x + s * 0.22f, y + s * 0.88f),
                            new PointF(x + s * 0.9f, cy) });
                        break;
                    }
                    case "pause":
                    {
                        g.FillRectangle(br, x + s * 0.2f, y + s * 0.14f, s * 0.22f, s * 0.72f);
                        g.FillRectangle(br, x + s * 0.58f, y + s * 0.14f, s * 0.22f, s * 0.72f);
                        break;
                    }
                    case "restart":
                    {
                        float r = s * 0.36f;
                        g.DrawArc(pen, cx - r, cy - r, r * 2, r * 2, 20, 290);
                        double th = -50 * Math.PI / 180;
                        float px = cx + (float)Math.Cos(th) * r, py = cy + (float)Math.Sin(th) * r;
                        float tx = -(float)Math.Sin(th), ty = (float)Math.Cos(th); // hướng đi của cung
                        float nx = -ty, ny = tx;
                        g.FillPolygon(br, new[] {
                            new PointF(px + tx * s * 0.22f, py + ty * s * 0.22f),
                            new PointF(px + nx * s * 0.17f, py + ny * s * 0.17f),
                            new PointF(px - nx * s * 0.17f, py - ny * s * 0.17f) });
                        break;
                    }
                    case "trophy":
                    {
                        using (var cup = new GraphicsPath())
                        {
                            cup.AddLine(x + s * 0.25f, y + s * 0.12f, x + s * 0.75f, y + s * 0.12f);
                            cup.AddArc(x + s * 0.25f, y + s * 0.12f, s * 0.5f, s * 0.62f, 0, 180);
                            cup.CloseFigure();
                            g.FillPath(br, cup);
                        }
                        g.DrawArc(pen, x + s * 0.04f, y + s * 0.2f, s * 0.3f, s * 0.28f, 90, 180);
                        g.DrawArc(pen, x + s * 0.66f, y + s * 0.2f, s * 0.3f, s * 0.28f, 270, 180);
                        g.FillRectangle(br, x + s * 0.45f, y + s * 0.72f, s * 0.1f, s * 0.12f);
                        g.FillRectangle(br, x + s * 0.3f, y + s * 0.84f, s * 0.4f, s * 0.1f);
                        break;
                    }
                    case "gear":
                    {
                        float r1 = s * 0.48f, r2 = s * 0.34f;
                        double[] da = { -0.2, -0.13, 0.13, 0.2 };
                        float[] rr = { r2, r1, r1, r2 };
                        List<PointF> pts = new List<PointF>();
                        for (int i = 0; i < 8; i++)
                        {
                            double a = i * Math.PI / 4;
                            for (int k = 0; k < 4; k++)
                                pts.Add(new PointF(cx + (float)Math.Cos(a + da[k]) * rr[k],
                                                   cy + (float)Math.Sin(a + da[k]) * rr[k]));
                        }
                        using (var gp = new GraphicsPath())
                        {
                            gp.AddPolygon(pts.ToArray());
                            gp.AddEllipse(cx - s * 0.15f, cy - s * 0.15f, s * 0.3f, s * 0.3f); // lỗ giữa
                            g.FillPath(br, gp);
                        }
                        break;
                    }
                    case "help":
                    {
                        g.DrawEllipse(pen, x + s * 0.1f, y + s * 0.1f, s * 0.8f, s * 0.8f);
                        using (var f = new Font("Segoe UI", s * 0.6f, FontStyle.Bold, GraphicsUnit.Pixel))
                        using (var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
                            g.DrawString("?", f, br, new RectangleF(x, y + s * 0.04f, s, s), sf);
                        break;
                    }
                    case "group":
                    {
                        g.FillEllipse(br, x + s * 0.0f, y + s * 0.3f, s * 0.22f, s * 0.22f);
                        g.FillPie(br, x, y + s * 0.56f, s * 0.32f, s * 0.5f, 180, 180);
                        g.FillEllipse(br, x + s * 0.78f, y + s * 0.3f, s * 0.22f, s * 0.22f);
                        g.FillPie(br, x + s * 0.68f, y + s * 0.56f, s * 0.32f, s * 0.5f, 180, 180);
                        g.FillEllipse(br, x + s * 0.34f, y + s * 0.1f, s * 0.32f, s * 0.32f);
                        g.FillPie(br, x + s * 0.2f, y + s * 0.5f, s * 0.6f, s * 0.8f, 180, 180);
                        break;
                    }
                    case "back":
                    {
                        g.DrawLine(pen, x + s * 0.85f, cy, x + s * 0.15f, cy);
                        g.DrawLine(pen, x + s * 0.15f, cy, x + s * 0.45f, cy - s * 0.3f);
                        g.DrawLine(pen, x + s * 0.15f, cy, x + s * 0.45f, cy + s * 0.3f);
                        break;
                    }
                    case "sound":
                    case "mute":
                    {
                        g.FillPolygon(br, new[] {
                            new PointF(x + s * 0.08f, y + s * 0.38f), new PointF(x + s * 0.28f, y + s * 0.38f),
                            new PointF(x + s * 0.5f, y + s * 0.18f), new PointF(x + s * 0.5f, y + s * 0.82f),
                            new PointF(x + s * 0.28f, y + s * 0.62f), new PointF(x + s * 0.08f, y + s * 0.62f) });
                        if (name == "sound")
                        {
                            g.DrawArc(pen, x + s * 0.42f, y + s * 0.32f, s * 0.3f, s * 0.36f, -60, 120);
                            g.DrawArc(pen, x + s * 0.4f, y + s * 0.16f, s * 0.5f, s * 0.68f, -60, 120);
                        }
                        else
                        {
                            g.DrawLine(pen, x + s * 0.64f, y + s * 0.36f, x + s * 0.94f, y + s * 0.64f);
                            g.DrawLine(pen, x + s * 0.94f, y + s * 0.36f, x + s * 0.64f, y + s * 0.64f);
                        }
                        break;
                    }
                    case "home":
                    {
                        g.FillPolygon(br, new[] {
                            new PointF(cx, y + s * 0.08f), new PointF(x + s * 0.94f, y + s * 0.5f),
                            new PointF(x + s * 0.06f, y + s * 0.5f) });
                        g.FillRectangle(br, x + s * 0.2f, y + s * 0.5f, s * 0.6f, s * 0.4f);
                        break;
                    }
                    case "clock":
                    {
                        g.DrawEllipse(pen, x + s * 0.1f, y + s * 0.1f, s * 0.8f, s * 0.8f);
                        g.DrawLine(pen, cx, cy, cx, y + s * 0.26f);
                        g.DrawLine(pen, cx, cy, x + s * 0.7f, cy);
                        break;
                    }
                    case "down":
                    {
                        g.DrawLine(pen, cx, y + s * 0.12f, cx, y + s * 0.86f);
                        g.DrawLine(pen, cx, y + s * 0.86f, cx - s * 0.26f, y + s * 0.58f);
                        g.DrawLine(pen, cx, y + s * 0.86f, cx + s * 0.26f, y + s * 0.58f);
                        break;
                    }
                    case "spark":
                    {
                        Star(g, cx, cy, s * 0.5f, br);
                        break;
                    }
                    case "star1":
                    case "star2":
                    case "star3":
                    {
                        int n = name[4] - '0';
                        for (int i = 0; i < n; i++)
                            Star(g, x + s * 0.45f + i * s * 0.9f, cy, s * 0.42f, br);
                        break;
                    }
                }
            }
        }

        public static Color Mix(Color c, Color t, float k)
        {
            return Color.FromArgb(255,
                (int)(c.R + (t.R - c.R) * k),
                (int)(c.G + (t.G - c.G) * k),
                (int)(c.B + (t.B - c.B) * k));
        }
    }

    // Nút bo tròn kiểu kính
    public class GlowButton : Control
    {
        public Color ColorA = Color.FromArgb(255, 90, 150);
        public Color ColorB = Color.FromArgb(255, 165, 60);
        private bool filled, hover, down;
        private string icon;

        // tên icon (xem Gfx.DrawIcon), null = nút không có icon
        public string Icon
        {
            get { return icon; }
            set { icon = value; Invalidate(); }
        }

        public bool Filled
        {
            get { return filled; }
            set { filled = value; Invalidate(); }
        }

        public GlowButton()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw |
                     ControlStyles.SupportsTransparentBackColor | ControlStyles.StandardClick, true);
            SetStyle(ControlStyles.Selectable, false);
            BackColor = Color.Transparent;
            ForeColor = Color.White;
            Cursor = Cursors.Hand;
            Font = new Font("Segoe UI", 17f, FontStyle.Bold, GraphicsUnit.Pixel);
        }

        protected override void OnMouseEnter(EventArgs e) { hover = true; Invalidate(); base.OnMouseEnter(e); }
        protected override void OnMouseLeave(EventArgs e) { hover = false; down = false; Invalidate(); base.OnMouseLeave(e); }
        protected override void OnMouseDown(MouseEventArgs e) { down = true; Invalidate(); base.OnMouseDown(e); }
        protected override void OnMouseUp(MouseEventArgs e) { down = false; Invalidate(); base.OnMouseUp(e); }

        protected override void OnPaint(PaintEventArgs e)
        {
            try
            {
                if (Width < 4 || Height < 4) return;
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
                var rc = new RectangleF(1, 1, Width - 3, Height - 3);
                using (var path = Gfx.RoundRect(rc, Math.Min(Height / 2f, 26f)))
                {
                    if (filled)
                    {
                        using (var br = new LinearGradientBrush(ClientRectangle, ColorA, ColorB, 0f))
                            g.FillPath(br, path);
                        if (hover || down)
                            using (var ov = new SolidBrush(Color.FromArgb(down ? 45 : 28, 255, 255, 255)))
                                g.FillPath(ov, path);
                    }
                    else
                    {
                        int a = down ? 62 : (hover ? 46 : 26);
                        using (var br = new SolidBrush(Color.FromArgb(a, 255, 255, 255)))
                            g.FillPath(br, path);
                        using (var pen = new Pen(Color.FromArgb(hover ? 140 : 75, 255, 255, 255), 1.5f))
                            g.DrawPath(pen, path);
                    }
                }
                using (var tb = new SolidBrush(ForeColor))
                {
                    if (icon == null)
                    {
                        using (var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
                            g.DrawString(Text, Font, tb, new RectangleF(0, 0, Width, Height), sf);
                    }
                    else
                    {
                        // icon + chữ, canh giữa cả cụm
                        float s = Math.Min(Height * 0.5f, 26f);
                        float iw = Gfx.IconWidth(icon, s);
                        SizeF ts = g.MeasureString(Text, Font, 1000, StringFormat.GenericTypographic);
                        float x0 = (Width - (iw + 10 + ts.Width)) / 2;
                        Gfx.DrawIcon(g, icon, x0, (Height - s) / 2, s, ForeColor);
                        using (var sf = new StringFormat(StringFormat.GenericTypographic))
                        {
                            sf.LineAlignment = StringAlignment.Center;
                            g.DrawString(Text, Font, tb, new RectangleF(x0 + iw + 10, 0, ts.Width + 6, Height), sf);
                        }
                    }
                }
            }
            catch (Exception) { }
        }
    }

    // Panel làm nền cho cả màn: tím đậm chuyển sắc + 2 vệt sáng
    public class BackdropPanel : Panel
    {
        public BackdropPanel()
        {
            DoubleBuffered = true;
            ResizeRedraw = true;
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            try
            {
                Rectangle rc = ClientRectangle;
                if (rc.Width <= 0 || rc.Height <= 0) return;
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                using (var br = new LinearGradientBrush(rc, Color.FromArgb(32, 12, 70), Color.FromArgb(8, 6, 28), 60f))
                    g.FillRectangle(br, rc);
                Glow(g, 150, 120, 380, Color.FromArgb(120, 70, 200));
                Glow(g, 760, 610, 420, Color.FromArgb(210, 60, 140));
            }
            catch (Exception) { }
        }

        private static void Glow(Graphics g, float cx, float cy, float r, Color c)
        {
            using (var path = new GraphicsPath())
            {
                path.AddEllipse(cx - r, cy - r, r * 2, r * 2);
                using (var pg = new PathGradientBrush(path))
                {
                    pg.CenterColor = Color.FromArgb(70, c);
                    pg.SurroundColors = new[] { Color.FromArgb(0, c) };
                    g.FillPath(pg, path);
                }
            }
        }
    }

    // Thẻ kính bo góc (trong mờ), có thể chỉnh bo góc / màu nền / màu viền
    public class GlassPanel : Panel
    {
        private int radius = 28;
        private Color fill = Color.FromArgb(24, 255, 255, 255);
        private Color border = Color.FromArgb(60, 255, 255, 255);

        public GlassPanel()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw |
                     ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
        }

        public int Radius { get { return radius; } set { radius = value; Invalidate(); } }
        public Color Fill { get { return fill; } set { fill = value; Invalidate(); } }
        public Color Border { get { return border; } set { border = value; Invalidate(); } }

        protected override void OnPaint(PaintEventArgs e)
        {
            try
            {
                base.OnPaint(e);
                if (Width < 4 || Height < 4) return;
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                using (var p = Gfx.RoundRect(new RectangleF(1, 1, Width - 3, Height - 3), radius))
                {
                    using (var br = new SolidBrush(fill)) g.FillPath(br, p);
                    using (var pen = new Pen(border, 1.5f)) g.DrawPath(pen, p);
                }
            }
            catch (Exception) { }
        }
    }

    // Nhãn chữ chuyển sắc cam - hồng - xanh (dùng cho tiêu đề)
    public class GradientLabel : Control
    {
        public GradientLabel()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw |
                     ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.Selectable, false);
            BackColor = Color.Transparent;
        }

        protected override void OnTextChanged(EventArgs e) { base.OnTextChanged(e); Invalidate(); }

        protected override void OnPaint(PaintEventArgs e)
        {
            try
            {
                if (Width < 4 || Height < 4) return;
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
                var r = new RectangleF(0, 0, Width, Height);
                using (var br = new LinearGradientBrush(r, Color.Orange, Color.DeepSkyBlue, 0f))
                {
                    br.InterpolationColors = new ColorBlend(3)
                    {
                        Colors = new[] { Color.FromArgb(255, 175, 90), Color.FromArgb(255, 105, 175), Color.FromArgb(120, 170, 255) },
                        Positions = new[] { 0f, 0.5f, 1f }
                    };
                    using (var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
                        g.DrawString(Text, Font, br, r, sf);
                }
            }
            catch (Exception) { }
        }
    }

    // Quả bóng: để trống BubbleColor thì là bóng trang trí trong mờ, đặt màu thì là bóng thật
    public class OrbControl : Control
    {
        private Color bubbleColor = Color.Empty;

        public OrbControl()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw |
                     ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.Selectable, false);
            BackColor = Color.Transparent;
        }

        public Color BubbleColor { get { return bubbleColor; } set { bubbleColor = value; Invalidate(); } }

        private bool ShouldSerializeBubbleColor() { return !bubbleColor.IsEmpty; }
        private void ResetBubbleColor() { bubbleColor = Color.Empty; }

        protected override void OnPaint(PaintEventArgs e)
        {
            try
            {
                if (Width < 4 || Height < 4) return;
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                var rect = new RectangleF(1, 1, Width - 3, Height - 3);
                using (var path = new GraphicsPath())
                {
                    path.AddEllipse(rect);
                    using (var pg = new PathGradientBrush(path))
                    {
                        pg.CenterPoint = new PointF(rect.X + rect.Width * 0.35f, rect.Y + rect.Height * 0.35f);
                        if (bubbleColor.IsEmpty)
                        {
                            pg.CenterColor = Color.FromArgb(120, 255, 255, 255);
                            pg.SurroundColors = new[] { Color.FromArgb(20, 200, 190, 255) };
                        }
                        else
                        {
                            pg.CenterColor = Gfx.Mix(bubbleColor, Color.White, 0.55f);
                            pg.SurroundColors = new[] { Gfx.Mix(bubbleColor, Color.Black, 0.3f) };
                        }
                        g.FillPath(pg, path);
                    }
                    using (var pen = new Pen(Color.FromArgb(bubbleColor.IsEmpty ? 85 : 90, 255, 255, 255), 1.5f))
                        g.DrawPath(pen, path);
                }
                if (!bubbleColor.IsEmpty)
                    using (var hl = new SolidBrush(Color.FromArgb(170, 255, 255, 255)))
                        g.FillEllipse(hl, rect.X + rect.Width * 0.22f, rect.Y + rect.Height * 0.14f, rect.Width * 0.4f, rect.Height * 0.26f);
            }
            catch (Exception) { }
        }
    }

    // Icon nhỏ (tên icon xem Gfx.DrawIcon)
    public class IconBox : Control
    {
        private string icon = "down";
        private Color iconColor = Color.White;

        public IconBox()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw |
                     ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.Selectable, false);
            BackColor = Color.Transparent;
        }

        public string Icon { get { return icon; } set { icon = value; Invalidate(); } }
        public Color IconColor { get { return iconColor; } set { iconColor = value; Invalidate(); } }

        protected override void OnPaint(PaintEventArgs e)
        {
            try
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                float s = Math.Min(Width, Height);
                float w = Gfx.IconWidth(icon, s);
                Gfx.DrawIcon(g, icon, (Width - w) / 2, (Height - s) / 2, s, iconColor);
            }
            catch (Exception) { }
        }
    }

    // Thanh thời gian: Value từ 0 đến 1
    public class BarControl : Control
    {
        private double value = 1;
        private Color barColor = Color.FromArgb(255, 165, 60);

        public BarControl()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw |
                     ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.Selectable, false);
            BackColor = Color.Transparent;
        }

        public double Value
        {
            get { return value; }
            set
            {
                double v = Math.Max(0, Math.Min(1, value));
                if (Math.Abs(v - this.value) < 0.002) return;
                this.value = v;
                Invalidate();
            }
        }

        public Color BarColor
        {
            get { return barColor; }
            set { if (barColor != value) { barColor = value; Invalidate(); } }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            try
            {
                if (Width < 4 || Height < 4) return;
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                float rad = Height / 2f;
                using (var p = Gfx.RoundRect(new RectangleF(0, 0, Width - 1, Height - 1), rad))
                using (var br = new SolidBrush(Color.FromArgb(40, 255, 255, 255)))
                    g.FillPath(br, p);
                if (value > 0.02)
                    using (var p = Gfx.RoundRect(new RectangleF(0, 0, (float)((Width - 1) * value), Height - 1), rad))
                    using (var br = new SolidBrush(barColor))
                        g.FillPath(br, p);
            }
            catch (Exception) { }
        }
    }

    // Panel bật double buffer để bàn chơi không nhấp nháy
    public class GamePanel : Panel
    {
        public GamePanel()
        {
            DoubleBuffered = true;
            ResizeRedraw = true;
        }
    }

}
