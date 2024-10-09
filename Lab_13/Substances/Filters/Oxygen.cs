using Lab_13.Substances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13.Filters
{
    internal class Oxygen : Filter
    {
        public Oxygen(Substance substance):base(substance)
        {
            Add = " O";
            Name = substance.Name;
            Base = substance.Base;
        }

        public override string Base
        {
            get { return _base; }
            set { _base = value; }
        }

        public override string Name
        {
            get { return _name + Add; }
            set { _name += value; }
        }
        public override string ToString()
        {
            return Name + "\n \t Base " + Base;
        }
    }
}
