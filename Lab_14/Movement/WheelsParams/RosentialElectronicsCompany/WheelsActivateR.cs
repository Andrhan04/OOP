using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace team.Movement.WheelsParams.RosentialElectronics
{
    internal class WheelsActivateR : WheelsRosentialR, ICommand
    {
        public WheelsActivateR(WheelsRosentialR w)
        {
            wheels = w;
        }

        public WheelsRosentialR wheels;
        public void Execute()
        {
            wheels.Activate1();
        }

        public void Undo()
        {
            wheels.Deactivate1();
        }
        public string GetName()
        {
            return "I have the ability to move";
        }
    }
}
