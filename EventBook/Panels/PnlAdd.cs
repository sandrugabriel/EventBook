using EventBook.Controllers;
using EventBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventBook.Panels
{
    internal class PnlAdd : Panel
    {

        Form1 form;
        Utilizator utilizator;

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.Label lblDurata;
        private System.Windows.Forms.NumericUpDown numericDurata;
        private System.Windows.Forms.CheckBox chkPrivat;
        private System.Windows.Forms.Label lblNr;
        private System.Windows.Forms.NumericUpDown numericNr;

        ControllerEventuri controllerEventuri;

        public PnlAdd(Form1 form, Utilizator utilizator)
        {
            this.form = form;
            this.utilizator = utilizator;
            this.controllerEventuri = new ControllerEventuri();

            // MockupAdd
            this.Size = new System.Drawing.Size(1340, 779);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular);
            this.Name = "PnlAdd";
            this.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F4FEFD");

            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblType = new System.Windows.Forms.Label();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.lblDurata = new System.Windows.Forms.Label();
            this.numericDurata = new System.Windows.Forms.NumericUpDown();
            this.chkPrivat = new System.Windows.Forms.CheckBox();
            this.lblNr = new System.Windows.Forms.Label();
            this.numericNr = new System.Windows.Forms.NumericUpDown();

            this.Controls.Add(this.numericNr);
            this.Controls.Add(this.lblNr);
            this.Controls.Add(this.chkPrivat);
            this.Controls.Add(this.numericDurata);
            this.Controls.Add(this.lblDurata);
            this.Controls.Add(this.comboType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);

            // btnCancel
            this.btnCancel.Location = new System.Drawing.Point(84, 609);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(194, 80);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.BackColor = System.Drawing.ColorTranslator.FromHtml("#3A4F50");
            this.btnCancel.Click += new EventHandler(btnCancel_Click);

            // btnAdd
            this.btnAdd.Location = new System.Drawing.Point(1064, 618);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(194, 80);
            this.btnAdd.Text = "Add Event";
            this.btnAdd.BackColor = System.Drawing.ColorTranslator.FromHtml("#3A4F50");
            this.btnAdd.Click += new EventHandler(btnAdd_Click);

            // lblName
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(173, 116);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(76, 30);
            this.lblName.Text = "Name";
             
            // txtName
            this.txtName.Location = new System.Drawing.Point(84, 158);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(263, 38);
            
            // lblData
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(1059, 112);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(61, 30);
            this.lblData.Text = "Data";
             
            // dateTimePicker1
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F);
            this.dateTimePicker1.Location = new System.Drawing.Point(931, 165);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(323, 31);
             
            // lblType
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(584, 112);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(64, 30);
            this.lblType.Text = "Type";
             
            // comboType
            this.comboType.FormattingEnabled = true;
            this.comboType.Location = new System.Drawing.Point(493, 158);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(289, 38);
            this.comboType.Text = "concert";
            this.comboType.Items.Add("concert");
            this.comboType.Items.Add("coferinta");
            this.comboType.Items.Add("spectacol");
            this.comboType.SelectedIndexChanged += new EventHandler(cmbType_SelectedIndexChanged);

            // lblDurata
            this.lblDurata.AutoSize = true;
            this.lblDurata.Location = new System.Drawing.Point(177, 282);
            this.lblDurata.Name = "lblDurata";
            this.lblDurata.Size = new System.Drawing.Size(82, 30);
            this.lblDurata.Text = "Durata";
            this.lblDurata.Visible = false;
             
            // numericDurata
            this.numericDurata.Location = new System.Drawing.Point(131, 324);
            this.numericDurata.Name = "numericDurata";
            this.numericDurata.Size = new System.Drawing.Size(165, 38);
            this.numericDurata.Visible = false;
             
            // chkPrivat
            this.chkPrivat.AutoSize = true;
            this.chkPrivat.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18.8F);
            this.chkPrivat.Location = new System.Drawing.Point(575, 317);
            this.chkPrivat.Name = "chkPrivat";
            this.chkPrivat.Size = new System.Drawing.Size(120, 45);
            this.chkPrivat.Text = "Privat";
            this.chkPrivat.Visible = false;
             
            // lblNr
            this.lblNr.AutoSize = true;
            this.lblNr.Location = new System.Drawing.Point(1030, 282);
            this.lblNr.Name = "lblNr";
            this.lblNr.Size = new System.Drawing.Size(131, 30);
            this.lblNr.Text = "Nr Artistilor";
             
            // numericNr
            this.numericNr.Location = new System.Drawing.Point(1008, 324);
            this.numericNr.Name = "numericNr";
            this.numericNr.Size = new System.Drawing.Size(165, 38);

        }


        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboType.SelectedItem.ToString().Equals("coferinta"))
            {
                this.numericNr.Visible = false;
                this.numericDurata.Visible = false;
                this.lblNr.Visible = false;
                this.lblDurata.Visible = false;
                this.chkPrivat.Visible = true;
            }

            if (comboType.SelectedItem.ToString().Equals("concert"))
            {
                this.numericNr.Visible = true;
                this.numericDurata.Visible = false;
                this.lblNr.Visible = true;
                this.lblDurata.Visible = false;
                this.chkPrivat.Visible = false;
            }

            if (comboType.SelectedItem.ToString().Equals("spectacol"))
            {
                this.numericNr.Visible = false;
                this.numericDurata.Visible = true;
                this.lblNr.Visible = false;
                this.lblDurata.Visible = true;
                this.chkPrivat.Visible = false;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


            int id = controllerEventuri.generareId();
            string data = dateTimePicker1.Value.ToString("MM/dd/yyyy");

            if (comboType.SelectedItem.ToString().Equals("coferinta"))
            {
                string ogl = "false";
                if (chkPrivat.Checked)
                {
                    ogl = "true";
                }
                string t = comboType.Text + "," + id.ToString() + "," + data + "," + ogl + "," + txtName.Text;
                controllerEventuri.save(t);
                form.removepnl("PnlAdd");
                form.Controls.Add(new PnlMeniu(form,utilizator));
                form.Controls.Add(new PnlAfisare(form,utilizator));
            }

            else if (comboType.SelectedItem.ToString().Equals("concert"))
            {
                string nr = numericNr.Value.ToString();
                string t = comboType.Text + "," + id.ToString() + "," + data + "," + nr + "," + txtName.Text;
                controllerEventuri.save(t);
                form.removepnl("PnlAdd");
                form.Controls.Add(new PnlMeniu(form, utilizator));
                form.Controls.Add(new PnlAfisare(form, utilizator));
            }

            else if (comboType.SelectedItem.ToString().Equals("spectacol"))
            {
                string dur = numericDurata.Value.ToString();

                string t = comboType.Text + "," + id.ToString() + "," + data + "," + txtName + "," + dur;
                controllerEventuri.save(t);
                form.removepnl("PnlAdd");
                form.Controls.Add(new PnlMeniu(form, utilizator));
                form.Controls.Add(new PnlAfisare(form, utilizator));
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            this.form.removepnl("PnlAdd");
            this.form.Controls.Add(new PnlMeniu(form, utilizator));
            this.form.Controls.Add(new PnlAfisare(form,utilizator));

        }


    }
}
