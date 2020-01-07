using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mgtk_Click(object sender, EventArgs e)
        {
            DateTime siandienosData = DateTime.Today;
            String diena = siandienosData.ToString();
            tekstoDezute.Text = $"Ugnius {diena}";
        }

        private void tekstoDezute_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
