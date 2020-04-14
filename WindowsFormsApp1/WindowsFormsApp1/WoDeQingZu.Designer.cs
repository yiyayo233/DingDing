namespace WindowsFormsApp1
{
    partial class WoDeQingZu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WoDeQingZu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Txt_TopName = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox_Top = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.skinPanel8 = new CCWin.SkinControl.SkinPanel();
            this.panelLieBiao = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Top)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.Txt_TopName);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.pictureBox_Top);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 60);
            this.panel1.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(822, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 60);
            this.panel5.TabIndex = 7;
            // 
            // Txt_TopName
            // 
            this.Txt_TopName.AutoSize = true;
            this.Txt_TopName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Txt_TopName.Location = new System.Drawing.Point(78, 19);
            this.Txt_TopName.Name = "Txt_TopName";
            this.Txt_TopName.Size = new System.Drawing.Size(74, 21);
            this.Txt_TopName.TabIndex = 6;
            this.Txt_TopName.Text = "我的群组";
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(65, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 60);
            this.panel4.TabIndex = 2;
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
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(25, 60);
            this.panel3.TabIndex = 0;
            // 
            // skinPanel8
            // 
            this.skinPanel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.skinPanel8.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel8.DownBack = null;
            this.skinPanel8.Location = new System.Drawing.Point(0, 60);
            this.skinPanel8.MouseBack = null;
            this.skinPanel8.Name = "skinPanel8";
            this.skinPanel8.NormlBack = null;
            this.skinPanel8.Size = new System.Drawing.Size(832, 1);
            this.skinPanel8.TabIndex = 10;
            // 
            // panelLieBiao
            // 
            this.panelLieBiao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLieBiao.Location = new System.Drawing.Point(0, 61);
            this.panelLieBiao.Name = "panelLieBiao";
            this.panelLieBiao.Size = new System.Drawing.Size(832, 524);
            this.panelLieBiao.TabIndex = 11;
            // 
            // WoDeQingZu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelLieBiao);
            this.Controls.Add(this.skinPanel8);
            this.Controls.Add(this.panel1);
            this.Name = "WoDeQingZu";
            this.Size = new System.Drawing.Size(832, 585);
            this.Load += new System.EventHandler(this.WoDeQingZu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Top)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label Txt_TopName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox_Top;
        private System.Windows.Forms.Panel panel3;
        private CCWin.SkinControl.SkinPanel skinPanel8;
        private System.Windows.Forms.Panel panelLieBiao;
    }
}
