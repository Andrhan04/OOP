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
        StreamReader Input;
        public Royal_Greenwich_Observatory(List<Listener> list)
        {
            Input = new StreamReader(file);
            Observatory = new List<Asteroid>();
            listeners = list;
        }

        public void GiveData(Asteroid a)
        {

            foreach (Listener listener in listeners){
                listener.Take(a);
                listener.MyData();
                Thread.Sleep(1000);
            }
        }

        public void GetData()
        {
            Observatory.Clear();
            string data = Input.ReadLine();
            while (data != null)
            {
                string[] buf = data.Split();
                Asteroid a = new Asteroid(int.Parse(buf[0]), int.Parse(buf[1]), int.Parse(buf[2]));
                Observatory.Add(a);
                GiveData(a);
                data = Input.ReadLine();
            }
        }
    }
}
