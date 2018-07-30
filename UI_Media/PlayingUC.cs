using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LedControllerWS2801;

namespace UI_Media
{
    public partial class PlayingUC : UserControl
    {
        public TimeSpan duration { get; set; }

        Analyzer analyzer;

        public PlayingUC()
        {
            InitializeComponent();
            duration = new TimeSpan(0);

            Un4seen.Bass.BassNet.Registration("naruvssasu@gmail.com", "2X143820152222");
            analyzer = new Analyzer(pb1, pb2, spectrum1, comboBox1);
            analyzer.Enable = true;
            analyzer.DisplayEnable = true;

            switch (PlayMainForm.repeat_mode)
            {
                case 0:
                    repeat.Text = "No Repeat";
                    break;
                case 1:
                    repeat.Text = "Repeat One";
                    break;
                case 2:
                    repeat.Text = "Repeat All";
                    break;
            }
        }
        

        private void seek_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan temp = new TimeSpan(seek.Value * duration.Ticks / seek.Maximum);
            label1.Text = temp.ToString(@"hh\:mm\:ss");

            PlayMainForm.mediaPlayer.Position = temp;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (PlayMainForm.playing == false) 
                return;
            if (seek.Capture == true && Control.MouseButtons == MouseButtons.Left)           
                return;           

            int pos = (int)(seek.Maximum * 1.0 * PlayMainForm.mediaPlayer.Position.Ticks / duration.Ticks);
            if (pos > seek.Maximum)
                pos = seek.Maximum;
            seek.Value = pos;
            label1.Text = PlayMainForm.mediaPlayer.Position.ToString(@"hh\:mm\:ss");            
        }

        private void fforward_Click(object sender, EventArgs e)
        {
            TimeSpan dt = new TimeSpan(0, 0, 10);
            PlayMainForm.mediaPlayer.Position += dt;
            label1.Text = PlayMainForm.mediaPlayer.Position.ToString(@"hh\:mm\:ss");
        }

        private void rewind_Click(object sender, EventArgs e)
        {
            TimeSpan dt = new TimeSpan(0, 0, 10);
            PlayMainForm.mediaPlayer.Position -= dt;
            label1.Text = PlayMainForm.mediaPlayer.Position.ToString(@"hh\:mm\:ss");
        }

        private void repeat_Click(object sender, EventArgs e)
        {
            PlayMainForm.repeat_mode = (PlayMainForm.repeat_mode + 1) % 3;
            switch (PlayMainForm.repeat_mode)
            {
                case 0:
                    repeat.Text = "No Repeat";
                    break;
                case 1:
                    repeat.Text = "Repeat One";
                    break;
                case 2:
                    repeat.Text = "Repeat All";
                    break;
            }
        }
    }
}
