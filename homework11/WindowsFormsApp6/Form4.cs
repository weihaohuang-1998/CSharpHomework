using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form4 : Form
    {
        int rem;
        Order item = null;
        public Form4()
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
            rem= comboBox1.FindStringExact(a);//索引选项顺序号，如+为0，/为3
            switch (rem)
            {
                case 0:
                    label2.Text = "请输入要查询的订单号：";
                    break;
                case 1:
                    label2.Text = "请输入要查询的客户名：";
                    break;
                case 2:
                    label2.Text = "请输入要查询的商品名：";
                    break;
                default:
                    break;
            }
            textBox1.Visible = true;
            label2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
                for (int i = 0; i < Program.form1.students.ToArray().Length; i++)
                {
                    if (rem == 0 && GeneralMethod.IsNumberic(textBox1.Text) &&
                       Program.form1.students[i].OrderNumber == int.Parse(textBox1.Text))
                    {
                        item = Program.form1.students[i];
                    }
                    if (rem == 1 && Program.form1.students[i].ClientName == textBox1.Text)
                    {
                        item = Program.form1.students[i];
                    }
                    if (rem == 2 && Program.form1.students[i].GoodsName == textBox1.Text)
                    {
                         item = Program.form1.students[i];
                    }
                }
            orderitem.DataSource = null;
            orderitem.DataSource = item;
            dataGridView2.Visible = true;
            
           
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
