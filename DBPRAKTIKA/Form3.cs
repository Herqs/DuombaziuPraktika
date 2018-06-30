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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id=sqlcoms.Login(textBox1.Text, textBox2.Text);
            if (id!=0)
            {
                Form1 f1 = new Form1(id);
                    f1.Show();
                this.Hide();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            regform f1 = new regform();
            f1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(0);
            f1.Show();
        }
    }
}
