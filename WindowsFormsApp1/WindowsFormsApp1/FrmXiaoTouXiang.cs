using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin.Imaging;
using 钉钉;
using System.Data.SqlClient;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class FrmXiaoTouXiang : UserControl
    {
        public FrmXiaoTouXiang()
        {
            InitializeComponent();
        }

        string strconn = "Data Source=.;Initial Catalog=DingDing;Integrated Security=True";
        DataSet dataSet = new DataSet();
        SqlDataAdapter adapter = new SqlDataAdapter();

        /// <summary>
        /// 用户id
        /// </summary>
        public string Yh_ld = "";

        #region 初始化
        /// <summary>
        /// 初始化
        /// </summary>
        public void ChuShiHua() {
            SqlConnection sqlConnection = new SqlConnection(strconn);
            try
            {
                StringBuilder selectYh = new StringBuilder();
                selectYh.AppendFormat("select * ");
                selectYh.AppendFormat("from Yh ");
                selectYh.AppendFormat("where Yh_Id = '{0}'",Yh_ld);
                adapter = new SqlDataAdapter(selectYh.ToString(),sqlConnection);
                if (dataSet.Tables["yh"] != null)
                {
                    dataSet.Tables["yh"].Rows.Clear();
                }
                adapter.Fill(dataSet,"yh");

                this.YhName.Text = dataSet.Tables["yh"].Rows[0][1].ToString().Trim();
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region 改变用户名颜色
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            this.YhName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
        }
        private void YhName_MouseLeave(object sender, EventArgs e)
        {
            this.YhName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        }
        #endregion

        #region 修改密码&背景颜色
        private void panel6_MouseDown(object sender, MouseEventArgs e)
        {
            UpdateMiMa();
        }

        #region 修改密码
        /// <summary>
        /// 修改密码
        /// </summary>
        public void UpdateMiMa() {
            XuiGaiYhMiMa xuiGaiYhMiMa = new XuiGaiYhMiMa();
            xuiGaiYhMiMa.Yh_ld = Yh_ld;
            xuiGaiYhMiMa.Show();
        }
        #endregion

        private void panel6_MouseEnter(object sender, EventArgs e)
        {
            if (this.panel6.BackColor != System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(240))))))
            {
                this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            }
        }

        private void panel6_MouseLeave(object sender, EventArgs e)
        {
            if (this.panel6.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(240))))))
            {

            }
            else
            {
                if (this.panel6.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247))))))
                {
                    this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                }
            }
        }

        #endregion

        #region 切换账号&背景颜色
        private void panel8_MouseDown(object sender, MouseEventArgs e)
        {
            QeiHuanZhangHao();
        }

        #region 切换账号
        /// <summary>
        /// 切换账号
        /// </summary>
        public void QeiHuanZhangHao() {
            this.Hide();
            this.FindForm().Close();
            DingDing dingDing = new DingDing();
            dingDing.Show();
        }
        #endregion

        private void panel8_MouseEnter(object sender, EventArgs e)
        {
            if (this.panel8.BackColor != System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(240))))))
            {
                this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            }
        }

        private void panel8_MouseLeave(object sender, EventArgs e)
        {
            if (this.panel8.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(240))))))
            {

            }
            else
            {
                if (this.panel8.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247))))))
                {
                    this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                }
            }
        }

        #endregion

        #region 退出钉钉&背景颜色
        private void panel13_MouseDown(object sender, MouseEventArgs e)
        {
            TuiChuDingDing();
        }

        #region 退出钉钉
        /// <summary>
        /// 退出钉钉
        /// </summary>
        public void TuiChuDingDing()
        {
            Application.Exit();
        }
        #endregion

        private void panel13_MouseEnter(object sender, EventArgs e)
        {
            if (this.panel13.BackColor != System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(240))))))
            {
                this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            }
        }

        private void panel13_MouseLeave(object sender, EventArgs e)
        {
            if (this.panel13.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(240))))))
            {

            }
            else
            {
                if (this.panel13.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247))))))
                {
                    this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                }
            }
        }
        #endregion

        private void FrmXiaoTouXiang_Load(object sender, EventArgs e)
        {
            ChuShiHua();
        }

        #region 更换头像
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            UpdateTouXiang();
        }

        /// <summary>
        /// 更换头像
        /// <para>实现方法：通过 OpenFileDialog 对象获取图片位置</para>
        /// </summary>
        public void UpdateTouXiang() {
            SqlConnection connection = new SqlConnection(strconn);
            try
            {
                OpenFileDialog of = new OpenFileDialog();
                //多选文件
                of.Multiselect = false;
                of.Title = "请选择图片文件";
                //文件属性
                //of.Filter = "(*.mp3)|*.mp3";
                
                //图片路径
                string picturePath = null;
                //确定用户选择的是确认按钮
                if (of.ShowDialog() == DialogResult.OK)
                {
                    //图片路径
                    picturePath = of.FileNames[0].Trim();

                    StringBuilder updateTouXiang = new StringBuilder();
                    updateTouXiang.AppendFormat("update Yh set Yh_Tx = '@blobdata' ");
                    updateTouXiang.AppendFormat("where Yh_Id = '{0}'", Yh_ld);

                    SqlCommand command = new SqlCommand(updateTouXiang.ToString(), connection);

                    //文件的名称，每次必须更换图片的名称，这里很为不便
                    //创建FileStream对象
                    FileStream fs = new FileStream(picturePath, FileMode.Open, FileAccess.Read);
                    //声明Byte数组
                    Byte[] mybyte = new byte[fs.Length];
                    //读取数据
                    fs.Read(mybyte, 0, mybyte.Length);
                    fs.Close();
                    //转换成二进制数据，并保存到数据库
                    SqlParameter prm = new SqlParameter
                  ("@blobdata", SqlDbType.VarBinary, mybyte.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, mybyte);
                    command.Parameters.Add(prm);
                    //打开数据库连接
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    #region 刷新头像
                    MemoryStream ms = new MemoryStream(mybyte);
                    PBoxTouXiang.Image = Image.FromStream(ms);
                    #endregion
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
