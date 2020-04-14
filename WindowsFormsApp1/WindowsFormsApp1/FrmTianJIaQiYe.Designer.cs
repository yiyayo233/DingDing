namespace WindowsFormsApp1
{
    partial class FrmTianJIaQiYe
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
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.ButFaXiaoXi = new CCWin.SkinControl.SkinButton();
            this.ComGongSiLeiXing = new CCWin.SkinControl.SkinComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_GongSiName = new CCWin.SkinControl.SkinTextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.skinPanel2.Size = new System.Drawing.Size(526, 50);
            this.skinPanel2.TabIndex = 2;
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
            this.label1.Size = new System.Drawing.Size(152, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "创建企业/组织/团队";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.skinButton1);
            this.panel1.Controls.Add(this.ButFaXiaoXi);
            this.panel1.Controls.Add(this.ComGongSiLeiXing);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Txt_GongSiName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 231);
            this.panel1.TabIndex = 3;
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
            this.skinButton1.Location = new System.Drawing.Point(322, 169);
            this.skinButton1.MouseBack = null;
            this.skinButton1.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinButton1.Size = new System.Drawing.Size(82, 39);
            this.skinButton1.TabIndex = 18;
            this.skinButton1.Text = "确定";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
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
            this.ButFaXiaoXi.Location = new System.Drawing.Point(410, 169);
            this.ButFaXiaoXi.MouseBack = null;
            this.ButFaXiaoXi.MouseBaseColor = System.Drawing.Color.White;
            this.ButFaXiaoXi.Name = "ButFaXiaoXi";
            this.ButFaXiaoXi.NormlBack = null;
            this.ButFaXiaoXi.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.ButFaXiaoXi.Size = new System.Drawing.Size(82, 39);
            this.ButFaXiaoXi.TabIndex = 19;
            this.ButFaXiaoXi.Text = "取消";
            this.ButFaXiaoXi.UseVisualStyleBackColor = false;
            this.ButFaXiaoXi.Click += new System.EventHandler(this.ButFaXiaoXi_Click);
            // 
            // ComGongSiLeiXing
            // 
            this.ComGongSiLeiXing.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.ComGongSiLeiXing.BaseColor = System.Drawing.Color.White;
            this.ComGongSiLeiXing.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.ComGongSiLeiXing.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComGongSiLeiXing.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.ComGongSiLeiXing.FormattingEnabled = true;
            this.ComGongSiLeiXing.ItemHoverForeColor = System.Drawing.Color.Black;
            this.ComGongSiLeiXing.Items.AddRange(new object[] {
            "事假",
            "休假",
            "病假"});
            this.ComGongSiLeiXing.Location = new System.Drawing.Point(28, 113);
            this.ComGongSiLeiXing.MouseColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.ComGongSiLeiXing.MouseGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.ComGongSiLeiXing.Name = "ComGongSiLeiXing";
            this.ComGongSiLeiXing.Size = new System.Drawing.Size(467, 26);
            this.ComGongSiLeiXing.TabIndex = 10;
            this.ComGongSiLeiXing.WaterText = "请选择行业类型";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label3.Location = new System.Drawing.Point(35, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "行业类型";
            // 
            // Txt_GongSiName
            // 
            this.Txt_GongSiName.BackColor = System.Drawing.Color.Transparent;
            this.Txt_GongSiName.DownBack = null;
            this.Txt_GongSiName.Icon = null;
            this.Txt_GongSiName.IconIsButton = false;
            this.Txt_GongSiName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.Txt_GongSiName.IsPasswordChat = '\0';
            this.Txt_GongSiName.IsSystemPasswordChar = false;
            this.Txt_GongSiName.Lines = new string[0];
            this.Txt_GongSiName.Location = new System.Drawing.Point(28, 48);
            this.Txt_GongSiName.Margin = new System.Windows.Forms.Padding(0);
            this.Txt_GongSiName.MaxLength = 32767;
            this.Txt_GongSiName.MinimumSize = new System.Drawing.Size(28, 28);
            this.Txt_GongSiName.MouseBack = null;
            this.Txt_GongSiName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.Txt_GongSiName.Multiline = false;
            this.Txt_GongSiName.Name = "Txt_GongSiName";
            this.Txt_GongSiName.NormlBack = null;
            this.Txt_GongSiName.Padding = new System.Windows.Forms.Padding(5);
            this.Txt_GongSiName.ReadOnly = false;
            this.Txt_GongSiName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_GongSiName.Size = new System.Drawing.Size(467, 28);
            // 
            // 
            // 
            this.Txt_GongSiName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_GongSiName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_GongSiName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.Txt_GongSiName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.Txt_GongSiName.SkinTxt.Name = "BaseText";
            this.Txt_GongSiName.SkinTxt.Size = new System.Drawing.Size(457, 18);
            this.Txt_GongSiName.SkinTxt.TabIndex = 0;
            this.Txt_GongSiName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.Txt_GongSiName.SkinTxt.WaterText = "请填写企业/组织/团队名称";
            this.Txt_GongSiName.TabIndex = 8;
            this.Txt_GongSiName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Txt_GongSiName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.Txt_GongSiName.WaterText = "请填写企业/组织/团队名称";
            this.Txt_GongSiName.WordWrap = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label2.Location = new System.Drawing.Point(35, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "创建企业/组织/团队名称";
            // 
            // FrmTianJIaQiYe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 281);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.skinPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTianJIaQiYe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTianJIaQiYe";
            this.Load += new System.EventHandler(this.FrmTianJIaQiYe_Load);
            this.skinPanel2.ResumeLayout(false);
            this.skinPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinPanel skinPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private CCWin.SkinControl.SkinTextBox Txt_GongSiName;
        private System.Windows.Forms.Label label2;
        private CCWin.SkinControl.SkinComboBox ComGongSiLeiXing;
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinButton ButFaXiaoXi;
    }
}