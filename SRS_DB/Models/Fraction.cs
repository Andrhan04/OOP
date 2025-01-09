using SRS_DB.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS_DB.Models
{
    internal class Fraction:DomainObject
    {
       
        int _numerator;
        int _denominator;
        int _fraction_type_id;
        FractionType _fractionType;
        public int numerator
        {
            get { return _numerator; }
            set
            {
                _numerator = value;
            }
        }
        public int denominator
        {
            get { return _denominator; }
            set
            {
                if (value == 0) { _denominator = 1; }
                else { _denominator = value; }
            }
        }
        public int fraction_type_id
        {
            get
            {
                if (_fraction_type_id > 0)
                {
                    Console.WriteLine("Берем из базы");
                    Mapper FTM = new Mapper("fraction_type");
                    _fractionType = (FractionType)FTM.Find(_fraction_type_id);
                }
                else
                {
                    if (Id != 0)
                    {
                        throw new Exception("Не могу загрузить объект");
                    }
                    else
                    {
                        _fractionType = null;
                    }
                }
                return _fraction_type_id;
            }
            set
            {
                _fraction_type_id = value;
            }
        }
        public FractionType fractionType
        {
            get {
                int get = fraction_type_id;
                return _fractionType; 
            }
        }
        public Fraction(List<string> _params) : base(_params) { }

        public Fraction(int id, int numerator, int denominator, int FracionTypeId):base(new List<string>() { id.ToString(), numerator.ToString(), denominator.ToString(), FracionTypeId.ToString()})
        {
        }
        protected override void LoadObject(List<string> _params)
        {
            numerator = Convert.ToInt32(_params[1]);
            denominator = Convert.ToInt32(_params[2]);
            fraction_type_id = Convert.ToInt32(_params[3]);
        }

        public override List<string> GetColums()
        {
            return new List<string>() { "numerator", "denominator", "fraction_type_id" };
        }

        public override List<string> GetValues()
        {
            return new List<string>() { "'" + numerator.ToString() + "'", "'" + denominator.ToString() + "'", "'" +  fraction_type_id.ToString() + "'" };
        }
    }
}
