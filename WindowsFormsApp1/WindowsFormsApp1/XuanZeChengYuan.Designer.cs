namespace WindowsFormsApp1
{
    partial class XuanZeChengYuan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XuanZeChengYuan));
            this.TopPanelGsName = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Txt_Name = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelAll = new System.Windows.Forms.Panel();
            this.RadioButtonAll = new CCWin.SkinControl.SkinRadioButton();
            this.xuanZeYongHu1 = new WindowsFormsApp1.XuanZeYongHu();
            this.TopPanelGsName.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelAll.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanelGsName
            // 
            this.TopPanelGsName.Controls.Add(this.panel1);
            this.TopPanelGsName.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanelGsName.Location = new System.Drawing.Point(0, 0);
            this.TopPanelGsName.Name = "TopPanelGsName";
            this.TopPanelGsName.Size = new System.Drawing.Size(342, 46);
            this.TopPanelGsName.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Txt_Name);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(15, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(103, 33);
            this.panel1.TabIndex = 9;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Txt_Name_MouseClick);
            // 
            // Txt_Name
            // 
            this.Txt_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Txt_Name.AutoSize = true;
            this.Txt_Name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Txt_Name.Font = new System.Drawing.Font("阿里巴巴普惠体", 12F);
            this.Txt_Name.Location = new System.Drawing.Point(24, 6);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(74, 22);
            this.Txt_Name.TabIndex = 6;
            this.Txt_Name.Text = "公司名称";
            this.Txt_Name.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Txt_Name_MouseClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(4, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 15);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Txt_Name_MouseClick);
            // 
            // panelAll
            // 
            this.panelAll.Controls.Add(this.RadioButtonAll);
            this.panelAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAll.Location = new System.Drawing.Point(0, 46);
            this.panelAll.Name = "panelAll";
            this.panelAll.Size = new System.Drawing.Size(342, 45);
            this.panelAll.TabIndex = 1;
            this.panelAll.MouseEnter += new System.EventHandler(this.panelAll_MouseEnter);
            this.panelAll.MouseLeave += new System.EventHandler(this.panelAll_MouseLeave);
            // 
            // RadioButtonAll
            // 
            this.RadioButtonAll.AutoSize = true;
            this.RadioButtonAll.BackColor = System.Drawing.Color.Transparent;
            this.RadioButtonAll.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(210)))), ((int)(((byte)(212)))));
            this.RadioButtonAll.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.RadioButtonAll.DefaultRadioButtonWidth = 15;
            this.RadioButtonAll.DownBack = null;
            this.RadioButtonAll.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.RadioButtonAll.Location = new System.Drawing.Point(19, 10);
            this.RadioButtonAll.MouseBack = null;
            this.RadioButtonAll.Name = "RadioButtonAll";
            this.RadioButtonAll.NormlBack = null;
            this.RadioButtonAll.SelectedDownBack = null;
            this.RadioButtonAll.SelectedMouseBack = null;
            this.RadioButtonAll.SelectedNormlBack = null;
            this.RadioButtonAll.Size = new System.Drawing.Size(55, 24);
            this.RadioButtonAll.TabIndex = 0;
            this.RadioButtonAll.TabStop = true;
            this.RadioButtonAll.Text = "全选";
            this.RadioButtonAll.UseVisualStyleBackColor = false;
            this.RadioButtonAll.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RadioButtonAll_MouseClick);
            this.RadioButtonAll.MouseEnter += new System.EventHandler(this.panelAll_MouseEnter);
            this.RadioButtonAll.MouseLeave += new System.EventHandler(this.panelAll_MouseLeave);
            // 
            // xuanZeYongHu1
            // 
            this.xuanZeYongHu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.xuanZeYongHu1.Location = new System.Drawing.Point(0, 91);
            this.xuanZeYongHu1.Name = "xuanZeYongHu1";
            this.xuanZeYongHu1.Size = new System.Drawing.Size(342, 45);
            this.xuanZeYongHu1.TabIndex = 2;
            // 
            // XuanZeChengYuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.xuanZeYongHu1);
            this.Controls.Add(this.panelAll);
            this.Controls.Add(this.TopPanelGsName);
            this.Name = "XuanZeChengYuan";
            this.Size = new System.Drawing.Size(342, 491);
            this.TopPanelGsName.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelAll.ResumeLayout(false);
            this.panelAll.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanelGsName;
        private System.Windows.Forms.Panel panelAll;
        private System.Windows.Forms.Label Txt_Name;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private CCWin.SkinControl.SkinRadioButton RadioButtonAll;
        private XuanZeYongHu xuanZeYongHu1;
    }
}
