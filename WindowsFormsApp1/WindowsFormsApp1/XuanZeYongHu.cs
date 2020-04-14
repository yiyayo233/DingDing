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
    /// <summary>
    /// 这个控件暂时没有
    /// </summary>
    public partial class XuanZeYongHu : UserControl
    {
        public XuanZeYongHu()
        {
            InitializeComponent();
        }

        #region 改变 单选框框 背景颜色
        private void panelDanGe_MouseEnter(object sender, EventArgs e)
        {
            if (this.panelDanGe.BackColor != System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(240))))))
            {
                this.panelDanGe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            }
        }

        private void panelDanGe_MouseLeave(object sender, EventArgs e)
        {
            if (this.panelDanGe.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(240))))))
            {

            }
            else
            {
                if (this.panelDanGe.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247))))))
                {
                    this.panelDanGe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                }
            }
        }
        #endregion

    }
}
