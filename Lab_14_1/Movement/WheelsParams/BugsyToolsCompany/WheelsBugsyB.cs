using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using team.Company;

namespace team.Movement.WheelsParams.BugsyToolsCompany
{
    internal class WheelsBugsyB : BugsyTools
    {
        public void Activate2()
        {
            Console.WriteLine("I'm walking again!!!2");
        }

        public void Deactivate2()
        {
            Console.WriteLine("I CAN'T MOVING!!!2");
        }

        public void Left2()
        {
            Console.WriteLine("Turning left2");
        }

        public void Right2()
        {
            Console.WriteLine("Turning right2");
        }

        public void Forward2()
        {
            Console.WriteLine("Moving forward2");
        }

        public void Back2()
        {
            Console.WriteLine("Moving backward2");
        }

        public void Stop2()
        {
        }
    }
}
