namespace 坐不住
{
    partial class Work
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理 所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Work));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblSecond = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWarn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer);
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.BackColor = System.Drawing.Color.Transparent;
            this.lblSecond.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lblSecond.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecond.ForeColor = System.Drawing.Color.White;
            this.lblSecond.Location = new System.Drawing.Point(126, 53);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(38, 28);
            this.lblSecond.TabIndex = 4;
            this.lblSecond.Text = "  ";
            this.lblSecond.Click += new System.EventHandler(this.LblSecond_Click);
            this.lblSecond.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WorkMouseDown);
            this.lblSecond.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WorkMouseMove);
            this.lblSecond.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WorkMouseUp);
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.BackColor = System.Drawing.Color.Transparent;
            this.lblMin.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.ForeColor = System.Drawing.Color.White;
            this.lblMin.Location = new System.Drawing.Point(65, 53);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(38, 28);
            this.lblMin.TabIndex = 5;
            this.lblMin.Text = "  ";
            this.lblMin.Click += new System.EventHandler(this.lblMin_Click);
            this.lblMin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WorkMouseDown);
            this.lblMin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WorkMouseMove);
            this.lblMin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WorkMouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(98, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = ":";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WorkMouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WorkMouseMove);
            this.label2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WorkMouseUp);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label3.Location = new System.Drawing.Point(4, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 37);
            this.label3.TabIndex = 8;
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WorkMouseDown);
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WorkMouseMove);
            this.label3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WorkMouseUp);
            // 
            // lblWarn
            // 
            this.lblWarn.AutoSize = true;
            this.lblWarn.BackColor = System.Drawing.Color.Transparent;
            this.lblWarn.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lblWarn.Font = new System.Drawing.Font("微软雅黑", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblWarn.ForeColor = System.Drawing.Color.White;
            this.lblWarn.Location = new System.Drawing.Point(55, 9);
            this.lblWarn.Name = "lblWarn";
            this.lblWarn.Size = new System.Drawing.Size(151, 44);
            this.lblWarn.TabIndex = 7;
            this.lblWarn.Text = "注意坐姿";
            this.lblWarn.Click += new System.EventHandler(this.Label1_Click);
            this.lblWarn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WorkMouseDown);
            this.lblWarn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WorkMouseMove);
            this.lblWarn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WorkMouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(183, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "查看坐姿建议";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Work
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(313, 76);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblWarn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblSecond);
            this.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Work";
            this.Opacity = 0.4D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "wrkFrm";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WorkMouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WorkMouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WorkMouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWarn;
        private System.Windows.Forms.Label label1;
    }
}

