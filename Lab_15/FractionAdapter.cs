using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab_15
{
    internal class FractionAdapter : JSONImportable
    {
        Fraction _fraction;
        public FractionAdapter (Fraction fraction)
        {
            _fraction = fraction;
        }
        public string GetJson()
        {
            return "{title: " + _fraction.Name + ", Numerator: " + _fraction.Numerator + ", Denominator: " +  _fraction.Denominator + "}";
        }
    }
}
