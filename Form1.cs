using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcu_Activity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int input1 = Convert.ToInt32(textBox1.Text);
            int input2 = Convert.ToInt32(textBox2.Text);

            int result = input1 + input2;

            MessageBox.Show("The answer is: " + result.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int input1 = Convert.ToInt32(textBox1.Text);
            int input2 = Convert.ToInt32(textBox2.Text);

            int result = input1 - input2;

            MessageBox.Show("The answer is: " + result.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int input1 = Convert.ToInt32(textBox1.Text);
            int input2 = Convert.ToInt32(textBox2.Text);

            int result = input1 * input2;

            MessageBox.Show("The answer is: " + result.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int input1 = Convert.ToInt32(textBox1.Text);
            int input2 = Convert.ToInt32(textBox2.Text);

            int result = input1 / input2;

            MessageBox.Show("The answer is: " + result.ToString());
        }
    }
}
