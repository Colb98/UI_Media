namespace UI_Media
{
    partial class PlayingUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Timer timer1;
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pos = new System.Windows.Forms.Label();
            this.seek = new System.Windows.Forms.TrackBar();
            this.rewind = new UI_Media.CircularButton();
            this.fforward = new UI_Media.CircularButton();
            this.play = new UI_Media.CircularButton();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.spectrum1 = new LedControllerWS2801.Spectrum();
            this.elementHost3 = new System.Windows.Forms.Integration.ElementHost();
            this.pb2 = new LedControllerWS2801.PB();
            this.elementHost2 = new System.Windows.Forms.Integration.ElementHost();
            this.pb1 = new LedControllerWS2801.PB();
            this.repeat = new System.Windows.Forms.Button();
            timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seek)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 200;
            timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.repeat);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pos);
            this.panel1.Controls.Add(this.seek);
            this.panel1.Controls.Add(this.rewind);
            this.panel1.Controls.Add(this.fforward);
            this.panel1.Controls.Add(this.play);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 179);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(641, 81);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(564, 28);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(74, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "dummy";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "dummy";
            this.label1.Visible = false;
            // 
            // pos
            // 
            this.pos.AutoSize = true;
            this.pos.ForeColor = System.Drawing.Color.White;
            this.pos.Location = new System.Drawing.Point(3, 28);
            this.pos.Name = "pos";
            this.pos.Size = new System.Drawing.Size(0, 26);
            this.pos.TabIndex = 2;
            // 
            // seek
            // 
            this.seek.AutoSize = false;
            this.seek.Dock = System.Windows.Forms.DockStyle.Top;
            this.seek.Enabled = false;
            this.seek.LargeChange = 50;
            this.seek.Location = new System.Drawing.Point(0, 0);
            this.seek.Maximum = 1000;
            this.seek.Name = "seek";
            this.seek.Size = new System.Drawing.Size(641, 26);
            this.seek.TabIndex = 1;
            this.seek.TickStyle = System.Windows.Forms.TickStyle.None;
            this.seek.MouseCaptureChanged += new System.EventHandler(this.seek_ValueChanged);
            // 
            // rewind
            // 
            this.rewind.BackgroundImage = global::UI_Media.Properties.Resources.rewind;
            this.rewind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rewind.FlatAppearance.BorderSize = 0;
            this.rewind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rewind.Location = new System.Drawing.Point(183, 24);
            this.rewind.Name = "rewind";
            this.rewind.Size = new System.Drawing.Size(54, 54);
            this.rewind.TabIndex = 0;
            this.rewind.UseVisualStyleBackColor = true;
            this.rewind.Click += new System.EventHandler(this.rewind_Click);
            // 
            // fforward
            // 
            this.fforward.BackgroundImage = global::UI_Media.Properties.Resources.fast_forward;
            this.fforward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.fforward.FlatAppearance.BorderSize = 0;
            this.fforward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fforward.Location = new System.Drawing.Point(343, 24);
            this.fforward.Name = "fforward";
            this.fforward.Size = new System.Drawing.Size(54, 54);
            this.fforward.TabIndex = 0;
            this.fforward.UseVisualStyleBackColor = true;
            this.fforward.Click += new System.EventHandler(this.fforward_Click);
            // 
            // play
            // 
            this.play.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.play.BackgroundImage = global::UI_Media.Properties.Resources.play_button;
            this.play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.play.FlatAppearance.BorderSize = 0;
            this.play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play.Location = new System.Drawing.Point(263, 24);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(54, 54);
            this.play.TabIndex = 0;
            this.play.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(8, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 34);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Visible = false;
            // 
            // elementHost1
            // 
            this.elementHost1.BackColorTransparent = true;
            this.elementHost1.Location = new System.Drawing.Point(31, 38);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(581, 135);
            this.elementHost1.TabIndex = 6;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Visible = false;
            this.elementHost1.Child = this.spectrum1;
            // 
            // elementHost3
            // 
            this.elementHost3.Location = new System.Drawing.Point(246, 38);
            this.elementHost3.Name = "elementHost3";
            this.elementHost3.Size = new System.Drawing.Size(80, 21);
            this.elementHost3.TabIndex = 5;
            this.elementHost3.Text = "elementHost3";
            this.elementHost3.Visible = false;
            this.elementHost3.Child = this.pb2;
            // 
            // elementHost2
            // 
            this.elementHost2.Location = new System.Drawing.Point(162, 38);
            this.elementHost2.Name = "elementHost2";
            this.elementHost2.Size = new System.Drawing.Size(78, 21);
            this.elementHost2.TabIndex = 4;
            this.elementHost2.Text = "elementHost2";
            this.elementHost2.Visible = false;
            this.elementHost2.Child = this.pb1;
            // 
            // repeat
            // 
            this.repeat.FlatAppearance.BorderSize = 0;
            this.repeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.repeat.Font = new System.Drawing.Font("Microsoft MHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repeat.ForeColor = System.Drawing.Color.White;
            this.repeat.Location = new System.Drawing.Point(418, 42);
            this.repeat.Margin = new System.Windows.Forms.Padding(0);
            this.repeat.Name = "repeat";
            this.repeat.Size = new System.Drawing.Size(98, 36);
            this.repeat.TabIndex = 5;
            this.repeat.UseVisualStyleBackColor = true;
            this.repeat.Click += new System.EventHandler(this.repeat_Click);
            // 
            // PlayingUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.elementHost1);
            this.Controls.Add(this.elementHost3);
            this.Controls.Add(this.elementHost2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft MHei", 14.25F);
            this.Name = "PlayingUC";
            this.Size = new System.Drawing.Size(641, 260);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CircularButton rewind;
        private CircularButton fforward;
        private CircularButton play;
        private System.Windows.Forms.TrackBar seek;
        private System.Windows.Forms.Label pos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Integration.ElementHost elementHost2;
        private LedControllerWS2801.PB pb1;
        private System.Windows.Forms.Integration.ElementHost elementHost3;
        private LedControllerWS2801.PB pb2;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private LedControllerWS2801.Spectrum spectrum1;
        private System.Windows.Forms.Button repeat;
    }
}
