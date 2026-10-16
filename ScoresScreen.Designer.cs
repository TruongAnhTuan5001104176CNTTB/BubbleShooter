namespace BubbleShooter
{
    partial class ScoresScreen
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
            this.lblH1 = new System.Windows.Forms.Label();
            this.lblH2 = new System.Windows.Forms.Label();
            this.lblH3 = new System.Windows.Forms.Label();
            this.lblH4 = new System.Windows.Forms.Label();
            this.lblH5 = new System.Windows.Forms.Label();
            this.lvScores = new System.Windows.Forms.ListView();
            this.lblEmpty = new System.Windows.Forms.Label();
            this.btnBack = new BubbleShooter.GlowButton();
            this.colRank = new System.Windows.Forms.ColumnHeader();
            this.colName = new System.Windows.Forms.ColumnHeader();
            this.colScore = new System.Windows.Forms.ColumnHeader();
            this.colDiff = new System.Windows.Forms.ColumnHeader();
            this.colDate = new System.Windows.Forms.ColumnHeader();
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
            this.lblTitle.Text = "Bảng thành tích";
            //
            // lblH1
            //
            this.lblH1.Name = "lblH1";
            this.lblH1.AutoSize = false;
            this.lblH1.BackColor = System.Drawing.Color.Transparent;
            this.lblH1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblH1.ForeColor = System.Drawing.Color.FromArgb(185, 190, 225);
            this.lblH1.Location = new System.Drawing.Point(30, 88);
            this.lblH1.Size = new System.Drawing.Size(40, 20);
            this.lblH1.Text = "#";
            this.lblH1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblH2
            //
            this.lblH2.Name = "lblH2";
            this.lblH2.AutoSize = false;
            this.lblH2.BackColor = System.Drawing.Color.Transparent;
            this.lblH2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblH2.ForeColor = System.Drawing.Color.FromArgb(185, 190, 225);
            this.lblH2.Location = new System.Drawing.Point(75, 88);
            this.lblH2.Size = new System.Drawing.Size(140, 20);
            this.lblH2.Text = "TÊN";
            this.lblH2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblH3
            //
            this.lblH3.Name = "lblH3";
            this.lblH3.AutoSize = false;
            this.lblH3.BackColor = System.Drawing.Color.Transparent;
            this.lblH3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblH3.ForeColor = System.Drawing.Color.FromArgb(185, 190, 225);
            this.lblH3.Location = new System.Drawing.Point(215, 88);
            this.lblH3.Size = new System.Drawing.Size(95, 20);
            this.lblH3.Text = "ĐIỂM";
            this.lblH3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // lblH4
            //
            this.lblH4.Name = "lblH4";
            this.lblH4.AutoSize = false;
            this.lblH4.BackColor = System.Drawing.Color.Transparent;
            this.lblH4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblH4.ForeColor = System.Drawing.Color.FromArgb(185, 190, 225);
            this.lblH4.Location = new System.Drawing.Point(325, 88);
            this.lblH4.Size = new System.Drawing.Size(100, 20);
            this.lblH4.Text = "ĐỘ KHÓ";
            this.lblH4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblH5
            //
            this.lblH5.Name = "lblH5";
            this.lblH5.AutoSize = false;
            this.lblH5.BackColor = System.Drawing.Color.Transparent;
            this.lblH5.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblH5.ForeColor = System.Drawing.Color.FromArgb(185, 190, 225);
            this.lblH5.Location = new System.Drawing.Point(435, 88);
            this.lblH5.Size = new System.Drawing.Size(80, 20);
            this.lblH5.Text = "NGÀY";
            this.lblH5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lvScores
            //
            this.lvScores.Name = "lvScores";
            this.lvScores.BackColor = System.Drawing.Color.FromArgb(32, 22, 76);
            this.lvScores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvScores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { this.colRank, this.colName, this.colScore, this.colDiff, this.colDate });
            this.lvScores.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lvScores.ForeColor = System.Drawing.Color.White;
            this.lvScores.FullRowSelect = true;
            this.lvScores.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvScores.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            new System.Windows.Forms.ListViewItem(new string[] { "1", "Linh", "5.420", "Trung bình", "12/10/26" }, -1),
            new System.Windows.Forms.ListViewItem(new string[] { "2", "Minh", "4.980", "Khó", "11/10/26" }, -1),
            new System.Windows.Forms.ListViewItem(new string[] { "3", "Hà", "4.210", "Dễ", "12/10/26" }, -1),
            new System.Windows.Forms.ListViewItem(new string[] { "4", "Bảo", "3.860", "Trung bình", "10/10/26" }, -1)
            });
            this.lvScores.Location = new System.Drawing.Point(25, 112);
            this.lvScores.Size = new System.Drawing.Size(490, 380);
            this.lvScores.View = System.Windows.Forms.View.Details;
            this.lvScores.GridLines = false;
            this.lvScores.HideSelection = false;
            //
            // lblEmpty
            //
            this.lblEmpty.Name = "lblEmpty";
            this.lblEmpty.AutoSize = false;
            this.lblEmpty.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpty.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblEmpty.ForeColor = System.Drawing.Color.FromArgb(185, 190, 225);
            this.lblEmpty.Location = new System.Drawing.Point(25, 220);
            this.lblEmpty.Size = new System.Drawing.Size(490, 70);
            this.lblEmpty.Text = "Chưa có thành tích nào.\nHãy chơi ván đầu tiên!";
            this.lblEmpty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEmpty.Visible = false;
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
            //
            // colRank
            //
            this.colRank.Name = "colRank";
            this.colRank.Text = "#";
            this.colRank.Width = 45;
            this.colRank.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            //
            // colName
            //
            this.colName.Name = "colName";
            this.colName.Text = "Tên";
            this.colName.Width = 150;
            this.colName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            //
            // colScore
            //
            this.colScore.Name = "colScore";
            this.colScore.Text = "Điểm";
            this.colScore.Width = 95;
            this.colScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // colDiff
            //
            this.colDiff.Name = "colDiff";
            this.colDiff.Text = "Độ khó";
            this.colDiff.Width = 110;
            this.colDiff.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            //
            // colDate
            //
            this.colDate.Name = "colDate";
            this.colDate.Text = "Ngày";
            this.colDate.Width = 90;
            this.colDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // gắn control con vào pnlBack
            this.pnlBack.Controls.Add(this.orbA);
            this.pnlBack.Controls.Add(this.orbB);
            this.pnlBack.Controls.Add(this.pnlCard);
            // gắn control con vào pnlCard
            this.pnlCard.Controls.Add(this.lblTitle);
            this.pnlCard.Controls.Add(this.lblH1);
            this.pnlCard.Controls.Add(this.lblH2);
            this.pnlCard.Controls.Add(this.lblH3);
            this.pnlCard.Controls.Add(this.lblH4);
            this.pnlCard.Controls.Add(this.lblH5);
            this.pnlCard.Controls.Add(this.lvScores);
            this.pnlCard.Controls.Add(this.lblEmpty);
            this.pnlCard.Controls.Add(this.btnBack);
            //
            // ScoresScreen
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Size = new System.Drawing.Size(900, 720);
            this.Controls.Add(this.pnlBack);
            this.Name = "ScoresScreen";
            this.ResumeLayout(false);
        }

        #endregion

        private BubbleShooter.BackdropPanel pnlBack;
        private BubbleShooter.OrbControl orbA;
        private BubbleShooter.OrbControl orbB;
        private BubbleShooter.GlassPanel pnlCard;
        private BubbleShooter.GradientLabel lblTitle;
        private System.Windows.Forms.Label lblH1;
        private System.Windows.Forms.Label lblH2;
        private System.Windows.Forms.Label lblH3;
        private System.Windows.Forms.Label lblH4;
        private System.Windows.Forms.Label lblH5;
        private System.Windows.Forms.ListView lvScores;
        private System.Windows.Forms.Label lblEmpty;
        private BubbleShooter.GlowButton btnBack;
        private System.Windows.Forms.ColumnHeader colRank;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colScore;
        private System.Windows.Forms.ColumnHeader colDiff;
        private System.Windows.Forms.ColumnHeader colDate;
    }
}
