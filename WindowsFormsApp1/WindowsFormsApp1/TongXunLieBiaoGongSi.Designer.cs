namespace WindowsFormsApp1
{
    partial class TongXunLieBiaoGongSi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TongXunLieBiaoGongSi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Txt_GongSiName = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Txt_GongSiName);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 70);
            this.panel1.TabIndex = 2;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Txt_Name_MouseClick);
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // Txt_GongSiName
            // 
            this.Txt_GongSiName.AutoSize = true;
            this.Txt_GongSiName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Txt_GongSiName.Location = new System.Drawing.Point(74, 22);
            this.Txt_GongSiName.Name = "Txt_GongSiName";
            this.Txt_GongSiName.Size = new System.Drawing.Size(74, 21);
            this.Txt_GongSiName.TabIndex = 5;
            this.Txt_GongSiName.Text = "公司名称";
            this.Txt_GongSiName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Txt_Name_MouseClick);
            this.Txt_GongSiName.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.Txt_GongSiName.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(65, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 50);
            this.panel5.TabIndex = 4;
            this.panel5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Txt_Name_MouseClick);
            this.panel5.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.panel5.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Txt_Name_MouseClick);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(15, 50);
            this.panel4.TabIndex = 2;
            this.panel4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Txt_Name_MouseClick);
            this.panel4.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.panel4.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(249, 10);
            this.panel3.TabIndex = 1;
            this.panel3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Txt_Name_MouseClick);
            this.panel3.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.panel3.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 10);
            this.panel2.TabIndex = 0;
            this.panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Txt_Name_MouseClick);
            this.panel2.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.panel2.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 70);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(249, 45);
            this.panel7.TabIndex = 4;
            this.panel7.Visible = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.pictureBox2);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(249, 45);
            this.panel8.TabIndex = 0;
            this.panel8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel8_MouseDown);
            this.panel8.MouseEnter += new System.EventHandler(this.panel8_MouseEnter);
            this.panel8.MouseLeave += new System.EventHandler(this.panel8_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(34, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 15);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel8_MouseDown);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.panel8_MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.panel8_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.label2.Location = new System.Drawing.Point(61, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "按组织架构选择";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel8_MouseDown);
            this.label2.MouseEnter += new System.EventHandler(this.panel8_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.panel8_MouseLeave);
            // 
            // TongXunLieBiaoGongSi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Name = "TongXunLieBiaoGongSi";
            this.Size = new System.Drawing.Size(249, 70);
            this.Load += new System.EventHandler(this.TongXunLieBiaoGongSi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Txt_GongSiName;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
    }
}
