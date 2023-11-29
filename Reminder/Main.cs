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
    public partial class Main : Form
    {
        Work workForm;
        public Main()
        {
            InitializeComponent();
        }
        private void MainLoad(object sender, EventArgs e)
        {
            this.TopMost = true;

        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            //设置托盘图标
            this.notifyIcon1.Icon = new Icon("Resources\\坐不住.ico");
            //设置托盘图标的显示文本
            this.notifyIcon1.Text = "坐不住";
            //设置托盘图标的显示类型
            this.notifyIcon1.Visible = true;
            //设置托盘图标的菜单
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            
        }

        /// <summary>
        ///  开始按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_start_Click(object sender, EventArgs e)
        {
            bool inputFlag;// 是否输入工作内容

            if (this.ckBoxInput.Checked)// 是否输入工作内容
            {
                inputFlag = true;
            }
            else {
                inputFlag = false;
            }
            // 传入工作时间和休息时间
            int workTime = (int)this.numWrkTime.Value;
            int restTime = (int)this.numRstTime.Value;
            // 创建工作窗口
            workForm = new Work(workTime,restTime,inputFlag);
            workForm.Show();
            //MainFrm.Visible = false;
            this.Visible = false;// 隐藏主窗口

        }

        /// <summary>
        ///  系统托盘图标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 主窗体ToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            this.Visible = true;// 显示主窗口

            this.TopMost = true;// 窗口置顶

            this.WindowState = FormWindowState.Normal;// 还原窗口
            //if (workForm !=null)// 关闭工作窗口
            //{
            //    workForm.Close();
            //}
            workForm?.Close();

        }

        /// <summary>
        ///  系统托盘图标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainClosing(object sender, FormClosingEventArgs e)
        {            
            //取消关闭窗口
            e.Cancel = true;
            //最小化主窗口
            this.WindowState = FormWindowState.Minimized;
            this.Visible = false;// 隐藏主窗口
            //不在系统任务栏显示主窗口图标
            this.ShowInTaskbar = false;
        }

        /// <summary>
        ///  系统托盘图标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 退出Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;// 隐藏托盘图标
            //Application.Exit(); // 退出程序和所有线程
            notifyIcon1.Dispose();// 释放资源 避免托盘图标的堆积问题
            System.Environment.Exit(0);// 强制退出所有消息中止退出程序
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 关于Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }


        //
        //private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        //{
        //    if (WindowState == FormWindowState.Minimized)
        //    {
        //        //还原窗体显示
        //        WindowState = FormWindowState.Normal;
        //        //激活窗体并给予它焦点
        //        this.Activate();
        //        //任务栏区显示图标
        //        this.ShowInTaskbar = true;
        //        //托盘区图标隐藏
        //        notifyIcon1.Visible = false;
        //    }
        //}

    }
}
