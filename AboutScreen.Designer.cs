namespace BubbleShooter
{
    partial class AboutScreen
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
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblMembers = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
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
            this.lblTitle.Text = "Nhóm thực hiện";
            //
            // lblGroup
            //
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.AutoSize = false;
            this.lblGroup.BackColor = System.Drawing.Color.Transparent;
            this.lblGroup.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblGroup.ForeColor = System.Drawing.Color.White;
            this.lblGroup.Location = new System.Drawing.Point(30, 115);
            this.lblGroup.Size = new System.Drawing.Size(480, 44);
            this.lblGroup.Text = "HACKER";
            this.lblGroup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lblMembers
            //
            this.lblMembers.Name = "lblMembers";
            this.lblMembers.AutoSize = false;
            this.lblMembers.BackColor = System.Drawing.Color.Transparent;
            this.lblMembers.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblMembers.ForeColor = System.Drawing.Color.FromArgb(185, 190, 225);
            this.lblMembers.Location = new System.Drawing.Point(30, 185);
            this.lblMembers.Size = new System.Drawing.Size(480, 210);
            this.lblMembers.Text = "Lương Trường Thành - MSSV: 50.01.104.048\n\nTrương Anh Tuấn - MSSV: 50.01.104.176\n\nTrần Trọng Đức Huy - MSSV: 51.01.104.036\n\nĐoàn Quang Vinh - MSSV: 51.01.104.119";
            this.lblMembers.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            //
            // lblCourse
            //
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.AutoSize = false;
            this.lblCourse.BackColor = System.Drawing.Color.Transparent;
            this.lblCourse.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCourse.ForeColor = System.Drawing.Color.FromArgb(185, 190, 225);
            this.lblCourse.Location = new System.Drawing.Point(30, 410);
            this.lblCourse.Size = new System.Drawing.Size(480, 60);
            this.lblCourse.Text = "Học phần: Lập trình Windows Form\nMini Game: Bubble Pop (Bắn bóng)";
            this.lblCourse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.pnlCard.Controls.Add(this.lblGroup);
            this.pnlCard.Controls.Add(this.lblMembers);
            this.pnlCard.Controls.Add(this.lblCourse);
            this.pnlCard.Controls.Add(this.btnBack);
            //
            // AboutScreen
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Size = new System.Drawing.Size(900, 720);
            this.Controls.Add(this.pnlBack);
            this.Name = "AboutScreen";
            this.ResumeLayout(false);
        }

        #endregion

        private BubbleShooter.BackdropPanel pnlBack;
        private BubbleShooter.OrbControl orbA;
        private BubbleShooter.OrbControl orbB;
        private BubbleShooter.GlassPanel pnlCard;
        private BubbleShooter.GradientLabel lblTitle;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label lblMembers;
        private System.Windows.Forms.Label lblCourse;
        private BubbleShooter.GlowButton btnBack;
    }
}
