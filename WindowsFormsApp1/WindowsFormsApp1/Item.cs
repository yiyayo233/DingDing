﻿using System;
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
    public partial class Item : UserControl
    {
        /// <summary>
        /// 本窗体总高度
        /// </summary>
        public int HEIGHT = 50;
        /// <summary>
        /// 本窗体总宽度
        /// </summary>
        public int WIDTH = 45;

        /// <summary>
        /// 头像距离总高度
        /// </summary>
        public int HEIGHTtx = 40;
        /// <summary>
        /// 头像距离总宽度
        /// </summary>
        public int WIDTHtx = 45;

        /// <summary>
        /// 消息类型
        /// </summary>
        public MessageType messageType;

        /// <summary>
        /// 对话人昵称
        /// </summary>
        public string Text_duiHuaRenName = "";


        public Item()
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

                /*Color color = System.Drawing.Color.LightGray;
                skinPanel1.BackColor = color;
                Brush brushes = new SolidBrush(color);
                Point[] point = new Point[3];
                point[0] = new Point(WIDTH - 5, 10);
                point[1] = new Point(WIDTH - 15, 10);
                point[2] = new Point(WIDTH - 15, 20);
                e.Graphics.FillPolygon(brushes, point);*/
                this.touXiangZJ.Visible = true;
            }
            else
            {
                this.skinPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                this.skinPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                this.touXiangBG.Visible = true;
                if (Text_duiHuaRenName == "TFDNDSFJIF")
                {
                    this.touXiangBG.Top = 21;
                }
                else
                {
                    this.DuiHuaRenName.Text = Text_duiHuaRenName;
                    this.DuiHuaRenName.Visible = true;
                }
                
                /*Color color = System.Drawing.Color.LightGray;
                Brush brushes = new SolidBrush(color);
                Point[] point = new Point[3];
                point[0] = new Point(10, 10);
                point[1] = new Point(20, 10);
                point[2] = new Point(20, 20);
                e.Graphics.FillPolygon(brushes, point);*/
            }
        }
        #endregion

        #region 功能操作

        /// <summary>
        /// 设置气泡内容
        /// </summary>
        /// <param name="type">消息类型</param>
        /// <param name="content">消息内容</param>
        public void SetWeChatContent(string content)
        {

            lblContent.Text = content;
            lblContent.Visible = true;
            HEIGHT += lblContent.Height;
            WIDTH += lblContent.Width;

            HEIGHTtx += lblContent.Height;
            WIDTHtx += lblContent.Width;
            touXiangZJ.Left = WIDTHtx + 40;
        }

        #endregion

        /// <summary>
        /// 内部类
        /// </summary>

        class MessageItem
        {
            public string RESPATH { get; set; }
            public string RESTYPE { get; set; }
        }
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