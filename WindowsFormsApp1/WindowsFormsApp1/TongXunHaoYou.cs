﻿using System;
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
    public partial class TongXunHaoYou : UserControl
    {
        public TongXunHaoYou(XinDeHaoYou parent)
        {
            InitializeComponent();
            paf = parent;
        }

        private XinDeHaoYou paf;

        public TongXunHaoYou(TongXunGongSi parent)
        {
            InitializeComponent();
            paf1 = parent;
        }
        private TongXunGongSi paf1;

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
        /// <summary>
        /// 好友头像
        /// </summary>
        public string chaZhaoYhTX = "";

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
            if (chaZhaoYhTX.Length != 0)
            {
                this.pictureBox_Top.Load(UploadFileController.rootPath + chaZhaoYhTX);
            }
        }
        #endregion

        #region 打开好友信息窗口
        /// <summary>
        /// 打开好友信息窗口
        /// </summary>
        private void ShowFrmTongXunXiangXiXingXi()
        {
            FrmTongXunXiangXiXingXi frmTongXunXiangXiXingXi = null;
            if (paf != null)
            {
                frmTongXunXiangXiXingXi = new FrmTongXunXiangXiXingXi(paf);
            }
            else
            {
                frmTongXunXiangXiXingXi = new FrmTongXunXiangXiXingXi(paf1);
            }
            frmTongXunXiangXiXingXi.Yh_ld = Yh_ld;
            frmTongXunXiangXiXingXi.chaZhaoYhld = chaZhaoYhld;
            frmTongXunXiangXiXingXi.Show();
        }
        #endregion

        #region 打开添加好友窗口
        /// <summary>
        /// 打开添加好友窗口
        /// </summary>
        private void ShowFrmTianJiaXiangXiXingXi1()
        {
            FrmTianJiaXiangXiXingXi frmTianJiaXiangXiXingXi1 = new FrmTianJiaXiangXiXingXi(paf1);
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
                selectHY.AppendFormat("where Hy_Yhld = '{0}' ", Yh_ld);
                selectHY.AppendFormat("and Hy_Hyld = '{0}'", chaZhaoYhld);
                adapter = new SqlDataAdapter(selectHY.ToString(), sqlConnection);
                adapter.Fill(dataSet, "Hy");
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
