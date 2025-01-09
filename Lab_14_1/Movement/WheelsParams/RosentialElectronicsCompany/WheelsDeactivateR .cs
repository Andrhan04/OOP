using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace team.Movement.WheelsParams.RosentialElectronics
{
    internal class WheelsDeactivateR : WheelsRosentialR, ICommand
    {
        public WheelsDeactivateR(WheelsRosentialR w)
        {
            wheels = w;
        }

        public WheelsRosentialR wheels;
        public void Execute()
        {
            wheels.Deactivate1();
        }

        public void Undo()
        {
            wheels.Activate1();
        }

        public string GetName()
        {
            return "I haven't the ability to move";
        }
    }
}
