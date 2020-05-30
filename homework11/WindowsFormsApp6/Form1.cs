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
    public partial class Form1 : Form
    {
       
        public List<Order> students = new List<Order>();
        public Order item = new Order(0003, "张三", "大学英语");

        
        public Form1()
        {
            InitializeComponent();
            students.Add(new Order(0001, "张三", "软件构造基础"));
            students.Add(new Order(0002, "李四", "高等数学"));
            students.Add(new Order(0003, "王五", "大学英语"));
            orderlist.DataSource = students;
            orderItem.DataSource = item;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string con, sql;
            con = "Server=localhost;DataBase=demo;user id=sa;password=123456789;";
            sql = "select * from lianxi";
            SqlConnection mycon = new SqlConnection(con);
            mycon.Open();//打开数据库
            SqlDataAdapter myda = new SqlDataAdapter(sql, con);
            DataSet myds = new DataSet();
            myda.Fill(myds, "lianxi");
            dataGridView2.DataSource = myds.Tables["lianxi"];//数据绑定
            mycon.Close();//关闭数据库
            new Form2().ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public  void addStudent(int ordernumber,string clientname,string goodsname)
        {
            students.Add(new Order(ordernumber, clientname, goodsname));
            addStudentBinding();
        }

        public void addStudentBinding()
        {
            orderlist.DataSource = null;
            orderlist.DataSource = students;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form3().ShowDialog();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string con, sql;
            con = "Server=localhost;DataBase=demo;user id=sa;password=123456789;";
            sql = "select * from lianxi";
            SqlConnection mycon = new SqlConnection(con);
            mycon.Open();//打开数据库
            SqlDataAdapter myda = new SqlDataAdapter(sql, con);
            DataSet myds = new DataSet();
            myda.Fill(myds, "lianxi");
            orderlist.DataSource = myds.Tables["lianxi"];//数据绑定
            mycon.Close();//关闭数据库
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form5().ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string con, sql;
            con = "Server=localhost;DataBase=demo;user id=sa;password=123456789;";
            sql = "select * from lianxi";
            SqlConnection mycon = new SqlConnection(con);
            mycon.Open();//打开数据库
            SqlDataAdapter myda = new SqlDataAdapter(sql, con);
            DataSet myds = new DataSet();
            myda.Fill(myds, "lianxi");
            dataGridView2.DataSource = myds.Tables["lianxi"];//数据绑定
            mycon.Close();//关闭数据库
        }
    }
}
