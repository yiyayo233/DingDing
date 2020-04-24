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
    public partial class WoDeHaoYou : UserControl
    {
        public WoDeHaoYou()/*FrmTongXunLu parent*/
        {
            InitializeComponent();
            /*paf = parent;*/
        }
        /*private FrmTongXunLu paf;*/

        /*static string strcon = "Data Source=.;Initial Catalog=DingDing;Integrated Security=True";
        DataSet dataSet = new DataSet();
        SqlDataAdapter adapter = new SqlDataAdapter();

        public string Yh_ld = "";

        private void WoDeHaoYou_Load(object sender, EventArgs e)
        {
            CheckHaoYou();
        }

        #region 查询好友、初始化&添加tongXunHaoYou控件
        /// <summary>
        /// 查询好友、初始化&添加tongXunHaoYou控件
        /// </summary>
        public void CheckHaoYou() {
            SqlConnection sqlConnection = new SqlConnection(strcon);
            try
            {
                this.panelLieBiao.Controls.Clear();

                StringBuilder selectHaoYou = new StringBuilder();
                selectHaoYou.AppendFormat("select * ");
                selectHaoYou.AppendFormat("from Hy ");
                selectHaoYou.AppendFormat("where Hy_Yhld = '{0}'",Yh_ld);
                adapter = new SqlDataAdapter(selectHaoYou.ToString(), sqlConnection);

                if (dataSet.Tables["Hy"] != null)
                {
                    dataSet.Tables["Hy"].Clear();
                }

                adapter.Fill(dataSet,"Hy");

                for (int i = 0; i < dataSet.Tables["Hy"].Rows.Count; i++)
                {
                    StringBuilder selectXiangQing = new StringBuilder();
                    selectXiangQing.AppendFormat("select * ");
                    selectXiangQing.AppendFormat("from Yh ");//.Item("Hy_Hyld")
                    selectXiangQing.AppendFormat("where Yh_Id = '{0}'", dataSet.Tables["Hy"].Rows[i][2].ToString());
                    adapter = new SqlDataAdapter(selectXiangQing.ToString(), sqlConnection);

                    if (dataSet.Tables["Yh"] != null)
                    {
                        dataSet.Tables["Yh"].Clear();
                    }
                    adapter.Fill(dataSet, "Yh");

                    #region 初始化控件&添加
                    TongXunHaoYou tongXunHaoYou = new TongXunHaoYou(this);
                    tongXunHaoYou.txt_HaoYouName = dataSet.Tables["Yh"].Rows[0][1].ToString();
                    tongXunHaoYou.Yh_ld = Yh_ld;
                    tongXunHaoYou.chaZhaoYhld = dataSet.Tables["Yh"].Rows[0][0].ToString();
                    tongXunHaoYou.Dock = DockStyle.Top;
                    string tongXunHaoYouName = "tongXunHaoYou" + i;
                    tongXunHaoYou.Name = tongXunHaoYouName;

                    this.panelLieBiao.Controls.Add(tongXunHaoYou);
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

        private void skinButton1_Click(object sender, EventArgs e)
        {
            FrmTianJIaHaoYou frmTianJIaHaoYou = new FrmTianJIaHaoYou(this);
            frmTianJIaHaoYou.Yh_ld = Yh_ld;
            frmTianJIaHaoYou.Show();
        }*/
    }
}
