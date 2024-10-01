using Lab_12_first.Listeners;
using Lab_12_first.Recipients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12_first
{
    internal class Royal_Greenwich_Observatory
    {
        List<Asteroid> Observatory = new List<Asteroid>();
        List<Listener> listeners = new List<Listener> ();
        private string file = "Input.txt";
        public Royal_Greenwich_Observatory(List<Listener> list)
        {
            Observatory = new List<Asteroid>();
            listeners = list;
        }

        public void GiveData()
        {
            foreach (Asteroid a in Observatory)
            {
                foreach (Listener listener in listeners)
                {
                    listener.Take(a);
                }
            }
        }

        public void GetData()
        {
            string[] data = File.ReadAllLines(file);
            foreach (string asteroid in data)
            {
                Observatory.Add(new Asteroid(int.Parse(asteroid), int.Parse(asteroid), int.Parse(asteroid)));
            }
        }

    }
}
