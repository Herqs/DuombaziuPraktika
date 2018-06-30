namespace DBPRAKTIKA
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnchangegroup = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Atributas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Reiksme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btngrowinfo = new System.Windows.Forms.Button();
            this.btnPlantinfo = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnadduserplant = new System.Windows.Forms.Button();
            this.btnrefresh2 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(161, 186);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(182, 26);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(94, 23);
            this.btnrefresh.TabIndex = 1;
            this.btnrefresh.Text = "Plants";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnchangegroup
            // 
            this.btnchangegroup.Location = new System.Drawing.Point(182, 384);
            this.btnchangegroup.Name = "btnchangegroup";
            this.btnchangegroup.Size = new System.Drawing.Size(94, 23);
            this.btnchangegroup.TabIndex = 2;
            this.btnchangegroup.Text = "ChangeGroup";
            this.btnchangegroup.UseVisualStyleBackColor = true;
            this.btnchangegroup.Click += new System.EventHandler(this.btnchangegroup_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Atributas,
            this.Reiksme});
            this.listView1.Location = new System.Drawing.Point(282, 25);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(252, 124);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Atributas
            // 
            this.Atributas.Text = "Atributas";
            this.Atributas.Width = 110;
            // 
            // Reiksme
            // 
            this.Reiksme.Text = "Reiksme";
            this.Reiksme.Width = 135;
            // 
            // btngrowinfo
            // 
            this.btngrowinfo.Location = new System.Drawing.Point(182, 113);
            this.btngrowinfo.Name = "btngrowinfo";
            this.btngrowinfo.Size = new System.Drawing.Size(94, 23);
            this.btngrowinfo.TabIndex = 4;
            this.btngrowinfo.Text = "Growing info";
            this.btngrowinfo.UseVisualStyleBackColor = true;
            this.btngrowinfo.Click += new System.EventHandler(this.btngrowinfo_Click);
            // 
            // btnPlantinfo
            // 
            this.btnPlantinfo.Location = new System.Drawing.Point(182, 142);
            this.btnPlantinfo.Name = "btnPlantinfo";
            this.btnPlantinfo.Size = new System.Drawing.Size(94, 23);
            this.btnPlantinfo.TabIndex = 5;
            this.btnPlantinfo.Text = "Plant info";
            this.btnPlantinfo.UseVisualStyleBackColor = true;
            this.btnPlantinfo.Click += new System.EventHandler(this.btnPlantinfo_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(282, 155);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(252, 56);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(14, 234);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(162, 173);
            this.listBox2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Jūsų daržovės";
            // 
            // btnadduserplant
            // 
            this.btnadduserplant.Location = new System.Drawing.Point(182, 263);
            this.btnadduserplant.Name = "btnadduserplant";
            this.btnadduserplant.Size = new System.Drawing.Size(94, 23);
            this.btnadduserplant.TabIndex = 9;
            this.btnadduserplant.Text = "Add/Remove";
            this.btnadduserplant.UseVisualStyleBackColor = true;
            this.btnadduserplant.Click += new System.EventHandler(this.btnadduserplant_Click);
            // 
            // btnrefresh2
            // 
            this.btnrefresh2.Location = new System.Drawing.Point(182, 234);
            this.btnrefresh2.Name = "btnrefresh2";
            this.btnrefresh2.Size = new System.Drawing.Size(94, 23);
            this.btnrefresh2.TabIndex = 11;
            this.btnrefresh2.Text = "Refresh";
            this.btnrefresh2.UseVisualStyleBackColor = true;
            this.btnrefresh2.Click += new System.EventHandler(this.btnrefresh2_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(282, 234);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(252, 173);
            this.richTextBox2.TabIndex = 12;
            this.richTextBox2.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Diseases";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(182, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Pests";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Pasirinktų duomenų sąrašas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Pasirinkto elemento atribbutai";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Jūsų daržo informacija";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 414);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.btnrefresh2);
            this.Controls.Add(this.btnadduserplant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnPlantinfo);
            this.Controls.Add(this.btngrowinfo);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnchangegroup);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnchangegroup;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Atributas;
        private System.Windows.Forms.ColumnHeader Reiksme;
        private System.Windows.Forms.Button btngrowinfo;
        private System.Windows.Forms.Button btnPlantinfo;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnadduserplant;
        private System.Windows.Forms.Button btnrefresh2;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

