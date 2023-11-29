using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 坐不住
{
    public partial class Work : Form
    {
        private int workMins;//工作时间(分)
        private int workSec;//工作时间(秒)
        private readonly int workM;
        private int restMins;//休息时间(分)
        private bool inputFlag;//是否选中锁定键盘
        private bool leftFlag;//鼠标左键是否点击
        private Point mouseOff;//鼠标移动位置变量
        public Work()
        {
            InitializeComponent();
        }

        //定义一个构造函数，接受前一个窗体传来的参数
        public Work(int workMins, int restMins, bool inputFlag)
        {
            InitializeComponent();           
            this.workMins = workMins;
            this.restMins = restMins;
            //this.input_flag = input_flag;
            this.workM = workMins;
            this.inputFlag = inputFlag;

            int x = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Size.Width - 160;
            int y = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Size.Height - 90;
            Point p = new Point(x, y);
            this.PointToScreen(p);
            this.Location = p;
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

            //任务栏高度
            //Size OutTaskBarSize = new Size(SystemInformation.WorkingArea.Width, SystemInformation.WorkingArea.Height);
            //Size ScreenSize = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            //this.Height = ScreenSize.Height - OutTaskBarSize.Height;
            //Size TaskBarSize;

            //TaskBarSize = new Size(
            //                (ScreenSize.Width - (ScreenSize.Width - OutTaskBarSize.Width)),
            //                (ScreenSize.Height - OutTaskBarSize.Height)
            //               );


            workSec = 0; // 初始化秒数

            if (workSec >= 10)// 判断秒数是否大于10
            {
                lblSecond.Text = workSec.ToString();// 显示秒数
            }
            else //workSec<10  显示格式为0x
            {
                lblSecond.Text = "0" + workSec.ToString();// 显示秒数
            }

            if (workMins >=10) //判断分钟数是否大于10
            {
                lblMin.Text = workMins.ToString();// 显示分钟数
            }
            else // workMins<10 显示格式为0x
            {
                lblMin.Text = "0"+workMins.ToString();
            }

            this.Opacity = 0.8;// 设置窗体透明度
            
        }
        /// <summary>
        /// 定时器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer(object sender, EventArgs e)
        {
            timing();
        }

        /// <summary>
        /// 递归的方式倒计时
        /// </summary>
        public  void timing()
        {
            Warn();// 工作的最后15秒提醒
            
            if (workSec > 0)//  秒数不为0时，秒数-1
            {
                workSec = workSec - 1;// 秒数-1
                
                if (workSec >= 10)// 判断秒数是否大于10
                {
                    lblSecond.Text = workSec.ToString();// 显示秒数
                }
                else //workSec<10  显示格式为0x
                {
                    lblSecond.Text = "0" + workSec.ToString();// 显示秒数
                }
            }
            // 
            else //秒=0时，分钟-1
            {
                timer.Enabled = false;// 关闭定时器
                workMins--;// 分钟-1
                if (workMins >= 10)
                {
                    lblMin.Text = workMins.ToString();
                }
                else
                {
                    lblMin.Text = "0"+ workMins.ToString();
                }
                
                if (workMins > -1) //若分钟不为0，秒回到60，继续递归
                {
                    timer.Enabled = true;// 开启定时器
                    workSec = 60;// 秒数回到60
                    
                    timing();// 递归
                }
                else// 若分钟为0，秒为0，关闭窗体
                {
                    this.Close();
                    Rest restFrm = new Rest(restMins, workM, inputFlag);
                    restFrm.ShowDialog();                   
                }
            }
        }

        /// <summary>
        /// 工作的最后15秒提醒
        /// </summary>
        private void Warn()
        {
            if (workMins ==0&&workSec <=16)// 工作的最后15秒提醒
            {
                this.BackColor = Color.Red;// 窗体背景色调整为红
                lblWarn.ForeColor = Color.Yellow;// 提示信息颜色调整为黄
                lblWarn.Text = "该休息了！";// 提示信息

                int x = (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Size.Width) / 2 - this.Width/2;
                int y = (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Size.Height) / 2 - this.Height/2;
                Point p = new Point(x, y);// 窗体位置
                this.PointToScreen(p);
                this.Location = p;
            }         
            
        }

        /// <summary>
        /// 让程序不显示在alt+Tab视图窗体中
        /// </summary>
        protected override CreateParams CreateParams// 重写CreateParams属性
        {
            get// 重写get方法
            {
                const int WS_EX_APPWINDOW = 0x40000;
                const int WS_EX_TOOLWINDOW = 0x80;
                CreateParams cp = base.CreateParams;
                cp.ExStyle &= (~WS_EX_APPWINDOW);    // 不显示在TaskBar
                cp.ExStyle |= WS_EX_TOOLWINDOW;      // 不显示在Alt+Tab
                return cp;
            }
        }


        private void MainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void LblSecond_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        ///  鼠标按下
        /// </summary>
        /// <param name="e"></param>
        private void mouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)// 判断鼠标左键是否按下
            {
                mouseOff = new Point(e.X, e.Y);// 获取鼠标按下的位置
                leftFlag = true;// 标记为true

            }
        }
        /// <summary>
        ///   移动窗体
        /// </summary>
        private void mouseMove()
        {
            if (leftFlag)// 判断鼠标左键是否按下
            {
                Point mouseSet = Control.MousePosition;// 获取鼠标位置
                mouseSet.Offset(-mouseOff.X, -mouseOff.Y);// 设置偏移量
                //这里注意下-的用意，offset
                Location = mouseSet;// 设置窗体位置
            }
        }
        /// <summary>
        ///  鼠标抬起
        /// </summary>
        private void mouseUp()
        {
            if (leftFlag)// 判断鼠标左键是否按下
            {
                leftFlag = false;// 标记为false
            }
        }
        private void WorkMouseDown(object sender, MouseEventArgs e)
        {
            mouseDown(e);// 调用鼠标按下方法
        }

        private void WorkMouseMove(object sender, MouseEventArgs e)
        {
            mouseMove();
        }

        private void WorkMouseUp(object sender, MouseEventArgs e)
        {
            mouseUp();
        }

      

        private void LblWarn_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void LblWarn_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void LblWarn_MouseUp(object sender, MouseEventArgs e)
        {
           
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            WorkAdviceSelect workAdviceSelect = new WorkAdviceSelect();
            workAdviceSelect.ShowDialog();
        }

        private void lblMin_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
