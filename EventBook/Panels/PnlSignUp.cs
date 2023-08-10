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
    internal class PnlSignUp : Panel
    {

        Form1 form;

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.TextBox txtRePass;
        private System.Windows.Forms.Label lblRePass;

        List<string> erori;
        ControllerUtilizatori controllerUtilizatori;

        public PnlSignUp(Form1 form1) {
        
            this.form = form1;

            this.form.Size = new System.Drawing.Size(764, 674);
            this.form.MinimumSize = new System.Drawing.Size(764, 674);
            this.form.MaximumSize = new System.Drawing.Size(764, 674);

            this.erori = new List<string>();
            this.controllerUtilizatori = new ControllerUtilizatori();

            // MockupSign
            this.Size = new System.Drawing.Size(764, 674);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular);
            this.Name = "PnlSign";
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#1B2223");

            this.lblLogin = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSign = new System.Windows.Forms.Button();
            this.txtRePass = new System.Windows.Forms.TextBox();
            this.lblRePass = new System.Windows.Forms.Label();

            this.Controls.Add(this.txtRePass);
            this.Controls.Add(this.lblRePass);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSign);

            // lblLogin
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 11.2F);
            this.lblLogin.Location = new System.Drawing.Point(330, 597);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(232, 25);
            this.lblLogin.Text = "Do you have an account?";
            this.lblLogin.BackColor = System.Drawing.ColorTranslator.FromHtml("#1B2223");
            this.lblLogin.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F4FEFD");
            this.lblLogin.Click += new EventHandler(lblLogin_Click);

            // txtPass
            this.txtPass.Location = new System.Drawing.Point(424, 244);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(307, 38);
             
            // lblPass
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(506, 193);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(112, 30);
            this.lblPass.Text = "Password";
            this.lblPass.BackColor = System.Drawing.ColorTranslator.FromHtml("#1B2223");
            this.lblPass.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F4FEFD");

            // txtName
            this.txtName.Location = new System.Drawing.Point(23, 244);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(307, 38);
             
            // lblName
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(128, 192);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(76, 30);
            this.lblName.Text = "Name";
            this.lblName.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F4FEFD");
            this.lblName.BackColor = System.Drawing.ColorTranslator.FromHtml("#1B2223");

            // lblTitlu
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 25.2F);
            this.lblTitlu.Location = new System.Drawing.Point(291, 38);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(171, 55);
            this.lblTitlu.Text = "Sign Up";
            this.lblTitlu.BackColor = System.Drawing.ColorTranslator.FromHtml("#3A4F50");
            this.lblTitlu.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F4FEFD");
             
            // pictureBox1
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(758, 149);
            this.pictureBox1.BackColor = System.Drawing.ColorTranslator.FromHtml("#3A4F50");

            // btnSign
            this.btnSign.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSign.Location = new System.Drawing.Point(263, 519);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(199, 71);
            this.btnSign.Text = "Sign Up";
            this.btnSign.BackColor = System.Drawing.ColorTranslator.FromHtml("#0EF6CC");
            this.btnSign.Click += new EventHandler(btnSign_Click);

            // txtRePass
            this.txtRePass.Location = new System.Drawing.Point(229, 386);
            this.txtRePass.Name = "txtRePass";
            this.txtRePass.Size = new System.Drawing.Size(307, 38);
             
            // lblRePass
            this.lblRePass.AutoSize = true;
            this.lblRePass.Location = new System.Drawing.Point(278, 332);
            this.lblRePass.Name = "lblRePass";
            this.lblRePass.Size = new System.Drawing.Size(201, 30);
            this.lblRePass.Text = "Confirm Password";
            this.lblRePass.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F4FEFD");
            this.lblRePass.BackColor = System.Drawing.ColorTranslator.FromHtml("#1B2223");

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

            this.form.removepnl("PnlSign");
            this.form.Controls.Add(new PnlLogin(form));
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
            else
            {
                if(txtPass.Text != txtRePass.Text)
                {
                    erori.Add("You have not entered the same passwords");
                }
            }

            if (controllerUtilizatori.verificationPassword(txtPass.Text) == false)
            {
                txtPass.Focus();
                erori.Add("Password is invalid");

            }


        }

        private void btnSign_Click(object sender, EventArgs e)
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


                int id = controllerUtilizatori.generareId();
                string name = txtName.Text;
                string password = txtPass.Text;

                string textul = id.ToString() + "," + name + "," + password;

                controllerUtilizatori.save(textul);

                controllerUtilizatori.load();

                Utilizator utilizator = new Utilizator(textul);

                this.form.removepnl("PnlSign");
                this.form.Controls.Add(new PnlMeniu(form, utilizator));
                this.form.Controls.Add(new PnlAfisare(form, utilizator));

            }


        }

    }
}
