using EventBook.Models.Mostenirea;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventBook.Controllers
{
    internal class ControllerEventuri
    {

        private List<Event> eventuri;

        public ControllerEventuri()
        {

            this.eventuri = new List<Event>();

            load();

        }

        public void load()
        {

            string path = Application.StartupPath;

            StreamReader streamReader = new StreamReader(path);

            string t;

            while ((t = streamReader.ReadLine()) != null)
            {
                switch (t.Split(',')[0])
                {

                    case "spectacol":
                        eventuri.Add(new Spectacol(t));
                        break;
                    case "coferinte":
                        eventuri.Add(new Conferinte(t));
                        break;
                    case "concert":
                        eventuri.Add(new Concert(t));
                        break;
                }
            }

            streamReader.Close();
        }

        public List<Event> getAll()
        {
            return eventuri;
        }

        public Event getEventById(int id)
        {

            for (int i = 0; i < eventuri.Count; i++)
            {
                if (eventuri[i].Id == id)
                {
                    return eventuri[i];
                }
            }

            return null;
        }

        public int generareId()
        {
            Random random = new Random();

            int id = random.Next();
            while (this.getEventById(id) != null)
            {

                id = random.Next(36, 10000);

            }


            return id;

        }

        public void save(string textul)
        {

            string text = textul;
            string path = Application.StartupPath + @"/data/eventuri.txt";
            File.AppendAllText(path, text + "\n");


        }

        public string saveAllFisier()
        {

            string t = "";

            for (int i = 0; i < eventuri.Count; i++)
            {
                t += eventuri[i].toSave() + "\n";
            }

            return t;
        }

        public int pozId(int id)
        {

            for (int i = 0; i < eventuri.Count; i++)
            {
                if (eventuri[i].Id == id)
                    return i;
            }

            return -1;
        }

        public void stergere(int id)
        {

            int p = pozId(id);

            eventuri.RemoveAt(p);


        }

        public void delete(int id)
        {

            this.stergere(id);

            string path = Application.StartupPath + @"/data/eventuri.txt";
            StreamWriter streamWriter = new StreamWriter(path);
            streamWriter.Write(this.saveAllFisier());

            streamWriter.Close();
        }


    }
}
