using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsApp1
{
    static class UploadFileController
    {
        /// <summary>
        /// 本地文件保存路径
        /// </summary>
        public static string rootPath = @"E:\S1\项目\winfrom\项目文件\ThisLocality";

        static string strconn = "Data Source=.;Initial Catalog=DingDing;Integrated Security=True";

        /// <summary>
        /// 上传头像
        /// </summary>
        public static void UploadHeadPortrait(string Yh_ld) {
            SqlConnection connection = new SqlConnection(strconn);
            try
            {
                OpenFileDialog of = new OpenFileDialog();
                //多选文件
                of.Multiselect = false;
                of.Title = "请选择图片文件";
                //文件属性
                of.Filter = "所有文件(*.*)|*.*";

                //图片路径
                string picturePath = null;
                //确定用户选择的是确认按钮
                if (of.ShowDialog() == DialogResult.OK)
                {
                    //图片路径
                    picturePath = of.FileNames[0].Trim();
//添加 这里还要把路径存到数据库
//优化 子查询
                    //生成文件名
                    string fileName = picturePath.Substring(picturePath.LastIndexOf(@"\"),picturePath.Length - picturePath.LastIndexOf(@"\"));
                    //生成文件存放父目录
                    string Path =  @"\user\" + Yh_ld + @"\HeadPortrait";
                    //生成文件目录
                    string filePath = Path + fileName;

                    //新建文件存放文件夹
                    System.IO.Directory.CreateDirectory(rootPath + Path);

                    //上传头像
                    File.Copy(picturePath, rootPath + filePath);

                    StringBuilder updateTouXiang = new StringBuilder();
                    updateTouXiang.AppendFormat("update Yh set Yh_Tx = '{0}' ", filePath);
                    updateTouXiang.AppendFormat("where Yh_Id = '{0}'", Yh_ld);
                    connection.Open();

                    SqlCommand sqlCommand = new SqlCommand(updateTouXiang.ToString(),connection);
                    int jg = sqlCommand.ExecuteNonQuery();
                    if (jg > 0)
                    {
                        MessageBox.Show("修改成功");
                    }
                    else
                    {
                        MessageBox.Show("修改失败");
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
