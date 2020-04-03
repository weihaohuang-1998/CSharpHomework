using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Graphics graphics;
        int n=10;
        double leng = 100;
        double per1 = 0.6;
        double per2 = 0.7;
        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        Pen color=Pens.Black;

        /*将课本中例5-31的Cayley树绘图代码进行修改。添加一组控件用以调节树的绘制参数。
         * 参数包括递归深度（n）、主干长度（leng）、右分支长度比（per1）、左分支长度比（per2）、
         * 右分支角度（th1）、左分支角度（th2）、画笔颜色（pen）。
        */
        private void draw_Click(object sender, EventArgs e)
        {
            if(graphics==null)
            {
                graphics = this.CreateGraphics();
            }
            graphics.Clear(BackColor);//每次绘图前先清理界面
            drawCayleTree(n, 200, 310, leng, -Math.PI / 2);
        }

        void drawCayleTree(int n, double x0, double y0, double leng, double th)
        {
            if(n==0)
            {
                return;
            }

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drwaLine(x0, y0, x1, y1);

            drawCayleTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleTree(n - 1, x1, y1, per2 * leng, th - th2);
        }

        void drwaLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(
                color,
                (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void depthTrackBar_Scroll(object sender, EventArgs e)
        {
            n = depthTrackBar.Value;
        }

        private void lengTrackBar_Scroll(object sender, EventArgs e)
        {
            leng = lengTrackBar.Value;
        }

        private void per1TrackBar_Scroll(object sender, EventArgs e)
        {
            per1 = per1TrackBar.Value * 0.01;
        }

        private void per2TrackBar_Scroll(object sender, EventArgs e)
        {
            per2 = per2TrackBar.Value * 0.01;
        }

        private void th1TrackBar_Scroll(object sender, EventArgs e)
        {
            th1 = th1TrackBar.Value;
        }

        private void th2TrackBar_Scroll(object sender, EventArgs e)
        {
            th2 = th2TrackBar.Value;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            color = Pens.Red;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            color = Pens.Green;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            color = Pens.Blue;
        }
    }
}
