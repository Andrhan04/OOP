using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using team.Movement.WheelsParams;

namespace team.Senses.EchoSounderParams
{
    internal class EchoCheck : EchoSounder
    {
        public EchoCheck(EchoSounder e)
        {
            echo = e;
        }

        public EchoSounder echo;
        public void Execute()
        {
            echo.Check();
        }
        public void Undo() { }
        public string GetName()
        {
            return "I see everything";
        }
    }
}
