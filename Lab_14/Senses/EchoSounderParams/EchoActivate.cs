using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace team.Senses.EchoSounderParams
{
    internal class EchoActivate : EchoSounder
    {
        public EchoActivate(EchoSounder e)
        {
            echo = e;
        }

        public EchoSounder echo;
        public void Execute()
        {
            echo.Activate();
        }
        public void Undo()
        {
            echo.Deactivate();
        }

        public string GetName()
        {
            return "I see you";
        }
    }
}
