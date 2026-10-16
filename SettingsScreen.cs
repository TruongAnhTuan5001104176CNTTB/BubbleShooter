using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BubbleShooter
{
    // Màn cài đặt: chọn độ khó, bật/tắt âm thanh.
    public partial class SettingsScreen : UserControl
    {
        public event Action<int> DiffChosen;
        public event EventHandler SoundToggled;
        public event EventHandler BackClicked;

        private int diff = 1;
        private bool soundOn = true;

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Diff
        {
            get { return diff; }
            set { diff = value; UpdateButtons(); }
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool SoundOn
        {
            get { return soundOn; }
            set { soundOn = value; UpdateButtons(); }
        }

        public SettingsScreen()
        {
            InitializeComponent();
            UpdateButtons();
        }

        // nút đang chọn thì tô màu (Filled), nút còn lại để trong mờ
        private void UpdateButtons()
        {
            btnEasy.Filled = diff == 0;
            btnMed.Filled = diff == 1;
            btnHard.Filled = diff == 2;
            btnSound.Filled = soundOn;
            btnSound.Text = soundOn ? "Âm thanh: BẬT" : "Âm thanh: TẮT";
            btnSound.Icon = soundOn ? "sound" : "mute";
            lblDiffDesc.Text = MainForm.DiffDesc[diff];
        }

        private void Choose(int d)
        {
            Diff = d;
            if (DiffChosen != null) DiffChosen(d);
        }

        private void btnEasy_Click(object sender, EventArgs e) { Choose(0); }
        private void btnMed_Click(object sender, EventArgs e) { Choose(1); }
        private void btnHard_Click(object sender, EventArgs e) { Choose(2); }
        private void btnSound_Click(object sender, EventArgs e) { if (SoundToggled != null) SoundToggled(this, e); }
        private void btnBack_Click(object sender, EventArgs e) { if (BackClicked != null) BackClicked(this, e); }
    }
}
