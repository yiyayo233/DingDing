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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class TongXunQunZu : UserControl
    {
        public TongXunQunZu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 群昵称
        /// </summary>
        public string txt_QunZuName = "";

        /// <summary>
        /// 群人数
        /// </summary>
        public string txt_QunZuRenShu = "";

        /// <summary>
        /// 
        /// </summary>
        public string chaZhaoYhld = "";


        private void TongXunQunZu_Load(object sender, EventArgs e)
        {
            UptedaTongXunQunZu();
        }

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            ShowLiaoTianChuangKou();
        }

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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.panel1.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(240))))))
            {
                this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            }
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));
        }
        #endregion

        #region 初始化控件
        /// <summary>
        /// 初始化控件
        /// </summary>
        public void UptedaTongXunQunZu()
        {
            foreach (var lb in panel1.Controls)
            {
                if (lb is Label)
                {
                    Label obj = lb as Label;   
                    if (obj.Name == "Txt_QunZuName")
                    {
                        obj.Text = txt_QunZuName;
                    }

                    if (obj.Name == "Txt_RenShu")
                    {
                        obj.Text = txt_QunZuRenShu + "人";
                    }
                }
            }
        }
        #endregion

        #region 打开聊天窗口
        /// <summary>
        /// 打开聊天窗口
        /// </summary>
        private void ShowLiaoTianChuangKou()
        {
            //获得父页面
            Form p = this.Parent.Parent.Parent.Parent.Parent.FindForm();
            Type pageType = p.GetType();
            //父页面的方法名
            MethodInfo mi = pageType.GetMethod("XiaoXi");
            //执行
            mi.Invoke(p, null);
        }
        #endregion        
    }
}
