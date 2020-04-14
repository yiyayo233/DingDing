using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using CCWin.SkinClass;
using System.Reflection;

namespace WindowsFormsApp1
{
    public partial class FrmTianJIaQiYe : Form
    {
        #region 阴影
        private const int CS_DropSHADOW = 0x20000;
        private const int GCL_STYLE = (-26);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SetClassLong(IntPtr hwnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetClassLong(IntPtr hwnd, int nIndex);
        #endregion

        public FrmTianJIaQiYe(FrmTongXunLu parent)
        {
            InitializeComponent();
            SetClassLong(this.Handle, GCL_STYLE, GetClassLong(this.Handle, GCL_STYLE) | CS_DropSHADOW);
            paf = parent;
        }

        private FrmTongXunLu paf;

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
            if (PaiKong())
            {
                InsertGongSi();
            }
            
        }

        #region 提交
        public void InsertGongSi() {
            SqlConnection sqlConnection = new SqlConnection(strcon);
            try
            {
                StringBuilder selectGSld = new StringBuilder();
                selectGSld.AppendFormat("select * ");
                selectGSld.AppendFormat("from GS ");
                string GSld = "GS" + JieQvRiQi();
                selectGSld.AppendFormat("where Gs_ld like '{0}%'", GSld);
                adapter = new SqlDataAdapter(selectGSld.ToString(),sqlConnection);
                adapter.Fill(dataSet,"GS");
                if ((dataSet.Tables["GS"].Rows.Count + 1).ToString().Length == 1)
                {
                    GSld = GSld + "0" + (dataSet.Tables["GS"].Rows.Count + 1);
                }
                else
                {
                    GSld = GSld + (dataSet.Tables["GS"].Rows.Count + 1);
                }
                
                StringBuilder insertGS = new StringBuilder();
                insertGS.AppendFormat("insert GS ");
                insertGS.AppendFormat("values('{0}','{1}','{2}')", GSld, this.Txt_GongSiName.Text.Trim(),this.ComGongSiLeiXing.SelectedIndex);
                adapter = new SqlDataAdapter(insertGS.ToString(), sqlConnection);
                adapter.Fill(dataSet, "GS1");

                StringBuilder insertGongSiXiangXi = new StringBuilder();
                insertGongSiXiangXi.AppendFormat("insert GSXiangXi ");
                insertGongSiXiangXi.AppendFormat("values('{0}','{1}')", GSld, Yh_ld);
                adapter = new SqlDataAdapter(insertGongSiXiangXi.ToString(), sqlConnection);
                adapter.Fill(dataSet, "GSXiangXi");

                //调用通讯录页面的初始化方法
                Control control = paf;
                string s = control.Name;
                paf.Yh_ld = Yh_ld;
                Type pageType = control.GetType();
                //父页面的方法名
                MethodInfo mi = pageType.GetMethod("SelectGongSi");
                mi.Invoke(control, null);

                this.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region 排空
        public bool PaiKong() {
            if (this.Txt_GongSiName.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入创建企业/组织/团队名称","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return false;
            }
            else if (this.ComGongSiLeiXing.SelectedIndex == 0)
            {
                MessageBox.Show("选择行业类型", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

        #region 截取日期
        public string JieQvRiQi()
        {
            string dAteTime = "";
            dAteTime = DateTime.Now.Year.ToString();
            if (DateTime.Now.Month.ToString().Length == 1)
            {
                dAteTime = dAteTime+ "0" + DateTime.Now.Month.ToString();
            }
            else
            {
                dAteTime = dAteTime + DateTime.Now.Month.ToString();
            }
            

            /*string dateTime = DateTime.Now.ToString();
            string time = dateTime.Substring(0, dateTime. "/");*/
            return dAteTime;
        }
        #endregion

        private void FrmTianJIaQiYe_Load(object sender, EventArgs e)
        {
            ChuShiHua();
        }

        #region 初始化页面
        public void ChuShiHua() {
            SqlConnection sqlConnection = new SqlConnection(strcon);
            try
            {
                StringBuilder selectGsLx = new StringBuilder();
                selectGsLx.AppendFormat("select * ");
                selectGsLx.AppendFormat("from GsLx");
                adapter = new SqlDataAdapter(selectGsLx.ToString(),sqlConnection);
                adapter.Fill(dataSet,"GsLx");

                DataRow row = dataSet.Tables["GsLx"].NewRow();
                row["GsLx_ld"] = -1;
                row["GsLx_Name"] = "请选择";
                dataSet.Tables["GsLx"].Rows.InsertAt(row, 0);

                this.ComGongSiLeiXing.DataSource = dataSet.Tables["GsLx"];
                this.ComGongSiLeiXing.ValueMember = "GsLx_ld";
                this.ComGongSiLeiXing.DisplayMember = "GsLx_Name";
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
    }
}
