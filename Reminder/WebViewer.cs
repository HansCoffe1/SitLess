using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 坐不住
{
    public partial class WebViewer : Form
    {
        public WebViewer()
        {
            InitializeComponent();
            //注册Load事件
            this.Load += WebViewer_Load;
            //    InitializeComponent();
            //    //调用EnsureCoreWebView2Async方法来初始化webView21控件
            //    webView21.EnsureCoreWebView2Async();
            //    //在CoreWebView2InitializationCompleted事件中设置webView21控件的源地址
            //    webView21.CoreWebView2InitializationCompleted += WebView21_CoreWebView2InitializationCompleted;
        }

        private void WebViewer_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;// 最大化窗口
            webView21.Source = new Uri("https://www.who.int/zh");// 加载网页
        }

        //private void WebView21_CoreWebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs e)
        //{
        //    if (e.IsSuccess) 
        //    {
        //        //设置webView21控件的源地址为https://www.who.int/zh/
        //        webView21.Source = new Uri("https://www.who.int/zh/");
        //    }
        //    else
        //    {
        //        //处理初始化失败的情况
        //        MessageBox.Show("初始化失败：" + e.InitializationException.Message);
        //    }
        //}


    }
}
