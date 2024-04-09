using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
       // int num = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int num=label1.Text.Length;
            //int num = 1;
            
            this.BackColor = Color.Blue;
            //this.BackColor = Color.Yellow;
            //this.BackColor = Color.Red;

            //num++;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = (Color.Yellow);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.BackColor = (Color.Yellow);
        }
    }
}
