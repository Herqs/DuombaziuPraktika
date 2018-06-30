using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBPRAKTIKA
{
    public partial class regform : Form
    {
        public regform()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sqlcoms.checkifexists(textBox1.Text))
            {
                MessageBox.Show("User already exists");
            }
            else
            {
                int gender = 2;
                if(radioButton1.Checked)
                gender = 1;

                if(sqlcoms.Adduser(textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text,textBox5.Text,textBox6.Text,gender));
                { this.Close(); }
            }
        }
    }
}
