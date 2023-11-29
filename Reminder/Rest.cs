using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace 坐不住
{
    public partial class Rest : Form
    {
        private int restM;
        private int workM;
        private int restM2;
        private bool inputFlag;
        int restSec = 0;
        
        public Rest()
        {
            InitializeComponent();
        }
        
        /// <summary>
        ///  重载构造
        /// </summary>
        /// <param name="restMins"></param>
        /// <param name="workMins"></param>
        /// <param name="inputFlag"></param>
        public Rest(int restMins,int workMins, bool inputFlag)
        {
            InitializeComponent();
            this.restM = restMins;
            this.workM = workMins;
            this.restM2 = restMins;
            this.inputFlag = inputFlag;
        }
        /// <summary>
        ///  窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void RestFrm_Load(object sender, EventArgs e)
        {           
            if (inputFlag)// 如果是锁定键盘的模式
            {
                lblText.Text = "您已久坐" + workM.ToString() + "分钟了，键盘和鼠标被锁定，站起来活动下！";
            }
            else// 如果是弹窗提醒的模式
            {
                lblText.Text = "您已久坐" + workM.ToString() + "分钟了，站起来活动下！Alt+F4 退出本界面。";
            }

            //lblText.Text = "您已久坐60分钟了，键盘和鼠标被锁定，站起来活动下！";

            TimerRest.Enabled = true;     // 启动计时器
            this.TopMost = true;// 窗体置顶
           
            this.WindowState = FormWindowState.Maximized;// 最大化窗体
            this.Opacity = 0.75;// 设置窗体透明度
            if (inputFlag)
            {
                KeyBlocker.off();//锁定键盘               
            }

            if (restSec >= 10)
            {
                lbl_seconds.Text = restSec.ToString();
            }
            else
            {
                lbl_seconds.Text = "0"+restSec.ToString();
            }


            if (restM >= 10)
            {
                lbl_minutes.Text = restM.ToString();
            }
            else
            {
                lbl_minutes.Text = "0" + restM.ToString();
            }
        }

        /// <summary>
        ///  计时器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerRestTick(object sender, EventArgs e)
        {
            timing();
        }

        /// <summary>
        ///  计时
        /// </summary>
        private void timing()
        {
            if (restSec > 0)
            {
                restSec = restSec - 1;
                if (restSec >= 10)
                {
                    lbl_seconds.Text = restSec.ToString();
                }
                else
                {
                    lbl_seconds.Text = "0"+restSec.ToString();
                }
                
            }
            else //秒=0时，分钟-1
            {
                TimerRest.Enabled = false; // 暂停计时器
                restM--;// 分钟-1
                if (restM >=10) {
                    lbl_minutes.Text = restM.ToString();// 显示分钟
                }
                else
                {
                    lbl_minutes.Text = "0"+restM.ToString();// 显示分钟
                }
                
                if (restM > -1) //若分钟不为0，秒回到60，继续递归
                {
                    TimerRest.Enabled = true;// 继续计时
                    restSec = 59;// 秒回到60
                    timing();// 递归
                }
                else
                {                    
                    if (inputFlag)// 如果是锁定键盘的模式
                    {                       
                        KeyBlocker.on();//解锁键盘
                    }

                    if (restSec == 0)// 如果休息时间到了
                    {
                        Work workFrm = new Work(workM, restM2, inputFlag);// 实例化Work窗体
                        workFrm.Show();
                    }
                    this.Close();
                }
            }
        }

        private void RestClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void RestClosing(object sender, FormClosingEventArgs e)
        {
            //Work work = new WorkFrm(workM, restM2, inputFlag);
           // work.Show();
        }

        private void lblText_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        ///  点击“休息建议”标签，弹出休息建议窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label4_Click(object sender, EventArgs e)
        {
            RestAdviceSelect restAdviceSelect = new RestAdviceSelect
            {
                //弹出 RestAdviceSelect 窗体 并置顶显示
                TopMost = true
            };
            restAdviceSelect .Show();


        }
    }
}
