using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int week = int.Parse(textBox1.Text);
            int day = week * 7;
            label1.Text = day.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int year = int.Parse(textBox1.Text);
            int day = year * 365;
            label1.Text = day.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int mounth = int.Parse(textBox1.Text);
            int day = mounth * 30;
            label1.Text = day.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
