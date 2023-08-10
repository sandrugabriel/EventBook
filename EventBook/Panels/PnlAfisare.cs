using EventBook.Controllers;
using EventBook.Models;
using EventBook.Models.Mostenirea;
using System;
using System.Collections.Generic;
using System.IO;
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

        List<Event> events;
        ControllerEventuri controllerEventuri;
        public PnlAfisare(Form1 form1, Utilizator utilizator1)
        {

            this.form = form1;
            this.utilizator = utilizator1;

            events = new List<Event>();
            controllerEventuri = new ControllerEventuri();

            this.form.Size = new System.Drawing.Size(1358, 826);
            this.form.MinimumSize = new System.Drawing.Size(1358, 826);
            this.form.MaximumSize = new System.Drawing.Size(1358, 826);

            //PnlAfisare
            this.Size = new System.Drawing.Size(1358, 665);
            this.Location = new System.Drawing.Point(0, 111);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular);
            this.Name = "PnlAfisare";
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#1B2223");


            events = controllerEventuri.getAll();

            createCard(4);
        }


        public void createCard(int nr)
        {
            this.Controls.Clear();

            // this.Controls.Add(lbl1);

            int x, y;

            x = 15;
            y = 13;

            int ct = 0;

            foreach (Event _event in events)
            {

                ct++;
                    PnlCard pnlCardDulap = new PnlCard(form, utilizator,_event);
                    pnlCardDulap.Location = new System.Drawing.Point(x, y);
                    this.Controls.Add(pnlCardDulap);

                x += 330;

                if (ct % nr == 0)
                {
                    x = 15;
                    y += 320;
                }

                if (y > this.Height)
                {
                    this.AutoScroll = true;
                }

            }

        }




    }
}
