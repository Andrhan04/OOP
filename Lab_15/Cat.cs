using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_15
{
    internal class Cat 
    {
        string _name = "default";
        int _age = 0;
        public string Name { get { return _name; } set { _name = value; } }
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0)
                {
                    _age = 0;
                }
                else if(value > 30)
                {
                    _age = 30;
                }
                else 
                {
                    _age = value;
                }
            }
        }
        public Cat(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
