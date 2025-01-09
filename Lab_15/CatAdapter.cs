using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab_15
{
    internal class CatAdapter : JSONImportable
    {
        Cat _cat;
        public CatAdapter(Cat cat)
        {
            _cat = cat;
        }
        public string GetJson()
        {
            return "{title: " + _cat.Name + ", Age: " + _cat.Age + "}";
        }
    }
}
