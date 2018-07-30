namespace UI_Media
{
    partial class PlayMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayMainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_songs = new System.Windows.Forms.Button();
            this.btn_about = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.playingUC1 = new UI_Media.PlayingUC();
            this.aboutUC1 = new UI_Media.AboutUC();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btn_play);
            this.panel1.Controls.Add(this.btn_songs);
            this.panel1.Controls.Add(this.btn_about);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 288);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(641, 86);
            this.panel1.TabIndex = 0;
            // 
            // btn_play
            // 
            this.btn_play.FlatAppearance.BorderSize = 0;
            this.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_play.ForeColor = System.Drawing.Color.White;
            this.btn_play.Location = new System.Drawing.Point(0, 0);
            this.btn_play.Margin = new System.Windows.Forms.Padding(0);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(117, 86);
            this.btn_play.TabIndex = 0;
            this.btn_play.Text = "Playing";
            this.btn_play.UseVisualStyleBackColor = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_songs
            // 
            this.btn_songs.FlatAppearance.BorderSize = 0;
            this.btn_songs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_songs.ForeColor = System.Drawing.Color.White;
            this.btn_songs.Location = new System.Drawing.Point(117, 0);
            this.btn_songs.Margin = new System.Windows.Forms.Padding(0);
            this.btn_songs.Name = "btn_songs";
            this.btn_songs.Size = new System.Drawing.Size(117, 86);
            this.btn_songs.TabIndex = 0;
            this.btn_songs.Text = "Playlist";
            this.btn_songs.UseVisualStyleBackColor = false;
            this.btn_songs.Click += new System.EventHandler(this.btn_songs_Click);
            // 
            // btn_about
            // 
            this.btn_about.FlatAppearance.BorderSize = 0;
            this.btn_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_about.ForeColor = System.Drawing.Color.White;
            this.btn_about.Location = new System.Drawing.Point(234, 0);
            this.btn_about.Margin = new System.Windows.Forms.Padding(0);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(117, 86);
            this.btn_about.TabIndex = 0;
            this.btn_about.Text = "About";
            this.btn_about.UseVisualStyleBackColor = false;
            this.btn_about.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft MHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(577, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button4.Size = new System.Drawing.Size(64, 27);
            this.button4.TabIndex = 0;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft MHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(513, -1);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button5.Size = new System.Drawing.Size(64, 28);
            this.button5.TabIndex = 0;
            this.button5.Text = "_";
            this.button5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(641, 28);
            this.panel2.TabIndex = 2;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Media Player";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // playingUC1
            // 
            this.playingUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.playingUC1.duration = System.TimeSpan.Parse("00:00:00");
            this.playingUC1.Font = new System.Drawing.Font("Microsoft MHei", 14.25F);
            this.playingUC1.ForeColor = System.Drawing.Color.White;
            this.playingUC1.Location = new System.Drawing.Point(0, 28);
            this.playingUC1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.playingUC1.Name = "playingUC1";
            this.playingUC1.Size = new System.Drawing.Size(641, 260);
            this.playingUC1.TabIndex = 3;
            this.playingUC1.Visible = false;
            // 
            // aboutUC1
            // 
            this.aboutUC1.AutoSize = true;
            this.aboutUC1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.aboutUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.aboutUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutUC1.Font = new System.Drawing.Font("Microsoft MHei", 14.25F);
            this.aboutUC1.ForeColor = System.Drawing.Color.White;
            this.aboutUC1.Location = new System.Drawing.Point(0, 28);
            this.aboutUC1.Margin = new System.Windows.Forms.Padding(0);
            this.aboutUC1.Name = "aboutUC1";
            this.aboutUC1.Size = new System.Drawing.Size(641, 260);
            this.aboutUC1.TabIndex = 1;
            this.aboutUC1.Visible = false;
            // 
            // PlayMainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(641, 374);
            this.Controls.Add(this.playingUC1);
            this.Controls.Add(this.aboutUC1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft MHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PlayMainForm";
            this.Text = "Player";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.PlayMainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.PlayMainForm_DragEnter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PlayMainForm_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_about;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_songs;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private AboutUC aboutUC1;
        private System.Windows.Forms.Panel panel2;
        private PlayingUC playingUC1;
        private System.Windows.Forms.Label label1;
    }
}

