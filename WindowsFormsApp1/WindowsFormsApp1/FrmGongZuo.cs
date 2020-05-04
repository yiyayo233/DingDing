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
    public partial class FrmGongZuo : UserControl
    {
        public FrmGongZuo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 用户ld
        /// </summary>
        public string Yh_ld = "";

        #region 改变考勤背景颜色
        private void panelKaoQing_MouseEnter(object sender, EventArgs e)
        {
            if (this.panelKaoQing.BackColor != System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(240))))))
            {
                this.panelKaoQing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            }
        }

        private void panelKaoQing_MouseLeave(object sender, EventArgs e)
        {
            if (this.panelKaoQing.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(240))))))
            {

            }
            else
            {
                if (this.panelKaoQing.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247))))))
                {
                    this.panelKaoQing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                }
            }
        }
        #endregion

        private void panelQingJIa_MouseEnter(object sender, EventArgs e)
        {
            if (this.panelQingJIa.BackColor != System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(240))))))
            {
                this.panelQingJIa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            }
        }

        #region 改变更多背景颜色
        private void panelQingJIa_MouseLeave(object sender, EventArgs e)
        {
            if (this.panelQingJIa.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(240))))))
            {

            }
            else
            {
                if (this.panelQingJIa.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247))))))
                {
                    this.panelQingJIa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                }
            }
        }
        #endregion

        /// <summary>
        /// 考勤
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelKaoQing_Click(object sender, EventArgs e)
        {
            ShowKaoQing();
        }

        /// <summary>
        /// 更多
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelQingJIa_Click(object sender, EventArgs e)
        {
            ShowQingJIa();
        }

        #region 显示考勤
        /// <summary>
        /// 显示考勤
        /// </summary>
        public void ShowKaoQing()
        {
            //获得父页面
            Control control = this.Parent.Parent;
            string s = control.Name;
            //获得父页面的子控件
            foreach (var lb in control.Controls)
            {
                if (lb is Panel)
                {
                    Panel panel = lb as Panel;
                    if (panel.Name == "YeMian")
                    {
                        foreach (var lb1 in panel.Controls)
                        {
                            if (lb1 is FrmKaoQin)
                            {
                                FrmKaoQin frmKaoQin = lb1 as FrmKaoQin;
                                if (frmKaoQin.Name == "frmKaoQin1")
                                {
                                    frmKaoQin.Yh_ld = Yh_ld;

                                    Type pageType = control.GetType();
                                    MethodInfo mi = pageType.GetMethod("FrmAllClose");
                                    mi.Invoke(control, null);

                                    Type pageType1 = frmKaoQin.GetType();
                                    MethodInfo mi1 = pageType1.GetMethod("ShiFouDaKa");
                                    mi1.Invoke(frmKaoQin, null);
                                    frmKaoQin.Visible = true;
                                    this.Visible = false;
                                }
                            }
                        }
                    }
                }
                
            }
        }
        #endregion

        #region 显示请假
        /// <summary>
        /// 显示请假
        /// </summary>
        public void ShowQingJIa()
        {
            //获得父页面
            Control control = this.Parent.Parent;
            string s = control.Name;
            //获得父页面的子控件
            foreach (var lb in control.Controls)
            {
                if (lb is Panel)
                {
                    Panel panel = lb as Panel;
                    if (panel.Name == "YeMian")
                    {
                        foreach (var lb1 in panel.Controls)
                        {
                            if (lb1 is FrmQingJia)
                            {
                                FrmQingJia frmQingJia = lb1 as FrmQingJia;
                                if (frmQingJia.Name == "frmQingJia1")
                                {
                                    Type pageType = control.GetType();
                                    MethodInfo mi = pageType.GetMethod("FrmAllClose");
                                    mi.Invoke(control, null);
                                    frmQingJia.Yh_ld = Yh_ld;
                                    frmQingJia.Visible = true;
                                    this.Visible = false;
                                }
                            }
                        }
                    }
                }

            }

        }
        #endregion
    }
}
