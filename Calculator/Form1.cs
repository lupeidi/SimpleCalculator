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
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.box.Text = "";
            input += "1";
            this.box.Text += input;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.box.Text = "";
            input += "2";
            this.box.Text += input;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.box.Text = "";
            input += "3";
            this.box.Text += input;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.box.Text = "";
            input += "4";
            this.box.Text += input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.box.Text = "";
            input += "5";
            this.box.Text += input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.box.Text = "";
            input += "6";
            this.box.Text += input;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.box.Text = "";
            input += "7";
            this.box.Text += input;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.box.Text = "";
            input += "8";
            this.box.Text += input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.box.Text = "";
            input += "9";
            this.box.Text += input;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            this.box.Text = "";
            input += "0";
            this.box.Text += input;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void buttonTimes_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
perand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            this.box.Text = "";
            this.operand2 = String.Empty;
            this.input = String.Empty;

            if (operation == '+')
            {
                result = num1 + num2;
                this.operand1 = result.ToString();
                box.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                this.operand1 = result.ToString();
                box.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                this.operand1 = result.ToString();
                box.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    this.operand1 = result.ToString();
                    box.Text = result.ToString();
                }
                else
                {
                    box.Text = "DIV/Zero!";
                }

            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            this.box.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
