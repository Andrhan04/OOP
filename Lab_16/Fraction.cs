using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_15
{
    internal class Fraction
    {
        int _numerator;
        int _denominator;
        public int Numerator {
            get { return _numerator; }
            set {
                _numerator = value;
            }
        }
        public int Denominator
        {
            get { return _denominator; }
            set
            {
                if (value == 0) { _denominator = 1; }
                else { _denominator = value; }
            }
        }
        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }
        public static Fraction operator +(Fraction a, Fraction b)
        {
            return new Fraction(a.Numerator * b.Denominator + b.Numerator * a.Numerator, a.Denominator *b.Denominator);
        }

        int gcd(int a, int b) {
            while(b != 0)
            {
                int c = b;
                b = a % b;
                a = c;
            }
            return a;
        }
        public void Simple()
        {
           
            int gcd_num = gcd(Numerator, Denominator);
            Numerator /= gcd_num;
            Denominator /= gcd_num;
        }
        public string Print()
        {
            return "Numerator: " + Numerator + ", Denominator: " + Denominator;
        }
            
    }
}
