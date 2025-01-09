using Lab_15;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_16
{
    internal class ConsoleWorker
    {
        Fraction _fraction;
        public void CreateObject()
        {
            if (_fraction != null)
            {
                Console.WriteLine("Объект уже создан");
            }
            else
            {
                Console.WriteLine("Введите числитель и знаменатель");
                int numerator  = Int32.Parse(Console.ReadLine());
                int denominator = Int32.Parse(Console.ReadLine());
                _fraction = new Fraction(numerator, denominator);
            }


        }
        public void PrintObject()
        {
            if (_fraction != null)
            {
                Console.WriteLine(_fraction.Print());
            }
            else
            {
                Console.WriteLine("Объект ещё не создан");
            }
        }
        public void EraseObject()
        {
            if (_fraction != null)
            {
                _fraction = null;
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
            if (Int32.TryParse(line, out operation))
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
