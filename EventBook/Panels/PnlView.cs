using EventBook.Controllers;
using EventBook.Models;
using EventBook.Models.Mostenirea;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventBook.Panels
{
    internal class PnlView:Panel
    {

        Form1 form;
        Utilizator utilizator;
        Event _event;

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblDurata;
        private System.Windows.Forms.NumericUpDown numericDurata;
        private System.Windows.Forms.CheckBox chkPrivat;
        private System.Windows.Forms.Label lblNr;
        private System.Windows.Forms.NumericUpDown numericNr;

        ControllerEventuri controllerEventuri;

        public PnlView(Form1 form, Utilizator utilizator, Event @event)
        {
            this.form = form;
            this.utilizator = utilizator;
            this.controllerEventuri = new ControllerEventuri();
            this._event = @event;

            // MockupAdd
            this.Size = new System.Drawing.Size(1340, 779);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular);
            this.Name = "PnlView";
            this.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F4FEFD");

            this.btnCancel = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblType = new System.Windows.Forms.Label();
            this.lblDurata = new System.Windows.Forms.Label();
            this.numericDurata = new System.Windows.Forms.NumericUpDown();
            this.chkPrivat = new System.Windows.Forms.CheckBox();
            this.lblNr = new System.Windows.Forms.Label();
            this.numericNr = new System.Windows.Forms.NumericUpDown();

            this.Controls.Add(this.lblType);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnCancel);

            // btnCancel
            this.btnCancel.Location = new System.Drawing.Point(84, 609);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(194, 80);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.BackColor = System.Drawing.ColorTranslator.FromHtml("#3A4F50");
            this.btnCancel.Click += new EventHandler(btnCancel_Click);

            // lblName
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(173, 116);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(76, 30);
            this.lblName.Text = "Name";

            // txtName
            this.txtName.Location = new System.Drawing.Point(84, 158);
            this.txtName.Text = _event.getName();
            this.txtName.Size = new System.Drawing.Size(263, 38);
            this.txtName.ReadOnly = true;

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
            this.dateTimePicker1.MinDate = dateTimePicker1.MaxDate = _event.DataStart;
            this.dateTimePicker1.Size = new System.Drawing.Size(323, 31);

            // lblType
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(584, 112);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(64, 30);
            this.lblType.Text = "Type : " + _event.Type;

            if (_event is Spectacol)
            {
                Spectacol spectacol = (Spectacol)_event;
                this.Controls.Add(this.numericDurata);
                this.Controls.Add(this.lblDurata);
                // lblDurata
                this.lblDurata.AutoSize = true;
                this.lblDurata.Location = new System.Drawing.Point(177, 282);
                this.lblDurata.Name = "lblDurata";
                this.lblDurata.Size = new System.Drawing.Size(82, 30);
                this.lblDurata.Text = "Durata";

                // numericDurata
                this.numericDurata.Location = new System.Drawing.Point(131, 324);
                this.numericDurata.Name = "numericDurata";
                this.numericDurata.ReadOnly = true;
                this.numericDurata.Value = spectacol.Durata;
                this.numericDurata.Size = new System.Drawing.Size(165, 38);
            }

            else if (_event is Conferinte)
            {

                Conferinte conferinte = (Conferinte)_event;


                this.Controls.Add(this.chkPrivat);
                // chkPrivat
                this.chkPrivat.AutoSize = true;
                this.chkPrivat.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18.8F);
                this.chkPrivat.Location = new System.Drawing.Point(575, 317);
                this.chkPrivat.Name = "chkPrivat";
                this.chkPrivat.Size = new System.Drawing.Size(120, 45);
                this.chkPrivat.Text = "Privat";

                if (conferinte.Privat == true) chkPrivat.Checked = true;

            }

            else if (_event is Concert)
            {
                this.Controls.Add(this.numericNr);
                this.Controls.Add(this.lblNr);

                Concert concert = (Concert)_event;

                // lblNr
                this.lblNr.AutoSize = true;
                this.lblNr.Location = new System.Drawing.Point(1030, 282);
                this.lblNr.Name = "lblNr";
                this.lblNr.Size = new System.Drawing.Size(131, 30);
                this.lblNr.Text = "Nr Artistilor";

                // numericNr
                this.numericNr.Location = new System.Drawing.Point(1008, 324);
                this.numericNr.Name = "numericNr";
                this.numericNr.ReadOnly = true;
                this.numericNr.Value = concert.NrArtistilor;
                this.numericNr.Size = new System.Drawing.Size(165, 38);
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            this.form.removepnl("PnlView");
            this.form.Controls.Add(new PnlMeniu(form, utilizator));
            this.form.Controls.Add(new PnlAfisare(form, utilizator));

        }



    }
}
