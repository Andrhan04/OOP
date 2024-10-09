using Lab_13.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13.Substances
{
    internal class Water : Substance
    {
        public Water() : base()
        {
            Name = "H H O";
            Base = "H H O";
        }
        public override string Base
        {
            get { return "H H O"; }
            set { _base = "H H O"; }
        }
        override public string Name
        {
            get
            {
                string ans = _name;
                return ans;
            }
            set { _name = "H H O"; }
        }

        public override string ToString()
        {
            return Name;
        }

    }
}
