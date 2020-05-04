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
    public partial class FrmTongXunLu : UserControl
    {
        public FrmTongXunLu()
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

        private void FrmTongXunLu_Load(object sender, EventArgs e)
        {
            SelectGongSi();
        }
        #region 改变panel3背景颜色 我的好友
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {

            Panel3Panel9Panel14Panel19Panel24();
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));
            CloseAllFrom();
            this.xinDeHaoYou1.Yh_ld = Yh_ld;
            this.xinDeHaoYou1.Visible = true;
        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            if (this.panel3.BackColor != System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(240))))))
            {
                this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            }
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            if (this.panel3.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(240))))))
            {

            }
            else
            {
                if (this.panel3.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247))))))
                {
                    this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                }
            }
        }
        #endregion

        #region 改变panel9背景颜色 新的好友
        /*private void panel9_MouseDown(object sender, MouseEventArgs e)
        {
            Panel3Panel9Panel14Panel19Panel24();
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));
            CloseAllFrom();
            this.xinDeHaoYou1.Yh_ld = Yh_ld;
            this.xinDeHaoYou1.Visible = true;
        }

        private void panel9_MouseEnter(object sender, EventArgs e)
        {
            if (this.panel9.BackColor != System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(240))))))
            {
                this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            }
        }

        private void panel9_MouseLeave(object sender, EventArgs e)
        {
            if (this.panel9.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(240))))))
            {

            }
            else
            {
                if (this.panel9.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247))))))
                {
                    this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                }
            }
        }*/
        #endregion

        #region 改变panel14背景颜色 我的群组
        private void panel14_MouseDown(object sender, MouseEventArgs e)
        {
            Panel3Panel9Panel14Panel19Panel24();
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));
            CloseAllFrom();
            this.woDeQingZu1.Yh_ld = Yh_ld;
            this.woDeQingZu1.Visible = true;
        }

        private void panel14_MouseEnter(object sender, EventArgs e)
        {
            if (this.panel14.BackColor != System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(240))))))
            {
                this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            }
        }

        private void panel14_MouseLeave(object sender, EventArgs e)
        {
            if (this.panel14.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(240))))))
            {

            }
            else
            {
                if (this.panel14.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247))))))
                {
                    this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                }
            }
        }
        #endregion

        #region 改变panel14背景颜色 创建团队
        private void panel24_MouseDown(object sender, MouseEventArgs e)
        {
            Panel3Panel9Panel14Panel19Panel24();
            this.panel24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));
            CloseAllFrom();
            /*this.teBieGuanZhu1.Yh_ld = Yh_ld;
            this.teBieGuanZhu1.Visible = true;*/

            FrmTianJIaQiYe frmTianJIaQiYe = new FrmTianJIaQiYe(this);
            frmTianJIaQiYe.Yh_ld = Yh_ld;
            frmTianJIaQiYe.Show();
        }

        private void panel24_MouseEnter(object sender, EventArgs e)
        {
            if (this.panel24.BackColor != System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(240))))))
            {
                this.panel24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            }
        }

        private void panel24_MouseLeave(object sender, EventArgs e)
        {
            if (this.panel24.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(240))))))
            {

            }
            else
            {
                if (this.panel24.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247))))))
                {
                    this.panel24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                }
            }
        }
        #endregion

        #region 全部给我变白
        /// <summary>
        /// 全部给我变白
        /// </summary>
        private void Panel3Panel9Panel14Panel19Panel24() {
            if (this.panel3.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(240))))))
            {
                this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            }
            /*if (this.panel9.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(240))))))
            {
                this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            }*/
            if (this.panel14.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(240))))))
            {
                this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            }
            /*if (this.panel19.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(240))))))
            {
                this.panel19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            }*/
            if (this.panel24.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(240))))))
            {
                this.panel24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            }
        }
        #endregion

        #region 关闭全部分组窗口
        /// <summary>
        /// 关闭全部分组窗口
        /// </summary>
        private void CloseAllFrom() {
            this.xinDeHaoYou1.Visible = false;
            this.woDeQingZu1.Visible = false;
            this.teBieGuanZhu1.Visible = false;
            this.tongXunGongSi1.Visible = false;
        }
        #endregion

        #region 查找公司
        /// <summary>
        /// 查找公司
        /// </summary>
        public void SelectGongSi() {
            SqlConnection sqlConnection = new SqlConnection(strcon);
            try
            {
                /*Control Control = this.panel6;
                foreach (var lb in Control.Controls)
                {
                    if (lb is TongXunLieBiaoGongSi)
                    {
                        TongXunLieBiaoGongSi tongXunLieBiaoGongSi = lb as TongXunLieBiaoGongSi;
                        this.panel6.Controls.Remove(tongXunLieBiaoGongSi);
                    }
                }*/

                StringBuilder selectGongSiXiangXi = new StringBuilder();
                selectGongSiXiangXi.AppendFormat("select * ");
                selectGongSiXiangXi.AppendFormat("from GsXiangXi ");
                selectGongSiXiangXi.AppendFormat("where Yh_ld = '{0}'",Yh_ld);
                adapter = new SqlDataAdapter(selectGongSiXiangXi.ToString(),sqlConnection);
                if (dataSet.Tables["GsXiangXi"] != null)
                {
                    dataSet.Tables["GsXiangXi"].Clear();
                }
                adapter.Fill(dataSet, "GsXiangXi");

                for (int i = 0; i < dataSet.Tables["GsXiangXi"].Rows.Count; i++)
                {
                    StringBuilder selectGongSi = new StringBuilder();
                    selectGongSi.AppendFormat("select * ");
                    selectGongSi.AppendFormat("from Gs ");
                    selectGongSi.AppendFormat("where Gs_ld = '{0}'",dataSet.Tables["GsXiangXi"].Rows[i][1].ToString());
                    adapter = new SqlDataAdapter(selectGongSi.ToString(), sqlConnection);
                    if (dataSet.Tables["Gs"] != null)
                    {
                        dataSet.Tables["Gs"].Clear();
                    }
                    adapter.Fill(dataSet, "Gs");

                    TongXunLieBiaoGongSi tongXunLieBiaoGongSi = new TongXunLieBiaoGongSi();
                    tongXunLieBiaoGongSi.txt_GongSiName = dataSet.Tables["Gs"].Rows[0][1].ToString();
                    tongXunLieBiaoGongSi.txt_GongSild = dataSet.Tables["Gs"].Rows[0][0].ToString();
                    tongXunLieBiaoGongSi.Yh_ld = Yh_ld;
                    tongXunLieBiaoGongSi.Dock = DockStyle.Top;
                    string tongXunHaoYouName = "tongXunLieBiaoGongSi" + i;
                    tongXunLieBiaoGongSi.Name = tongXunHaoYouName;

                    this.panel6.Controls.Add(tongXunLieBiaoGongSi);

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
