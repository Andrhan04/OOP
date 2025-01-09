using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using team.Senses.EchoSounderParams;

namespace team.Enabling
{
    internal class TurnOff : Enable
    {
        public TurnOff(Enable e)
        {
            en = e;
        }

        public Enable en;
        public void Execute()
        {
            en.Deactivate();
        }

        public void Undo()
        {
            en.Activate();
        }
        public string GetName()
        {
            return "I'm switching off";
        }
    }
}
