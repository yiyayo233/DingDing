using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace WindowsFormsApp1
{
    public partial class HuiHuaLieBiaoQunZu : UserControl
    {
        public HuiHuaLieBiaoQunZu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 用户id
        /// </summary>
        public string Yh_ld = "";

        /// <summary>
        /// 对话群名称
        /// </summary>
        public string txt_ShouXinName = "";

        /// <summary>
        /// 信息发送人昵称
        /// </summary>
        public string txt_FaSongRewn = "";

        /// <summary>
        /// 信息内容
        /// </summary>
        public string txt_XiaoXi = "";

        /// <summary>
        /// 对话时间
        /// </summary>
        public string duiHuaShiJian = "";

        /// <summary>
        /// 对话群id
        /// </summary>
        public string sxld = "";

        private void HuiHuaLieBiaoQunZu_Load(object sender, EventArgs e)
        {
            UptedaHuiHuaLieBiaoQunZu();
        }

        #region 改变 HuiHuaLieBiaoQunZu 背景颜色
        private void HuiHuaLieBiaoQunZu_MouseDown(object sender, MouseEventArgs e)
        {
            //Bai();
            ShowFrmLiaoTian();

            /*if (this.panel1.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(240))))))
            {
                this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            }
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));*/
        }

        private void HuiHuaLieBiaoQunZu_MouseEnter(object sender, EventArgs e)
        {
            if (this.panel1.BackColor != System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(240))))))
            {
                this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            }
        }

        private void HuiHuaLieBiaoQunZu_MouseLeave(object sender, EventArgs e)
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

        #region 初始化控件
        /// <summary>
        /// 初始化控件
        /// </summary>
        public void UptedaHuiHuaLieBiaoQunZu()
        {
            foreach (var lb in panel1.Controls)
            {
                if (lb is Label)
                {
                    Label obj = lb as Label;
                    if (obj.Name == "Txt_ShouXinName")
                    {
                        obj.Text = txt_ShouXinName;
                    }
                    if (obj.Name == "Txt_DuiHuaShiJian")
                    {
                        obj.Text = duiHuaShiJian;
                    }
                }
                if (lb is Panel)
                {
                    Panel obj1 = lb as Panel;
                    if (obj1.Name == "DuiHuaRenANDXinXi")
                    {
                        foreach (var lb1 in DuiHuaRenANDXinXi.Controls)
                        {
                            if (lb1 is Label)
                            {
                                Label obj2 = lb1 as Label;
                                if (obj2.Name == "Txt_XiaoXi")
                                {
                                    obj2.Text = txt_FaSongRewn+ ": " + txt_XiaoXi;
                                }
                            }
                        }
                    }
                }
            }

        }


        #endregion

        #region 显示聊天框
        /// <summary>
        /// 显示聊天框
        /// </summary>
        public void ShowFrmLiaoTian()
        {
            //获得父页面
            Control control = this.Parent.Parent.Parent.Parent;
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
                            if (lb1 is Panel)
                            {
                                Panel obj1 = lb1 as Panel;
                                if (obj1.Name == "panelLiaoTian")
                                {
                                    foreach (var lb2 in obj1.Controls)
                                    {
                                        if (lb2 is FrmLiaoTian)
                                        {
                                            FrmLiaoTian obj2 = lb2 as FrmLiaoTian;
                                            if (obj2.Name == "frmLiaoTian1")
                                            {
                                                obj2.fsld = Yh_ld;
                                                obj2.sxld = sxld;
                                                obj2.i = 2;
                                                if (obj2.Visible == true)
                                                {
                                                    obj2.Emptypanel1();
                                                    obj2.CheckSXXiangXi(2);
                                                    obj2.CheckFSXiangXi();
                                                    obj2.CheckXinXi();
                                                }

                                                obj2.Visible = true;
                                            }

                                        }
                                        if (lb2 is Panel)
                                        {
                                            Panel obj2 = lb2 as Panel;
                                            if (obj2.Name == "PanelTop")
                                            {
                                                obj2.Visible = false;
                                            }
                                        }

                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        #endregion

        /*#region 把其他的HuiHuaLieBiao变白
        public void Bai()
        {
            Control control = this.Parent;
            string s = control.Name;

            foreach (var lb in control.Controls)
            {
                if (lb is HuiHuaLieBiao)
                {
                    HuiHuaLieBiao obj = lb as HuiHuaLieBiao;
                    foreach (var lb1 in obj.Controls)
                    {
                        if (lb1 is Panel)
                        {
                            Panel obj1 = lb1 as Panel;
                            if (obj1.Name == "panel1")
                            {
                                this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                            }
                        }
                    }
                }
            }
        }
        #endregion*/
    }
}
