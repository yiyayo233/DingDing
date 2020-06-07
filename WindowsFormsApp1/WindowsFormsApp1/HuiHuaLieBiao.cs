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
    public partial class HuiHuaLieBiao : UserControl
    {
        public HuiHuaLieBiao()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 用户id
        /// </summary>
        public string Yh_ld = "";

        /// <summary>
        /// 用户头像
        /// </summary>
        public string Yh_Tx = "";

        /// <summary>
        /// 对话人昵称
        /// </summary>
        public string txt_ShouXinName = "";

        /// <summary>
        /// 对话内容
        /// </summary>
        public string txt_XiaoXi = "";

        /// <summary>
        /// 对话时间
        /// </summary>
        public string duiHuaShiJian = "";

        /// <summary>
        /// 对话人id
        /// </summary>
        public string sxld = "";

        /// <summary>
        /// 对话人头像
        /// </summary>
        public string sxTx = "";

        #region 改变 HuiHuaLieBiao 背景颜色
        private void HuiHuaLieBiao_MouseDown(object sender, MouseEventArgs e)
        {
            //Bai();
            ShowFrmLiaoTian();

            /*if (this.panel1.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(240))))))
            {
                this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            }
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));*/
        }

        private void HuiHuaLieBiao_MouseEnter(object sender, EventArgs e)
        {
            if (this.panel1.BackColor != System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(240))))))
            {
                this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            }
        }

        private void HuiHuaLieBiao_MouseLeave(object sender, EventArgs e)
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

        private void HuiHuaLieBiao_Load(object sender, EventArgs e)
        {
            UptedaHuiHuaLieBiao();
        }

        #region 初始化控件
        /// <summary>
        /// 初始化控件
        /// </summary>
        public void UptedaHuiHuaLieBiao()
        {
            foreach (var lb in panel1.Controls)
            {
                if (lb is Label)
                {
                    Label obj = lb as Label;
                    if (obj.Name == "Txt_ShouXinName1")
                    {
                        obj.Text = txt_ShouXinName;
                    }
                    if (obj.Name == "Txt_XiaoXi1")
                    {
                        obj.Text = txt_XiaoXi;
                    }
                    if (obj.Name == "Txt_DuiHuaShiJian")
                    {
                        obj.Text = duiHuaShiJian;
                    }
                }
            }
            if (Yh_Tx.Length != 0)
            {
                this.pictureBox1.Load(UploadFileController.rootPath + Yh_Tx);
            }

        }

        #endregion

        #region 显示聊天框
        /// <summary>
        /// 显示聊天框
        /// </summary>
        public void ShowFrmLiaoTian() {
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
                                                obj2.fsTx = Yh_Tx;
                                                obj2.sxld = sxld;
                                                obj2.sxTx = sxTx;
                                                obj2.i = 1;
                                                if (obj2.Visible == true)
                                                {
                                                    obj2.Emptypanel1();
                                                    obj2.CheckSXXiangXi(1);
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
        public void Bai() {
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
