using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace team.Movement.WheelsParams.RosentialElectronics
{
    internal class WheelsToRightR : WheelsRosentialR, ICommand
    {
        public WheelsToRightR(WheelsRosentialR w)
        {
            wheels = w;
        }

        public WheelsRosentialR wheels;

        public void Execute()
        {
            wheels.Right1();
        }

        public void Undo()
        {
            wheels.Left1();
        }

        public string GetName()
        {
            return "I'm going right!";
        }
    }
}
