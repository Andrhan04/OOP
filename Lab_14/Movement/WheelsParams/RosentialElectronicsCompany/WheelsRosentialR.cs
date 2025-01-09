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
            Console.WriteLine("I'm walking again!!!");
        }

        public void Deactivate1()
        {
            Console.WriteLine("I CAN'T MOVING!!!");
        }

        public void Left1()
        {
            Console.WriteLine("Turning left");
        }

        public void Right1()
        {
            Console.WriteLine("Turning right");
        }

        public void Forward1()
        {
            Console.WriteLine("Moving forward");
        }

        public void Back1()
        {
            Console.WriteLine("Moving backward");
        }

        public void Stop1()
        {
            Console.WriteLine("Not moving");
        }
    }
}
