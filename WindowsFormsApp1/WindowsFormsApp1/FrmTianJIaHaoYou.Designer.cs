namespace WindowsFormsApp1
{
    partial class FrmTianJIaHaoYou
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.skinPanel2 = new CCWin.SkinControl.SkinPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Text_ShuRuYHld = new CCWin.SkinControl.SkinTextBox();
            this.ButFaXiaoXi = new CCWin.SkinControl.SkinButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.skinPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinPanel2
            // 
            this.skinPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.skinPanel2.Controls.Add(this.label1);
            this.skinPanel2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel2.DownBack = null;
            this.skinPanel2.Location = new System.Drawing.Point(0, 0);
            this.skinPanel2.MouseBack = null;
            this.skinPanel2.Name = "skinPanel2";
            this.skinPanel2.NormlBack = null;
            this.skinPanel2.Radius = 20;
            this.skinPanel2.Size = new System.Drawing.Size(413, 50);
            this.skinPanel2.TabIndex = 1;
            this.skinPanel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.skinPanel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.skinPanel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label1.Location = new System.Drawing.Point(24, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "添加好友";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.skinButton1);
            this.panel1.Controls.Add(this.ButFaXiaoXi);
            this.panel1.Controls.Add(this.Text_ShuRuYHld);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("宋体", 9F);
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 138);
            this.panel1.TabIndex = 2;
            // 
            // Text_ShuRuYHld
            // 
            this.Text_ShuRuYHld.BackColor = System.Drawing.Color.Transparent;
            this.Text_ShuRuYHld.DownBack = null;
            this.Text_ShuRuYHld.Icon = null;
            this.Text_ShuRuYHld.IconIsButton = false;
            this.Text_ShuRuYHld.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.Text_ShuRuYHld.IsPasswordChat = '\0';
            this.Text_ShuRuYHld.IsSystemPasswordChar = false;
            this.Text_ShuRuYHld.Lines = new string[0];
            this.Text_ShuRuYHld.Location = new System.Drawing.Point(28, 18);
            this.Text_ShuRuYHld.Margin = new System.Windows.Forms.Padding(0);
            this.Text_ShuRuYHld.MaxLength = 32767;
            this.Text_ShuRuYHld.MinimumSize = new System.Drawing.Size(28, 28);
            this.Text_ShuRuYHld.MouseBack = null;
            this.Text_ShuRuYHld.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.Text_ShuRuYHld.Multiline = false;
            this.Text_ShuRuYHld.Name = "Text_ShuRuYHld";
            this.Text_ShuRuYHld.NormlBack = null;
            this.Text_ShuRuYHld.Padding = new System.Windows.Forms.Padding(5);
            this.Text_ShuRuYHld.ReadOnly = false;
            this.Text_ShuRuYHld.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Text_ShuRuYHld.Size = new System.Drawing.Size(355, 28);
            // 
            // 
            // 
            this.Text_ShuRuYHld.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Text_ShuRuYHld.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Text_ShuRuYHld.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.Text_ShuRuYHld.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.Text_ShuRuYHld.SkinTxt.Name = "BaseText";
            this.Text_ShuRuYHld.SkinTxt.Size = new System.Drawing.Size(345, 16);
            this.Text_ShuRuYHld.SkinTxt.TabIndex = 0;
            this.Text_ShuRuYHld.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.Text_ShuRuYHld.SkinTxt.WaterText = "请输入手机号/钉钉号";
            this.Text_ShuRuYHld.TabIndex = 0;
            this.Text_ShuRuYHld.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Text_ShuRuYHld.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.Text_ShuRuYHld.WaterText = "请输入手机号/钉钉号";
            this.Text_ShuRuYHld.WordWrap = true;
            // 
            // ButFaXiaoXi
            // 
            this.ButFaXiaoXi.BackColor = System.Drawing.Color.Transparent;
            this.ButFaXiaoXi.BaseColor = System.Drawing.Color.White;
            this.ButFaXiaoXi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(213)))), ((int)(((byte)(214)))));
            this.ButFaXiaoXi.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.ButFaXiaoXi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButFaXiaoXi.DownBack = null;
            this.ButFaXiaoXi.DownBaseColor = System.Drawing.Color.White;
            this.ButFaXiaoXi.FadeGlow = false;
            this.ButFaXiaoXi.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButFaXiaoXi.ForeColor = System.Drawing.Color.Black;
            this.ButFaXiaoXi.IsDrawGlass = false;
            this.ButFaXiaoXi.Location = new System.Drawing.Point(301, 80);
            this.ButFaXiaoXi.MouseBack = null;
            this.ButFaXiaoXi.MouseBaseColor = System.Drawing.Color.White;
            this.ButFaXiaoXi.Name = "ButFaXiaoXi";
            this.ButFaXiaoXi.NormlBack = null;
            this.ButFaXiaoXi.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.ButFaXiaoXi.Size = new System.Drawing.Size(82, 39);
            this.ButFaXiaoXi.TabIndex = 16;
            this.ButFaXiaoXi.Text = "取消";
            this.ButFaXiaoXi.UseVisualStyleBackColor = false;
            this.ButFaXiaoXi.Click += new System.EventHandler(this.ButFaXiaoXi_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.panel2.Location = new System.Drawing.Point(28, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(355, 1);
            this.panel2.TabIndex = 17;
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skinButton1.DownBack = null;
            this.skinButton1.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.skinButton1.FadeGlow = false;
            this.skinButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButton1.ForeColor = System.Drawing.Color.White;
            this.skinButton1.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.skinButton1.IsDrawBorder = false;
            this.skinButton1.IsDrawGlass = false;
            this.skinButton1.Location = new System.Drawing.Point(213, 80);
            this.skinButton1.MouseBack = null;
            this.skinButton1.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinButton1.Size = new System.Drawing.Size(82, 39);
            this.skinButton1.TabIndex = 16;
            this.skinButton1.Text = "确定";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // FrmTianJIaHaoYou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 188);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.skinPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTianJIaHaoYou";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTianJIaHaoYou";
            this.Leave += new System.EventHandler(this.FrmTianJIaHaoYou_Leave);
            this.skinPanel2.ResumeLayout(false);
            this.skinPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinPanel skinPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private CCWin.SkinControl.SkinTextBox Text_ShuRuYHld;
        private System.Windows.Forms.Panel panel2;
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinButton ButFaXiaoXi;
    }
}