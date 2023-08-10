using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventBook.Panels
{
    internal class PnlStart : Panel
    {


        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Button btnSign;

        Form1 form;

        public PnlStart(Form1 form1) {
        
            this.form = form1;

            this.form.Size = new System.Drawing.Size(683, 622);
            this.form.MinimumSize = new System.Drawing.Size(683, 622);
            this.form.MaximumSize = new System.Drawing.Size(683, 622);


            // MockupStart
            this.Size = new System.Drawing.Size(683, 622);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F, System.Drawing.FontStyle.Regular);
            this.Name = "PnlStart";
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#1B2223");

            this.btnLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.btnSign = new System.Windows.Forms.Button();

            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogin);

            // btnLogin
            this.btnLogin.Location = new System.Drawing.Point(201, 247);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(218, 86);
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new EventHandler(btnLogin_Click);
            this.btnLogin.BackColor = System.Drawing.ColorTranslator.FromHtml("#0EF6CC");

            // pictureBox1
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(687, 149);
            this.pictureBox1.BackColor = System.Drawing.ColorTranslator.FromHtml("#3A4F50");

            // lblTitlu
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18.2F);
            this.lblTitlu.Location = new System.Drawing.Point(125, 53);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(480, 40);
            this.lblTitlu.Text = "EventBook: Rezervări Simplificate";
            this.lblTitlu.BackColor = System.Drawing.ColorTranslator.FromHtml("#3A4F50");
            this.lblTitlu.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F4FEFD");

            // btnSign
            this.btnSign.Location = new System.Drawing.Point(201, 411);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(218, 86);
            this.btnSign.Text = "Sign Up";
            this.btnSign.Click += new EventHandler(btnSign_Click);
            this.btnSign.BackColor = System.Drawing.ColorTranslator.FromHtml("#0EF6CC");

        }


        private void btnLogin_Click(object sender, EventArgs e)
        {

            this.form.removepnl("PnlStart");
            this.form.Controls.Add(new PnlLogin(this.form));

        }

        private void btnSign_Click(object sender, EventArgs e)
        {

            this.form.removepnl("PnlStart");
            this.form.Controls.Add(new PnlSignUp(this.form));

        }


    }
}
