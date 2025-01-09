using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using team.Movement.WheelsParams.BugsyToolsCompany;

namespace team.Movement.WheelsParams
{
    internal class WheelsDeactivateB : WheelsBugsyB, ICommand
    {
        public WheelsDeactivateB(WheelsBugsyB w)
        {
            wheels = w;
        }

        public WheelsBugsyB wheels;
        public void Execute()
        {
            wheels.Deactivate2();
        }

        public void Undo()
        {
            wheels.Activate2();
        }

        public string GetName()
        {
            return "I haven't the ability to move";
        }
    }
}
