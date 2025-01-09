using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using team.Company;

namespace team.Movement.WheelsParams.RosentialElectronics
{
    internal class WheelsRosentialR : RosentalElectronics
    {
        public void Activate1()
        {
            Console.WriteLine("I'm walking again!!!1");
        }

        public void Deactivate1()
        {
            Console.WriteLine("I CAN'T MOVING!!!1");
        }

        public void Left1()
        {
            Console.WriteLine("Turning left1");
        }

        public void Right1()
        {
            Console.WriteLine("Turning right1");
        }

        public void Forward1()
        {
            Console.WriteLine("Moving forward1");
        }

        public void Back1()
        {
            Console.WriteLine("Moving backward1");
        }

        public void Stop1()
        {
            Console.WriteLine("Not moving(1");
        }
    }
}
