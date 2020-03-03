using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void equalClick_Click(object sender, EventArgs e)
        {
            double num1, num2;
            if (!double.TryParse(input1.Text, out num1) || !double.TryParse(input2.Text, out num2))
            {
                output.Text = "input not a valid number";
                return;
            }

            switch (Operator.Text)
            {
                case "+":
                    output.Text = $"{num1 + num2}";
                    break;
                case "-":
                    output.Text = $"{num1 - num2}";
                    break;
                case "*":
                    output.Text = $"{num1 * num2}";
                    break;
                case "/":
                    output.Text = num2 == 0 ? "can't divide by zero" : $"{num1 / num2}";
                    break;
            }
        }

        private void input1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
