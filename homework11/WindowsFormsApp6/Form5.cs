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

namespace WindowsFormsApp6
{
    public partial class Form5 : Form
    {
        int rem;
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = (string)comboBox1.SelectedItem;//选定程序运行时复选框中的选项
            rem = comboBox1.FindStringExact(a);//索引选项顺序号，如+为0，/为3
            switch (rem)
            {
                case 0:
                    label2.Text = "请输入要修改的订单号：";
                    break;
                case 1:
                    label2.Text = "请输入要修改的客户名：";
                    break;
                case 2:
                    label2.Text = "请输入要修改的商品名：";
                    break;
                default:
                    break;
            }
            textBox1.Visible = true;
            label2.Visible = true;
            textBox2.Visible = true;
            label3.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string con = "Server=localhost;DataBase=demo;user id=sa;password=123456789;";//数据库的信息
            SqlConnection mycon = new SqlConnection(con);//连接数据库
            mycon.Open();//打开数据库

            string sel;
            //按订单号修改
            if (rem == 0 && GeneralMethod.IsNumberic(textBox1.Text)&& GeneralMethod.IsNumberic(textBox2.Text))
            {//rem=0表示按订单号修改，GeneralMethod.IsNumberic(string)函数用来判断字符串是否为数字
                sel = "update lianxi set 订单号 ="+ textBox2.Text+"where 订单号 ="+ textBox1.Text;//修改项目的代码
                SqlCommand com = new SqlCommand(sel, mycon);//将执行代码放入命令中
                com.ExecuteReader();//执行
            }

            //按客户修改
            if (rem == 1)//rem=1表示按客户修改
            {
                sel = "update lianxi set 客户 =" +
                    "\'"+ textBox2.Text+"\'"+ "where 客户 =" +"\'"+ textBox1.Text + "\'";//修改项目的代码
                SqlCommand com = new SqlCommand(sel, mycon);//将执行代码放入命令中
                com.ExecuteReader();//执行
            }

            //按商品修改
            if (rem == 2)//rem=2表示按商品修改
            {
                sel = "update lianxi set 商品 =" +
                    "\'" + textBox2.Text + "\'" + "where 商品 =" + "\'" + textBox1.Text + "\'";//修改项目的代码
                SqlCommand com = new SqlCommand(sel, mycon);//将执行代码放入命令中
                com.ExecuteReader();//执行
            }
            Close();
        }
    }
}
