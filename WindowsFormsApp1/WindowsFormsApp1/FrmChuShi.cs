using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmChuShi : UserControl
    {
        public FrmChuShi()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void skinButton1_MouseEnter(object sender, EventArgs e)
        {
            this.skinButton1.BackgroundImage = Image.FromFile("E:\\项目\\winfrom\\项目文件\\图标\\16x\\加号 (1).png");// 通过绝对路径;
        }

        private void skinButton1_MouseLeave(object sender, EventArgs e)
        {
            this.skinButton1.BackgroundImage = Image.FromFile("E:\\项目\\winfrom\\项目文件\\图标\\16x\\加号.png");// 通过绝对路径;
        }
    }
}
