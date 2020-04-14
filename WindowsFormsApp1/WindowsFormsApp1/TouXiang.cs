using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformBubble
{
    public partial class TouXiang : UserControl
    {
        /// <summary>
        /// 本窗体总高度
        /// </summary>
        public int HEIGHT = 40;
        /// <summary>
        /// 本窗体总宽度
        /// </summary>
        public int WIDTH = 45;
        /// <summary>
        /// 消息类型
        /// </summary>
        public MessageType messageType;


        public TouXiang()
        {
            ///设置控件样式
            SetStyle(
                    ControlStyles.AllPaintingInWmPaint | //不闪烁
                    ControlStyles.OptimizedDoubleBuffer //支持双缓存
                    , true);
            InitializeComponent();
            this.Paint += Item_Paint;
        }

        #region 界面重绘

        /// <summary>
        /// 绘制气泡左上角小箭头
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Item_Paint(object sender, PaintEventArgs e)
        {
            //自己发送的消息箭头在右上角
            if (messageType == MessageType.send)
            {

               /* Color color = System.Drawing.Color.LightGray;
                skinPanel1.BackColor = color;
                Brush brushes = new SolidBrush(color);
                Point[] point = new Point[3];
                point[0] = new Point(WIDTH - 5, 10);
                point[1] = new Point(WIDTH - 15, 10);
                point[2] = new Point(WIDTH - 15, 20);
                e.Graphics.FillPolygon(brushes, point);*/
            }
            else
            {

                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TouXiang));

                this.skinPictureBox1.Image = Image.FromFile("E:\\01百度云下载\\高清壁纸\\炮姐\\Misaka_Mikoto_Toaru_Kagaku_no_Railgun_Uiharu_Kazari_Misaka_Imouto_anime_Shirai_Kuroko_Saten_Ruiko_Toaru_Majutsu_no_Index_1920x1080.jpg");// 通过绝对路径;;
                /*this.skinPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                this.skinPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                Color color = System.Drawing.Color.LightGray;
                Brush brushes = new SolidBrush(color);
                Point[] point = new Point[3];
                point[0] = new Point(10, 10);
                point[1] = new Point(20, 10);
                point[2] = new Point(20, 20);
                e.Graphics.FillPolygon(brushes, point);*/
            }
        }
        #endregion

        /// <summary>
        /// 消息类型
        /// </summary>
        public enum MessageType
        {
            send,
            receive
        }

    }
}
