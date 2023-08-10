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
    internal class PnlLogin : Panel
    {

        Form1 form;

        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblSign;

        List<string> erori;
        ControllerUtilizatori controllerUtilizatori;
        public PnlLogin(Form1 form1) {
        
            
            this.form = form1;
            this.erori = new List<string>();
            this.controllerUtilizatori = new ControllerUtilizatori();

            this.form.Size = new System.Drawing.Size(640, 654);
            this.form.MinimumSize = new System.Drawing.Size(640, 654);
            this.form.MaximumSize = new System.Drawing.Size(640, 654);

            // MockupLogin
            this.Size = new System.Drawing.Size(640, 654);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F, System.Drawing.FontStyle.Regular);            
            this.Name = "PnlLogin";
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#1B2223");

            this.lblTitlu = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblSign = new System.Windows.Forms.Label();

            this.Controls.Add(this.lblSign);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogin);

            // lblTitlu
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 25.2F);
            this.lblTitlu.Location = new System.Drawing.Point(236, 40);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(128, 55);
            this.lblTitlu.Text = "Login";
            this.lblTitlu.BackColor = System.Drawing.ColorTranslator.FromHtml("#3A4F50");
            this.lblTitlu.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F4FEFD");

            // pictureBox1
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(644, 149);
            this.pictureBox1.BackColor = System.Drawing.ColorTranslator.FromHtml("#3A4F50");

            // btnLogin
            this.btnLogin.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(197, 490);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(199, 71);
            this.btnLogin.Text = "Login";
            this.btnLogin.BackColor = System.Drawing.ColorTranslator.FromHtml("#0EF6CC");
            this.btnLogin.Click += new EventHandler(btnLogin_Click);

            // lblName
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(263, 207);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(91, 36);
            this.lblName.Text = "Name";
            this.lblName.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F4FEFD");

            // txtName
            this.txtName.Location = new System.Drawing.Point(158, 259);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(307, 43);
             
            // txtPass
            this.txtPass.Location = new System.Drawing.Point(158, 411);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(307, 43);
             
            // lblPass
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(240, 360);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(134, 36);
            this.lblPass.Text = "Password";
            this.lblPass.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F4FEFD");

            // lblSign
            this.lblSign.AutoSize = true;
            this.lblSign.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 11.2F);
            this.lblSign.Location = new System.Drawing.Point(264, 570);
            this.lblSign.Name = "lblSign";
            this.lblSign.Size = new System.Drawing.Size(253, 25);
            this.lblSign.Text = "Don\'t you have an account?";
            this.lblSign.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F4FEFD");
            this.lblSign.Click += new EventHandler(lblSign_Click);

        }

        private void lblSign_Click(object sender, EventArgs e)
        {

            this.form.removepnl("PnlLogin");
            this.form.Controls.Add(new PnlSignUp(form));

        }

        private void errors()
        {

            erori.Clear();

            if (txtName.Text.Equals(""))
            {
                erori.Add("You have not entered the username");
            }

            if (txtPass.Text.Equals(""))
            {
                erori.Add("You have not entered the password");
            }

            if (erori.Count == 0)
            {
                if (controllerUtilizatori.verification(txtPass.Text, txtName.Text) == false)
                {
                    erori.Add("You have not entered password / username incorrectly");
                }
            }


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            errors();

            if (erori.Count > 0)
            {

                for (int i = 0; i < erori.Count; i++)
                {
                    MessageBox.Show(erori[i], "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {

                Utilizator utilizator = controllerUtilizatori.utilizatorByNume(txtPass.Text,txtName.Text);

                this.form.removepnl("PnlLogin");

            }



        }

    }
}
