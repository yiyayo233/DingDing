namespace WinformBubble
{
    partial class Item
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
            this.lblContent = new System.Windows.Forms.Label();
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.skinContextMenuStrip1 = new CCWin.SkinControl.SkinContextMenuStrip();
            this.复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.日程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.代办ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DuiHuaRenName = new System.Windows.Forms.Label();
            this.touXiangBG = new WinformBubble.TouXiang();
            this.touXiangZJ = new WinformBubble.TouXiang();
            this.skinPanel1.SuspendLayout();
            this.skinContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblContent.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.lblContent.ForeColor = System.Drawing.Color.Black;
            this.lblContent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblContent.Location = new System.Drawing.Point(6, 10);
            this.lblContent.Margin = new System.Windows.Forms.Padding(0);
            this.lblContent.MaximumSize = new System.Drawing.Size(280, 1000);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(13, 20);
            this.lblContent.TabIndex = 5;
            this.lblContent.Text = " ";
            this.lblContent.Visible = false;
            // 
            // skinPanel1
            // 
            this.skinPanel1.AutoSize = true;
            this.skinPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.skinPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(218)))), ((int)(((byte)(242)))));
            this.skinPanel1.ContextMenuStrip = this.skinContextMenuStrip1;
            this.skinPanel1.Controls.Add(this.lblContent);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(61, 25);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Padding = new System.Windows.Forms.Padding(10, 10, 5, 10);
            this.skinPanel1.Radius = 10;
            this.skinPanel1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinPanel1.Size = new System.Drawing.Size(26, 40);
            this.skinPanel1.TabIndex = 6;
            // 
            // skinContextMenuStrip1
            // 
            this.skinContextMenuStrip1.Arrow = System.Drawing.Color.Black;
            this.skinContextMenuStrip1.Back = System.Drawing.Color.White;
            this.skinContextMenuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.skinContextMenuStrip1.BackRadius = 5;
            this.skinContextMenuStrip1.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.skinContextMenuStrip1.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skinContextMenuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.skinContextMenuStrip1.Fore = System.Drawing.Color.Black;
            this.skinContextMenuStrip1.HoverFore = System.Drawing.Color.Black;
            this.skinContextMenuStrip1.ItemAnamorphosis = false;
            this.skinContextMenuStrip1.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.skinContextMenuStrip1.ItemBorderShow = false;
            this.skinContextMenuStrip1.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.skinContextMenuStrip1.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.skinContextMenuStrip1.ItemRadius = 5;
            this.skinContextMenuStrip1.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.skinContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.复制ToolStripMenuItem,
            this.粘贴ToolStripMenuItem,
            this.日程ToolStripMenuItem,
            this.代办ToolStripMenuItem});
            this.skinContextMenuStrip1.ItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinContextMenuStrip1.Name = "skinContextMenuStrip1";
            this.skinContextMenuStrip1.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinContextMenuStrip1.Size = new System.Drawing.Size(107, 100);
            this.skinContextMenuStrip1.SkinAllColor = true;
            this.skinContextMenuStrip1.TitleAnamorphosis = false;
            this.skinContextMenuStrip1.TitleColor = System.Drawing.Color.Transparent;
            this.skinContextMenuStrip1.TitleRadius = 5;
            this.skinContextMenuStrip1.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            // 
            // 复制ToolStripMenuItem
            // 
            this.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
            this.复制ToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.复制ToolStripMenuItem.Text = "复制";
            // 
            // 粘贴ToolStripMenuItem
            // 
            this.粘贴ToolStripMenuItem.Name = "粘贴ToolStripMenuItem";
            this.粘贴ToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.粘贴ToolStripMenuItem.Text = "粘贴";
            // 
            // 日程ToolStripMenuItem
            // 
            this.日程ToolStripMenuItem.Name = "日程ToolStripMenuItem";
            this.日程ToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.日程ToolStripMenuItem.Text = "日程";
            // 
            // 代办ToolStripMenuItem
            // 
            this.代办ToolStripMenuItem.Name = "代办ToolStripMenuItem";
            this.代办ToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.代办ToolStripMenuItem.Text = "代办";
            // 
            // DuiHuaRenName
            // 
            this.DuiHuaRenName.AutoSize = true;
            this.DuiHuaRenName.Font = new System.Drawing.Font("阿里巴巴普惠体", 9F);
            this.DuiHuaRenName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(122)))), ((int)(((byte)(131)))));
            this.DuiHuaRenName.Location = new System.Drawing.Point(61, 4);
            this.DuiHuaRenName.Name = "DuiHuaRenName";
            this.DuiHuaRenName.Size = new System.Drawing.Size(43, 17);
            this.DuiHuaRenName.TabIndex = 10;
            this.DuiHuaRenName.Text = "label1";
            this.DuiHuaRenName.Visible = false;
            // 
            // touXiangBG
            // 
            this.touXiangBG.Location = new System.Drawing.Point(15, 8);
            this.touXiangBG.Name = "touXiangBG";
            this.touXiangBG.Size = new System.Drawing.Size(40, 40);
            this.touXiangBG.TabIndex = 9;
            this.touXiangBG.Visible = false;
            // 
            // touXiangZJ
            // 
            this.touXiangZJ.Location = new System.Drawing.Point(93, 21);
            this.touXiangZJ.Name = "touXiangZJ";
            this.touXiangZJ.Size = new System.Drawing.Size(40, 40);
            this.touXiangZJ.TabIndex = 8;
            this.touXiangZJ.Visible = false;
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.DuiHuaRenName);
            this.Controls.Add(this.touXiangBG);
            this.Controls.Add(this.touXiangZJ);
            this.Controls.Add(this.skinPanel1);
            this.Name = "Item";
            this.Padding = new System.Windows.Forms.Padding(5, 10, 10, 5);
            this.Size = new System.Drawing.Size(146, 73);
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.skinContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContent;
        private CCWin.SkinControl.SkinPanel skinPanel1;
        private CCWin.SkinControl.SkinContextMenuStrip skinContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 日程ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 代办ToolStripMenuItem;
        private TouXiang touXiangZJ;
        private TouXiang touXiangBG;
        private System.Windows.Forms.Label DuiHuaRenName;
    }
}