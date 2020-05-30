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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int orderNumber;
            string con = "Server=localhost;DataBase=demo;user id=sa;password=123456789;";//数据库的信息
            SqlConnection mycon = new SqlConnection(con);//连接数据库
            mycon.Open();//打开数据库

            //增加数据
            string sql = "insert into lianxi(订单号,客户,商品)"+
                         "values('{0}','{1}','{2}')";
            string sel;
            SqlCommand com;//将执行代码放入命令中
            if (GeneralMethod.IsNumberic(textBox1.Text))
            {
                orderNumber = Int32.Parse(textBox1.Text);
                sel = string.Format(sql, orderNumber, textBox2.Text, comboBox1.Text);
                com = new SqlCommand(sel, mycon);
                com.ExecuteReader();//执行

            }

            else
            {
                MessageBox.Show("请输入正确的订单号", "输入错误！！！");
            }
            Close();







        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
