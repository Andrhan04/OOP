using Lab_15;
using Lab_16;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_16
{
    internal class ConsoleWorker
    {
        Alarm _alarm = null;
        public void CreateObject()
        {
            if (_alarm != null)
            {
                Console.WriteLine("Объект уже создан");
            }
            else
            {
                Console.WriteLine("Введите часы");
                int hour  = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите минуты");
                int min = int.Parse(Console.ReadLine());
                _alarm = new Alarm(hour, min);
            }


        }
        public void PrintObject()
        {
            if (_alarm != null)
            {
                Console.WriteLine(_alarm);
            }
            else
            {
                Console.WriteLine("Объект ещё не создан");
            }
        }
        public void EraseObject()
        {
            if (_alarm != null)
            {
                _alarm = null;
                Console.WriteLine("Объект успешно стерт");
            }
            else
            {
                Console.WriteLine("Объект ещё не создан");
            }
        }
        public void PrintMenu()
        {
            Console.WriteLine("1. Создать объект класса\r\n2. Вывести объект класса \r\n3. Стереть объект \n");
            
            string line = Console.ReadLine();
            int operation;
            if (int.TryParse(line, out operation))
            {
                if (operation == 1)
                {
                    CreateObject();
                }
                else if (operation == 2)
                {
                    PrintObject();
                }
                else if (operation == 3)
                {
                    EraseObject();
                }
                else
                {
                    Console.WriteLine("Неверная команда");
                }
                PrintMenu();
            }            
        }

    }
}
