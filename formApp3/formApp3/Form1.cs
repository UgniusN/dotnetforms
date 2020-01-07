using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int skaicius = Convert.ToInt32(textBox2.Text);
            if (skaicius % 2 == 0)
                textBox1.Text = $"Lyginis";
            else
                textBox1.Text = $"Nelyginis";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rezultatas_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)

        { 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
