using System;
using System.Windows.Forms;

namespace BubbleShooter
{
    public partial class AboutScreen : UserControl
    {
        public event EventHandler BackClicked;

        public AboutScreen()
        {
            InitializeComponent();
            lblGroup.Text = MainForm.GroupName;
            lblMembers.Text = string.Join("\n\n", MainForm.Members);
        }

        private void btnBack_Click(object sender, EventArgs e) { if (BackClicked != null) BackClicked(this, e); }
    }
}
