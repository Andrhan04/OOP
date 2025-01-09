using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace team
{
    internal class MacroCommands : ICommand
    {
        public MacroCommands(ICommand[] com) 
        {
            commands = com;
        }

        ICommand[] commands;

        public void Execute() 
        {
            for (int i = 0; i < commands.Length; i++) 
            {
                commands[i].Execute();
            }
        }

        public void Undo()
        {
            for (int i = 0; i < commands.Length; i++)
            {
                commands[i].Undo();
            }
        }

        public string GetName()
        {
            return "Use macros";
        }
    }
}
