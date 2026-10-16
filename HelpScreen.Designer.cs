namespace BubbleShooter
{
    partial class HelpScreen
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
            this.pnlBack = new BubbleShooter.BackdropPanel();
            this.orbA = new BubbleShooter.OrbControl();
            this.orbB = new BubbleShooter.OrbControl();
            this.pnlCard = new BubbleShooter.GlassPanel();
            this.lblTitle = new BubbleShooter.GradientLabel();
            this.lblRuleHead = new System.Windows.Forms.Label();
            this.pnlArt1 = new BubbleShooter.GlassPanel();
            this.lblRule1 = new System.Windows.Forms.Label();
            this.lblRuleDesc1 = new System.Windows.Forms.Label();
            this.pnlArt2 = new BubbleShooter.GlassPanel();
            this.lblRule2 = new System.Windows.Forms.Label();
            this.lblRuleDesc2 = new System.Windows.Forms.Label();
            this.pnlArt3 = new BubbleShooter.GlassPanel();
            this.lblRule3 = new System.Windows.Forms.Label();
            this.lblRuleDesc3 = new System.Windows.Forms.Label();
            this.pnlArt4 = new BubbleShooter.GlassPanel();
            this.lblRule4 = new System.Windows.Forms.Label();
            this.lblRuleDesc4 = new System.Windows.Forms.Label();
            this.pnlArt5 = new BubbleShooter.GlassPanel();
            this.lblRule5 = new System.Windows.Forms.Label();
            this.lblRuleDesc5 = new System.Windows.Forms.Label();
            this.orb1a = new BubbleShooter.OrbControl();
            this.orb1b = new BubbleShooter.OrbControl();
            this.orb1c = new BubbleShooter.OrbControl();
            this.orb2a = new BubbleShooter.OrbControl();
            this.ico2 = new BubbleShooter.IconBox();
            this.ico3a = new BubbleShooter.IconBox();
            this.ico3b = new BubbleShooter.IconBox();
            this.orb4 = new BubbleShooter.OrbControl();
            this.pnlLine = new System.Windows.Forms.Panel();
            this.ico5 = new BubbleShooter.IconBox();
            this.lblCtrlHead = new System.Windows.Forms.Label();
            this.lblCtrl1 = new System.Windows.Forms.Label();
            this.lblCtrl2 = new System.Windows.Forms.Label();
            this.lblCtrl3 = new System.Windows.Forms.Label();
            this.btnBack = new BubbleShooter.GlowButton();
            this.SuspendLayout();
            //
            // pnlBack
            //
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.Location = new System.Drawing.Point(0, 0);
            this.pnlBack.Size = new System.Drawing.Size(900, 720);
            //
            // orbA
            //
            this.orbA.Name = "orbA";
            this.orbA.Location = new System.Drawing.Point(70, 90);
            this.orbA.Size = new System.Drawing.Size(60, 60);
            //
            // orbB
            //
            this.orbB.Name = "orbB";
            this.orbB.Location = new System.Drawing.Point(745, 590);
            this.orbB.Size = new System.Drawing.Size(70, 70);
            //
            // pnlCard
            //
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Location = new System.Drawing.Point(180, 70);
            this.pnlCard.Size = new System.Drawing.Size(540, 580);
            //
            // lblTitle
            //
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitle.Location = new System.Drawing.Point(0, 20);
            this.lblTitle.Size = new System.Drawing.Size(540, 50);
            this.lblTitle.Text = "Hướng dẫn";
            //
            // lblRuleHead
            //
            this.lblRuleHead.Name = "lblRuleHead";
            this.lblRuleHead.AutoSize = false;
            this.lblRuleHead.BackColor = System.Drawing.Color.Transparent;
            this.lblRuleHead.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblRuleHead.ForeColor = System.Drawing.Color.FromArgb(255, 175, 90);
            this.lblRuleHead.Location = new System.Drawing.Point(30, 76);
            this.lblRuleHead.Size = new System.Drawing.Size(480, 24);
            this.lblRuleHead.Text = "Luật chơi:";
            this.lblRuleHead.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // pnlArt1
            //
            this.pnlArt1.Name = "pnlArt1";
            this.pnlArt1.Location = new System.Drawing.Point(25, 106);
            this.pnlArt1.Size = new System.Drawing.Size(100, 52);
            this.pnlArt1.Radius = 14;
            this.pnlArt1.Fill = System.Drawing.Color.FromArgb(30, 255, 255, 255);
            this.pnlArt1.Border = System.Drawing.Color.FromArgb(0, 255, 255, 255);
            //
            // lblRule1
            //
            this.lblRule1.Name = "lblRule1";
            this.lblRule1.AutoSize = false;
            this.lblRule1.BackColor = System.Drawing.Color.Transparent;
            this.lblRule1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblRule1.ForeColor = System.Drawing.Color.White;
            this.lblRule1.Location = new System.Drawing.Point(140, 110);
            this.lblRule1.Size = new System.Drawing.Size(385, 24);
            this.lblRule1.Text = "Bắn trúng 3 bóng trở lên cùng màu thì nổ";
            this.lblRule1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblRuleDesc1
            //
            this.lblRuleDesc1.Name = "lblRuleDesc1";
            this.lblRuleDesc1.AutoSize = false;
            this.lblRuleDesc1.BackColor = System.Drawing.Color.Transparent;
            this.lblRuleDesc1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRuleDesc1.ForeColor = System.Drawing.Color.FromArgb(185, 190, 225);
            this.lblRuleDesc1.Location = new System.Drawing.Point(140, 134);
            this.lblRuleDesc1.Size = new System.Drawing.Size(385, 22);
            this.lblRuleDesc1.Text = "Mỗi bóng nổ được +10 điểm.";
            this.lblRuleDesc1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // pnlArt2
            //
            this.pnlArt2.Name = "pnlArt2";
            this.pnlArt2.Location = new System.Drawing.Point(25, 161);
            this.pnlArt2.Size = new System.Drawing.Size(100, 52);
            this.pnlArt2.Radius = 14;
            this.pnlArt2.Fill = System.Drawing.Color.FromArgb(30, 255, 255, 255);
            this.pnlArt2.Border = System.Drawing.Color.FromArgb(0, 255, 255, 255);
            //
            // lblRule2
            //
            this.lblRule2.Name = "lblRule2";
            this.lblRule2.AutoSize = false;
            this.lblRule2.BackColor = System.Drawing.Color.Transparent;
            this.lblRule2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblRule2.ForeColor = System.Drawing.Color.White;
            this.lblRule2.Location = new System.Drawing.Point(140, 165);
            this.lblRule2.Size = new System.Drawing.Size(385, 24);
            this.lblRule2.Text = "Bóng bị treo lơ lửng sẽ rơi xuống";
            this.lblRule2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblRuleDesc2
            //
            this.lblRuleDesc2.Name = "lblRuleDesc2";
            this.lblRuleDesc2.AutoSize = false;
            this.lblRuleDesc2.BackColor = System.Drawing.Color.Transparent;
            this.lblRuleDesc2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRuleDesc2.ForeColor = System.Drawing.Color.FromArgb(185, 190, 225);
            this.lblRuleDesc2.Location = new System.Drawing.Point(140, 189);
            this.lblRuleDesc2.Size = new System.Drawing.Size(385, 22);
            this.lblRuleDesc2.Text = "Mỗi bóng rơi được +20 điểm.";
            this.lblRuleDesc2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // pnlArt3
            //
            this.pnlArt3.Name = "pnlArt3";
            this.pnlArt3.Location = new System.Drawing.Point(25, 216);
            this.pnlArt3.Size = new System.Drawing.Size(100, 52);
            this.pnlArt3.Radius = 14;
            this.pnlArt3.Fill = System.Drawing.Color.FromArgb(30, 255, 255, 255);
            this.pnlArt3.Border = System.Drawing.Color.FromArgb(0, 255, 255, 255);
            //
            // lblRule3
            //
            this.lblRule3.Name = "lblRule3";
            this.lblRule3.AutoSize = false;
            this.lblRule3.BackColor = System.Drawing.Color.Transparent;
            this.lblRule3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblRule3.ForeColor = System.Drawing.Color.White;
            this.lblRule3.Location = new System.Drawing.Point(140, 220);
            this.lblRule3.Size = new System.Drawing.Size(385, 24);
            this.lblRule3.Text = "Hết giờ hoặc bắn trượt, lưới tụt xuống";
            this.lblRule3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblRuleDesc3
            //
            this.lblRuleDesc3.Name = "lblRuleDesc3";
            this.lblRuleDesc3.AutoSize = false;
            this.lblRuleDesc3.BackColor = System.Drawing.Color.Transparent;
            this.lblRuleDesc3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRuleDesc3.ForeColor = System.Drawing.Color.FromArgb(185, 190, 225);
            this.lblRuleDesc3.Location = new System.Drawing.Point(140, 244);
            this.lblRuleDesc3.Size = new System.Drawing.Size(385, 22);
            this.lblRuleDesc3.Text = "Nổ bóng hồi giờ; chơi càng lâu rút càng nhanh.";
            this.lblRuleDesc3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // pnlArt4
            //
            this.pnlArt4.Name = "pnlArt4";
            this.pnlArt4.Location = new System.Drawing.Point(25, 271);
            this.pnlArt4.Size = new System.Drawing.Size(100, 52);
            this.pnlArt4.Radius = 14;
            this.pnlArt4.Fill = System.Drawing.Color.FromArgb(30, 255, 255, 255);
            this.pnlArt4.Border = System.Drawing.Color.FromArgb(0, 255, 255, 255);
            //
            // lblRule4
            //
            this.lblRule4.Name = "lblRule4";
            this.lblRule4.AutoSize = false;
            this.lblRule4.BackColor = System.Drawing.Color.Transparent;
            this.lblRule4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblRule4.ForeColor = System.Drawing.Color.White;
            this.lblRule4.Location = new System.Drawing.Point(140, 275);
            this.lblRule4.Size = new System.Drawing.Size(385, 24);
            this.lblRule4.Text = "Bóng chạm vạch đỏ là thua";
            this.lblRule4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblRuleDesc4
            //
            this.lblRuleDesc4.Name = "lblRuleDesc4";
            this.lblRuleDesc4.AutoSize = false;
            this.lblRuleDesc4.BackColor = System.Drawing.Color.Transparent;
            this.lblRuleDesc4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRuleDesc4.ForeColor = System.Drawing.Color.FromArgb(185, 190, 225);
            this.lblRuleDesc4.Location = new System.Drawing.Point(140, 299);
            this.lblRuleDesc4.Size = new System.Drawing.Size(385, 22);
            this.lblRuleDesc4.Text = "Đừng để lưới xuống quá thấp.";
            this.lblRuleDesc4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // pnlArt5
            //
            this.pnlArt5.Name = "pnlArt5";
            this.pnlArt5.Location = new System.Drawing.Point(25, 326);
            this.pnlArt5.Size = new System.Drawing.Size(100, 52);
            this.pnlArt5.Radius = 14;
            this.pnlArt5.Fill = System.Drawing.Color.FromArgb(30, 255, 255, 255);
            this.pnlArt5.Border = System.Drawing.Color.FromArgb(0, 255, 255, 255);
            //
            // lblRule5
            //
            this.lblRule5.Name = "lblRule5";
            this.lblRule5.AutoSize = false;
            this.lblRule5.BackColor = System.Drawing.Color.Transparent;
            this.lblRule5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblRule5.ForeColor = System.Drawing.Color.White;
            this.lblRule5.Location = new System.Drawing.Point(140, 330);
            this.lblRule5.Size = new System.Drawing.Size(385, 24);
            this.lblRule5.Text = "Xóa sạch bóng để qua màn";
            this.lblRule5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblRuleDesc5
            //
            this.lblRuleDesc5.Name = "lblRuleDesc5";
            this.lblRuleDesc5.AutoSize = false;
            this.lblRuleDesc5.BackColor = System.Drawing.Color.Transparent;
            this.lblRuleDesc5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRuleDesc5.ForeColor = System.Drawing.Color.FromArgb(185, 190, 225);
            this.lblRuleDesc5.Location = new System.Drawing.Point(140, 354);
            this.lblRuleDesc5.Size = new System.Drawing.Size(385, 22);
            this.lblRuleDesc5.Text = "Màn sau nhiều hàng bóng, giờ rút nhanh hơn.";
            this.lblRuleDesc5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // orb1a
            //
            this.orb1a.Name = "orb1a";
            this.orb1a.Location = new System.Drawing.Point(9, 13);
            this.orb1a.Size = new System.Drawing.Size(26, 26);
            this.orb1a.BubbleColor = System.Drawing.Color.FromArgb(240, 70, 70);
            //
            // orb1b
            //
            this.orb1b.Name = "orb1b";
            this.orb1b.Location = new System.Drawing.Point(35, 13);
            this.orb1b.Size = new System.Drawing.Size(26, 26);
            this.orb1b.BubbleColor = System.Drawing.Color.FromArgb(240, 70, 70);
            //
            // orb1c
            //
            this.orb1c.Name = "orb1c";
            this.orb1c.Location = new System.Drawing.Point(61, 13);
            this.orb1c.Size = new System.Drawing.Size(26, 26);
            this.orb1c.BubbleColor = System.Drawing.Color.FromArgb(240, 70, 70);
            //
            // orb2a
            //
            this.orb2a.Name = "orb2a";
            this.orb2a.Location = new System.Drawing.Point(17, 7);
            this.orb2a.Size = new System.Drawing.Size(26, 26);
            this.orb2a.BubbleColor = System.Drawing.Color.FromArgb(60, 130, 250);
            //
            // ico2
            //
            this.ico2.Name = "ico2";
            this.ico2.Icon = "down";
            this.ico2.IconColor = System.Drawing.Color.FromArgb(255, 190, 110);
            this.ico2.Location = new System.Drawing.Point(56, 12);
            this.ico2.Size = new System.Drawing.Size(28, 28);
            //
            // ico3a
            //
            this.ico3a.Name = "ico3a";
            this.ico3a.Icon = "clock";
            this.ico3a.IconColor = System.Drawing.Color.White;
            this.ico3a.Location = new System.Drawing.Point(16, 11);
            this.ico3a.Size = new System.Drawing.Size(30, 30);
            //
            // ico3b
            //
            this.ico3b.Name = "ico3b";
            this.ico3b.Icon = "down";
            this.ico3b.IconColor = System.Drawing.Color.FromArgb(255, 190, 110);
            this.ico3b.Location = new System.Drawing.Point(58, 11);
            this.ico3b.Size = new System.Drawing.Size(30, 30);
            //
            // orb4
            //
            this.orb4.Name = "orb4";
            this.orb4.Location = new System.Drawing.Point(37, 6);
            this.orb4.Size = new System.Drawing.Size(26, 26);
            this.orb4.BubbleColor = System.Drawing.Color.FromArgb(255, 205, 50);
            //
            // pnlLine
            //
            this.pnlLine.Name = "pnlLine";
            this.pnlLine.BackColor = System.Drawing.Color.FromArgb(255, 90, 110);
            this.pnlLine.Location = new System.Drawing.Point(10, 38);
            this.pnlLine.Size = new System.Drawing.Size(80, 2);
            //
            // ico5
            //
            this.ico5.Name = "ico5";
            this.ico5.Icon = "star3";
            this.ico5.IconColor = System.Drawing.Color.FromArgb(255, 215, 0);
            this.ico5.Location = new System.Drawing.Point(16, 14);
            this.ico5.Size = new System.Drawing.Size(70, 24);
            //
            // lblCtrlHead
            //
            this.lblCtrlHead.Name = "lblCtrlHead";
            this.lblCtrlHead.AutoSize = false;
            this.lblCtrlHead.BackColor = System.Drawing.Color.Transparent;
            this.lblCtrlHead.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblCtrlHead.ForeColor = System.Drawing.Color.FromArgb(255, 175, 90);
            this.lblCtrlHead.Location = new System.Drawing.Point(30, 388);
            this.lblCtrlHead.Size = new System.Drawing.Size(480, 24);
            this.lblCtrlHead.Text = "Điều khiển:";
            this.lblCtrlHead.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblCtrl1
            //
            this.lblCtrl1.Name = "lblCtrl1";
            this.lblCtrl1.AutoSize = false;
            this.lblCtrl1.BackColor = System.Drawing.Color.Transparent;
            this.lblCtrl1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCtrl1.ForeColor = System.Drawing.Color.White;
            this.lblCtrl1.Location = new System.Drawing.Point(30, 416);
            this.lblCtrl1.Size = new System.Drawing.Size(490, 22);
            this.lblCtrl1.Text = "• Di chuột để ngắm, click chuột trái (hoặc Space) để bắn.";
            this.lblCtrl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblCtrl2
            //
            this.lblCtrl2.Name = "lblCtrl2";
            this.lblCtrl2.AutoSize = false;
            this.lblCtrl2.BackColor = System.Drawing.Color.Transparent;
            this.lblCtrl2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCtrl2.ForeColor = System.Drawing.Color.White;
            this.lblCtrl2.Location = new System.Drawing.Point(30, 440);
            this.lblCtrl2.Size = new System.Drawing.Size(490, 22);
            this.lblCtrl2.Text = "• Chuột phải (hoặc ↓) để đổi bóng. Phím ← → chỉnh góc bắn.";
            this.lblCtrl2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblCtrl3
            //
            this.lblCtrl3.Name = "lblCtrl3";
            this.lblCtrl3.AutoSize = false;
            this.lblCtrl3.BackColor = System.Drawing.Color.Transparent;
            this.lblCtrl3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCtrl3.ForeColor = System.Drawing.Color.White;
            this.lblCtrl3.Location = new System.Drawing.Point(30, 464);
            this.lblCtrl3.Size = new System.Drawing.Size(490, 22);
            this.lblCtrl3.Text = "• P: tạm dừng.   M: bật/tắt âm thanh.";
            this.lblCtrl3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // btnBack
            //
            this.btnBack.Name = "btnBack";
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnBack.Location = new System.Drawing.Point(150, 512);
            this.btnBack.Size = new System.Drawing.Size(240, 48);
            this.btnBack.Text = "Quay lại";
            this.btnBack.Icon = "back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // gắn control con vào pnlBack
            this.pnlBack.Controls.Add(this.orbA);
            this.pnlBack.Controls.Add(this.orbB);
            this.pnlBack.Controls.Add(this.pnlCard);
            // gắn control con vào pnlCard
            this.pnlCard.Controls.Add(this.lblTitle);
            this.pnlCard.Controls.Add(this.lblRuleHead);
            this.pnlCard.Controls.Add(this.pnlArt1);
            this.pnlCard.Controls.Add(this.lblRule1);
            this.pnlCard.Controls.Add(this.lblRuleDesc1);
            this.pnlCard.Controls.Add(this.pnlArt2);
            this.pnlCard.Controls.Add(this.lblRule2);
            this.pnlCard.Controls.Add(this.lblRuleDesc2);
            this.pnlCard.Controls.Add(this.pnlArt3);
            this.pnlCard.Controls.Add(this.lblRule3);
            this.pnlCard.Controls.Add(this.lblRuleDesc3);
            this.pnlCard.Controls.Add(this.pnlArt4);
            this.pnlCard.Controls.Add(this.lblRule4);
            this.pnlCard.Controls.Add(this.lblRuleDesc4);
            this.pnlCard.Controls.Add(this.pnlArt5);
            this.pnlCard.Controls.Add(this.lblRule5);
            this.pnlCard.Controls.Add(this.lblRuleDesc5);
            this.pnlCard.Controls.Add(this.lblCtrlHead);
            this.pnlCard.Controls.Add(this.lblCtrl1);
            this.pnlCard.Controls.Add(this.lblCtrl2);
            this.pnlCard.Controls.Add(this.lblCtrl3);
            this.pnlCard.Controls.Add(this.btnBack);
            // gắn control con vào pnlArt1
            this.pnlArt1.Controls.Add(this.orb1a);
            this.pnlArt1.Controls.Add(this.orb1b);
            this.pnlArt1.Controls.Add(this.orb1c);
            // gắn control con vào pnlArt2
            this.pnlArt2.Controls.Add(this.orb2a);
            this.pnlArt2.Controls.Add(this.ico2);
            // gắn control con vào pnlArt3
            this.pnlArt3.Controls.Add(this.ico3a);
            this.pnlArt3.Controls.Add(this.ico3b);
            // gắn control con vào pnlArt4
            this.pnlArt4.Controls.Add(this.orb4);
            this.pnlArt4.Controls.Add(this.pnlLine);
            // gắn control con vào pnlArt5
            this.pnlArt5.Controls.Add(this.ico5);
            //
            // HelpScreen
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Size = new System.Drawing.Size(900, 720);
            this.Controls.Add(this.pnlBack);
            this.Name = "HelpScreen";
            this.ResumeLayout(false);
        }

        #endregion

        private BubbleShooter.BackdropPanel pnlBack;
        private BubbleShooter.OrbControl orbA;
        private BubbleShooter.OrbControl orbB;
        private BubbleShooter.GlassPanel pnlCard;
        private BubbleShooter.GradientLabel lblTitle;
        private System.Windows.Forms.Label lblRuleHead;
        private BubbleShooter.GlassPanel pnlArt1;
        private System.Windows.Forms.Label lblRule1;
        private System.Windows.Forms.Label lblRuleDesc1;
        private BubbleShooter.GlassPanel pnlArt2;
        private System.Windows.Forms.Label lblRule2;
        private System.Windows.Forms.Label lblRuleDesc2;
        private BubbleShooter.GlassPanel pnlArt3;
        private System.Windows.Forms.Label lblRule3;
        private System.Windows.Forms.Label lblRuleDesc3;
        private BubbleShooter.GlassPanel pnlArt4;
        private System.Windows.Forms.Label lblRule4;
        private System.Windows.Forms.Label lblRuleDesc4;
        private BubbleShooter.GlassPanel pnlArt5;
        private System.Windows.Forms.Label lblRule5;
        private System.Windows.Forms.Label lblRuleDesc5;
        private BubbleShooter.OrbControl orb1a;
        private BubbleShooter.OrbControl orb1b;
        private BubbleShooter.OrbControl orb1c;
        private BubbleShooter.OrbControl orb2a;
        private BubbleShooter.IconBox ico2;
        private BubbleShooter.IconBox ico3a;
        private BubbleShooter.IconBox ico3b;
        private BubbleShooter.OrbControl orb4;
        private System.Windows.Forms.Panel pnlLine;
        private BubbleShooter.IconBox ico5;
        private System.Windows.Forms.Label lblCtrlHead;
        private System.Windows.Forms.Label lblCtrl1;
        private System.Windows.Forms.Label lblCtrl2;
        private System.Windows.Forms.Label lblCtrl3;
        private BubbleShooter.GlowButton btnBack;
    }
}
