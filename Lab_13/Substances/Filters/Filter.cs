using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_13.Substances;

namespace Lab_13.Filters
{
    abstract class Filter : Substance
    {
        public Filter(Substance substance)
        {
            Add = "";
            Name = "";
            Base = "";
        }

        private string _add;
        public string Add
        {
            get { return _add; }
            set { _add = value; }
        }
    }
}
