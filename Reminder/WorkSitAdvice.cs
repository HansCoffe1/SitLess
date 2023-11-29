using 坐不住;
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
    public partial class WorkSitAdvice : Form
    {
        public WorkSitAdvice()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;// 最大化窗口
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblText_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            PDFViewer  pDFViewer = new PDFViewer();
            pDFViewer.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void label3_Click(object sender, EventArgs e)
        {
            WebViewer webViewer = new WebViewer();
            webViewer.Show();
        }
    }
}
