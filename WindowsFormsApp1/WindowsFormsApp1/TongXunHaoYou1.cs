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
    public partial class TongXunHaoYou1 : UserControl
    {
        public TongXunHaoYou1(TongXunGongSi parent)
        {
            InitializeComponent();
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
        /// 好友名称
        /// </summary>
        public string txt_HaoYouName = "";
        /// <summary>
        /// 好友id
        /// </summary>
        public string chaZhaoYhld = "";

        private void TongXunHaoYou_Load(object sender, EventArgs e)
        {

            UptedaTongXunHaoYou();
        }

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            IfHongYou();
        }

        #region 改变panel1背景颜色
        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            if (this.panel1.BackColor != System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(240))))))
            {
                this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            }

        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            if (this.panel1.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(240))))))
            {

            }
            else
            {
                if (this.panel1.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247))))))
                {
                    this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                }
            }

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.panel1.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(240))))))
            {
                this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            }
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));
        }
        #endregion

        #region 初始化控件
        /// <summary>
        /// 初始化控件
        /// </summary>
        public void UptedaTongXunHaoYou()
        {
            foreach (var lb in panel1.Controls)
            {
                if (lb is Label)
                {
                    Label obj = lb as Label;   

                    if (obj.Name == "Txt_HaoYouName")
                    {
                        obj.Text = txt_HaoYouName;
                    }
                }
            }
        }
        #endregion

        #region 打开FrmTongXunXiangXiXingXi窗口
        /// <summary>
        /// 打开好友信息1窗口
        /// </summary>
        private void ShowFrmTongXunXiangXiXingXi()
        {
            FrmTongXunXiangXiXingXi1 frmTongXunXiangXiXingXi1 = new FrmTongXunXiangXiXingXi1(paf);
            frmTongXunXiangXiXingXi1.Yh_ld = Yh_ld;
            frmTongXunXiangXiXingXi1.chaZhaoYhld = chaZhaoYhld;
            frmTongXunXiangXiXingXi1.Show();
        }
        #endregion

        #region 打开FrmTianJiaXiangXiXingXi1窗口
        /// <summary>
        /// 打开添加好友1窗口
        /// </summary>
        private void ShowFrmTianJiaXiangXiXingXi1()
        {
            FrmTianJiaXiangXiXingXi1 frmTianJiaXiangXiXingXi1 = new FrmTianJiaXiangXiXingXi1(paf);
            frmTianJiaXiangXiXingXi1.Yh_ld = Yh_ld;
            frmTianJiaXiangXiXingXi1.chaZhaoYhld = chaZhaoYhld;
            frmTianJiaXiangXiXingXi1.Show();
        }
        #endregion


        #region 判断是否是好友
        /// <summary>
        /// 判断是否是好友
        /// </summary>
        public void IfHongYou()
        {
            SqlConnection sqlConnection = new SqlConnection(strcon);
            try
            {
                StringBuilder selectHY = new StringBuilder();
                selectHY.AppendFormat("select * ");
                selectHY.AppendFormat("from Hy ");
                selectHY.AppendFormat("where Hy_Yhld = '{0}' ",Yh_ld);
                selectHY.AppendFormat("and Hy_Hyld = '{0}'",chaZhaoYhld);
                adapter = new SqlDataAdapter(selectHY.ToString(),sqlConnection);
                adapter.Fill(dataSet,"Hy");
                if (dataSet.Tables["Hy"].Rows.Count > 0)
                {
                    ShowFrmTongXunXiangXiXingXi();
                }
                else
                {
                    ShowFrmTianJiaXiangXiXingXi1();
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
