using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 吃热狗_最终版本
{
    public partial class Form1 : Form
    {
        public int baseborder = 813;//边界
        public int score;//玩家分数
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyDown += new KeyEventHandler(PlayerMove);
            timer1.Start();
        }

        

        void PlayerMove(object sender, KeyEventArgs e)//键盘左右操控校长
        {
            switch (e.KeyCode.ToString())
            {
                case "Left": pictureBox1.Location = new Point(pictureBox1.Location.X - 30, pictureBox1.Location.Y);
                    break;
                case "Right": pictureBox1.Location = new Point(pictureBox1.Location.X + 30, pictureBox1.Location.Y);
                    break;
                default:
                    break;
            }
            if (pictureBox1.Left <= 0)               //保证校长不越界
            {
                pictureBox1.Location = new Point(0, pictureBox1.Location.Y);
            }
            if (pictureBox1.Right >= 700)
            {
                pictureBox1.Location = new Point(614, pictureBox1.Location.Y);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            HotdogMove();
            MyScore();
        }
        void MyScore()//显示得分
        {
            this.Text = "当前分数：" + score.ToString();
        }
        void HotdogMove()//撒热狗
        {
            Random ran = new Random();        //产生随机数 使得热狗随机撒下
            int ranx2 = ran.Next(1, 659);
            int ranx3 = ran.Next(1, 659);
            int ranx4 = ran.Next(1, 659);
            int ranx5 = ran.Next(1, 659);
            int ranx6 = ran.Next(1, 659);
            int ranx7 = ran.Next(1, 659);
            pictureBox2.Top += 10;
            pictureBox3.Top += 10;
            pictureBox4.Top += 10;
            pictureBox5.Top += 10;
            pictureBox6.Top += 10;
            pictureBox7.Top += 10;
            if ((pictureBox1.Top >= pictureBox2.Top - pictureBox1.Height &&
                pictureBox1.Top <= pictureBox2.Top + pictureBox2.Height &&
                pictureBox1.Left >= pictureBox2.Left - pictureBox1.Width &&
                pictureBox1.Left <= pictureBox2.Left + pictureBox2.Width)     //校长“吃到热狗”
                || pictureBox2.Top >= baseborder)                             //没吃到热狗，热狗掉出边界
            {
                if (pictureBox1.Top >= pictureBox2.Top - pictureBox1.Height &&
                    pictureBox1.Top <= pictureBox2.Top + pictureBox2.Height &&
                    pictureBox1.Left >= pictureBox2.Left - pictureBox1.Width &&
                    pictureBox1.Left <= pictureBox2.Left + pictureBox2.Width)
                {
                    score += 1;                                                    //吃到热狗，分数加1
                }
                pictureBox2.Top = 0 - pictureBox2.Height;                    //重新“生产”热狗
                pictureBox2.Location = new Point(ranx2, pictureBox2.Location.Y);   //水平位置随机
            }

            if ((pictureBox1.Top >= pictureBox3.Top - pictureBox1.Height &&
                pictureBox1.Top <= pictureBox3.Top + pictureBox3.Height &&
                pictureBox1.Left >= pictureBox3.Left - pictureBox1.Width &&
                pictureBox1.Left <= pictureBox3.Left + pictureBox3.Width)
                || pictureBox3.Top >= baseborder)
            {
                if (pictureBox1.Top >= pictureBox3.Top - pictureBox1.Height &&
                    pictureBox1.Top <= pictureBox3.Top + pictureBox3.Height &&
                    pictureBox1.Left >= pictureBox3.Left - pictureBox1.Width &&
                    pictureBox1.Left <= pictureBox3.Left + pictureBox3.Width)
                {
                    score += 1;
                }
                pictureBox3.Top = 0 - pictureBox3.Height;
                pictureBox3.Location = new Point(ranx3, pictureBox3.Location.Y);
            }

            if ((pictureBox1.Top >= pictureBox4.Top - pictureBox1.Height &&
                pictureBox1.Top <= pictureBox4.Top + pictureBox4.Height &&
                pictureBox1.Left >= pictureBox4.Left - pictureBox1.Width &&
                pictureBox1.Left <= pictureBox4.Left + pictureBox4.Width)
                || pictureBox4.Top >= baseborder)
            {
                if (pictureBox1.Top >= pictureBox4.Top - pictureBox1.Height &&
                    pictureBox1.Top <= pictureBox4.Top + pictureBox4.Height &&
                    pictureBox1.Left >= pictureBox4.Left - pictureBox1.Width &&
                    pictureBox1.Left <= pictureBox4.Left + pictureBox4.Width)
                {
                    score += 1;
                }
                pictureBox4.Top = 0 - pictureBox4.Height;
                pictureBox4.Location = new Point(ranx4, pictureBox4.Location.Y);
            }

            if ((pictureBox1.Top >= pictureBox5.Top - pictureBox1.Height &&
                pictureBox1.Top <= pictureBox5.Top + pictureBox5.Height &&
                pictureBox1.Left >= pictureBox5.Left - pictureBox1.Width &&
                pictureBox1.Left <= pictureBox5.Left + pictureBox5.Width)
                || pictureBox5.Top >= baseborder)
            {
                if (pictureBox1.Top >= pictureBox5.Top - pictureBox1.Height &&
                    pictureBox1.Top <= pictureBox5.Top + pictureBox5.Height &&
                    pictureBox1.Left >= pictureBox5.Left - pictureBox1.Width &&
                    pictureBox1.Left <= pictureBox5.Left + pictureBox5.Width)
                {
                    score += 1;
                }
                pictureBox5.Top = 0 - pictureBox5.Height;
                pictureBox5.Location = new Point(ranx5, pictureBox5.Location.Y);
            }

            if ((pictureBox1.Top >= pictureBox6.Top - pictureBox1.Height &&
                pictureBox1.Top <= pictureBox6.Top + pictureBox6.Height &&
                pictureBox1.Left >= pictureBox6.Left - pictureBox1.Width &&
                pictureBox1.Left <= pictureBox6.Left + pictureBox6.Width)
                || pictureBox6.Top >= baseborder)
            {
                if (pictureBox1.Top >= pictureBox6.Top - pictureBox1.Height &&
                    pictureBox1.Top <= pictureBox6.Top + pictureBox6.Height &&
                    pictureBox1.Left >= pictureBox6.Left - pictureBox1.Width &&
                    pictureBox1.Left <= pictureBox6.Left + pictureBox6.Width)
                {
                    score += 1;
                }
                pictureBox6.Top = 0 - pictureBox6.Height;
                pictureBox6.Location = new Point(ranx6, pictureBox6.Location.Y);
            }

            if ((pictureBox1.Top >= pictureBox7.Top - pictureBox1.Height &&
                pictureBox1.Top <= pictureBox7.Top + pictureBox7.Height &&
                pictureBox1.Left >= pictureBox7.Left - pictureBox1.Width &&
                pictureBox1.Left <= pictureBox7.Left + pictureBox7.Width)
                || pictureBox7.Top >= baseborder)
            {
                if (pictureBox1.Top >= pictureBox7.Top - pictureBox1.Height &&
                    pictureBox1.Top <= pictureBox7.Top + pictureBox7.Height &&
                    pictureBox1.Left >= pictureBox7.Left - pictureBox1.Width &&
                    pictureBox1.Left <= pictureBox7.Left + pictureBox7.Width)
                {
                    score += 1;
                }
                pictureBox7.Top = 0 - pictureBox7.Height;
                pictureBox7.Location = new Point(ranx7, pictureBox7.Location.Y);
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("最终得分：" + score.ToString());
        }

        
    }
}
