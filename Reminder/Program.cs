using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace 坐不住
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]//指示程序的属性和行为
        static void Main()
        {
            bool ExisFlag = false;// 进程标记
            System.Diagnostics.Process currentProccess = System.Diagnostics.Process.GetCurrentProcess();// 获取当前进程
            System.Diagnostics.Process[] currentProccessArray = System.Diagnostics.Process.GetProcesses();// 获取当前运行中的所有进程
            foreach (System.Diagnostics.Process p in currentProccessArray)//遍历所有进程
            {
                //如果进程名和进程id重复了
                if (p.ProcessName == currentProccess.ProcessName && p.Id != currentProccess.Id)
                {
                    ExisFlag = true;//进程标记为true
                }
            }

            if (ExisFlag)//防止程序二次运行
            {
                MessageBox.Show("程序运行中，见右下角系统托盘");
                return;
            }
            else//正常运行
            {
                Application.EnableVisualStyles();// 使窗体样式与操作系统的当前主题一致
                Application.SetCompatibleTextRenderingDefault(false);// 设置应用程序的文本显示使用默认的字体
                Application.Run(new Main());
            }
           
        }
    }
}
