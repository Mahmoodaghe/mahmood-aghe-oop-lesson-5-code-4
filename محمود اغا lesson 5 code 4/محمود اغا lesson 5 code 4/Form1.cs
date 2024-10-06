using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace محمود_اغا_lesson_5_code_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt16(textBox1.Text);
            int s1 = Convert.ToInt16(textBox2.Text);
            textBox3.Text = (s + s1).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int s = Convert.ToInt16(textBox6.Text);
            int s1 = Convert.ToInt16(textBox5.Text);
            textBox4.Text = (s - s1).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int s = Convert.ToInt16(textBox9.Text);
            int s1 = Convert.ToInt16(textBox8.Text);
            textBox7.Text = (s * s1).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            int s = Convert.ToInt16(textBox12.Text);
            int s1 = Convert.ToInt16(textBox11.Text);
            if (s1 != 0)
            {
                textBox10.Text = (s / s1).ToString();
            }
            else
                MessageBox.Show("error");
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.groupBox1.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.groupBox2.Visible = false;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.groupBox3.Visible = false;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.groupBox4.Visible = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
              
           //groupBox1.Visible = groupBox2.Visible = groupBox3.Visible = groupBox4.Visible = false;
            groupBox1.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            groupBox1.Visible = groupBox2.Visible = groupBox3.Visible = groupBox4.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {
            groupBox4.Visible = true;

        }
    }
}
