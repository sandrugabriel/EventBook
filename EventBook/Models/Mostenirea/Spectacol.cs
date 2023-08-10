using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBook.Models.Mostenirea
{
    internal class Spectacol : Event
    {

        private string name;
        private int durata;

        public Spectacol(int id, string type, DateTime data, string name, int durata) : base(id, type, data)
        {
            this.name = name;
            this.durata = durata;
        }

        public Spectacol(string t):base(t)
        {
            string[] prop = t.Split(',');

            this.name = prop[3];
            this.durata = int.Parse(prop[4]);

        }

        public string Name { get => name; set => name = value; }

        public int Durata { get => durata; set => durata = value; }

        public override string toSave()
        {
            string t = base.toSave();
            t += name + "," + durata.ToString();
            return t;
        }

        public override string getName()
        {
            return name;
        }

    }
}
