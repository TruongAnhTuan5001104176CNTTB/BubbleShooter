using System;
using System.Windows.Forms;

namespace BubbleShooter
{
    public partial class HelpScreen : UserControl
    {
        public event EventHandler BackClicked;

        public HelpScreen()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e) { if (BackClicked != null) BackClicked(this, e); }
    }
}
