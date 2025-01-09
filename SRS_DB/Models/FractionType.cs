using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS_DB.Models
{
    internal class FractionType:DomainObject
    {        
        public string fraction_type_name;
        public string fraction_type_description;

        public FractionType(int id, string fraction_type_name, string fraction_type_description) : base(new List<string>() { id.ToString(), fraction_type_name, fraction_type_description })
        {}
        public FractionType(List<string> _params) : base(_params) { }

        protected override void LoadObject(List<string> _params)
        {
            fraction_type_name = _params[1];
            fraction_type_description = _params[2];
        }

        public override List<string> GetColums()
        {
            return new List<string> {"fraction_type_name", "fraction_type_description"};
        }

        public override List<string> GetValues()
        {
            return new List<string> { "'" + fraction_type_name + "'", "'" + fraction_type_description + "'" };
        }
    }
}
