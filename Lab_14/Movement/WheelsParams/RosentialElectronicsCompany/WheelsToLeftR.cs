using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace team.Movement.WheelsParams.RosentialElectronics
{
    internal class WheelsToLeftR : WheelsRosentialR, ICommand
    {
        public WheelsToLeftR(WheelsRosentialR w)
        {
            wheels = w;
        }

        public WheelsRosentialR wheels;
        public void Execute()
        {
            wheels.Left1();
        }

        public void Undo()
        {
            wheels.Right1();
        }
        public string GetName()
        {
            return "I'm going left!";
        }
    }
}
