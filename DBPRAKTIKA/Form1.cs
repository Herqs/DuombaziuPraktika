using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Configuration;
using System.Data.SqlClient;

namespace DBPRAKTIKA
{
    public partial class Form1 : Form
    {
        int userid;
        public Form1(int _userid)
        {
            InitializeComponent();
            refreshplants();
            refreshusrplants();
            userid = _userid;
            optimizeform();
            btnchangegroup.Visible = false;
        }

        private void optimizeform()
        {
            if (userid==0)
            {
                btnrefresh2.Enabled = false;
                btnadduserplant.Enabled = false;
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
 
        }
        private void refreshplants()
        {
            var plants = sqlcoms.plants("Plant");

            listBox1.DataSource = plants;
            listBox1.DisplayMember = "name";
            listBox1.ValueMember = "id";
        }

        private void btnchangegroup_Click(object sender, EventArgs e)
        {
            ChangeGroup f2 = new ChangeGroup(Convert.ToInt32(listBox1.SelectedValue));
            f2.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                refreshplantinfo();
            }
            catch { }
        }

        private void btngrowinfo_Click(object sender, EventArgs e)
        {
            refreshgrowinfo();
        }

        private void refreshgrowinfo()
        {
            listView1.Items.Clear();
            var info = sqlcoms.growinfo(Convert.ToInt32(listBox1.SelectedValue));

            ListViewItem itm = new ListViewItem();
            itm.Text = "Kada sodinti";
            itm.SubItems.Add(info[0]);
            listView1.Items.Add(itm);
            ListViewItem itm1 = new ListViewItem();
            itm1.Text = "Kada derlius";
            itm1.SubItems.Add(info[1]);
            listView1.Items.Add(itm1);
            ListViewItem i2tm = new ListViewItem();
            i2tm.Text = "Vieta augalui (kv. m)";
            i2tm.SubItems.Add(info[2]);
            listView1.Items.Add(i2tm);
            richTextBox1.Text = info[3];
        }

        private void btnPlantinfo_Click(object sender, EventArgs e)
        {
            refreshplantinfo();
        }

        private void refreshplantinfo()
        {
            listView1.Items.Clear();
            var info = sqlcoms.PlantSpecs(Convert.ToInt32(listBox1.SelectedValue));

            ListViewItem itm = new ListViewItem();
            itm.Text = "Spalva";
            itm.SubItems.Add(info[2]);
            listView1.Items.Add(itm);
            ListViewItem itm1 = new ListViewItem();
            itm1.Text = "Vidut. aukstis";
            itm1.SubItems.Add(info[3]);
            listView1.Items.Add(itm1);
            ListViewItem i2tm = new ListViewItem();
            i2tm.Text = "Vidut. plotis";
            i2tm.SubItems.Add(info[4]);
            listView1.Items.Add(i2tm);
            ListViewItem it3m = new ListViewItem();
            it3m.Text = "pH";
            it3m.SubItems.Add(info[5]);
            listView1.Items.Add(it3m);

            richTextBox1.Text = "Grupė: " + sqlcoms.getgroup(Convert.ToInt32(info[1])) + "\n\n" + info[6];
        }

        private void btnadduserplant_Click(object sender, EventArgs e)
        {
            FormAddRemove f2 = new FormAddRemove(userid);
            f2.Show();
            f2.Deactivate += F2_Deactivate;
        }

        private void F2_Deactivate(object sender, EventArgs e)
        {
            richTextBox2.Clear();
            refreshusrplants();
        }

        private void btnrefresh2_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
            refreshusrplants();
        }
        private void refreshusrplants()
        {
            var plants = sqlcoms.getuserplants(userid);
            listBox2.DataSource = plants;
            listBox2.DisplayMember = "Name";
            listBox2.ValueMember = "ID";
            List<int> ids = new List<int>();
            foreach (PlantClass plc in plants)
            {
                ids.Add(plc.id);
            }
            
            foreach (PlantClass plant in plants)
            {
                var plantrel=sqlcoms.getplantrel(plant.id);
                foreach (PlantClass plantr in plantrel)
                {
                    string status = plantr.relstat();
                    string p2name = sqlcoms.getplname(plantr.id); 

                    if (ids.Contains(plantr.id))
                    richTextBox2.AppendText(plantr.name+status+p2name+"\nNotes: "+plantr.note+"\n\n");
                }
            }


        }
    }
}
