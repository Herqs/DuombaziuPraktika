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
    public partial class ChangeGroup : Form
    {
        int id;
        public ChangeGroup(int _id)
        {
            id = _id;
            InitializeComponent();
            refreshgroup();
        }

        private void refreshgroup()
        {
            var plants = sqlcoms.plants("PlantGroup");

            listBox1.DataSource = plants;
            listBox1.DisplayMember = "name";
            listBox1.ValueMember = "id";
            refreshnote();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnchange_Click(object sender, EventArgs e)
        {
            sqlcoms.changeGroup(id, Convert.ToInt32(listBox1.SelectedValue));
            Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                refreshnote();
            }
            catch { }
        }

        private void refreshnote()
        {
            richTextBox1.Text = sqlcoms.getgroupnote(Convert.ToInt32(listBox1.SelectedValue));
        }
    }
}
