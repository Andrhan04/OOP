using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_13.Substances;


namespace Lab_13.Filters
{
    internal class Hydrogen : Filter
    {
        public Hydrogen(Substance substances) : base(substances)
        {
            Add = " H";
            Name = substances.Name;
            Base = substances.Base;
        }

        public override string Base
        {
            get { return _base; }
            set { _base = value; }
        }

        public override string Name { 
            get { return _name; }
            set { _name += value + Add; }
        }
        public override string ToString()
        {
            return Name + "\n \t Base " + Base;
        }
    }
}
