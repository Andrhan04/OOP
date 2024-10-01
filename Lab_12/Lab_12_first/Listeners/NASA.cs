using Lab_12_first.Listeners;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12_first.Recipients
{
    internal class NASA : Listener
    {
        private List<List<int>> asteroid = new List<List<int>>();
        public override void MyData()
        {
            Console.WriteLine(GetType());
            int i = 0;
            foreach (var item in asteroid)
            {
                Console.WriteLine($"{++i}) INFO {item[0]}, {item[1]}, {item[2]}");
            }
        }

        public override void Take(Asteroid a)
        {
            asteroid.Add(new List<int>{a.Mass,a.Speed, a.Squeare });
        }
    }
}
