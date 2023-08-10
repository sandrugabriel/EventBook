using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EventBook.Models.Mostenirea
{
    internal class Conferinte : Event
    {

        private bool privat;
        private string name;

        public Conferinte(int id, string type, DateTime data, bool privat, string name):base(id,type, data)
        {
            this.privat = privat;
            this.name = name;
        }

        public Conferinte(string t):base(t)
        {
            string[] prop = t.Split(',');

            this.privat = bool.Parse(prop[3]);
            this.name = prop[4];

        }

        public bool Privat { get => privat; set => privat = value; }

        public string Name { get => name; set => name = value; }

        public override string toSave()
        {
            string t = base.toSave();
            t += privat.ToString() + "," + name;
            return t;
        }
        public override string getName()
        {
            return name;
        }
    }
}
