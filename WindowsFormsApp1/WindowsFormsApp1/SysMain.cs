using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformBubble;
using 钉钉;

namespace WindowsFormsApp1
{
    public partial class SysMain : Form
    {
        public SysMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 用户ld
        /// </summary>
        public string Yh_ld = "";

        #region 三大金刚键
        /// <summary>
        /// 关闭窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 最大化和默认大小
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinButton3_Click(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        /// <summary>
        /// 最小化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion

        #region  窗体无边框样式时移动
        bool formMove = false;//窗体是否移动
        Point formPoint;//记录窗体的位置
        //按下鼠标时记录移动
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            formPoint = new Point();
            int xOffset;
            int yOffset;
            if (e.Button == MouseButtons.Left)
            {
                //获取当前鼠标的X轴坐标,我理解负的鼠标的X轴坐标加上整个窗体的宽度，这里可以直接使用-e.x,-e.y
                // + SystemInformation.FrameBorderSize.Width
                xOffset = -e.X + SystemInformation.FrameBorderSize.Width;
                //获取当前鼠标的y轴坐标
                //- SystemInformation.CaptionHeight
                // + SystemInformation.FrameBorderSize.Height
                yOffset = -e.Y + SystemInformation.FrameBorderSize.Height;
                //将坐标存入
                formPoint = new Point(xOffset, yOffset);
                formMove = true;//开始移动
            }
        }
        //鼠标移动时移动
        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (formMove == true)
            {
                //拖动时获取鼠标的位置，存入
                Point mousePos = Control.MousePosition;
                //进行平移
                mousePos.Offset(formPoint.X, formPoint.Y);
                //执行平移
                Location = mousePos;
            }
        }

        //鼠标松开时停下
        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)//按下的是鼠标左键
            {
                formMove = false;//停止移动
            }
        }


        #endregion

        #region 消息按钮
        public void button1_Click(object sender, EventArgs e)
        {
            XiaoXi();
        }

        /// <summary>
        /// 显示消息控件
        /// </summary>
        public void XiaoXi() {
            FrmAllClose();
            frmXinXi1.Yh_ld = Yh_ld;
            frmXinXi1.Visible = true;
            //添加初始化事件
            frmXinXi1.ChuShiHua();


        }
        #endregion

        #region 工作按钮
        private void button2_Click(object sender, EventArgs e)
        {
            GongZuo();
        }

        /// <summary>
        /// 显示工作菜单
        /// </summary>
        public void GongZuo()
        {
            FrmAllClose();
            frmGongZuo1.Yh_ld = Yh_ld;
            frmGongZuo1.Visible = true;
        }
        #endregion

        #region 通讯录按钮
        private void button3_Click(object sender, EventArgs e)
        {
            TongXunLu();
        }
        /// <summary>
        /// 显示通讯录控件
        /// </summary>
        public void TongXunLu() {
            FrmAllClose();
            frmTongXunLu1.Yh_ld = Yh_ld;
            frmTongXunLu1.Visible = true;
            //frmTongXunLu1.SelectGongSi();
        }
        #endregion

        #region 关闭所有窗口
        /// <summary>
        /// 关闭所有窗口
        /// </summary>
        public void FrmAllClose()
        {
            frmXinXi1.Visible = false;
            frmGongZuo1.Visible = false;
            frmKaoQin1.Visible = false;
            frmQingJia1.Visible = false;
            frmTongXunLu1.Visible = false;
            frmXiaoTouXiang1.Visible = false;
        }
        #endregion

        #region 头像按钮
        /// <summary>
        /// 头像按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (this.frmGongZuo1.Visible == true)
            {
                this.frmGongZuo1.Visible = false;
            }

            if (this.frmXiaoTouXiang1.Visible == true)
            {
                this.frmXiaoTouXiang1.Visible = false;
            }
            else
            {
                this.frmXiaoTouXiang1.Yh_ld = Yh_ld;
                this.frmXiaoTouXiang1.Visible = true;
                this.frmXiaoTouXiang1.ChuShiHua();
            }
            
        }
        #endregion

    }
}
