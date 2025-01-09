using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace team
{
    internal class NoCommand : ICommand
    {
        public void Execute() {
            Console.WriteLine("I either don't know what to do or I'm not capable");
        }
        public void Undo() 
        {
            Console.WriteLine("I either don't know what to do or I'm not capable");
        }
        public string GetName() => "No command";
    }
}
