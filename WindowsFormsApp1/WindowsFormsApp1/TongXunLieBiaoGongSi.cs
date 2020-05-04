using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection;

namespace WindowsFormsApp1
{
    public partial class TongXunLieBiaoGongSi : UserControl
    {
        public TongXunLieBiaoGongSi()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 用户id
        /// </summary>
        public string Yh_ld = "";

        /// <summary>
        /// 公司id
        /// </summary>
        public string txt_GongSild = "";

        /// <summary>
        /// 公司昵称
        /// </summary>
        public string txt_GongSiName = "";

        /// <summary>
        /// 公司头像
        /// </summary>
        public string txt_GongSiTx = "";

        #region 改变panel1背景颜色
        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            if (this.panel1.BackColor != System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(240))))))
            {
                this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            }

        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            if (this.panel1.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(240))))))
            {

            }
            else
            {
                if (this.panel1.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247))))))
                {
                    this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                }
            }

        }

        #endregion

        #region 显示&隐藏panel7
        private void Txt_Name_MouseClick(object sender, MouseEventArgs e)
        {
            /*if (this.panel1.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(240))))))
            {
                this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            }
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));*/

            if (this.panel7.Visible == false)
            {
                this.Size = new System.Drawing.Size(249, 120);
                this.panel7.Visible = true;
            }
            else
            {
                this.Size = new System.Drawing.Size(249, 70);
                this.panel7.Visible = false;
            }

        }
        #endregion

        #region 更改panel8的背景颜色
        private void panel8_MouseEnter(object sender, EventArgs e)
        {
            if (this.panel8.BackColor != System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(240))))))
            {
                this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            }
        }

        private void panel8_MouseLeave(object sender, EventArgs e)
        {
            if (this.panel8.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(240))))))
            {

            }
            else
            {
                if (this.panel8.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247))))))
                {
                    this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                }
            }
        }
        #endregion

        private void panel8_MouseDown(object sender, MouseEventArgs e)
        {
            ShowTongXunGongSi();
        }

        #region 显示公司通讯页 按组织架构选择
        /// <summary>
        /// 显示公司通讯页
        /// </summary>
        public void ShowTongXunGongSi() {
            try
            {
                Control control = this.Parent.Parent.Parent;
                string s = control.Name;
                //获得父页面的子控件
                foreach (var lb in control.Controls)
                {
                    
                    if (lb is Panel)
                    {
                        Panel obj = lb as Panel;
                        if (obj.Name == "panel1")
                        {
                            foreach (var lb1 in obj.Controls)
                            {
                                if (lb1 is TongXunGongSi)
                                {
                                    TongXunGongSi tongXunGongSi = lb1 as TongXunGongSi;
                                    if (tongXunGongSi.Name == "tongXunGongSi1")
                                    {
                                        tongXunGongSi.Yh_ld = Yh_ld;
                                        tongXunGongSi.txt_GongSiName = txt_GongSiName;
                                        tongXunGongSi.txt_GongSild = txt_GongSild;
                                        tongXunGongSi.txt_GongSiTx = txt_GongSiTx;
                                        tongXunGongSi.Visible = true;
                                        Type pageType = tongXunGongSi.GetType();
                                        //父页面的方法名
                                        MethodInfo mi = pageType.GetMethod("UpdateTongXunGongSi");
                                        //执行
                                        mi.Invoke(tongXunGongSi, null);

                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        private void TongXunLieBiaoGongSi_Load(object sender, EventArgs e)
        {
            ChuShiHua();
        }

        #region 初始化控件
        /// <summary>
        /// 初始化控件
        /// </summary>
        public void ChuShiHua() {
            foreach (var lb in panel1.Controls)
            {
                if (lb is Label)
                {
                    Label label = lb as Label;
                    if (label.Name == "Txt_GongSiName")
                    {
                        label.Text = txt_GongSiName;
                    }
                }
            }
        }
        #endregion

        
    }
}
