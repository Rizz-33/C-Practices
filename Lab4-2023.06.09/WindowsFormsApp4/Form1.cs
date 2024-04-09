using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1,num2;
            num1=int.Parse(textBox1.Text);
            num2=int.Parse(textBox2.Text);

            int sum = num1+num2;
           

            label3.Text = "Addition " + sum.ToString();
            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = int.Parse(textBox1.Text);
            num2 = int.Parse(textBox2.Text);
            int sub = num1 - num2;

            label3.Text = "Substration " + sub.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            int num1, num2;
            num1 = int.Parse(textBox1.Text);
            num2 = int.Parse(textBox2.Text);
            int mul = num1 * num2;

            label3.Text = "Multiplication " + mul.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = int.Parse(textBox1.Text);
            num2 = int.Parse(textBox2.Text);
            double div = num1 / num2;

            label3.Text = "Division " + div.ToString();
        }
    }
}
