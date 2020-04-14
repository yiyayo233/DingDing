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
    /// <summary>
    /// 这个页面本来是请假页面后来改为更多页面     
    /// </summary>
    public partial class FrmQingJia : UserControl
    {
        public FrmQingJia()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 用户ld
        /// </summary>
        public string Yh_ld = "";

        static string strcon = "Data Source=.;Initial Catalog=DingDing;Integrated Security=True";
        DataSet dataSet = new DataSet();
        SqlDataAdapter adapter = new SqlDataAdapter();


        private void skinButton1_Click(object sender, EventArgs e)
        {
            FrmXuanRen frmXuanRen = new FrmXuanRen();
            frmXuanRen.Show();
        }

        private void ButChaoSongRen_Click(object sender, EventArgs e)
        {
            FrmXuanRen frmXuanRen2 = new FrmXuanRen();
            frmXuanRen2.Show();
        }

        private void skinButton4_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void ButTiJiao_Click(object sender, EventArgs e)
        {
            TiJiao();
        }

        private void ButShenPiRen_Click(object sender, EventArgs e)
        {

        }

        private void FrmQingJia_Load(object sender, EventArgs e)
        {
            TianJiaQingJiaLeiXing();
        }

        #region 添加请假类型
        public void TianJiaQingJiaLeiXing()
        {
            SqlConnection sqlConnection = new SqlConnection(strcon);
            try
            {
                string sql = @"select *
                            from QjLx";
                adapter = new SqlDataAdapter(sql, sqlConnection);
                adapter.Fill(dataSet, "QjLx");

                DataRow row = dataSet.Tables["QjLx"].NewRow();
                row["QjLx_ld"] = -1;
                row["QjLx_Name"] = "请选择";
                dataSet.Tables["QjLx"].Rows.InsertAt(row, 0);

                this.ComboBoxQingJiaLeiXing.DataSource = dataSet.Tables["QjLx"];
                this.ComboBoxQingJiaLeiXing.ValueMember = "QjLx_ld";
                this.ComboBoxQingJiaLeiXing.DisplayMember = "QjLx_Name";
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region 提交
        public void TiJiao() {
            SqlConnection sqlConnection = new SqlConnection(strcon);
            try
            {

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
