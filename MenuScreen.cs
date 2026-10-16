using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BubbleShooter
{
    // Màn menu chính. Giao diện (thẻ, tiêu đề, ô nhập tên, các nút) nằm trong MenuScreen.Designer.cs.
    public partial class MenuScreen : UserControl
    {
        public event EventHandler PlayClicked;
        public event EventHandler ScoresClicked;
        public event EventHandler SettingsClicked;
        public event EventHandler HelpClicked;
        public event EventHandler AboutClicked;

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string PlayerName { get { return txtName.Text; } }

        public MenuScreen()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e) { if (PlayClicked != null) PlayClicked(this, e); }
        private void btnScores_Click(object sender, EventArgs e) { if (ScoresClicked != null) ScoresClicked(this, e); }
        private void btnSettings_Click(object sender, EventArgs e) { if (SettingsClicked != null) SettingsClicked(this, e); }
        private void btnHelp_Click(object sender, EventArgs e) { if (HelpClicked != null) HelpClicked(this, e); }
        private void btnAbout_Click(object sender, EventArgs e) { if (AboutClicked != null) AboutClicked(this, e); }
    }
}
