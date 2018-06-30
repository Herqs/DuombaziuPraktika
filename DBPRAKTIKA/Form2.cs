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
    public partial class FormAddRemove : Form
    {
        int id;
        public FormAddRemove(int _id)
        {
            id = _id;
            InitializeComponent();
            loadusr();
            loadnotusr();
        }
        private void loadusr()
        {
            var plants = sqlcoms.getuserplants(id);

            listBox1.DataSource = plants;
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "ID";
        }
        private void loadnotusr()
        {
            var plants = sqlcoms.getnotuserplants(id);

            listBox2.DataSource = plants;
            listBox2.DisplayMember = "Name";
            listBox2.ValueMember = "ID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlcoms.addlantUser(id, Convert.ToInt32(listBox2.SelectedValue));
            loadusr();
            loadnotusr();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sqlcoms.removePlantUser(id, Convert.ToInt32(listBox1.SelectedValue));
            loadusr();
            loadnotusr();
        }
    }
}
