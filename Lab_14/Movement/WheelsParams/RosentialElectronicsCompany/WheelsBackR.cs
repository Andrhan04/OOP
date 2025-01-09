using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace team.Movement.WheelsParams.RosentialElectronics
{
    internal class WheelsBackR : WheelsRosentialR
    {
        public WheelsBackR(WheelsRosentialR w)
        {
            wheels = w;
        }

        public WheelsRosentialR wheels;

        public void Execute()
        {
            wheels.Back1();
        }

        public void Undo()
        {
            wheels.Forward1();
        }

        public string GetName()
        {
            return "I'm going back!";
        }
    }
}
