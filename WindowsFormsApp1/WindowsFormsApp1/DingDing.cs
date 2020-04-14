using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApp1;

namespace 钉钉
{
    public partial class DingDing : Form
    {
        public DingDing()
        {
            InitializeComponent();
        }
        string strconn = "Data Source=.;Initial Catalog=DingDing;Integrated Security=True";
        DataSet dataSet = new DataSet();
        SqlDataAdapter adapter = new SqlDataAdapter();

        #region 初始化
        /// <summary>
        /// 初始化下拉列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 钉钉_Load(object sender, EventArgs e)
        {
            txt_haoma.Text = "请输入手机号";
            this.skinComboBox1.Items.Add("+86");
            this.skinComboBox1.Items.Add("+852");
            this.skinComboBox1.Items.Add("+91");
            this.skinComboBox1.Items.Add("+62");
            this.skinComboBox1.Items.Add("+60");
            this.skinComboBox1.Items.Add("+63");
            this.skinComboBox1.SelectedIndex = 0;
        }
        #endregion

        #region 修改密码
        private void label1_Click(object sender, EventArgs e)
        {
            //忘记密码部分功能暂时不支持
            /*wangjimima tz = new wangjimima();
            tz.Show();
            this.Hide();*/
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Blue;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Silver;
        }
        #endregion

        #region 号码&密码
        private void txt_mima_Enter(object sender, EventArgs e)
        {
            txt_mima.PasswordChar = char.Parse("*");
            if (txt_mima.Text == "请输入密码")
            {
                txt_mima.Text = "";
            }
        }

        private void txt_mima_Leave(object sender, EventArgs e)
        {
            if (txt_mima.Text == "")
            {
                txt_mima.Text = "请输入密码";
                txt_mima.PasswordChar = '\0';
            }
        }

        private void txt_haoma_Enter(object sender, EventArgs e)
        {
            if (txt_haoma.Text == "请输入手机号")
            {
                txt_haoma.Text = "";
            }
        }

        private void txt_haoma_Leave(object sender, EventArgs e)
        {
            if (txt_haoma.Text == "")
            {
                txt_haoma.Text = "请输入手机号";
            }
        }
        #endregion

        #region 登录
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinButton1_Click(object sender, EventArgs e)
        {
            if (this.txt_haoma.Text.Trim() == "请输入手机号")
            {
                MessageBox.Show("请输入手机号", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txt_haoma.Focus();
            }
            else if (this.txt_mima.Text.Trim() == "请输入密码")
            {
                MessageBox.Show("请输入密码", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txt_mima.Focus();
            }
            else
            {
                SqlConnection conn = new SqlConnection(strconn);
                try
                {
                    string Sjh = this.txt_haoma.Text;
                    string Mima = this.txt_mima.Text;

                    StringBuilder sql = new StringBuilder();
                    sql.AppendFormat("select * ");
                    sql.AppendFormat("from Yh ");
                    sql.AppendFormat("where Yh_Sjh='{0}'and Yh_Mm='{1}'",Sjh,Mima);
                    /*string sql = @"select *
                                   from Yh
                                   where Yh_Sjh='" + Sjh + "'and Yh_Mm='" + Mima + "'";*/
                    adapter = new SqlDataAdapter(sql.ToString(), conn);
                    adapter.Fill(dataSet, "yh");
                    if (dataSet.Tables["yh"].Rows.Count > 0)
                    {
                        SysMain sysMain = new SysMain();
                        sysMain.Yh_ld = dataSet.Tables["yh"].Rows[0][0].ToString();
                        sysMain.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("登录失败！手机号或密码错误！");
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        #endregion

        #region 两大金刚键
        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinButton9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// 最小化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinButton8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region  窗体无边框样式时移动
        bool formMove = false;//窗体是否移动
        Point formPoint;//记录窗体的位置
        //按下鼠标时记录移动
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            formPoint = new Point();
            int xOffset;
            int yOffset;
            if (e.Button == MouseButtons.Left)
            {
                //获取当前鼠标的X轴坐标,我理解负的鼠标的X轴坐标加上整个窗体的宽度，这里可以直接使用-e.x,-e.y
                // + SystemInformation.FrameBorderSize.Width
                xOffset = -e.X + SystemInformation.FrameBorderSize.Width;
                //获取当前鼠标的y轴坐标
                //- SystemInformation.CaptionHeight
                // + SystemInformation.FrameBorderSize.Height
                yOffset = -e.Y + SystemInformation.FrameBorderSize.Height;
                //将坐标存入
                formPoint = new Point(xOffset, yOffset);
                formMove = true;//开始移动
            }
        }
        //鼠标移动时移动
        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (formMove == true)
            {
                //拖动时获取鼠标的位置，存入
                Point mousePos = Control.MousePosition;
                //进行平移
                mousePos.Offset(formPoint.X, formPoint.Y);
                //执行平移
                Location = mousePos;
            }
        }

        //鼠标松开时停下
        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)//按下的是鼠标左键
            {
                formMove = false;//停止移动
            }
        }


        #endregion

    }
}
