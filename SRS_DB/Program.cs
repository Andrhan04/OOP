using SRS_DB.Mappers;
using SRS_DB.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SRS_DB
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            Mapper mapper_fracion = new Mapper("fraction");
           
            List<DomainObject> allFracions = mapper_fracion.GetAll();

            Console.WriteLine("--------------------------------------------------");
            Fraction fraction = (Fraction)allFracions[0];

            Console.WriteLine(fraction.numerator + " " + fraction.denominator + " " + fraction.fraction_type_id);            

            Console.ReadKey();
        }
    }
}
