using Lab_13.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13.Substances
{
    abstract class Substance
    {

        protected string _name;
        protected string _base;
        abstract public string Name { get; set; }
        abstract public string Base
        {
            get;
            set;
        }
        public Substance() {}

        public override string ToString()
        {
            return Name;
        }
    }
}
