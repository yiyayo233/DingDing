namespace WindowsFormsApp1
{
    partial class TongXunQunZu
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TongXunQunZu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Txt_RenShu = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Txt_QunZuName = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox_Top = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Top)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Txt_RenShu);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.Txt_QunZuName);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.pictureBox_Top);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 60);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown_1);
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // Txt_RenShu
            // 
            this.Txt_RenShu.AutoSize = true;
            this.Txt_RenShu.Font = new System.Drawing.Font("阿里巴巴普惠体", 9F);
            this.Txt_RenShu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(188)))), ((int)(((byte)(198)))));
            this.Txt_RenShu.Location = new System.Drawing.Point(74, 35);
            this.Txt_RenShu.Name = "Txt_RenShu";
            this.Txt_RenShu.Size = new System.Drawing.Size(43, 17);
            this.Txt_RenShu.TabIndex = 8;
            this.Txt_RenShu.Text = "label1";
            this.Txt_RenShu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown_1);
            this.Txt_RenShu.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.Txt_RenShu.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(822, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 60);
            this.panel5.TabIndex = 7;
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown_1);
            this.panel5.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.panel5.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // Txt_QunZuName
            // 
            this.Txt_QunZuName.AutoSize = true;
            this.Txt_QunZuName.Font = new System.Drawing.Font("阿里巴巴普惠体", 12F);
            this.Txt_QunZuName.Location = new System.Drawing.Point(74, 12);
            this.Txt_QunZuName.Name = "Txt_QunZuName";
            this.Txt_QunZuName.Size = new System.Drawing.Size(74, 22);
            this.Txt_QunZuName.TabIndex = 6;
            this.Txt_QunZuName.Text = "群组名称";
            this.Txt_QunZuName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown_1);
            this.Txt_QunZuName.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.Txt_QunZuName.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(65, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 60);
            this.panel4.TabIndex = 2;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown_1);
            this.panel4.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.panel4.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // pictureBox_Top
            // 
            this.pictureBox_Top.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox_Top.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Top.Image")));
            this.pictureBox_Top.Location = new System.Drawing.Point(25, 0);
            this.pictureBox_Top.Name = "pictureBox_Top";
            this.pictureBox_Top.Size = new System.Drawing.Size(40, 60);
            this.pictureBox_Top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Top.TabIndex = 1;
            this.pictureBox_Top.TabStop = false;
            this.pictureBox_Top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown_1);
            this.pictureBox_Top.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.pictureBox_Top.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(25, 60);
            this.panel3.TabIndex = 0;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown_1);
            this.panel3.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.panel3.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // TongXunQunZu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "TongXunQunZu";
            this.Size = new System.Drawing.Size(832, 60);
            this.Load += new System.EventHandler(this.TongXunQunZu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Top)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label Txt_QunZuName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox_Top;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Txt_RenShu;
    }
}
