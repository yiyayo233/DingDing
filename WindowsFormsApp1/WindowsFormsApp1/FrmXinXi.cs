using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class FrmXinXi : UserControl
    {
        public FrmXinXi()
        {
            InitializeComponent();
        }

        static string strcon = "Data Source=.;Initial Catalog=DingDing;Integrated Security=True";
        DataSet dataSet = new DataSet();
        SqlDataAdapter adapter = new SqlDataAdapter();

        /// <summary>
        /// 用户id
        /// </summary>
        public string Yh_ld = "";

        /// <summary>
        /// 好友昵称
        /// </summary>
        public string txt_HaoYouName = "";

        /// <summary>
        /// 好友id
        /// </summary>
        public string chaZhaoYhld = "";

        private void FrmXinXi_Load(object sender, EventArgs e)
        {
            ChuShiHua();
        }

        #region 改变加号背景图片
        private void ButJiaHao_MouseEnter(object sender, EventArgs e)
        {
            this.ButJiaHao.BackgroundImage = Image.FromFile("E:\\项目\\winfrom\\项目文件\\图标\\16x\\加号 (1).png");// 通过绝对路径;
        }

        private void ButJiaHao_MouseLeave(object sender, EventArgs e)
        {
            this.ButJiaHao.BackgroundImage = Image.FromFile("E:\\项目\\winfrom\\项目文件\\图标\\16x\\加号.png");// 通过绝对路径;
        }
        #endregion

        /*#region 显示聊天窗口
        public void PanelTopV()
        {
            this.PanelTop.Visible = false;
            this.frmLiaoTian1.Visible = true;
        }
        #endregion*/

        private void ButJiaHao_Click(object sender, EventArgs e)
        {

        }

        #region 查询好友、初始化&添加huiHuaLieBiao控件
        /// <summary>
        /// 查询好友、初始化、添加huiHuaLieBiao控件
        /// </summary>
        public void CheckHaoYou()
        {
            SqlConnection sqlConnection = new SqlConnection(strcon);
            try
            {

                StringBuilder selectHaoYou = new StringBuilder();
                selectHaoYou.AppendFormat("select * ");
                selectHaoYou.AppendFormat("from Hy ");
                selectHaoYou.AppendFormat("where Hy_Yhld = '{0}'", Yh_ld);
                adapter = new SqlDataAdapter(selectHaoYou.ToString(), sqlConnection);
                if (dataSet.Tables["Hy"] != null)
                {
                    dataSet.Tables["Hy"].Clear();
                }
                adapter.Fill(dataSet, "Hy");

                for (int i = 0; i < dataSet.Tables["Hy"].Rows.Count; i++)
                {
                    StringBuilder selectXiangQing = new StringBuilder();
                    selectXiangQing.AppendFormat("select * ");
                    selectXiangQing.AppendFormat("from Yh ");
                    selectXiangQing.AppendFormat("where Yh_Id = '{0}'", dataSet.Tables["Hy"].Rows[i][2].ToString());
                    adapter = new SqlDataAdapter(selectXiangQing.ToString(), sqlConnection);

                    if (dataSet.Tables["Yh"] != null)
                    {
                        dataSet.Tables["Yh"].Clear();
                    }
                    adapter.Fill(dataSet, "Yh");

                    StringBuilder selectXingXi = new StringBuilder();
                    selectXingXi.AppendFormat("select top 1 * ");
                    selectXingXi.AppendFormat("from Xx ");
                    selectXingXi.AppendFormat("where Xx_Sxld = '{0}' ", dataSet.Tables["Hy"].Rows[i][2].ToString());
                    selectXingXi.AppendFormat("and Xx_Fsld  ='{0}' ", dataSet.Tables["Hy"].Rows[i][1].ToString());
                    selectXingXi.AppendFormat("or Xx_Sxld = '{0}' ", dataSet.Tables["Hy"].Rows[i][1].ToString());
                    selectXingXi.AppendFormat("and Xx_Fsld  ='{0}' ", dataSet.Tables["Hy"].Rows[i][2].ToString());
                    selectXingXi.AppendFormat("order by Xx_fssj desc");
                    adapter = new SqlDataAdapter(selectXingXi.ToString(), sqlConnection);

                    if (dataSet.Tables["Xx"] != null)
                    {
                        dataSet.Tables["Xx"].Clear();
                    }
                    adapter.Fill(dataSet, "Xx");

                    #region 初始化控件&添加
                    HuiHuaLieBiao huiHuaLieBiao = new HuiHuaLieBiao();
                    huiHuaLieBiao.txt_ShouXinName = dataSet.Tables["Yh"].Rows[0][1].ToString();
                    if (dataSet.Tables["Xx"].Rows.Count != 0)
                    {
                        string XiaoXi = dataSet.Tables["Xx"].Rows[0][2].ToString();
                        #region 更具日期截取时间
                        if (XiaoXi.Length > 10)
                        {
                            XiaoXi = XiaoXi.Substring(0,9);
                            XiaoXi = XiaoXi + "...";
                        }
                        #endregion
                        huiHuaLieBiao.txt_XiaoXi = XiaoXi;
   
                        string duiHuaShiJian = dataSet.Tables["Xx"].Rows[0][3].ToString();
                        #region 更具日期截取时间
                        if (JieQvRiQi(duiHuaShiJian) != HuoQvRiQi())
                        {
                            //duiHuaShiJian = JieQvRiQi(duiHuaShiJian);
                            duiHuaShiJian = JieQvShiJian(duiHuaShiJian);
                        }
                        else
                        {

                            duiHuaShiJian = JieQvShiJian(duiHuaShiJian);
                        }
                        #endregion
                        huiHuaLieBiao.duiHuaShiJian = duiHuaShiJian;
                    }
                    huiHuaLieBiao.sxld = dataSet.Tables["Hy"].Rows[i][2].ToString();
                    huiHuaLieBiao.Yh_ld = Yh_ld;
                    huiHuaLieBiao.Dock = DockStyle.Top;
                    string tongXunHaoYouName = "huiHuaLieBiao" + i;
                    huiHuaLieBiao.Name = tongXunHaoYouName;

                    this.panelHuiHua.Controls.Add(huiHuaLieBiao);
                    #endregion


                }


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
            }
        }
        #endregion

        #region 查询群组、初始化&添加huiHuaLieBiaoQunZu控件
        /// <summary>
        /// 查询群组、初始化、添加huiHuaLieBiaoQunZu控件
        /// </summary>
        public void CheckQunZu()
        {
            SqlConnection sqlConnection = new SqlConnection(strcon);
            try
            {
                StringBuilder selectHaoYou = new StringBuilder();
                selectHaoYou.AppendFormat("select * ");
                selectHaoYou.AppendFormat("from QunXiangXi ");
                selectHaoYou.AppendFormat("where Yh_ld = '{0}'", Yh_ld);
                adapter = new SqlDataAdapter(selectHaoYou.ToString(), sqlConnection);
                if (dataSet.Tables["QunXiangXi"] != null)
                {
                    dataSet.Tables["QunXiangXi"].Clear();
                }
                adapter.Fill(dataSet, "QunXiangXi");

                for (int i = 0; i < dataSet.Tables["QunXiangXi"].Rows.Count; i++)
                {
                    StringBuilder selectXiangQing = new StringBuilder();
                    selectXiangQing.AppendFormat("select * ");
                    selectXiangQing.AppendFormat("from Qun  ");
                    selectXiangQing.AppendFormat("where Qun_ld = '{0}';", dataSet.Tables["QunXiangXi"].Rows[i][1].ToString());
                    adapter = new SqlDataAdapter(selectXiangQing.ToString(), sqlConnection);

                    if (dataSet.Tables["Qun"] != null)
                    {
                        dataSet.Tables["Qun"].Clear();
                    }
                    adapter.Fill(dataSet, "Qun");

                    StringBuilder selectXingXi = new StringBuilder();
                    selectXingXi.AppendFormat("select top 1 * ");
                    selectXingXi.AppendFormat("from XxQ ");
                    selectXingXi.AppendFormat("where XxQ_Sxld = '{0}' ", dataSet.Tables["QunXiangXi"].Rows[i][1].ToString());/*
                    selectXingXi.AppendFormat("and XxQ_Fsld  ='{0}' ", dataSet.Tables["QunXiangXi"].Rows[i][2].ToString());
                    selectXingXi.AppendFormat("or XxQ_Sxld = '{0}' ", dataSet.Tables["QunXiangXi"].Rows[i][2].ToString());
                    selectXingXi.AppendFormat("and XxQ_Fsld  ='{0}' ", dataSet.Tables["QunXiangXi"].Rows[i][1].ToString());*/
                    selectXingXi.AppendFormat("order by XxQ_fssj desc");
                    adapter = new SqlDataAdapter(selectXingXi.ToString(), sqlConnection);

                    if (dataSet.Tables["XxQ"] != null)
                    {
                        dataSet.Tables["XxQ"].Clear();
                    }
                    adapter.Fill(dataSet, "XxQ");

                    #region 初始化控件&添加
                    HuiHuaLieBiaoQunZu huiHuaLieBiaoQunZu = new HuiHuaLieBiaoQunZu();
                    huiHuaLieBiaoQunZu.txt_ShouXinName = dataSet.Tables["Qun"].Rows[0][1].ToString();
                    if (dataSet.Tables["XxQ"].Rows.Count != 0)
                    {
                        StringBuilder selectFSRName = new StringBuilder();
                        selectFSRName.AppendFormat("select * ");
                        selectFSRName.AppendFormat("from Yh ");
                        string name = dataSet.Tables["XxQ"].Rows[0][4].ToString();
                        selectFSRName.AppendFormat("where Yh_Id = '{0}' ", dataSet.Tables["XxQ"].Rows[0][4].ToString());
                        adapter = new SqlDataAdapter(selectFSRName.ToString(), sqlConnection);

                        if (dataSet.Tables["Yh1"] != null)
                        {
                            dataSet.Tables["Yh1"].Clear();
                        }
                        adapter.Fill(dataSet, "Yh1");

                        huiHuaLieBiaoQunZu.txt_FaSongRewn = dataSet.Tables["Yh1"].Rows[0][1].ToString();
                        string XiaoXi = dataSet.Tables["XxQ"].Rows[0][2].ToString();
                        #region 更具日期截取时间
                        if (XiaoXi.Length > 5)
                        {
                            XiaoXi = XiaoXi.Substring(0, 5);
                            XiaoXi = XiaoXi + "...";
                        }
                        #endregion
                        huiHuaLieBiaoQunZu.txt_XiaoXi = XiaoXi;

                        string duiHuaShiJian = dataSet.Tables["XxQ"].Rows[0][3].ToString();
                        #region 更具日期截取时间
                        if (JieQvRiQi(duiHuaShiJian) != HuoQvRiQi())
                        {
                            duiHuaShiJian = JieQvRiQi(duiHuaShiJian);
                        }
                        else
                        {

                            duiHuaShiJian = JieQvShiJian(duiHuaShiJian);
                        }
                        #endregion
                        huiHuaLieBiaoQunZu.duiHuaShiJian = duiHuaShiJian;
                        
                    }
                    huiHuaLieBiaoQunZu.sxld = dataSet.Tables["Qun"].Rows[0][0].ToString();
                    huiHuaLieBiaoQunZu.Yh_ld = Yh_ld;
                    
                    huiHuaLieBiaoQunZu.Dock = DockStyle.Top;
                    string tongXunHaoYouName = "huiHuaLieBiao" + i;
                    huiHuaLieBiaoQunZu.Name = tongXunHaoYouName;

                    this.panelHuiHua.Controls.Add(huiHuaLieBiaoQunZu);
                    #endregion

                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
            }
        }
        #endregion

        #region 获取时间
        /// <summary>
        /// 获取时间
        /// </summary>
        /// <returns></returns>
        public string HuoQvShiJian()
        {
            DateTime dateTime = DateTime.Now;
            string time = string.Format("{0:t}", dateTime);
            return time;
        }
        #endregion

        #region 获取日期
        /// <summary>
        /// 获取日期
        /// </summary>
        /// <returns></returns>
        public string HuoQvRiQi()
        {
            string dateTime = DateTime.Now.ToString();
            string time = dateTime.Substring(0, dateTime.IndexOf(" "));
            return time;
        }


        #endregion

        #region 截取时间
        /// <summary>
        /// 截取时间
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public string JieQvShiJian(string dateTime)
        {
            DateTime dt = DateTime.Parse(dateTime);
            string time = dt.GetDateTimeFormats('t')[0].ToString();
            return time;
        }
        #endregion

        #region 截取日期
        /// <summary>
        /// 截取时间
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public string JieQvRiQi(string dateTime)
        {
            string time = dateTime.Substring(0, dateTime.IndexOf(" "));
            return time;
        }


        #endregion

        #region 初始化列表
        /// <summary>
        /// 初始化会话列表
        /// </summary>
        public void ChuShiHua() {
            //清除会话列表的所有控件
            this.panelHuiHua.Controls.Clear();  
            CheckQunZu();
            CheckHaoYou();
        }
        #endregion

        #region 刷新会话列表信息
        /// <summary>
        /// 定时刷新会话列表信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            ChuShiHua();
        }
        #endregion

    }
}
