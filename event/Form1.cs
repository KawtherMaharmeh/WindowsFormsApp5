using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @event
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtname_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar));
            {
                e.Handled = true;
                MessageBox.Show("pleas enter a string value");

            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) ;
            {
                e.Handled = true;
                MessageBox.Show("THE STRING NOT ALLOWED");

            }







        }

   
     

        }

   
      

        }
    

