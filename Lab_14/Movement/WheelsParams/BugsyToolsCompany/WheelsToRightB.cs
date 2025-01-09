using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using team.Movement.WheelsParams.BugsyToolsCompany;

namespace team.Movement.WheelsParams
{
    internal class WheelsToRightB : WheelsBugsyB, ICommand
    {
        public WheelsToRightB(WheelsBugsyB w)
        {
            wheels = w;
        }

        public WheelsBugsyB wheels;

        public void Execute()
        {
            wheels.Right2();
        }

        public void Undo()
        {
            wheels.Left2();
        }

        public string GetName()
        {
            return "I'm going right!";
        }
    }
}
