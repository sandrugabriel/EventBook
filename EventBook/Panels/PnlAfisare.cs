using EventBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventBook.Panels
{
    internal class PnlAfisare : Panel
    {

        Form1 form;
        Utilizator utilizator;

        public PnlAfisare(Form1 form1, Utilizator utilizator1)
        {

            this.form = form1;
            this.utilizator = utilizator1;

            this.form.Size = new System.Drawing.Size(1358, 826);
            this.form.MinimumSize = new System.Drawing.Size(1358, 826);
            this.form.MaximumSize = new System.Drawing.Size(1358, 826);

            //PnlAfisare
            this.Size = new System.Drawing.Size(1323, 586);
            this.Location = new System.Drawing.Point(0, 112);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular);
            this.Name = "PnlAfisare";






        }


    }
}
