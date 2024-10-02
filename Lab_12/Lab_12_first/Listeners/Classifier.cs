using Lab_12_first;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12_first.Listeners
{
    internal class Classifier : Listener
    {
        private List<string> asteroid = new List<string>();
        public override void MyData()
        {
            Console.WriteLine(GetType());
            int i = 0;
            foreach (var item in asteroid)
            {
                Console.WriteLine($"{++i}) INFO {item}");
            }
        }

        public override void Take(Asteroid a)
        {
            if (a.Mass > 200)
            {
                asteroid.Add("Heavy");
            }
            else
            {
                if(a.Speed > 40)
                {
                    asteroid.Add("Fast");
                }
                else
                {
                    asteroid.Add((a.Squeare > 100)?"Big":"Normal");
                }
            }
        }

        public override void Clear()
        {
            asteroid = new List<string>();
        }
    }
}
