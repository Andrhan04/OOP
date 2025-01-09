using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace team.Senses.EchoSounderParams
{
    internal class EchoDeactivate : EchoSounder
    {
        public EchoDeactivate(EchoSounder e)
        {
            echo = e;
        }

        public EchoSounder echo;
        public void Execute()
        {
            echo.Deactivate();
        }
        public void Undo()
        {
            echo.Activate();
        }

        public string GetName()
        {
            return "I don't see you";
        }
    }
}
