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
    public partial class WorkAdviceSelect : Form
    {
        public WorkAdviceSelect()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            WorkSitAdvice restAdvice = new WorkSitAdvice
            {
                //窗口置顶
                TopMost = true
            };
            restAdvice.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            WorkAdvicePic restAdvicePic = new WorkAdvicePic
            {
                TopMost = true
            };
            restAdvicePic.Show();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            WorkAdviceVideo workAdviceVideo = new WorkAdviceVideo
            {
                TopMost = true
            };
            workAdviceVideo.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            PDFViewer pdfViewer = new PDFViewer();
            pdfViewer.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            WebViewer webViewer = new WebViewer();
            webViewer.Show();
        }
    }
}
