using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using team.Movement.WheelsParams;
using team.Movement.WheelsParams.RosentialElectronics;
using team.Senses.EchoSounderParams;

namespace team.Movement
{
    internal class MovementOnEcho : ICommand
    {
        public MovementOnEcho(EchoSounder e, WheelsForwardB w_f, WheelsBackB w_b)
        {
            echo = e;
            wheels_f = w_f;
            wheels_b = w_b;
        }

        public EchoSounder echo;
        public WheelsForwardB wheels_f;
        public WheelsBackB wheels_b;

        public void Execute()
        {
            double dist = echo.CheckDouble();

            if (dist > 10)
            {
                Console.WriteLine("Moving forward by 10 units...");
            }
            else
            {
                Console.WriteLine("Moving back by 5 units...");
            }
        }
        public void Undo() { }

        public string GetName()
        {
            return "I have a super smart motion system.";
        }
    }
}
