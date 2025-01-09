using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS_DB.Models
{
    internal class Cat : DomainObject
    {
        public string name;
        public int age;

        public Cat(int id, string name, int age) : base(new List<string>(){id.ToString(), name, age.ToString()})
        {
        }
        public Cat(List<string> _params) : base(_params) { }

        public override List<string> GetColums()
        {
            return new List<string>() { "name", "age"};
        }

        public override List<string> GetValues()
        {
            return new List<string> { "'" + name + "'" , "'" + age + "'" };
        }

        protected override void LoadObject(List<string> _params)
        {
            name = _params[1];
            age = Convert.ToInt32(_params[2]);
        }
    }
}
