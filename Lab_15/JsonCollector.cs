using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_15
{
    internal class JsonCollector
    {
        string path = "JSON";
        public JsonCollector() { }
        public void GetInfo(JSONImportable ji)
        {
            File.AppendAllText(path, ji.GetJson() + '\n');
        }
    }
}
