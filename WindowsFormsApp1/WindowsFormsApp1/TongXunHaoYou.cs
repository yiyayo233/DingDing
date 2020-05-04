using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TongXunHaoYou : UserControl
    {
        public TongXunHaoYou(XinDeHaoYou parent)
        {
            InitializeComponent();
            paf = parent;
        }

        private XinDeHaoYou paf;

        /// <summary>
        /// 用户id
        /// </summary>

        public string Yh_ld = "";
        /// <summary>
        /// 好友名称
        /// </summary>
        public string txt_HaoYouName = "";
        /// <summary>
        /// 好友id
        /// </summary>
        public string chaZhaoYhld = "";

        private void TongXunHaoYou_Load(object sender, EventArgs e)
        {

            UptedaTongXunHaoYou();
        }

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            ShowFrmTongXunXiangXiXingXi();
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
        public void UptedaTongXunHaoYou()
        {
            foreach (var lb in panel1.Controls)
            {
                if (lb is Label)
                {
                    Label obj = lb as Label;   //如果把循环改成这样就可以省略这一步foreach(Label lb in mi_image1.Controls)
                                               //MessageBox.Show("哈哈哈，我找到用户控件里的控件对象啦"+obj.Name);
                    if (obj.Name == "Txt_HaoYouName")
                    {
                        obj.Text = txt_HaoYouName;
                    }
                }
            }
        }
        #endregion

        #region 打开FrmTongXunXiangXiXingXi窗口
        /// <summary>
        /// 打开好友详细1窗口
        /// </summary>
        private void ShowFrmTongXunXiangXiXingXi()
        {
            FrmTongXunXiangXiXingXi frmTongXunXiangXiXingXi = new FrmTongXunXiangXiXingXi(paf);
            frmTongXunXiangXiXingXi.Yh_ld = Yh_ld;
            frmTongXunXiangXiXingXi.chaZhaoYhld = chaZhaoYhld;
            frmTongXunXiangXiXingXi.Show();
        }
        #endregion
    }
}
