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
    public partial class Form3 : Form
    {
        int rem;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string con = "Server=localhost;DataBase=demo;user id=sa;password=123456789;";//数据库的信息
            SqlConnection mycon = new SqlConnection(con);//连接数据库
            mycon.Open();//打开数据库

            //删除数据
            string sel;
            //GeneralMethod.IsNumberic()这个函数判断字符串是否为数字
            if (rem == 0 && GeneralMethod.IsNumberic(textBox1.Text))//rem=0表示选择按订单号删除
            {
                sel="delete from lianxi where 订单号 ="+textBox1.Text;
                SqlCommand com = new SqlCommand(sel, mycon);//将执行代码放入命令中
                com.ExecuteReader();//执行
            }
            if (rem == 1)// rem = 1表示选择按客户名删除
            {
                string a= textBox1.Text;
                string b = @"‘a’";
                sel = "delete from lianxi where 客户 =" + "\'"+textBox1.Text + "\'";
                SqlCommand com = new SqlCommand(sel, mycon);//将执行代码放入命令中
                com.ExecuteReader();//执行
            }
            if (rem == 2)// rem = 2表示选择按商品删除
            {
                sel = "delete from lianxi where 商品 =" + "\'" + textBox1.Text + "\'";
                SqlCommand com = new SqlCommand(sel, mycon);//将执行代码放入命令中
                com.ExecuteReader();//执行
            }
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = (string)comboBox1.SelectedItem;//选定程序运行时复选框中的选项
            rem = comboBox1.FindStringExact(a);//索引选项顺序号，如+为0，/为3
            switch (rem)
            {
                case 0:
                    label2.Text = "请输入要删除的订单号：";
                    break;
                case 1:
                    label2.Text = "请输入要删除的客户名：";
                    break;
                case 2:
                    label2.Text = "请输入要删除的商品名：";
                    break;
                default:
                    break;
            }
            textBox1.Visible = true;
            label2.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
