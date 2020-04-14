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
    public partial class XuanZeChengYuan : UserControl
    {
        public XuanZeChengYuan()
        {
            InitializeComponent();
        }

        private void Txt_Name_MouseClick(object sender, MouseEventArgs e)
        {
            this.Visible = false;
            FrmXuanRen frmXuanRen = new FrmXuanRen();
            frmXuanRen.panelGongSiXuanZe.Visible = true;
        }

        #region 改变 全选框框 背景颜色
        private void panelAll_MouseEnter(object sender, EventArgs e)
        {
            if (this.panelAll.BackColor != System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(240))))))
            {
                this.panelAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            }
        }

        private void panelAll_MouseLeave(object sender, EventArgs e)
        {
            if (this.panelAll.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(240))))))
            {

            }
            else
            {
                if (this.panelAll.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247))))))
                {
                    this.panelAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                }
            }
        }
        #endregion

        private void RadioButtonAll_MouseClick(object sender, MouseEventArgs e)
        {
            xuanZeYongHu1.RadioButtonDanGe.Checked = true;
        }
    }
}
