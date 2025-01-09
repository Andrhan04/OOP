using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace team.Enabling
{
    internal class TurnOn : Enable, ICommand
    {
        public TurnOn(Enable e)
        {
            en = e;
        }

        public Enable en;
        public void Execute()
        {
            en.Activate();
        }

        public void Undo()
        {
            en.Deactivate();
        }

        public string GetName()
        {
            return "I'm switching on";
        }
    }
}
