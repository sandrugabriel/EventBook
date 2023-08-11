using EventBook.Controllers;
using EventBook.Models;
using EventBook.Models.Mostenirea;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventBook.Panels
{
    internal class PnlCard:Panel
    {

        Form1 form;
        Utilizator utilizator;
        Event _event;

        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblName1;
        private System.Windows.Forms.Label lblType1;
        private System.Windows.Forms.Button btnDelete;

        ControllerEventuri controllerEventuri;

        public PnlCard(Form1 form1, Utilizator utilizator1, Event _event1) {
        
            this.form = form1;
            this.utilizator = utilizator1;
            this._event = _event1;

            this.controllerEventuri = new ControllerEventuri();

            // MockupCard
            this.Size = new System.Drawing.Size(319, 303);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular);
            this.Name = "PnlCard";
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#F4FEFD");


            this.lblType = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblName1 = new System.Windows.Forms.Label();
            this.lblType1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();

            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblType1);
            this.Controls.Add(this.lblName1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblType);

            this.lblType1.Click += new EventHandler(view_Click); 
            this.lblType.Click += new EventHandler(view_Click);
            this.lblName.Click += new EventHandler(view_Click);
            this.lblName1.Click += new EventHandler(view_Click);
            this.Click += new EventHandler(view_Click);


            // lblType
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15.8F);
            this.lblType.Location = new System.Drawing.Point(39, 19);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(74, 35);
            this.lblType.Text = "Type";
             
            // lblName
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15.8F);
            this.lblName.Location = new System.Drawing.Point(39, 124);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(89, 35);
            this.lblName.Text = "Name";
            
            // lblName1
            this.lblName1.AutoSize = true;
            this.lblName1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F);
            this.lblName1.Location = new System.Drawing.Point(74, 168);
            this.lblName1.Name = "lblName1";
            this.lblName1.Size = new System.Drawing.Size(76, 30);
            this.lblName1.Text = _event.getName();
             
            // lblType1
            this.lblType1.AutoSize = true;
            this.lblType1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F);
            this.lblType1.Location = new System.Drawing.Point(74, 64);
            this.lblType1.Name = "lblType1";
            this.lblType1.Size = new System.Drawing.Size(76, 30);
            this.lblType1.Text = _event.Type;
             
            // btnDelete
            this.btnDelete.Location = new System.Drawing.Point(79, 225);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 49);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new EventHandler(btnDelete_Click); 
            this.btnDelete.BackColor = System.Drawing.ColorTranslator.FromHtml("#3A4F50"); 
            this.btnDelete.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F4FEFD");



        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            controllerEventuri.delete(_event.Id);

            form.removepnl("PnlAfisare");
            form.Controls.Add(new PnlAfisare(form,utilizator));
        }

        private void view_Click(object sender, EventArgs e)
        {
            form.removepnl("PnlMeniu");
            form.removepnl("PnlAfisare");
            form.Controls.Add(new PnlView(form, utilizator, _event));
        }
    }
}
