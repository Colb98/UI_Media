using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using LedControllerWS2801;
using Un4seen.Bass;


namespace UI_Media
{
    public partial class PlayMainForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public const int REPEAT_NONE = 0x0;
        public const int REPEAT_ONE = 0x1;
        public const int REPEAT_ALL = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public static System.Windows.Media.MediaPlayer mediaPlayer = null;
        public static bool playing = false;

        //Current song index
        static int i = 0;

        public static int repeat_mode = 0;
        static List<string> FilePath = new List<string>();

        public PlayMainForm()
        {
            InitializeComponent();

            CircularButton play = (CircularButton) playingUC2.Controls.Find("play", true)[0];

            play.Click += Play_Click;

            TrackBar seek = (TrackBar)playingUC2.Controls.Find("seek", true)[0];

            seek.ValueChanged += Seek_ValueChanged;

            playlistUC1.AutoScroll = true;
        }

        private void Seek_ValueChanged(object sender, EventArgs e)
        {
            //
        }

        public void changeTitle(int index)
        {
            string FileName = System.IO.Path.GetFileName(FilePath[i]);
            this.Text = label1.Text = FileName + " - Media Player";
        }

        private void Play_Click(object sender, EventArgs e)
        {
            CircularButton btn = (CircularButton)sender;
            if (FilePath == null || FilePath.Count == 0)
                return;
            if (playing == false)
            {
                mediaPlayer.Play();
                playing = true;                
                btn.BackgroundImage = UI_Media.Properties.Resources.pause;

                System.Windows.Forms.Integration.ElementHost spectrum = (System.Windows.Forms.Integration.ElementHost)playingUC2.Controls.Find("elementHost1", true)[0];
                spectrum.Visible = true;                
            }           
            else if(playing == true)
            {
                mediaPlayer.Pause();
                playing = false;
                btn.BackgroundImage = UI_Media.Properties.Resources.play_button;

                System.Windows.Forms.Integration.ElementHost spectrum = (System.Windows.Forms.Integration.ElementHost)playingUC2.Controls.Find("elementHost1", true)[0];
                spectrum.Visible = false;
            }    
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private static TimeSpan GetVideoDuration(string filePath)
        {
            using (var shell = Microsoft.WindowsAPICodePack.Shell.ShellObject.FromParsingName(filePath))
            {
                Microsoft.WindowsAPICodePack.Shell.PropertySystem.IShellProperty prop = shell.Properties.System.Media.Duration;
                var t = (ulong)prop.ValueAsObject;
                return TimeSpan.FromTicks((long)t);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aboutUC1.Visible = true;
            playingUC2.Visible = false;
            playlistUC1.Visible = false;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            playingUC2.Visible = true;
            aboutUC1.Visible = false;
            playlistUC1.Visible = false;
        }

        private void btn_songs_Click(object sender, EventArgs e)
        {
            playingUC2.Visible = false;
            aboutUC1.Visible = false;
            playlistUC1.Visible = true;
        }

        private void PlayMainForm_DragDrop(object sender, DragEventArgs e)
        {
            FilePath.AddRange((string[])e.Data.GetData(DataFormats.FileDrop, false));
            string FileName = System.IO.Path.GetFileName(FilePath[0]);
            this.Text = label1.Text = FileName + " - Media Player";

            playlistUC1.GetList(FilePath);

            if (mediaPlayer == null)
            {
                mediaPlayer = new System.Windows.Media.MediaPlayer();
                mediaPlayer.Open(new Uri(FilePath[0], UriKind.Absolute));

                mediaPlayer.MediaEnded += MediaPlayer_MediaEnded;
                mediaPlayer.MediaOpened += MediaPlayer_MediaOpened;
            }
        }

        private void MediaPlayer_MediaOpened(object sender, EventArgs e)
        {
            changeTitle(i);
            playingUC2.duration = GetVideoDuration(FilePath[i]);

            //Chơi
            CircularButton btn = (CircularButton)playingUC2.Controls.Find("play", true)[0];
            mediaPlayer.Play();
            playing = true;
            btn.BackgroundImage = UI_Media.Properties.Resources.pause;

            //Hiện spectrum
            System.Windows.Forms.Integration.ElementHost spectrum = (System.Windows.Forms.Integration.ElementHost)playingUC2.Controls.Find("elementHost1", true)[0];
            spectrum.Visible = true;

            //Hiện time tổng cộng
            Label lb2 = (Label)playingUC2.Controls.Find("label2", true)[0];
            lb2.Text = playingUC2.duration.ToString(@"hh\:mm\:ss");
            lb2.Visible = true;

            Label lb1 = (Label)playingUC2.Controls.Find("label1", true)[0];
            lb1.Visible = true;
            //Label lb3 = (Label)playingUC2.Controls.Find("label3", true)[0];
            //lb3.Visible = true;

            //Cho phép dùng Seek bar
            TrackBar track = (TrackBar)playingUC2.Controls.Find("seek", true)[0];
            track.Enabled = true;
        }

        private void MediaPlayer_MediaEnded(object sender, EventArgs e)
        {
            if (repeat_mode == 0)
            {
                if(i == FilePath.Count - 1)
                {
                    playing = false;
                    mediaPlayer.Stop();

                    CircularButton btn = (CircularButton)playingUC2.Controls.Find("play", true)[0];
                    btn.BackgroundImage = UI_Media.Properties.Resources.play_button;
                }
                else
                {
                    i++;
                    mediaPlayer.Open(new Uri(FilePath[i], UriKind.Absolute));
                    mediaPlayer.Play();
                }
            }
            else if (repeat_mode == 1)
                mediaPlayer.Position = new TimeSpan(0);
            else
            {
                i = (++i) % FilePath.Count;
                mediaPlayer.Open(new Uri(FilePath[i], UriKind.Absolute));
                mediaPlayer.Play();
                
                string FileName = System.IO.Path.GetFileName(FilePath[i]);
                this.Text = label1.Text = FileName + " - Media Player";
                System.Windows.Forms.Label lb = (System.Windows.Forms.Label)this.playingUC2.Controls.Find("label3", true)[0];
                lb.Text = FileName;
            }                
        }

        private void PlayMainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void PlayMainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (playingUC2.Visible == true)
                if (e.KeyCode == Keys.Right)
                    mediaPlayer.Position.Add(new TimeSpan(0, 0, 10));
                else if(e.KeyCode == Keys.Left)
                    mediaPlayer.Position.Subtract(new TimeSpan(0,0,10));
        }

        public static void Play(int index)
        {
            if (i == index && playing)
                return;
            i = index;
            if (i >= FilePath.Count)
                return;
            mediaPlayer.Open(new Uri(FilePath[i], UriKind.Absolute));
            mediaPlayer.Play();
        }

        public static void Delete(int index)
        {
            FilePath.RemoveAt(index);
        }
    }
}
