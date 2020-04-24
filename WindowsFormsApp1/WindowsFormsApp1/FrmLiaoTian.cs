using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformBubble;
using System.Data.SqlClient;
using System.Reflection;

namespace WindowsFormsApp1
{
    public partial class FrmLiaoTian : UserControl
    {
        public FrmLiaoTian()
        {
            InitializeComponent();
        }
        static string strcon = "Data Source=.;Initial Catalog=DingDing;Integrated Security=True";
        DataSet dataSet = new DataSet();
        SqlDataAdapter adapter = new SqlDataAdapter();

        public string sxld = "";
        public string fsld = "";
        string nr = "";

        public int pd = 0;

        public int i = 1;

        /// <summary>
        /// 当前消息气泡起始位置
        /// </summary>
        private int top = 0;

        /// <summary>
        /// 当前消息气泡高度
        /// </summary>
        private int height = 0;

        

        #region 加载页面事件
        private void FrmLiaoTian_Load(object sender, EventArgs e)
        {
            ShuaXin();
            ChuShiHua();
            
        }
        #endregion

        #region 发送
        private void butFaSong_Click(object sender, EventArgs e)
        {
            nr = textBox1.Text;
            if (CheckKong())
            {
                AddSendMessage(nr,1);  //自己的
                //AddReceiveMessage(nr,1);   //收消息的
                TextBox1TextDelete();
         
            }
            
        }
        #endregion

        #region 显示接收消息、收消息的
        /// <summary>
        /// 显示接收消息、收消息的
        /// </summary>
        /// <param name="model"></param>
        private void AddReceiveMessage(string content, int pd,string duiHuaRenName)
        {
            Item item = new Item();
            item.messageType = WinformBubble.Item.MessageType.receive;
            item.SetWeChatContent(content);
            item.Text_duiHuaRenName = duiHuaRenName;

            TouXiang touXiang = new TouXiang();
            touXiang.messageType = WinformBubble.TouXiang.MessageType.receive;


            //计算高度
            item.Top = top + height;
            top = item.Top;
            height = item.HEIGHT;

            //滚动条移动最上方，重新计算气泡在panel的位置
            panel1.AutoScrollPosition = new Point(0, 0);
            panel1.Controls.Add(item);


        }
        #endregion

        #region 更新界面，显示发送消息、自己的、添加
        /// <summary>
        /// 更新界面，显示发送消息、自己的、添加
        /// </summary>
        private void AddSendMessage(string content,int pd)
        {
            SqlConnection sqlConnection = new SqlConnection(strcon);
            try
            {
                if (i == 1)
                {
                    if (pd == 1)
                    {
                        StringBuilder insert = new StringBuilder();
                        insert.AppendFormat("insert Xx ");
                        insert.AppendFormat("values('{0}','{1}','{2}','{3}')", sxld, content, JieQvRiQi(), fsld);
                        sqlConnection.Open();
                        SqlCommand sqlCommand = new SqlCommand(insert.ToString(), sqlConnection);
                        sqlCommand.ExecuteNonQuery();
                        sqlConnection.Close();
                        ShuaXin();
                    }
                }
                else
                {
                    if (pd == 1)
                    {
                        StringBuilder insert = new StringBuilder();
                        insert.AppendFormat("insert XxQ ");
                        insert.AppendFormat("values('{0}','{1}','{2}','{3}')", sxld, content, JieQvRiQi(), fsld);
                        sqlConnection.Open();
                        SqlCommand sqlCommand = new SqlCommand(insert.ToString(), sqlConnection);
                        sqlCommand.ExecuteNonQuery();
                        sqlConnection.Close();
                        ShuaXin();
                    }
                    
                }
                

                Item item = new Item();
                item.messageType = WinformBubble.Item.MessageType.send;
                item.SetWeChatContent(content);
                item.Top = top + height;
                if (pd == 2)
                {
                    item.Left = 971 - item.WIDTH - 350;
                }
                else
                {
                    item.Left = this.panel1.Width - item.WIDTH - 230;
                }

                top = item.Top;
                height = item.HEIGHT;
                panel1.AutoScrollPosition = new Point(0, 0);
                panel1.Controls.Add(item);
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

        #region 清空
        /// <summary>
        /// 清空
        /// </summary>
        private void TextBox1TextDelete()
        {
            textBox1.Text = "";
        }
        #endregion

        #region 非空验证
        public bool CheckKong() {
            if (this.textBox1.Text.Equals(string.Empty))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

        #region 截取日期&时间
        public string JieQvRiQi()
        {
            string dateTime = DateTime.Now.ToString();
            return dateTime;
        }


        #endregion

        #region 查找数据
        public void CheckXinXi()
        {
            SqlConnection sqlConnection = new SqlConnection(strcon);
            try
            {

                StringBuilder selectXinXi = new StringBuilder();
                if (i == 1)
                {
                    selectXinXi.AppendFormat("select *");
                    selectXinXi.AppendFormat("from Xx ");
                    selectXinXi.AppendFormat("where Xx_Sxld = '{0}' ", sxld);
                    selectXinXi.AppendFormat("and Xx_Fsld  = '{0}'", fsld);
                    selectXinXi.AppendFormat("or Xx_Sxld = '{0}'", fsld);
                    selectXinXi.AppendFormat("and Xx_Fsld  ='{0}'", sxld);
                    selectXinXi.AppendFormat("order by Xx_fssj");

                    adapter = new SqlDataAdapter(selectXinXi.ToString(), sqlConnection);

                    if (dataSet.Tables["XxY"] != null)
                    {
                        dataSet.Tables["XxY"].Clear();
                    }

                    adapter.Fill(dataSet, "XxY");

                    for (int i = 0; i < dataSet.Tables["XxY"].Rows.Count; i++)
                    {
                        if (dataSet.Tables["XxY"].Rows[i][4].ToString().Equals(fsld))
                        {
                            AddSendMessage(dataSet.Tables["XxY"].Rows[i][2].ToString(), 2);
                        }
                        if (dataSet.Tables["XxY"].Rows[i][4].ToString() != fsld)
                        {
                            AddReceiveMessage(dataSet.Tables["XxY"].Rows[i][2].ToString(), 2,"TFDNDSFJIF");
                        }
                    }

                }
                else
                {
                    selectXinXi.AppendFormat("select *");
                    selectXinXi.AppendFormat("from XxQ ");
                    selectXinXi.AppendFormat("where XxQ_Sxld = '{0}' ", sxld);
                    selectXinXi.AppendFormat("order by XxQ_fssj");

                    adapter = new SqlDataAdapter(selectXinXi.ToString(), sqlConnection);

                    if (dataSet.Tables["XxQ"] != null)
                    {
                        dataSet.Tables["XxQ"].Clear();
                    }

                    adapter.Fill(dataSet, "XxQ");

                    for (int i = 0; i < dataSet.Tables["XxQ"].Rows.Count; i++)
                    {
                        if (dataSet.Tables["XxQ"].Rows[i][4].ToString().Equals(fsld))
                        {
                            AddSendMessage(dataSet.Tables["XxQ"].Rows[i][2].ToString(), 2);
                        }
                        if (dataSet.Tables["XxQ"].Rows[i][4].ToString() != fsld)
                        {
                            StringBuilder selectYh = new StringBuilder();
                            selectYh.AppendFormat("select * ");
                            selectYh.AppendFormat("from Yh ");
                            selectYh.AppendFormat("where Yh_Id = '{0}'",dataSet.Tables["XxQ"].Rows[i][4].ToString());
                            adapter = new SqlDataAdapter(selectYh.ToString(), sqlConnection);
                            if (dataSet.Tables["FxYh"] != null)
                            {
                                dataSet.Tables["FxYh"].Clear();
                            }

                            adapter.Fill(dataSet, "FxYh");

                            AddReceiveMessage(dataSet.Tables["XxQ"].Rows[i][2].ToString(), 2, dataSet.Tables["FxYh"].Rows[0][1].ToString());
                        }
                    }
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

        #region 查找发送人详细
        public void CheckFSXiangXi()
        {
            SqlConnection sqlConnection = new SqlConnection(strcon);
            try
            {
                string checkFS = @"select *
                                from Yh
                                where Yh_Id = '" + fsld + "'";
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(checkFS, sqlConnection);
                SqlDataReader sr = sqlCommand.ExecuteReader();
                while (sr.Read())
                {
                    string tx = sr["Yh_Tx"].ToString();
                }


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        #endregion

        #region 查找收信人详细
        public void CheckSXXiangXi(int i)
        {
            SqlConnection sqlConnection = new SqlConnection(strcon);
            try
            {
                
                StringBuilder CheckSX = new StringBuilder();
                if (i == 1)
                {
                    CheckSX.AppendFormat("select * ");
                    CheckSX.AppendFormat("from Yh ");
                    CheckSX.AppendFormat("where Yh_Id = '{0}'", sxld);
                    adapter = new SqlDataAdapter(CheckSX.ToString(), sqlConnection);

                    if (dataSet.Tables["checkSXY"] != null)
                    {
                        dataSet.Tables["checkSXY"].Rows.Clear();
                    }

                    adapter.Fill(dataSet, "checkSXY");
                    string name = dataSet.Tables["checkSXY"].Rows[0][1].ToString();
                    this.ShuoXinRenName.Text = dataSet.Tables["checkSXY"].Rows[0][1].ToString();
                    this.GongSiName.Text = dataSet.Tables["checkSXY"].Rows[0][1].ToString();
                }
                else
                {
                    CheckSX.AppendFormat("select * ");
                    CheckSX.AppendFormat("from Qun ");
                    CheckSX.AppendFormat("where Qun_ld = '{0}'",sxld);
                    adapter = new SqlDataAdapter(CheckSX.ToString(), sqlConnection);

                    if (dataSet.Tables["checkSXQ"] != null)
                    {
                        dataSet.Tables["checkSXQ"].Rows.Clear();
                    }

                    adapter.Fill(dataSet, "checkSXQ");
                    string name = dataSet.Tables["checkSXQ"].Rows[0][1].ToString();
                    this.ShuoXinRenName.Text = dataSet.Tables["checkSXQ"].Rows[0][1].ToString();
                    this.GongSiName.Text = dataSet.Tables["checkSXQ"].Rows[0][1].ToString();
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

        #region 清空panel1&初始化数据
        public void Emptypanel1()
        {
            this.panel1.Controls.Clear();
            top = 0;
            height = 0;
        }
        #endregion

        #region 判断是否是收信群 废
        /*public void IfSuoXinQun()
        {
            SqlConnection sqlConnection = new SqlConnection(strcon);
            try
            {
                StringBuilder selectYh = new StringBuilder();
                selectYh.AppendFormat("select COUNT(*) ");
                selectYh.AppendFormat("from Yh ");
                selectYh.AppendFormat("where Yh_Id = '{0}'", sxld);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(selectYh.ToString(), sqlConnection);
                string pd = sqlCommand.ExecuteScalar().ToString();
                if (pd.Equals("0"))
                {
                    i = 2;
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                sqlConnection.Close();
            }
        }*/
        #endregion

        #region 初始化
        public void ChuShiHua()
        {
            //IfSuoXinQun();
            CheckSXXiangXi(i);
            CheckFSXiangXi();
            CheckXinXi();

            timer1.Enabled = true;
        }
        #endregion

        #region 刷新会话列表
        public void ShuaXin() {
            Control control = this.Parent.Parent.Parent;
            string s = control.Name;
            Type pageType = control.GetType();
            //父页面的方法名
            MethodInfo mi = pageType.GetMethod("ChuShiHua");
            mi.Invoke(control, null);

        }
        #endregion

        #region 刷新聊天消息
        private void timer1_Tick(object sender, EventArgs e)
        {
            Emptypanel1();
            ShuaXin();
            ChuShiHua();
        }
        #endregion

    }
}
