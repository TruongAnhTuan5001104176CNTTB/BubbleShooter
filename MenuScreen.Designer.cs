namespace BubbleShooter
{
    partial class MenuScreen
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
            this.orbC = new BubbleShooter.OrbControl();
            this.pnlCard = new BubbleShooter.GlassPanel();
            this.lblTitle = new BubbleShooter.GradientLabel();
            this.lblSub = new System.Windows.Forms.Label();
            this.pnlInput = new BubbleShooter.GlassPanel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnPlay = new BubbleShooter.GlowButton();
            this.btnScores = new BubbleShooter.GlowButton();
            this.btnSettings = new BubbleShooter.GlowButton();
            this.btnHelp = new BubbleShooter.GlowButton();
            this.btnAbout = new BubbleShooter.GlowButton();
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
            this.orbA.Location = new System.Drawing.Point(160, 90);
            this.orbA.Size = new System.Drawing.Size(76, 76);
            //
            // orbB
            //
            this.orbB.Name = "orbB";
            this.orbB.Location = new System.Drawing.Point(684, 140);
            this.orbB.Size = new System.Drawing.Size(40, 40);
            //
            // orbC
            //
            this.orbC.Name = "orbC";
            this.orbC.Location = new System.Drawing.Point(700, 520);
            this.orbC.Size = new System.Drawing.Size(84, 84);
            //
            // pnlCard
            //
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Location = new System.Drawing.Point(260, 100);
            this.pnlCard.Size = new System.Drawing.Size(380, 500);
            //
            // lblTitle
            //
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 52F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitle.Location = new System.Drawing.Point(0, 38);
            this.lblTitle.Size = new System.Drawing.Size(380, 80);
            this.lblTitle.Text = "Bubble Pop";
            //
            // lblSub
            //
            this.lblSub.Name = "lblSub";
            this.lblSub.AutoSize = false;
            this.lblSub.BackColor = System.Drawing.Color.Transparent;
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSub.ForeColor = System.Drawing.Color.FromArgb(185, 190, 225);
            this.lblSub.Location = new System.Drawing.Point(0, 125);
            this.lblSub.Size = new System.Drawing.Size(380, 28);
            this.lblSub.Text = "Bắn bóng – Ghép màu – Phá kỷ lục";
            this.lblSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // pnlInput
            //
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Location = new System.Drawing.Point(30, 175);
            this.pnlInput.Size = new System.Drawing.Size(320, 50);
            this.pnlInput.Radius = 25;
            this.pnlInput.Fill = System.Drawing.Color.FromArgb(48, 36, 92);
            this.pnlInput.Border = System.Drawing.Color.FromArgb(70, 255, 255, 255);
            //
            // txtName
            //
            this.txtName.Name = "txtName";
            this.txtName.BackColor = System.Drawing.Color.FromArgb(48, 36, 92);
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(15, 13);
            this.txtName.MaxLength = 12;
            this.txtName.PlaceholderText = "Nhập tên người chơi";
            this.txtName.Size = new System.Drawing.Size(290, 24);
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //
            // btnPlay
            //
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnPlay.Location = new System.Drawing.Point(30, 240);
            this.btnPlay.Size = new System.Drawing.Size(320, 56);
            this.btnPlay.Text = "Chơi ngay";
            this.btnPlay.Icon = "play";
            this.btnPlay.Filled = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            //
            // btnScores
            //
            this.btnScores.Name = "btnScores";
            this.btnScores.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnScores.Location = new System.Drawing.Point(30, 310);
            this.btnScores.Size = new System.Drawing.Size(320, 52);
            this.btnScores.Text = "Bảng thành tích";
            this.btnScores.Icon = "trophy";
            this.btnScores.Click += new System.EventHandler(this.btnScores_Click);
            //
            // btnSettings
            //
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnSettings.Location = new System.Drawing.Point(30, 376);
            this.btnSettings.Size = new System.Drawing.Size(320, 52);
            this.btnSettings.Text = "Cài đặt";
            this.btnSettings.Icon = "gear";
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            //
            // btnHelp
            //
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnHelp.Location = new System.Drawing.Point(30, 443);
            this.btnHelp.Size = new System.Drawing.Size(155, 38);
            this.btnHelp.Text = "Hướng dẫn";
            this.btnHelp.Icon = "help";
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            //
            // btnAbout
            //
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnAbout.Location = new System.Drawing.Point(195, 443);
            this.btnAbout.Size = new System.Drawing.Size(155, 38);
            this.btnAbout.Text = "Nhóm";
            this.btnAbout.Icon = "group";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // gắn control con vào pnlBack
            this.pnlBack.Controls.Add(this.orbA);
            this.pnlBack.Controls.Add(this.orbB);
            this.pnlBack.Controls.Add(this.orbC);
            this.pnlBack.Controls.Add(this.pnlCard);
            // gắn control con vào pnlCard
            this.pnlCard.Controls.Add(this.lblTitle);
            this.pnlCard.Controls.Add(this.lblSub);
            this.pnlCard.Controls.Add(this.pnlInput);
            this.pnlCard.Controls.Add(this.btnPlay);
            this.pnlCard.Controls.Add(this.btnScores);
            this.pnlCard.Controls.Add(this.btnSettings);
            this.pnlCard.Controls.Add(this.btnHelp);
            this.pnlCard.Controls.Add(this.btnAbout);
            // gắn control con vào pnlInput
            this.pnlInput.Controls.Add(this.txtName);
            //
            // MenuScreen
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Size = new System.Drawing.Size(900, 720);
            this.Controls.Add(this.pnlBack);
            this.Name = "MenuScreen";
            this.ResumeLayout(false);
        }

        #endregion

        private BubbleShooter.BackdropPanel pnlBack;
        private BubbleShooter.OrbControl orbA;
        private BubbleShooter.OrbControl orbB;
        private BubbleShooter.OrbControl orbC;
        private BubbleShooter.GlassPanel pnlCard;
        private BubbleShooter.GradientLabel lblTitle;
        private System.Windows.Forms.Label lblSub;
        private BubbleShooter.GlassPanel pnlInput;
        private System.Windows.Forms.TextBox txtName;
        private BubbleShooter.GlowButton btnPlay;
        private BubbleShooter.GlowButton btnScores;
        private BubbleShooter.GlowButton btnSettings;
        private BubbleShooter.GlowButton btnHelp;
        private BubbleShooter.GlowButton btnAbout;
    }
}
