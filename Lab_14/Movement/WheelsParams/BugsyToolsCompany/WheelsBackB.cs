using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using team.Movement.WheelsParams.BugsyToolsCompany;

namespace team.Movement.WheelsParams
{
    internal class WheelsBackB : WheelsBugsyB, ICommand
    {
        public WheelsBackB(WheelsBugsyB w)
        {
            wheels = w;
        }

        public WheelsBugsyB wheels;

        public void Execute()
        {
            wheels.Back2();
        }

        public void Undo()
        {
            wheels.Forward2();
        }

        public string GetName()
        {
            return "I'm going back!";
        }
    }
}
