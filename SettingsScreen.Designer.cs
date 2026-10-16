namespace BubbleShooter
{
    partial class SettingsScreen
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
            this.lblDiffHead = new System.Windows.Forms.Label();
            this.btnEasy = new BubbleShooter.GlowButton();
            this.btnMed = new BubbleShooter.GlowButton();
            this.btnHard = new BubbleShooter.GlowButton();
            this.lblDiffDesc = new System.Windows.Forms.Label();
            this.lblSoundHead = new System.Windows.Forms.Label();
            this.btnSound = new BubbleShooter.GlowButton();
            this.lblNote = new System.Windows.Forms.Label();
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
            this.lblTitle.Location = new System.Drawing.Point(0, 25);
            this.lblTitle.Size = new System.Drawing.Size(540, 50);
            this.lblTitle.Text = "Cài đặt";
            //
            // lblDiffHead
            //
            this.lblDiffHead.Name = "lblDiffHead";
            this.lblDiffHead.AutoSize = false;
            this.lblDiffHead.BackColor = System.Drawing.Color.Transparent;
            this.lblDiffHead.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblDiffHead.ForeColor = System.Drawing.Color.White;
            this.lblDiffHead.Location = new System.Drawing.Point(30, 95);
            this.lblDiffHead.Size = new System.Drawing.Size(480, 26);
            this.lblDiffHead.Text = "Độ khó";
            this.lblDiffHead.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // btnEasy
            //
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnEasy.Location = new System.Drawing.Point(30, 135);
            this.btnEasy.Size = new System.Drawing.Size(150, 46);
            this.btnEasy.Text = "Dễ";
            this.btnEasy.Icon = "star1";
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);
            //
            // btnMed
            //
            this.btnMed.Name = "btnMed";
            this.btnMed.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnMed.Location = new System.Drawing.Point(195, 135);
            this.btnMed.Size = new System.Drawing.Size(150, 46);
            this.btnMed.Text = "Trung bình";
            this.btnMed.Icon = "star2";
            this.btnMed.Filled = true;
            this.btnMed.Click += new System.EventHandler(this.btnMed_Click);
            //
            // btnHard
            //
            this.btnHard.Name = "btnHard";
            this.btnHard.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnHard.Location = new System.Drawing.Point(360, 135);
            this.btnHard.Size = new System.Drawing.Size(150, 46);
            this.btnHard.Text = "Khó";
            this.btnHard.Icon = "star3";
            this.btnHard.Click += new System.EventHandler(this.btnHard_Click);
            //
            // lblDiffDesc
            //
            this.lblDiffDesc.Name = "lblDiffDesc";
            this.lblDiffDesc.AutoSize = false;
            this.lblDiffDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblDiffDesc.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDiffDesc.ForeColor = System.Drawing.Color.FromArgb(185, 190, 225);
            this.lblDiffDesc.Location = new System.Drawing.Point(30, 198);
            this.lblDiffDesc.Size = new System.Drawing.Size(480, 50);
            this.lblDiffDesc.Text = "5 màu bóng. Thanh thời gian 15 giây. Bắn trượt 6 lần thì lưới tụt.";
            this.lblDiffDesc.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            //
            // lblSoundHead
            //
            this.lblSoundHead.Name = "lblSoundHead";
            this.lblSoundHead.AutoSize = false;
            this.lblSoundHead.BackColor = System.Drawing.Color.Transparent;
            this.lblSoundHead.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblSoundHead.ForeColor = System.Drawing.Color.White;
            this.lblSoundHead.Location = new System.Drawing.Point(30, 270);
            this.lblSoundHead.Size = new System.Drawing.Size(480, 26);
            this.lblSoundHead.Text = "Âm thanh";
            this.lblSoundHead.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // btnSound
            //
            this.btnSound.Name = "btnSound";
            this.btnSound.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnSound.Location = new System.Drawing.Point(30, 305);
            this.btnSound.Size = new System.Drawing.Size(480, 50);
            this.btnSound.Text = "Âm thanh: BẬT";
            this.btnSound.Icon = "sound";
            this.btnSound.Filled = true;
            this.btnSound.Click += new System.EventHandler(this.btnSound_Click);
            //
            // lblNote
            //
            this.lblNote.Name = "lblNote";
            this.lblNote.AutoSize = false;
            this.lblNote.BackColor = System.Drawing.Color.Transparent;
            this.lblNote.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNote.ForeColor = System.Drawing.Color.FromArgb(185, 190, 225);
            this.lblNote.Location = new System.Drawing.Point(30, 370);
            this.lblNote.Size = new System.Drawing.Size(480, 60);
            this.lblNote.Text = "Độ khó áp dụng từ ván chơi mới. Phím M bật/tắt âm thanh khi đang chơi.";
            this.lblNote.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            //
            // btnBack
            //
            this.btnBack.Name = "btnBack";
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnBack.Location = new System.Drawing.Point(150, 500);
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
            this.pnlCard.Controls.Add(this.lblDiffHead);
            this.pnlCard.Controls.Add(this.btnEasy);
            this.pnlCard.Controls.Add(this.btnMed);
            this.pnlCard.Controls.Add(this.btnHard);
            this.pnlCard.Controls.Add(this.lblDiffDesc);
            this.pnlCard.Controls.Add(this.lblSoundHead);
            this.pnlCard.Controls.Add(this.btnSound);
            this.pnlCard.Controls.Add(this.lblNote);
            this.pnlCard.Controls.Add(this.btnBack);
            //
            // SettingsScreen
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Size = new System.Drawing.Size(900, 720);
            this.Controls.Add(this.pnlBack);
            this.Name = "SettingsScreen";
            this.ResumeLayout(false);
        }

        #endregion

        private BubbleShooter.BackdropPanel pnlBack;
        private BubbleShooter.OrbControl orbA;
        private BubbleShooter.OrbControl orbB;
        private BubbleShooter.GlassPanel pnlCard;
        private BubbleShooter.GradientLabel lblTitle;
        private System.Windows.Forms.Label lblDiffHead;
        private BubbleShooter.GlowButton btnEasy;
        private BubbleShooter.GlowButton btnMed;
        private BubbleShooter.GlowButton btnHard;
        private System.Windows.Forms.Label lblDiffDesc;
        private System.Windows.Forms.Label lblSoundHead;
        private BubbleShooter.GlowButton btnSound;
        private System.Windows.Forms.Label lblNote;
        private BubbleShooter.GlowButton btnBack;
    }
}
