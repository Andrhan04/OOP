using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace team.Senses.EchoSounderParams
{
    internal class EchoSounder
    {
        public void Check()
        {
            Random random = new Random();
            double randomNumber = Math.Round(random.NextDouble() * 30, 1);

            Console.WriteLine("The distance to something = " + randomNumber);
        }

        public double CheckDouble()
        {
            Random random = new Random();
            double randomNumber = Math.Round(random.NextDouble() * 30, 1);

            return randomNumber;
        }

        public void Activate()
        {
            Console.WriteLine("I see it again!!!");
        }

        public void Deactivate()
        {
            Console.WriteLine("I DON'T SEE!!!");
        }
    }
}
