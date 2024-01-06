using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label4.Text = textName1.Text + "\n";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label4.Text = textName2.Text + "\n";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label4.Text = textName3.Text + "\n";
        }
    }
}
