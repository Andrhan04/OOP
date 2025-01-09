using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace team.Movement.WheelsParams.RosentialElectronics
{
    internal class WheelsForwardR : WheelsRosentialR
    {
        public WheelsForwardR(WheelsRosentialR w)
        {
            wheels = w;
        }

        public WheelsRosentialR wheels;

        public void Execute()
        {
            wheels.Forward1();
        }

        public void Undo()
        {
            wheels.Back1();
        }

        public string GetName()
        {
            return "I'm going forward!";
        }
    }
}
