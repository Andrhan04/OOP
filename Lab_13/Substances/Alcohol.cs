using Lab_13.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13.Substances
{
    internal class Alcohol : Substance
    {
        public Alcohol() : base()
        {
            Name = "C C H H H H H O H";
        }

        override public string Name
        {
            get
            {
                return _name;
            }
            set { _name = "C C H H H H H O H"; }
        }

        public override string Base {
            get { return "C C H H H H H O H"; }
            set { _base = "C C H H H H H O H"; }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
