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
    public partial class WoDeQingZu : UserControl
    {
        public WoDeQingZu()
        {
            InitializeComponent();
        }

        static string strcon = "Data Source=.;Initial Catalog=DingDing;Integrated Security=True";
        DataSet dataSet = new DataSet();
        SqlDataAdapter adapter = new SqlDataAdapter();

        public string Yh_ld = "";

        private void WoDeQingZu_Load(object sender, EventArgs e)
        {
            CheckQingZu();
        }

        #region 查询好友、初始化&添加tongXunHaoYou控件
        /// <summary>
        /// 查询好友、初始化&添加tongXunHaoYou控件
        /// </summary>
        public void CheckQingZu()
        {
            SqlConnection sqlConnection = new SqlConnection(strcon);
            try
            {
                StringBuilder selectQingZu = new StringBuilder();
                selectQingZu.AppendFormat("select * ");
                selectQingZu.AppendFormat("from QunXiangXi as QX ");
                selectQingZu.AppendFormat("inner join Qun as Q on Q.Qun_ld = QX.XiangXi_ld ");
                selectQingZu.AppendFormat("where QX.Yh_ld = '{0}'", Yh_ld);
                adapter = new SqlDataAdapter(selectQingZu.ToString(), sqlConnection);
                adapter.Fill(dataSet, "QX");

                if (dataSet.Tables["QX"].Rows.Count <= 0)//没有加入任何群组
                {
                    return;
                }
                for (int i = 0; i < dataSet.Tables["QX"].Rows.Count; i++)
                {
                    StringBuilder selectXiangQing = new StringBuilder();
                    selectXiangQing.AppendFormat("select * ");
                    selectXiangQing.AppendFormat("from QunXiangXi ");
                    selectXiangQing.AppendFormat("where XiangXi_ld= '{0}'", dataSet.Tables["QX"].Rows[i][1].ToString());
                    adapter = new SqlDataAdapter(selectXiangQing.ToString(), sqlConnection);

                    if (dataSet.Tables["QunNum"] != null)
                    {
                        dataSet.Tables["QunNum"].Clear();
                    }
                    adapter.Fill(dataSet, "QunNum");

                    #region 初始化控件&添加
                    TongXunQunZu tongXunQunZu = new TongXunQunZu();
                    tongXunQunZu.txt_QunZuName = dataSet.Tables["QX"].Rows[i][4].ToString();
                    tongXunQunZu.txt_QunZuRenShu = dataSet.Tables["QunNum"].Rows.Count.ToString();
                    //头像
                    tongXunQunZu.chaZhaoYhld = dataSet.Tables["QX"].Rows[i][1].ToString();
                    tongXunQunZu.Dock = DockStyle.Top;
                    string tongXunQunZuName = "tongXunQunZu" + i;
                    tongXunQunZu.Name = tongXunQunZuName;

                    this.panelLieBiao.Controls.Add(tongXunQunZu);
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

       
    }
}
