using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using team.Movement.WheelsParams.BugsyToolsCompany;

namespace team.Movement.WheelsParams
{
    internal class WheelsActivateB : WheelsBugsyB, ICommand
    {
        public WheelsActivateB(WheelsBugsyB w)
        {
            wheels = w;
        }

        public WheelsBugsyB wheels;
        public void Execute()
        {
            wheels.Activate2();
        }

        public void Undo()
        {
            wheels.Deactivate2();
        }
        public string GetName()
        {
            return "I have the ability to move";
        }
    }
}
