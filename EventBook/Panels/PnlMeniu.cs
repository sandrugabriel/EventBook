using EventBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventBook.Panels
{
    internal class PnlMeniu:Panel
    {

        Form1 form;
        Utilizator utilizator;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblTitlu;

        public PnlMeniu(Form1 form1, Utilizator utilizator1) {
        
            this.form = form1;
            this.utilizator = utilizator1;

            //PnlMeniu
            this.Size = new System.Drawing.Size(1400, 111);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular);
            this.Name = "PnlMeniu";
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#3A4F50");


            this.lblTitlu = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();

            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblTitlu);

            // lblTitlu
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 24.8F);
            this.lblTitlu.Location = new System.Drawing.Point(524, this.Size.Height/2-55/2);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(208, 55);
            this.lblTitlu.Text = "Eventurile";
            this.lblTitlu.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F4FEFD");

            // btnAdd
            this.btnAdd.Location = new System.Drawing.Point(1129, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(164, 60);
            this.btnAdd.Text = "Add event";
            this.btnAdd.BackColor = System.Drawing.ColorTranslator.FromHtml("#0EF6CC");
            this.btnAdd.ForeColor = System.Drawing.ColorTranslator.FromHtml("#1B2223");

        }



    }
}
