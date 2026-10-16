using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BubbleShooter
{
    // Màn bảng thành tích: ListView đọc từ danh sách điểm (file bubble_scores.txt).
    public partial class ScoresScreen : UserControl
    {
        public event EventHandler BackClicked;

        public ScoresScreen()
        {
            InitializeComponent();
        }

        // đổ danh sách điểm vào bảng (tối đa 10 dòng)
        public void ShowScores(List<ScoreEntry> list)
        {
            lvScores.Items.Clear();
            Color[] medal = { Color.Gold, Color.Silver, Color.FromArgb(205, 127, 50) };
            for (int i = 0; i < list.Count && i < 10; i++)
            {
                ScoreEntry s = list[i];
                ListViewItem it = new ListViewItem(new string[]
                {
                    (i + 1).ToString(), s.Name, s.Score.ToString("N0"), s.Difficulty, s.Date
                });
                if (i < 3) it.ForeColor = medal[i];
                lvScores.Items.Add(it);
            }
            bool has = lvScores.Items.Count > 0;
            lvScores.Visible = has;
            lblEmpty.Visible = !has;
        }

        private void btnBack_Click(object sender, EventArgs e) { if (BackClicked != null) BackClicked(this, e); }
    }
}
