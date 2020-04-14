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
    public partial class TongXunGongSi : UserControl
    {
        public TongXunGongSi()
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
        /// 公司id
        /// </summary>
        public string txt_GongSild = "";

        /// <summary>
        /// 公司名称
        /// </summary>
        public string txt_GongSiName = "";

        /// <summary>
        /// 公司头像    暂时没有
        /// </summary>
        public string txt_GongSiTx = "";

        private void TongXunGongSi_Load(object sender, EventArgs e)
        {
            UpdateTongXunGongSi();
        }

        #region 查询公司 初始化
        /// <summary>
        /// 查询公司 初始化
        /// </summary>
        public void UpdateTongXunGongSi() {
            SqlConnection sqlConnection = new SqlConnection(strcon);
            try
            {
                this.GongSiLieBiao.Controls.Clear();
                this.Txt_GongSiName.Text = txt_GongSiName;
                this.Txt_GongSiName2.Text = txt_GongSiName;


                StringBuilder selectGongSiXingXi = new StringBuilder();
                selectGongSiXingXi.AppendFormat("select * ");
                selectGongSiXingXi.AppendFormat("from GsXiangXi ");
                selectGongSiXingXi.AppendFormat("where Gs_ld = '{0}'", txt_GongSild);
                adapter = new SqlDataAdapter(selectGongSiXingXi.ToString(),sqlConnection);
                if (dataSet.Tables["GsXiangXi"] != null)
                {
                    dataSet.Tables["GsXiangXi"].Rows.Clear();
                }
                adapter.Fill(dataSet, "GsXiangXi");

                for (int i = 0; i < dataSet.Tables["GsXiangXi"].Rows.Count; i++)
                {
                    StringBuilder selectYh = new StringBuilder();
                    selectYh.AppendFormat("select * ");
                    selectYh.AppendFormat("from Yh ");

                    selectYh.AppendFormat("where Yh_Id = '{0}'", dataSet.Tables["GsXiangXi"].Rows[i][2].ToString());
                    adapter = new SqlDataAdapter(selectYh.ToString(), sqlConnection);
                    if (dataSet.Tables["Yh"] != null)
                    {
                        dataSet.Tables["Yh"].Rows.Clear();
                    }
                    adapter.Fill(dataSet, "Yh");

                    #region 初始化控件&添加
                    TongXunHaoYou1 tongXunHaoYou1 = new TongXunHaoYou1(this);
                    tongXunHaoYou1.txt_HaoYouName = dataSet.Tables["Yh"].Rows[0][1].ToString();
                    tongXunHaoYou1.Yh_ld = Yh_ld;
                    tongXunHaoYou1.chaZhaoYhld = dataSet.Tables["Yh"].Rows[0][0].ToString();
                    tongXunHaoYou1.Dock = DockStyle.Top;
                    string tongXunHaoYouName = "tongXunHaoYou" + i;
                    tongXunHaoYou1.Name = tongXunHaoYouName;

                    this.GongSiLieBiao.Controls.Add(tongXunHaoYou1);
                    #endregion
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
    }
}
