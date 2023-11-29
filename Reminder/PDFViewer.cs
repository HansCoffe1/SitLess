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
//using Spire.PdfViewer.Forms;

namespace 坐不住
{
    public partial class PDFViewer : Form
    {
        public PDFViewer()
        {
            InitializeComponent();
            //注册Load事件
            this.Load += PDFViewer_Load;
        }
        
        private void PDFViewer_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;// 最大化窗口
            webView21.Source = new Uri(Path.Combine(Environment.CurrentDirectory, "PDF\\2020世卫组织关于身体活动和久坐行为的指南(chinese).pdf"));
        }

        //private void WebView21_Click(object sender, EventArgs e)
        //{
        //    //webView21.Source = new Uri("PDF\\2020世卫组织关于身体活动和久坐行为的指南(chinese).pdf");
        //    webView21.Source = new Uri(Path.Combine(Environment.CurrentDirectory, "PDF\\2020世卫组织关于身体活动和久坐行为的指南(chinese).pdf"));
        //    //webView21.Source = new Uri(Path.Combine(Environment.CurrentDirectory, "PDF\\2020世卫组织关于身体活动和久坐行为的指南(chinese).pdf"));
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    //加载pdf文件
        //    webView21.Source = new Uri("D:\\test.pdf");
        //}


        //private void button1_Click(object sender, EventArgs e)
        //{
        //    //加载pdf文件
        //    webBrowser1.Url = new Uri("PDF\\2020世卫组织关于身体活动和久坐行为的指南(chinese).pdf");
        //}

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    //拖拽PdfViewer控件到窗体上，并设置Dock属性为Fill
        //    //假设有一个名为test.pdf的文件在项目目录下
        //    //使用LoadFromFile方法来加载pdf文件
        //    //this.pdfViewer1.LoadFromFile(@"C:\Users\Public\Documents\test.pdf");
        //    //this.pdfViewer1.LoadFromFile(@"PDF\\2020世卫组织关于身体活动和久坐行为的指南(chinese).pdf");
        //    this.pdfViewer1.LoadFromFile("C:/Users/William/Desktop/2020世卫组织关于身体活动和久坐行为的指南(chinese).pdf");
        //}
    }
}