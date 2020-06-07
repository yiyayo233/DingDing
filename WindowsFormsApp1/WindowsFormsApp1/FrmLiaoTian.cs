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
using CCWin.SkinClass;

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

        /// <summary>
        /// 收信人ld
        /// </summary>
        public string sxld = "";

        /// <summary>
        /// 收信人头像
        /// </summary>
        public string sxTx = "";

        /// <summary>
        /// 发送人ld
        /// </summary>
        public string fsld = "";

        /// <summary>
        /// 发送人头像
        /// </summary>
        public string fsTx = "";

        /// <summary>
        /// 发送内容
        /// </summary>
        string nr = "";

        /// <summary>
        /// 判断是否是点击发送
        /// </summary>
        public int pd = 0;
        /// <summary>
        /// 判断是否是群消息
        /// </summary>
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
        /// <summary>
        /// 加载页面时 刷新会话列表和显示消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLiaoTian_Load(object sender, EventArgs e)
        {
            ShuaXin();
            ChuShiHua();
            
        }
        #endregion

        #region 发送
        /// <summary>
        /// 发送消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butFaSong_Click(object sender, EventArgs e)
        {
            nr = textBox1.Text;
            if (CheckKong())
            {
                AddSendMessage(nr,1,fsTx);
                TextBox1TextDelete();
         
            }
            
        }
        #endregion

        #region 显示接收消息、收消息的
        /// <summary>
        /// 显示接收消息、收消息的
        /// </summary>
        /// <param name="content">消息内容</param>
        /// <param name="duiHuaRenName">对话人名称</param>
        /// <param name="duiHuaRenTx">对话人头像</param>
        private void AddReceiveMessage(string content, string duiHuaRenName, string duiHuaRenTx)
        {
            Item item = new Item();
            item.messageType = WinformBubble.Item.MessageType.receive;
            item.SetWeChatContent(content);
            item.Text_duiHuaRenName = duiHuaRenName;
            item.Text_duiHuaRenTx = duiHuaRenTx;

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

        #region 更新界面，显示发送消息、自己的、发送消息
        /// <summary>
        /// 更新界面，显示发送消息、自己的、发送消息
        /// </summary>
        /// <param name="content">消息内容</param>
        /// <param name="pd">判断是否是点击发送</param>
        private void AddSendMessage(string content,int pd,string faSongRenTx)
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
                item.Yh_Tx = faSongRenTx;
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

        #region 清空输入框
        /// <summary>
        /// 清空输入框
        /// </summary>
        private void TextBox1TextDelete()
        {
            textBox1.Text = "";
        }
        #endregion

        #region 非空验证  查看输入框是否为空
        /// <summary>
        /// 非空验证  查看输入框是否为空
        /// </summary>
        /// <returns></returns>
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

        #region 截取日期和时间
        /// <summary>
        /// 截取日期和时间
        /// </summary>
        /// <returns></returns>
        public string JieQvRiQi()
        {
            string dateTime = DateTime.Now.ToString();
            return dateTime;
        }


        #endregion

        #region 查找消息
        /// <summary>
        /// 你与好友之间发送的消息总数
        /// </summary>
        int indexY = 0;
        /// <summary>
        /// 群组成员(包括自己)发送的消息总数
        /// </summary>
        int indexQ = -1;
        /// <summary>
        /// 查找消息
        /// </summary>
        public void CheckXinXi()
        {
            SqlConnection sqlConnection = new SqlConnection(strcon);
            try
            {
                StringBuilder selectXinXi = new StringBuilder();
                //判断是否是群消息
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
                    indexY = dataSet.Tables["XxY"].Rows.Count.ToInt32();

                    for (int i = 0; i < dataSet.Tables["XxY"].Rows.Count; i++)
                    {
                        if (dataSet.Tables["XxY"].Rows[i][4].ToString().Equals(fsld))
                        {
                            AddSendMessage(dataSet.Tables["XxY"].Rows[i][2].ToString(), 2, fsTx);
                        }
                        if (dataSet.Tables["XxY"].Rows[i][4].ToString() != fsld)
                        {
                            AddReceiveMessage(dataSet.Tables["XxY"].Rows[i][2].ToString(), "TFDNDSFJIF", sxTx);
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
                    indexQ = dataSet.Tables["XxQ"].Rows.Count.ToInt32();

                    for (int i = 0; i < dataSet.Tables["XxQ"].Rows.Count; i++)
                    {
                        if (dataSet.Tables["XxQ"].Rows[i][4].ToString().Equals(fsld))
                        {
                            AddSendMessage(dataSet.Tables["XxQ"].Rows[i][2].ToString(), 2, fsTx);
                        }
                        else
                        {
                            StringBuilder selectYh = new StringBuilder();
                            selectYh.AppendFormat("select * ");
                            selectYh.AppendFormat("from Yh ");
                            selectYh.AppendFormat("where Yh_Id = '{0}'", dataSet.Tables["XxQ"].Rows[i][4].ToString());
                            adapter = new SqlDataAdapter(selectYh.ToString(), sqlConnection);
                            if (dataSet.Tables["FxYh"] != null)
                            {
                                dataSet.Tables["FxYh"].Clear();
                            }

                            adapter.Fill(dataSet, "FxYh");

                            AddReceiveMessage(dataSet.Tables["XxQ"].Rows[i][2].ToString(), dataSet.Tables["FxYh"].Rows[0][1].ToString(),sxTx);
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
        /// <summary>
        /// 查找发送人详细
        /// </summary>
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
                    fsTx = sr["Yh_Tx"].ToString();
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
        /// <summary>
        /// 查找收信人详细
        /// </summary>
        /// <param name="i">区分好友还是群</param>
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
                    
                    sxTx = dataSet.Tables["checkSXY"].Rows[0][4].ToString();
                    if (sxTx.Length != 0)
                    {
                        if (sxTx != "null")
                        {
                            this.ShouXinRenTx.Load(UploadFileController.rootPath + sxTx);
                        }
                        else
                        {
                            sxTx = UploadFileController.rootPath + "\\user\\mr.png";
                            this.ShouXinRenTx.Load(sxTx);
                        }
                    }
                    else
                    {
                        sxTx = UploadFileController.rootPath + "\\user\\mr.png";
                        this.ShouXinRenTx.Load(sxTx);
                    }
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
                    sxTx = dataSet.Tables["checkSXQ"].Rows[0][2].ToString();
                    if (sxTx.Length != 0)
                    {
                        if (sxTx != "null")
                        {
                            this.ShouXinRenTx.Load(UploadFileController.rootPath + sxTx);
                        }
                        else
                        {
                            sxTx = UploadFileController.rootPath + "\\user\\mr.png";
                            this.ShouXinRenTx.Load(sxTx);
                        }
                    }
                    else
                    {
                        sxTx = UploadFileController.rootPath + "\\user\\mr.png";
                        this.ShouXinRenTx.Load(sxTx);
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

        #region 清空panel1和初始化数据
        /// <summary>
        /// 清空panel1和初始化数据
        /// </summary>
        public void Emptypanel1()
        {
            this.panel1.Controls.Clear();
            top = 0;
            height = 0;
        }
        #endregion
        
        #region 初始化
        /// <summary>
        /// 初始化
        /// </summary>
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
        /// <summary>
        /// 刷新会话列表
        /// </summary>
        public void ShuaXin() {
            Control control = this.Parent.Parent.Parent;
            string s = control.Name;
            Type pageType = control.GetType();
            //父页面的方法名
            MethodInfo mi = pageType.GetMethod("ChuShiHua");
            mi.Invoke(control, null);

        }
        #endregion

        #region 实时刷新消息
        /// <summary>
        /// 刷新消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            CheckXinXi(1);
        }

        #region 刷新消息
        /// <summary>
        /// 查找消息
        /// <para>实现方法：首先在页面加载(以下都叫初始化)时，获取你与好友之间(群组成员(包括自己))发送的消息总数,再在实时刷新时获取消息总数。如果实时刷新时获取的消息总数 大于 初始化时获取的消息总数，则添加新的气泡</para>
        /// <para>注意事项：1.不管发消息的是谁都要 给 初始化时获取的消息总数 加1。</para>
        /// </summary>
        /// <param name="z">没有实际用处只是用来区分方法</param>
        public void CheckXinXi(int z)
        {
            SqlConnection sqlConnection = new SqlConnection(strcon);
            try
            {
                IfSuoXinQun();
                StringBuilder selectXinXi = new StringBuilder();
                //判断是否是群消息
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
                    //实时消息总数
                    int index = dataSet.Tables["XxY"].Rows.Count.ToInt32();
                    //实时消息总数判断加载消息总数 是否大于 判断加载消息总数
                    if (indexY < index)
                    {
                        if (!dataSet.Tables["XxY"].Rows[index - 1][4].ToString().Equals(fsld))
                        {
                            //添加新的气泡
                            AddReceiveMessage(dataSet.Tables["XxY"].Rows[index - 1][2].ToString(), "TFDNDSFJIF","null");
                        }
                        indexY++;   //加载消息总数自增
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

                    int index = dataSet.Tables["XxQ"].Rows.Count.ToInt32();
                    if (indexQ < index)
                    {
                        if (!dataSet.Tables["XxQ"].Rows[index - 1][4].ToString().Equals(fsld))
                        {
                            StringBuilder selectYh = new StringBuilder();
                            selectYh.AppendFormat("select * ");
                            selectYh.AppendFormat("from Yh ");
                            selectYh.AppendFormat("where Yh_Id = '{0}'", dataSet.Tables["XxQ"].Rows[index - 1][4].ToString());
                            adapter = new SqlDataAdapter(selectYh.ToString(), sqlConnection);
                            if (dataSet.Tables["FxYh"] != null)
                            {
                                dataSet.Tables["FxYh"].Clear();
                            }

                            adapter.Fill(dataSet, "FxYh");

                            AddReceiveMessage(dataSet.Tables["XxQ"].Rows[index - 1][2].ToString(), dataSet.Tables["FxYh"].Rows[0][1].ToString(), dataSet.Tables["FxYh"].Rows[0][4].ToString());
                        }
                        indexQ++;
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

        #region 判断是否是收信群
        /// <summary>
        /// 判断是否是收信群
        /// </summary>
        public void IfSuoXinQun()
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
        }
        #endregion

        #endregion

    }
}
