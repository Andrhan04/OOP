using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12_first.Listeners
{
    internal class Club : Listener
    {
        private List<List<int>> asteroid = new List<List<int>>();
        public override void MyData()
        {
            Console.WriteLine(GetType());
            int i = 0;
            foreach (var item in asteroid)
            {
                Console.WriteLine($"{++i}) INFO {item[0]}, {item[1]}");
            }
        }
        public override void Take(Asteroid a)
        {
            asteroid.Add(new List<int> { a.Mass, a.Speed });
        }
        public override void Clear()
        {
            asteroid = new List<List<int>>();
        }
    }
}
