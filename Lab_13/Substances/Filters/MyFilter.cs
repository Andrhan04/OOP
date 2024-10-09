using Lab_13.Substances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13.Filters
{
    internal class MyFilter : Filter
    {
        public MyFilter(Substance substance) : base(substance)
        {
            Name = substance.Name;
            Base = substance.Base;
        }

        public override string Name
        {
            get { return _name; }
            set {
                _name = "";
                foreach (var i in value)
                {
                    if (i != 'O' && i != ' ')
                    {
                        _name += i + " ";
                    }
                }
            }
        }
        public override string Base
        {
            get { return _base; }
            set { _base = value; }
        }

        public override string ToString()
        {
            return Name + "\n \t Base " + Base;
        }
    }
}
