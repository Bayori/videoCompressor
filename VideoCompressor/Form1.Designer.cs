namespace VideoCompressor
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.go_button = new System.Windows.Forms.Button();
            this.textBox_ffmpegPath = new System.Windows.Forms.TextBox();
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.textBox_output = new System.Windows.Forms.TextBox();
            this.textBox_comand = new System.Windows.Forms.TextBox();
            this.textBox_bitrate = new System.Windows.Forms.TextBox();
            this.input_label = new System.Windows.Forms.Label();
            this.output_label = new System.Windows.Forms.Label();
            this.ffmpeg_label = new System.Windows.Forms.Label();
            this.command_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // go_button
            // 
            this.go_button.Location = new System.Drawing.Point(635, 395);
            this.go_button.Name = "go_button";
            this.go_button.Size = new System.Drawing.Size(153, 43);
            this.go_button.TabIndex = 0;
            this.go_button.Text = "Convert";
            this.go_button.UseVisualStyleBackColor = true;
            this.go_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_ffmpegPath
            // 
            this.textBox_ffmpegPath.Location = new System.Drawing.Point(12, 125);
            this.textBox_ffmpegPath.Name = "textBox_ffmpegPath";
            this.textBox_ffmpegPath.Size = new System.Drawing.Size(620, 20);
            this.textBox_ffmpegPath.TabIndex = 2;
            this.textBox_ffmpegPath.Text = "\\ffmpeg\\ffmpeg.exe";
            this.textBox_ffmpegPath.TextChanged += new System.EventHandler(this.textBox_ffmpegPath_TextChanged);
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(12, 46);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(620, 20);
            this.textBox_input.TabIndex = 3;
            this.textBox_input.Text = "C:\\path\\to\\mp4.mp4";
            // 
            // textBox_output
            // 
            this.textBox_output.Location = new System.Drawing.Point(12, 86);
            this.textBox_output.Name = "textBox_output";
            this.textBox_output.Size = new System.Drawing.Size(620, 20);
            this.textBox_output.TabIndex = 4;
            this.textBox_output.Text = "C:\\path\\to\\output\\folder";
            this.textBox_output.TextChanged += new System.EventHandler(this.textBox_output_TextChanged);
            // 
            // textBox_comand
            // 
            this.textBox_comand.Location = new System.Drawing.Point(12, 188);
            this.textBox_comand.Name = "textBox_comand";
            this.textBox_comand.Size = new System.Drawing.Size(620, 20);
            this.textBox_comand.TabIndex = 5;
            this.textBox_comand.Text = "-i";
            // 
            // textBox_bitrate
            // 
            this.textBox_bitrate.Location = new System.Drawing.Point(719, 86);
            this.textBox_bitrate.Name = "textBox_bitrate";
            this.textBox_bitrate.Size = new System.Drawing.Size(37, 20);
            this.textBox_bitrate.TabIndex = 6;
            this.textBox_bitrate.Text = "10";
            this.textBox_bitrate.TextChanged += new System.EventHandler(this.textBox_bitrate_TextChanged);
            // 
            // input_label
            // 
            this.input_label.AutoSize = true;
            this.input_label.Location = new System.Drawing.Point(9, 30);
            this.input_label.Name = "input_label";
            this.input_label.Size = new System.Drawing.Size(73, 13);
            this.input_label.TabIndex = 8;
            this.input_label.Text = "Input .mp4 file";
            // 
            // output_label
            // 
            this.output_label.AutoSize = true;
            this.output_label.Location = new System.Drawing.Point(9, 70);
            this.output_label.Name = "output_label";
            this.output_label.Size = new System.Drawing.Size(81, 13);
            this.output_label.TabIndex = 9;
            this.output_label.Text = "Output .mp4 file";
            // 
            // ffmpeg_label
            // 
            this.ffmpeg_label.AutoSize = true;
            this.ffmpeg_label.Location = new System.Drawing.Point(9, 109);
            this.ffmpeg_label.Name = "ffmpeg_label";
            this.ffmpeg_label.Size = new System.Drawing.Size(83, 13);
            this.ffmpeg_label.TabIndex = 10;
            this.ffmpeg_label.Text = "ffmpeg.exe path";
            // 
            // command_label
            // 
            this.command_label.AutoSize = true;
            this.command_label.Location = new System.Drawing.Point(9, 172);
            this.command_label.Name = "command_label";
            this.command_label.Size = new System.Drawing.Size(282, 13);
            this.command_label.TabIndex = 11;
            this.command_label.Text = "ffmpeg command (Manual changes are not recommended)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(761, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mbit";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(638, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(638, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::VideoCompressor.Properties.Resources.shocked_shocked_cat;
            this.pictureBox3.InitialImage = global::VideoCompressor.Properties.Resources.photo_2023_11_14_21_19_10;
            this.pictureBox3.Location = new System.Drawing.Point(389, 233);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(204, 194);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::VideoCompressor.Properties.Resources.photo_2023_11_14_21_19_09;
            this.pictureBox2.InitialImage = global::VideoCompressor.Properties.Resources.photo_2023_11_14_21_19_10;
            this.pictureBox2.Location = new System.Drawing.Point(229, 233);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(139, 194);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VideoCompressor.Properties.Resources.photo_2023_11_14_21_19_10;
            this.pictureBox1.InitialImage = global::VideoCompressor.Properties.Resources.photo_2023_11_14_21_19_10;
            this.pictureBox1.Location = new System.Drawing.Point(73, 233);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.command_label);
            this.Controls.Add(this.ffmpeg_label);
            this.Controls.Add(this.output_label);
            this.Controls.Add(this.input_label);
            this.Controls.Add(this.textBox_bitrate);
            this.Controls.Add(this.textBox_comand);
            this.Controls.Add(this.textBox_output);
            this.Controls.Add(this.textBox_input);
            this.Controls.Add(this.textBox_ffmpegPath);
            this.Controls.Add(this.go_button);
            this.Name = "Form1";
            this.Text = "Video Bitrate Compressor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button go_button;
        private System.Windows.Forms.TextBox textBox_ffmpegPath;
        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.TextBox textBox_output;
        private System.Windows.Forms.TextBox textBox_comand;
        private System.Windows.Forms.TextBox textBox_bitrate;
        private System.Windows.Forms.Label input_label;
        private System.Windows.Forms.Label output_label;
        private System.Windows.Forms.Label ffmpeg_label;
        private System.Windows.Forms.Label command_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

