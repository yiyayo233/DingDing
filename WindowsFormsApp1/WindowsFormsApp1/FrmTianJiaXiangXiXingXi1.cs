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
using System.Reflection;

namespace WindowsFormsApp1
{
    public partial class FrmTianJiaXiangXiXingXi1 : Form
    {
        #region 阴影
        private const int CS_DropSHADOW = 0x20000;
        private const int GCL_STYLE = (-26);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SetClassLong(IntPtr hwnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetClassLong(IntPtr hwnd, int nIndex);
        #endregion

        public FrmTianJiaXiangXiXingXi1(TongXunGongSi parent)
        {
            InitializeComponent();
            SetClassLong(this.Handle, GCL_STYLE, GetClassLong(this.Handle, GCL_STYLE) | CS_DropSHADOW);
            paf = parent;
        }
        private TongXunGongSi paf;

        static string strcon = "Data Source=.;Initial Catalog=DingDing;Integrated Security=True";
        DataSet dataSet = new DataSet();
        SqlDataAdapter adapter = new SqlDataAdapter();

        /// <summary>
        /// 用户id
        /// </summary>
        public string Yh_ld = "";
        /// <summary>
        /// 查找用户id
        /// </summary>
        public string chaZhaoYhld = "";

        private void FrmTianJiaXiangXiXingXi_Load(object sender, EventArgs e)
        {
            UptedFrmTianJiaXiangXiXingXi();
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButFaXiaoXi_Click(object sender, EventArgs e)
        {
            TianJiaHaoYou();
        }

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

        #region 初始化窗口
        /// <summary>
        /// 初始化窗口
        /// </summary>
        public void UptedFrmTianJiaXiangXiXingXi()
        {
            SqlConnection sqlConnection = new SqlConnection(strcon);
            try
            {
                StringBuilder selectXiangQing = new StringBuilder();
                selectXiangQing.AppendFormat("select * ");
                selectXiangQing.AppendFormat("from Yh ");
                selectXiangQing.AppendFormat("where Yh_Id = '{0}'", chaZhaoYhld);
                adapter = new SqlDataAdapter(selectXiangQing.ToString(), sqlConnection);

                if (dataSet.Tables["Yh"] != null)
                {
                    dataSet.Tables["Yh"].Clear();
                }
                adapter.Fill(dataSet, "Yh");

                this.HyName.Text = dataSet.Tables["Yh"].Rows[0][1].ToString();
                this.HyName2.Text = dataSet.Tables["Yh"].Rows[0][1].ToString();
                this.Hyld.Text = dataSet.Tables["Yh"].Rows[0][0].ToString();
                this.BeiZhu.Text = dataSet.Tables["Yh"].Rows[0][1].ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }


        #endregion

        #region 添加好友
        /// <summary>
        /// 添加好友
        /// </summary>
        public void TianJiaHaoYou()
        {
            SqlConnection sqlConnection = new SqlConnection(strcon);
            try
            {
                StringBuilder insertHy1 = new StringBuilder();
                insertHy1.AppendFormat("insert Hy(Hy_Yhld,Hy_Hyld) ");
                insertHy1.AppendFormat("values('{0}','{1}')", Yh_ld, chaZhaoYhld);
                adapter = new SqlDataAdapter(insertHy1.ToString(), sqlConnection);
                adapter.Fill(dataSet, "HY");

                StringBuilder insertHy2 = new StringBuilder();
                insertHy2.AppendFormat("insert Hy(Hy_Yhld,Hy_Hyld) ");
                insertHy2.AppendFormat("values('{0}','{1}')", chaZhaoYhld, Yh_ld);
                adapter = new SqlDataAdapter(insertHy2.ToString(), sqlConnection);
                adapter.Fill(dataSet, "HY");

                MessageBox.Show("TA已成为你的好友，快去和TA打招呼吧！", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                #region 更新我的好友窗口好友列表
                Control control = paf;
                string s = control.Name;
                paf.Yh_ld = Yh_ld;
                foreach (var bl in control.Controls)
                {
                    if (bl is Panel)
                    {
                        Panel panel = bl as Panel;
                        if (panel.Name == "panel1")
                        {
                            foreach (var bl1 in panel.Controls)
                            {
                                if (bl1 is XinDeHaoYou)
                                {
                                    XinDeHaoYou xinDeHaoYou = bl1 as XinDeHaoYou;
                                    if (xinDeHaoYou.Name == "xinDeHaoYou1")
                                    {
                                        Type pageType1 = xinDeHaoYou.GetType();
                                        //父页面的方法名
                                        MethodInfo mi1 = pageType1.GetMethod("CheckHaoYou");
                                        mi1.Invoke(xinDeHaoYou, null);
                                    }
                                }
                            }
                        }
                    }
                }
                #endregion

                #region 更新消息窗口会话列表
                Control control1 = paf.Parent.Parent.Parent;
                string s1 = control1.Name;
                paf.Yh_ld = Yh_ld;
                foreach (var lb in control1.Controls)
                {
                    if (lb is FrmXinXi)
                    {
                        FrmXinXi frmXinXi = lb as FrmXinXi;
                        if (frmXinXi.Name == "frmXinXi1")
                        {
                            Type pageType1 = frmXinXi.GetType();
                            //父页面的方法名
                            MethodInfo mi1 = pageType1.GetMethod("ChuShiHua");
                            mi1.Invoke(frmXinXi, null);
                        }
                    }
                }

                #endregion

                this.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
    }
}
