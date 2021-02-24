﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIT
{
    public partial class Msg : Form
    {
        public enum MsgType
        {
           Timeout,
           CorrectAnswer,
           IncorrectAnswer,
           Popup
        }

        public Msg()
        {
            InitializeComponent();
        }

        public Msg(MsgType msgType)
        {
            InitializeComponent();
            switch (msgType)
            {
                case MsgType.CorrectAnswer:
                    picThumbnail.BackgroundImage = Properties.Resources.true_answer;
                    lbTitle.Text = "Thông báo";
                    lbDescription.Text = "Xin chúc mừng! Bạn đã chọn đáp án đúng!";
                    btnCenter.Text = "OK";
                    btnRight.Hide();
                    btnLeft.Hide();
                    break;
                case MsgType.IncorrectAnswer:
                    picThumbnail.BackgroundImage = Properties.Resources.false_answer;
                    lbTitle.Text = "Thông báo";
                    lbDescription.Text = "Rất tiếc! Bạn đã chọn đáp án sai!";
                    btnCenter.Text = "OK";
                    btnRight.Hide();
                    btnLeft.Hide();
                    break;
                case MsgType.Timeout:
                    break;
                case MsgType.Popup:
                    break;
            }    
        }

        public static void ShowMsg(MsgType msgType)
        {
            Msg msg = new Msg(msgType);
            msg.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
