namespace WindowsFormsApp1
{
    partial class XuanZeYongHu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XuanZeYongHu));
            this.panelDanGe = new System.Windows.Forms.Panel();
            this.TxtYongHuName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RadioButtonDanGe = new CCWin.SkinControl.SkinRadioButton();
            this.panelDanGe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDanGe
            // 
            this.panelDanGe.Controls.Add(this.TxtYongHuName);
            this.panelDanGe.Controls.Add(this.pictureBox1);
            this.panelDanGe.Controls.Add(this.RadioButtonDanGe);
            this.panelDanGe.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDanGe.Location = new System.Drawing.Point(0, 0);
            this.panelDanGe.Name = "panelDanGe";
            this.panelDanGe.Size = new System.Drawing.Size(342, 45);
            this.panelDanGe.TabIndex = 2;
            this.panelDanGe.MouseEnter += new System.EventHandler(this.panelDanGe_MouseEnter);
            this.panelDanGe.MouseLeave += new System.EventHandler(this.panelDanGe_MouseLeave);
            // 
            // TxtYongHuName
            // 
            this.TxtYongHuName.AutoSize = true;
            this.TxtYongHuName.Font = new System.Drawing.Font("阿里巴巴普惠体", 10F);
            this.TxtYongHuName.Location = new System.Drawing.Point(75, 13);
            this.TxtYongHuName.Name = "TxtYongHuName";
            this.TxtYongHuName.Size = new System.Drawing.Size(65, 20);
            this.TxtYongHuName.TabIndex = 2;
            this.TxtYongHuName.Text = "用户名称";
            this.TxtYongHuName.MouseEnter += new System.EventHandler(this.panelDanGe_MouseEnter);
            this.TxtYongHuName.MouseLeave += new System.EventHandler(this.panelDanGe_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.panelDanGe_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.panelDanGe_MouseLeave);
            // 
            // RadioButtonDanGe
            // 
            this.RadioButtonDanGe.AutoSize = true;
            this.RadioButtonDanGe.BackColor = System.Drawing.Color.Transparent;
            this.RadioButtonDanGe.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(210)))), ((int)(((byte)(212)))));
            this.RadioButtonDanGe.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.RadioButtonDanGe.DefaultRadioButtonWidth = 15;
            this.RadioButtonDanGe.DownBack = null;
            this.RadioButtonDanGe.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.RadioButtonDanGe.Location = new System.Drawing.Point(19, 10);
            this.RadioButtonDanGe.MouseBack = null;
            this.RadioButtonDanGe.Name = "RadioButtonDanGe";
            this.RadioButtonDanGe.NormlBack = null;
            this.RadioButtonDanGe.SelectedDownBack = null;
            this.RadioButtonDanGe.SelectedMouseBack = null;
            this.RadioButtonDanGe.SelectedNormlBack = null;
            this.RadioButtonDanGe.Size = new System.Drawing.Size(31, 24);
            this.RadioButtonDanGe.TabIndex = 0;
            this.RadioButtonDanGe.TabStop = true;
            this.RadioButtonDanGe.Text = " ";
            this.RadioButtonDanGe.UseVisualStyleBackColor = false;
            this.RadioButtonDanGe.MouseEnter += new System.EventHandler(this.panelDanGe_MouseEnter);
            this.RadioButtonDanGe.MouseLeave += new System.EventHandler(this.panelDanGe_MouseLeave);
            // 
            // XuanZeYongHu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelDanGe);
            this.Name = "XuanZeYongHu";
            this.Size = new System.Drawing.Size(342, 45);
            this.panelDanGe.ResumeLayout(false);
            this.panelDanGe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDanGe;
        private System.Windows.Forms.Label TxtYongHuName;
        private System.Windows.Forms.PictureBox pictureBox1;
        public CCWin.SkinControl.SkinRadioButton RadioButtonDanGe;
    }
}
