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

namespace WindowsFormsApp1
{
    public partial class XuiGaiYhMiMa : Form
    {
        public XuiGaiYhMiMa()
        {
            InitializeComponent();
        }

        static string strcon = "Data Source=.;Initial Catalog=DingDing;Integrated Security=True";
        DataSet dataSet = new DataSet();
        SqlDataAdapter adapter = new SqlDataAdapter();

        public string Yh_ld = "";

        private void ButFaXiaoXi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            TiJiao();
        }

        #region 提交
        private void TiJiao() {
            SqlConnection sqlConnection = new SqlConnection(strcon);
            try
            {
                StringBuilder selectYhMM = new StringBuilder();
                selectYhMM.AppendFormat("select * ");
                selectYhMM.AppendFormat("from Yh ");
                selectYhMM.AppendFormat("where Yh_Id = '{0}'",Yh_ld);
                adapter = new SqlDataAdapter(selectYhMM.ToString(), sqlConnection);
                if (dataSet.Tables["yhMM"] != null)
                {
                    dataSet.Tables["yhMM"].Rows.Clear();
                }
                adapter.Fill(dataSet,"yhMM");
                if (this.Text_Ymima.Text != dataSet.Tables["yhMM"].Rows[0][2].ToString())
                {
                    MessageBox.Show("原密码有误");
                }
                else if (this.Text_Xmima.Text.ToString().Length < 6 )
                {
                    MessageBox.Show("新密码有误");
                }
                else if (this.Text_Xmima.Text.ToString().Equals(this.Text_Xmima2.Text.ToString()))
                {
                    StringBuilder updateYhMM = new StringBuilder();
                    updateYhMM.AppendFormat("update Yh set Yh_Mm = {0} ", this.Text_Xmima.Text.ToString());
                    updateYhMM.AppendFormat("where Yh_Id = '{0}'",Yh_ld);
                    adapter = new SqlDataAdapter(updateYhMM.ToString(), sqlConnection);
                    if (dataSet.Tables["yhMM1"] != null)
                    {
                        dataSet.Tables["yhMM1"].Rows.Clear();
                    }
                    adapter.Fill(dataSet, "yhMM1");
                    MessageBox.Show("修改成功");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("两次输入的新密码有不同字符");
                }
            }
            catch (Exception)
            {

                throw;
            }
            
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
