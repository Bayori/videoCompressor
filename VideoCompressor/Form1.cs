using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace VideoCompressor
{

    public partial class Form1 : Form
    {
        private Process ffmpegProcess;


        public string input_video, output_video;
        public int bitrateM = 10;
        public string fileName = "";
  
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            input_video = @textBox_input.Text;
            output_video = @textBox_output.Text;
            bitrateM = Convert.ToInt32(textBox_bitrate.Text);
            textBox_comand.Text = "-i \"" + input_video + "\" -b:v " + bitrateM + "M \"" + output_video + "\"";
            textBox_ffmpegPath.Text = System.Windows.Forms.Application.StartupPath + @"\ffmpeg\ffmpeg.exe";
        }




        private void button1_Click(object sender, EventArgs e)
        {
            // Создание процесса FFmpeg
            ffmpegProcess = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = @textBox_ffmpegPath.Text,
                    Arguments = @textBox_comand.Text,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                },
                EnableRaisingEvents = true
            };

            ffmpegProcess.Start();
            ffmpegProcess.WaitForExit();

        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button_command_Click(object sender, EventArgs e)
        {
            input_video = @textBox_input.Text;
            output_video = @textBox_output.Text;
            try { bitrateM = Math.Abs(Convert.ToInt32(textBox_bitrate.Text)); }
            catch { }
            
            textBox_comand.Text = "-i \"" + input_video + "\" -b:v " + bitrateM + "M \"" + output_video + "\"";
        }

        private void textBox_bitrate_TextChanged(object sender, EventArgs e)
        {
            button_command_Click(sender, e);
        }

        private void textBox_ffmpegPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Создаем новый OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Задаем фильтр для файлов (в данном случае, любые файлы)
            openFileDialog.Filter = "mp4 files|*.mp4";

            // Показываем диалог выбора файла
            DialogResult result = openFileDialog.ShowDialog();

            // Если пользователь выбрал файл, обновляем TextBox с путем к файлу
            if (result == DialogResult.OK)
            {
                textBox_input.Text = openFileDialog.FileName;
            }
            string originalPath = @textBox_input.Text;

            // Находим индексы последней косой черты и первой точки перед расширением файла
            int lastBackslashIndex = originalPath.LastIndexOf('\\');
            int extensionDotIndex = originalPath.LastIndexOf(".mp4");

            // Используем метод Substring, чтобы получить часть строки между последней косой черты и точкой перед расширением файла
            fileName = originalPath.Substring(lastBackslashIndex + 1, extensionDotIndex - lastBackslashIndex - 1);
            lastBackslashIndex = originalPath.LastIndexOf('\\');
            string resultPath = originalPath.Substring(0, lastBackslashIndex + 1);
            textBox_output.Text = resultPath+fileName + "-converted.mp4";
            button_command_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Создаем новый FolderBrowserDialog
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            // Показываем диалог выбора папки
            DialogResult result = folderBrowserDialog.ShowDialog();

            // Если пользователь выбрал папку, обновляем TextBox с путем к папке
            if (result == DialogResult.OK)
            {
                textBox_output.Text = folderBrowserDialog.SelectedPath + @"\" + fileName + "-converted.mp4";
            }
            button_command_Click(sender, e);
        }

        private void textBox_output_TextChanged(object sender, EventArgs e)
        {
            button_command_Click(sender, e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textbox_out_TextChanged(object sender, EventArgs e)
        {
            button_command_Click(sender, e);
        }

    }
}
