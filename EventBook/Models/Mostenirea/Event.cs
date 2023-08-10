using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBook.Models.Mostenirea
{
    internal class Event
    {

        private int id;
        private string type;
        private DateTime dataStart;

        public Event(int id, string type, DateTime dateTime)
        {
            this.id = id;
            this.type = type;
            this.dataStart = dateTime;
        }

        public Event(string t)
        {

            string[] prop = t.Split(',');

            this.type = prop[0];
            this.id = int.Parse(prop[1]);
            this.dataStart = DateTime.Parse(prop[2]);

        }

        public int Id { get => id; set => id = value; }

        public string Type { get => type; set => type = value; }

        public DateTime DataStart { get => dataStart; set => dataStart = value; }

        public virtual string toSave()
        {
            return type + "," + id.ToString() + "," + dataStart.ToString() + ",";
        }
    }
}
