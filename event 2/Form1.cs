using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace event_2
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)) ;
            {
                e.Handled = true;
                MessageBox.Show("pleas enter a string value");

            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) ;
            {
                e.Handled = true;
                MessageBox.Show("THE STRING NOT ALLOWED");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name;
            int age;
            name = txtname.Text;
            age = int.Parse(txtage.Text);
            MessageBox.Show("name:" + name + "\n" + "age:" + age);
        }
    }
}
