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

// 以下是一个基于C#的winform程序，实现了图片翻页的功能
// 假设您已经在窗体上添加了一个PictureBox控件和两个Button控件
// 并且将PictureBox控件的Name属性设置为pictureBox1
// 将两个Button控件的Name属性分别设置为button1和button2
// 将button1的Text属性设置为"上一张"
// 将button2的Text属性设置为"下一张"
// 并且为这两个按钮分别添加了Click事件处理方法

namespace 坐不住
{
    public partial class RestAdvicePic : Form
    {
        public RestAdvicePic()
        {
            InitializeComponent();
        }

        // 定义一个变量来存储图片文件夹的路径，可以根据实际情况修改
        //private static string folderPath = @"C:\Users\user\Pictures";
        private static string folderPath = Application.StartupPath + "\\Pic";

        // 定义一个数组来存储图片文件的路径，使用Directory.GetFiles方法获取
        private string[] photoPaths = Directory.GetFiles(folderPath);

        // 定义一个变量来记录当前显示的图片的索引，初始值为0
        private int currentIndex = 0;

        // 在窗体加载时，显示第一张图片
        private void Form1_Load(object sender, EventArgs e)
        {
            // 设置窗体的状态为最大化
            this.WindowState = FormWindowState.Maximized;
            // 设置图片如何在PictureBox中显示，这里使用了StretchImage模式，可以根据需要修改
            //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            //pictureBox1.Anchor = AnchorStyles.None;//设置图片居中显示

            // 使用Image.FromFile方法从文件路径加载图片，并赋值给PictureBox的Image属性
            pictureBox1.Image = Image.FromFile(photoPaths[currentIndex]);
        }

        // 当点击button1时，显示上一张图片
        private void button1_Click(object sender, EventArgs e)
        {
            // 将当前索引减一
            currentIndex--;

            // 如果当前索引小于0，说明已经到达数组的第一个元素，那么将当前索引设置为数组的最后一个元素的索引
            if (currentIndex < 0)
            {
                currentIndex = photoPaths.Length - 1;
            }
            //pictureBox1.Anchor = AnchorStyles.None;//设置图片居中显示

            // 显示当前索引对应的图片
            pictureBox1.Image = Image.FromFile(photoPaths[currentIndex]);

            // 设置图片显示方式为Zoom
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        // 当点击button2时，显示下一张图片
        private void button2_Click(object sender, EventArgs e)
        {
            // 将当前索引加一
            currentIndex++;

            // 如果当前索引大于等于数组的长度，说明已经到达数组的最后一个元素，那么将当前索引设置为0
            if (currentIndex >= photoPaths.Length)
            {
                currentIndex = 0;
            }
            
            //pictureBox1.Anchor = AnchorStyles.None;//设置图片居中显示

            // 显示当前索引对应的图片
            pictureBox1.Image = Image.FromFile(photoPaths[currentIndex]);

            // 设置图片显示方式
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
