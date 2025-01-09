using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace team.Movement.WheelsParams.RosentialElectronics
{
    internal class WheelsStopR : WheelsRosentialR, ICommand
    {
        public WheelsStopR(WheelsRosentialR w)
        {
            wheels = w;
        }

        public WheelsRosentialR wheels;
        public void Execute()
        {
            wheels.Stop1();
        }

        public void Undo()
        {
            wheels.Forward1();
        }
        public string GetName()
        {
            return "I'm not going(";
        }
    }
}
