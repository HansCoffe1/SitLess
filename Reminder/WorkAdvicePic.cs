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
    public partial class WorkAdvicePic : Form
    {
        public WorkAdvicePic()
        {
            InitializeComponent();
        }

        // 在窗体加载时，显示第一张图片
        private void Form1_Load(object sender, EventArgs e)
        {
            // 设置窗体的状态为最大化
            this.WindowState = FormWindowState.Maximized;
            // 设置图片如何在PictureBox中显示，这里使用了StretchImage模式，可以根据需要修改
            //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            //pictureBox1.Anchor = AnchorStyles.None;//设置图片居中显示
        }

        
    }
}
