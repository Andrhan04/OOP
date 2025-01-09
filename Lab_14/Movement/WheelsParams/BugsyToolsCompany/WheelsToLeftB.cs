using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using team.Movement.WheelsParams.BugsyToolsCompany;

namespace team.Movement.WheelsParams
{
    internal class WheelsToLeftB : WheelsBugsyB, ICommand
    {
        public WheelsToLeftB(WheelsBugsyB w)
        {
            wheels = w;
        }

        public WheelsBugsyB wheels;
        public void Execute()
        {
            wheels.Left2();
        }

        public void Undo()
        {
            wheels.Right2();
        }
        public string GetName()
        {
            return "I'm going left!";
        }
    }
}
