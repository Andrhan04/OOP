using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12_first
{
    internal class Asteroid
    {
        public Asteroid(int mass, int speed, int squeare) {
            Mass = mass;
            Speed = speed;
            Squeare = squeare;
        }

        private int _mass;
        public int Mass {
            set { _mass = (value > 0) ? value : 0; }
            get { return _mass; }
        }

        private int _speed;
        public int Speed {
            set { _speed = (value > 0)? value : 0; }
            get { return _speed; }
        }

        private int _square;
        public int Squeare {
            set { _square = (value > 0) ? value : 0; }
            get { return _square; }
        }

        override public string ToString()
        {
            return $"Mass {Mass}; Speed {Speed}; Square {Squeare}";
        }

    }
}
