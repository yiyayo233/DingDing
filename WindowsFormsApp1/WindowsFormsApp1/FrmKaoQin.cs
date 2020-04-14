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
    public partial class FrmKaoQin : UserControl
    {
        static string strcon = "Data Source=.;Initial Catalog=DingDing;Integrated Security=True";
        DataSet dataSet = new DataSet();
        SqlDataAdapter adapter = new SqlDataAdapter();

        /// <summary>
        /// 用户ld
        /// </summary>
        public string Yh_ld = "";

        /// <summary>
        /// 上班考勤时间
        /// </summary>
        public string SBKQSJ = "";

        /// <summary>
        /// 下班考勤时间
        /// </summary>
        public string XBKQSJ = "";

        /// <summary>
        /// 上班时间
        /// </summary>
        string sbsj = "";
        /// <summary>
        /// 上班日期
        /// </summary>
        string sbrq = "";


        public FrmKaoQin()
        {
            InitializeComponent();
        }


        private void FrmKaoQin_Load(object sender, EventArgs e)
        {
            ChuShiHuaYinPing();
            ShiFouDaKa();
        }
        /// <summary>
        /// 更改框框时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            ShiJIan.Text = DateTime.Now.ToString();
        }

        private void ButShangBan_Click(object sender, EventArgs e)
        {
            ShangBanDaKa(1);
        }

        private void ButShangBanG_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要更新此次打卡记录吗？", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                ShangBanDaKa(2);
            }
            
        }

        private void ButXiaBan_Click(object sender, EventArgs e)
        {
            XiaBanDaKa(1);
        }

        private void ButXiaBanG_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要更新此次打卡记录吗？","",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                XiaBanDaKa(2);
            }
            
        }
        
        #region 上班打卡
        /// <summary>
        /// 上班打卡
        /// </summary>
        /// <param name="pd">判断是否修改上班打卡时间</param>
        public void ShangBanDaKa(int pd)
        {
            SqlConnection sqlConnection = new SqlConnection(strcon);
            try
            {
                sbsj = JieQvShiJian();
                sbrq = JieQvRiQi();
                int sbKqZt = 1;
                if (DateTime.Parse(sbsj) > DateTime.Parse(SBKQSJ))
                {
                    sbKqZt = 2;
                }

                StringBuilder insert = new StringBuilder();
                if (pd == 1)
                {
                    insert.AppendFormat("insert Qd(Yh_ld,Qd_SBRQ,Qd_SBSJ,QdLx_SBld)");
                    insert.AppendFormat("values('{0}','{1}','{2}','{3}')", Yh_ld, sbrq, sbsj, sbKqZt);
                }
                else
                {
                    insert.AppendFormat("update Qd set Qd_SBRQ = '{0}',", sbrq);
                    insert.AppendFormat("Qd_SBSJ = '{0}',", sbsj);
                    insert.AppendFormat("QdLx_SBld = '{0}' ", sbKqZt);
                    insert.AppendFormat("where Yh_ld = '{0}' ", Yh_ld);
                    insert.AppendFormat("and Qd_SBRQ = '{0}'", sbrq);
                }
                
                adapter = new SqlDataAdapter(insert.ToString(),sqlConnection);
                if (pd == 1)
                {
                    adapter.Fill(dataSet, "Qd");
                }
                else
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(insert.ToString(),sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                }
                
                this.ShangBangDaKaShiajin.Visible = true;
                if (sbsj.Length == 5)
                {
                    this.ShangBangDaKaShiajin.Text = "打卡时间" + sbsj + ":00";
                }
                else
                {
                    this.ShangBangDaKaShiajin.Text = "打卡时间" + sbsj;
                }
               
                this.ButShangBanG.Visible = true;
                this.ButShangBan.Visible = false;
                this.ButXiaBan.Visible = true;
                if (sbKqZt == 2)
                {
                    this.ChiDao.Visible = true;
                }
                else
                {
                    this.ChiDao.Visible = false;
                }
                this.axWindowsMediaPlayer1.Ctlcontrols.play();

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

        #region 下班打卡
        /// <summary>
        /// 下班打卡
        /// </summary>
        /// <param name="pd">判断是否修改下班打卡时间</param>
        public void XiaBanDaKa(int pd)
        {
            SqlConnection sqlConnection = new SqlConnection(strcon);
            try
            {
                string xbsj = JieQvShiJian();
                string xbrq = JieQvRiQi();
                int xbKqZt = 1;
                if (DateTime.Parse(xbsj) < DateTime.Parse(XBKQSJ))
                {
                    xbKqZt = 2;
                }

                StringBuilder insert = new StringBuilder();
                if (pd == 1)
                {
                    insert.AppendFormat("update Qd set Qd_XBRQ = '{0}',", xbrq);
                    insert.AppendFormat("Qd_XBSJ = '{0}',", xbsj);
                    insert.AppendFormat("QdLx_XBld = '{0}' ", xbKqZt);
                    insert.AppendFormat("where Yh_ld = '{0}' ", Yh_ld);
                    insert.AppendFormat("and Qd_SBRQ = '{0}'", xbrq);
                }
                else
                {
                    insert.AppendFormat("update Qd set Qd_XBRQ = '{0}',", xbrq);
                    insert.AppendFormat("Qd_XBSJ = '{0}',", xbsj);
                    insert.AppendFormat("QdLx_XBld = '{0}' ", xbKqZt);
                    insert.AppendFormat("where Yh_ld = '{0}' ", Yh_ld);
                    insert.AppendFormat("and Qd_SBRQ = '{0}'", xbrq);
                }

                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(insert.ToString(), sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                this.XiaBangDaKaShiajin.Visible = true;
                if (xbsj.Length == 5)
                {
                    this.XiaBangDaKaShiajin.Text = "打卡时间" + xbsj + ":00";
                }
                else
                {
                    this.XiaBangDaKaShiajin.Text = "打卡时间" + xbsj;
                }
                ButShangBanG.Visible = false;
                this.ButXiaBan.Visible = false;
                this.ButXiaBanG.Visible = true;
                if (xbKqZt == 2)
                {
                    this.ZaoTui.Visible = true;
                }
                else
                {
                    this.ZaoTui.Visible = false;
                }
                this.axWindowsMediaPlayer1.Ctlcontrols.play();

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

        #region 截取时间
        /// <summary>
        /// 截取时间
        /// </summary>
        /// <returns>返回时间</returns>
        public string JieQvShiJian() {
            DateTime dateTime = DateTime.Now;
            string time = string.Format("{0:t}", dateTime);
            return time;
        }
        #endregion

        #region 截取日期
        /// <summary>
        /// 截取日期
        /// </summary>
        /// <returns>返回日期</returns>
        public string JieQvRiQi()
        {
            string dateTime = DateTime.Now.ToString();
            string time = dateTime.Substring(0, dateTime.IndexOf(" "));
            return time;
        }


        #endregion

        #region 判断当天是否打卡
        /// <summary>
        /// 判断当天是否打卡
        /// </summary>
        public void ShiFouDaKa() {
            int pd = 0;
            SqlConnection sqlConnection = new SqlConnection(strcon);
            try
            {
                StringBuilder select2 = new StringBuilder();
                select2.AppendFormat("select COUNT(*) ");
                select2.AppendFormat("from Qd ");
                select2.AppendFormat("where Yh_ld = '{0}' ", Yh_ld);
                select2.AppendFormat("and Qd_XBRQ = '{0}'", JieQvRiQi());
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(select2.ToString(), sqlConnection);
                if ((int)sqlCommand.ExecuteScalar() > 0)
                {
                    pd = 2; //2表示已打下班卡
                    ShiFouDaKaSG(pd);
                }
                sqlConnection.Close();

                if (pd == 1)
                {
                    StringBuilder select = new StringBuilder();
                    select.AppendFormat("select COUNT(*) ");
                    select.AppendFormat("from Qd ");
                    select.AppendFormat("where Yh_ld = '{0}' ", Yh_ld);
                    select.AppendFormat("and Qd_SBRQ = '{0}'", JieQvRiQi());
                    sqlConnection.Open();
                    sqlCommand = new SqlCommand(select.ToString(), sqlConnection);
                    if ((int)sqlCommand.ExecuteScalar() > 0)
                    {
                        sqlConnection.Close();
                        pd = 1; //1表示已打上班卡
                        ShiFouDaKaSG(pd);

                    }

                    
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

        #region 当天是否打卡对控件的操作
        /// <summary>
        /// 当天是否打卡对控件的操作
        /// </summary>
        /// <param name="pd">判断是否下班打卡</param>
        public void ShiFouDaKaSG(int pd) {
            SqlConnection sqlConnection = new SqlConnection(strcon);
            try
            {
                if (pd == 1)
                {
                    StringBuilder selectSBSJ = new StringBuilder();
                    selectSBSJ.AppendFormat("select * ");
                    selectSBSJ.AppendFormat("from Qd ");
                    selectSBSJ.AppendFormat("where Yh_ld = '{0}' ",Yh_ld);
                    selectSBSJ.AppendFormat("and Qd_SBRQ = '{0}'", JieQvRiQi());
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(selectSBSJ.ToString(), sqlConnection);
                    SqlDataReader sr = sqlCommand.ExecuteReader();
                    string sbdasj = "";
                    string cd = "";
                    while (sr.Read())
                    {
                        sbdasj = sr["Qd_SBSJ"].ToString();
                        cd = sr["QdLx_SBld"].ToString();
                    }

                    this.ShangBangDaKaShiajin.Visible = true;
                    this.ShangBangDaKaShiajin.Text = "打卡时间" + sbdasj;

                    sqlConnection.Close();
                    this.ButShangBanG.Visible = true;
                    this.ButShangBan.Visible = false;
                    this.ButXiaBan.Visible = true;
                    if (cd == "2")
                    {
                        this.ChiDao.Visible = true;
                    }
                }
                else
                {

                    StringBuilder selectSXBSJ = new StringBuilder();
                    selectSXBSJ.AppendFormat("select * ");
                    selectSXBSJ.AppendFormat("from Qd ");
                    selectSXBSJ.AppendFormat("where Yh_ld = '{0}' ", Yh_ld);
                    selectSXBSJ.AppendFormat("and Qd_XBRQ = '{0}'", JieQvRiQi());
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(selectSXBSJ.ToString(), sqlConnection);
                    SqlDataReader sr = sqlCommand.ExecuteReader();
                    string sbdasj = "";
                    string xbdasj = "";
                    string cd = "";
                    string zt = "";
                    while (sr.Read())
                    {
                        sbdasj = sr["Qd_SBSJ"].ToString();
                        xbdasj = sr["Qd_XBSJ"].ToString();
                        cd = sr["QdLx_SBld"].ToString();
                        zt = sr["QdLx_XBld"].ToString();
                    }
                    sqlConnection.Close();
                    sr.Close();
                    this.ShangBangDaKaShiajin.Visible = true;
                    this.ShangBangDaKaShiajin.Text = "打卡时间" + sbdasj;
                    this.ButShangBanG.Visible = true;
                    this.ButShangBan.Visible = false;
                    this.ButXiaBan.Visible = true;
                    if (cd == "2")
                    {
                        this.ChiDao.Visible = true;
                    }

                    this.XiaBangDaKaShiajin.Visible = true;
                    this.XiaBangDaKaShiajin.Text = "打卡时间" + xbdasj;
                    this.ButShangBanG.Visible = false;
                    this.ButXiaBan.Visible = false;
                    this.ButXiaBanG.Visible = true;
                    if (zt == "2")
                    {
                        this.ZaoTui.Visible = true;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        #endregion

        #region 初始化考勤时间、音频
        /// <summary>
        /// 初始化考勤时间、音频
        /// </summary>
        public void ChuShiHuaYinPing() {

            ShiJIan.Text = DateTime.Now.ToString();

            SqlConnection sqlConnection = new SqlConnection(strcon);
            sqlConnection.Open();
            StringBuilder select = new StringBuilder();
            select.AppendFormat("select K.Kq_SBSJ,K.Kq_XBSJ ");
            select.AppendLine("from Kq as K");
            SqlCommand sqlCommand = new SqlCommand(select.ToString(), sqlConnection);
            SqlDataReader dr = sqlCommand.ExecuteReader();
            while (dr.Read())
            {
                SBKQSJ = dr["Kq_SBSJ"].ToString();
                XBKQSJ = dr["Kq_XBSJ"].ToString();
            }


            this.ShangBanShiJIan.Text = "上班时间" + SBKQSJ;
            this.XiaBanShiJIan.Text = "下班时间" + XBKQSJ;
            sqlConnection.Close();

            this.axWindowsMediaPlayer1.URL = @"E:\项目\winfrom\项目文件\音频\yinxiao.mp3";
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }
        #endregion


    }
}
