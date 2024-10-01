using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12_first.Listeners
{
    abstract class Listener
    {
        public abstract void Take(Asteroid a);
        public abstract void MyData();
    }
}
