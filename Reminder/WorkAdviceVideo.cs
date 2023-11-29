using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 坐不住
{
    public partial class WorkAdviceVideo : Form
    {
        public WorkAdviceVideo()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;// 最大化窗口
            this.axWindowsMediaPlayer1.stretchToFit = true;
            //this.axWindowsMediaPlayer1.settings.autoStart = false;// 设置自动播放
            this.axWindowsMediaPlayer1.URL = Application.StartupPath + "\\Resources\\常在电脑前办公办公人员如何保持正确坐姿.mp4";
            //this.axWindowsMediaPlayer1.Ctlcontrols.play();

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 停止播放视频
            this.axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
