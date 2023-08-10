using EventBook.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EventBook.Controllers
{
    internal class ControllerUtilizatori
    {

        private List<Utilizator> utilizatori;

        public ControllerUtilizatori()
        {

            utilizatori = new List<Utilizator>();

            load();

        }

        public void load()
        {

            string path = Application.StartupPath + @"/data/utilizatori.txt";
            StreamReader streamReader = new StreamReader(path);

            string t;

            while((t = streamReader.ReadLine()) != null)
            {
                Utilizator utilizator = new Utilizator(t);
                utilizatori.Add(utilizator);
            }

            streamReader.Close();
        }

        public bool verification(string password, string username)
        {

            for (int i = 0; i < utilizatori.Count; i++)
            {

                if (utilizatori[i].Password.Equals(password) && utilizatori[i].Name.Equals(username))
                {
                    return true;
                }

            }

            return false;
        }

        public bool verificationPassword(string password)
        {

            if (password.Count() <= 8)
            {
                return false;
            }

            int semn = 0;
            int semn1 = 0;
            for (int i = 0; i < password.Count(); i++)
            {
                if ((int)password[i] >= 65 && (int)password[i] <= 90)
                {

                    semn = 1;

                }

                if ((int)password[i] >= 48 && (int)password[i] <= 57)
                {
                    semn1 = 1;

                }


            }

            if (semn == 1 && semn1 == 1)
            {
                return true;
            }


            return false;
        }

        public Utilizator utilizatorByNume(string pass, string nume)
        {

            for (int i = 0; i < utilizatori.Count; i++)
            {

                if (utilizatori[i].Name.Equals(nume) && utilizatori[i].Password.Equals(pass))
                {
                    return utilizatori[i];
                }

            }

            return null;
        }

        public Utilizator getClientById(int id)
        {

            for (int i = 0; i < utilizatori.Count; i++)
            {
                if (utilizatori[i].Id == id)
                {
                    return utilizatori[i];
                }
            }

            return null;
        }

        public int generareId()
        {
            Random random = new Random();

            int id = random.Next();
            while (this.getClientById(id) != null)
            {

                id = random.Next(11,1000);

            }


            return id;

        }

        public void save(string textul)
        {

            string text = textul;
            string path = Application.StartupPath + @"/data/utilizatori.txt";
            File.AppendAllText(path, text + "\n");


        }

    }
}
