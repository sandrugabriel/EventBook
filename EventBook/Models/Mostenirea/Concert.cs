using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBook.Models.Mostenirea
{
    internal class Concert : Event
    {

        private int nrArtistilor;
        private string name;

        public Concert(int id, string type, DateTime data, int nrArtistilor, string name) : base(id, type, data)
        {
            this.nrArtistilor = nrArtistilor;
            this.name = name;
        }

        public Concert(string t) : base(t)
        {

            string[] prop = t.Split(',');

            this.nrArtistilor = int.Parse(prop[3]);
            this.name = prop[4];

        }

        public int NrArtistilor { get => nrArtistilor; set => nrArtistilor = value; }

        public string Name { get => name; set => name = value; }

        public override string toSave()
        {
            string t = base.toSave();
            t += nrArtistilor.ToString() + "," + name;
            return t;
        }
    }
}
