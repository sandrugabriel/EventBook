using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBook.Models
{
    internal class Utilizator
    {

        private int id;
        private string name;
        private string password;

        public int Id { get => id; set => id = value; }

        public string Name { get => name; set => name = value; }

        public string Password { get => password; set => password = value; }

        public Utilizator(int id, string name, string password)
        {
            this.id = id;
            this.name = name;
            this.password = password;
        }

        public Utilizator(string text)
        {

            string[] prop = text.Split(',');

            this.id = int.Parse(prop[0]);
            this.name = prop[1];
            this.password = prop[2];

        }


    }
}
