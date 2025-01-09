using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace team
{
    internal class RemoteController
    {
        private const int _counter = 8;
        public RemoteController()
        {
            onCommands = new ICommand[_counter];

            ICommand noCommand = new NoCommand();
            for (int i = 0; i < _counter; i++)
            {
                onCommands[i] = noCommand;
            }
        }

        ICommand[] onCommands;

        public void setCommand(int slot, ICommand on_com)
        {
            onCommands[slot] = on_com;
        }

        public void onButtonWasPushed(int slot)
        {
            onCommands[slot].Execute();
        }

        public void offButtonWasPushed(int slot)
        {
            onCommands[slot].Undo();
        }

        public string showCommand()
        {
            string buf = "\n ---------- Remote Controller ---------- \n";

            for (int i = 0; i < onCommands.Length; i++)
            {
                buf += $"[slot] {i}     {onCommands[i].GetName()} \n";
            }

            return buf;
        }
    }
}
