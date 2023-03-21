using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool colorOn = false;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Opacity = 1.5 - this.Opacity;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorOn)
            {
                this.BackColor = Color.White;
                colorOn = false;
            }
            else
            {
                this.BackColor = Color.Yellow;
                colorOn = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, world!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Я супермегакнопка,\nі цього мене не позбавиш!");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {

                button4.Click += button1_Click;
            }
            else
            {
                button4.Click -= button1_Click;
            }

            if (checkBox2.Checked)
            {

                button4.Click += button2_Click;
            }
            else
            {
                button4.Click -= button2_Click;
            }

            if (checkBox3.Checked)
            {

                button4.Click += button3_Click;
            }
            else
            {
                button4.Click -= button3_Click;
            }
        }
    }
}
