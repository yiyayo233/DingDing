using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class FrmTianJIaHaoYou : Form
    {
        #region 阴影
        private const int CS_DropSHADOW = 0x20000;
        private const int GCL_STYLE = (-26);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SetClassLong(IntPtr hwnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetClassLong(IntPtr hwnd, int nIndex);
        #endregion

        public FrmTianJIaHaoYou(XinDeHaoYou parent)  
        {
            InitializeComponent();
            SetClassLong(this.Handle, GCL_STYLE, GetClassLong(this.Handle, GCL_STYLE) | CS_DropSHADOW);
            paf = parent;
        }

        private XinDeHaoYou paf;

        static string strcon = "Data Source=.;Initial Catalog=DingDing;Integrated Security=True";
        DataSet dataSet = new DataSet();
        SqlDataAdapter adapter = new SqlDataAdapter();

        public string Yh_ld = "";

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

        private void ButFaXiaoXi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            TiJiao();
        }

        #region 提交
        /// <summary>
        /// 提交
        /// </summary>
        public void TiJiao() {
            SqlConnection sqlConnection = new SqlConnection(strcon);
            try
            {
                StringBuilder selectYH = new StringBuilder();
                selectYH.AppendFormat("select * ");
                selectYH.AppendFormat("from Yh ");
                selectYH.AppendFormat("where Yh_Id = '{0}' ",this.Text_ShuRuYHld.Text.Trim());
                selectYH.AppendFormat("or Yh_Sjh = '{0}'", this.Text_ShuRuYHld.Text.Trim());
                adapter = new SqlDataAdapter(selectYH.ToString(),sqlConnection);
                adapter.Fill(dataSet, "Yh");
                if (dataSet.Tables["Yh"].Rows.Count != 0)
                {
                    StringBuilder selectHy = new StringBuilder();
                    selectHy.AppendFormat("select * ");
                    selectHy.AppendFormat("from Hy ");
                    selectHy.AppendFormat("where Hy_Yhld = '{0}' ",Yh_ld);
                    string AAAA = dataSet.Tables["Yh"].Rows[0][0].ToString();
                    selectHy.AppendFormat("and Hy_Hyld  = '{0}' ", dataSet.Tables["Yh"].Rows[0][0].ToString());
                    adapter = new SqlDataAdapter(selectHy.ToString(), sqlConnection);
                    adapter.Fill(dataSet, "Hy");
                    if (dataSet.Tables["Hy"].Rows.Count == 0)   //判断是否已经加该用户为好友
                    {
                        //添加好友窗口
                        FrmTianJiaXiangXiXingXi frmTianJiaXiangXiXingXi = new FrmTianJiaXiangXiXingXi(paf);
                        frmTianJiaXiangXiXingXi.Yh_ld = Yh_ld;
                        frmTianJiaXiangXiXingXi.chaZhaoYhld = dataSet.Tables["Yh"].Rows[0][0].ToString();
                        frmTianJiaXiangXiXingXi.Show();
                    }
                    else
                    {
                        //查看好友详细信息窗口
                        FrmTongXunXiangXiXingXi frmTongXunXiangXiXingXi = new FrmTongXunXiangXiXingXi(paf);
                        frmTongXunXiangXiXingXi.Yh_ld = Yh_ld;
                        frmTongXunXiangXiXingXi.chaZhaoYhld = dataSet.Tables["Yh"].Rows[0][0].ToString();
                        frmTongXunXiangXiXingXi.Show();
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("无法找到该用户，请检查搜索内容再重试", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion

        private void FrmTianJIaHaoYou_Leave(object sender, EventArgs e)
        {
            this.skinButton1.Focus();
        }
    }
}
