﻿using EventBook.Models;
using EventBook.Panels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*
                        Utilizator utilizator = new Utilizator("0,gabi,gabi1234");
                        this.Controls.Add(new PnlMeniu(this,utilizator));
                        this.Controls.Add(new PnlAfisare(this, utilizator));*/
            this.Controls.Add(new PnlStart(this));
        }

        public void removepnl(string pnl)
        {

            Control control = null;

            foreach (Control c in this.Controls)
            {
                if (c.Name.Equals(pnl))
                {
                    control = c;
                }

            }

            this.Controls.Remove(control);

        }

    }
}
