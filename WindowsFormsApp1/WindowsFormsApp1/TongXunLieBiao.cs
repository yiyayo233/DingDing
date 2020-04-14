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
    /// 这个控件暂时没用
    /// </summary>
    public partial class TongXunLieBiao : UserControl
    {
        public TongXunLieBiao()
        {
            InitializeComponent();
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

        private void Txt_ShiJian_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.panel1.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(240))))))
            {
                this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            }
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));
        }
        #endregion
    }
}
