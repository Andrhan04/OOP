using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Lab_16
{
    internal class Alarm
    {
        private int _minutes;
        private int _hours;
        private int _ringMinute;
        private int _ringHour;
        private string _sound;
        public int RingMinute
        {
            set
            {
                if (value >= 0 && value < 60)
                {
                    _ringMinute = value;
                }
                else
                {
                    _ringMinute = 0;
                    Console.WriteLine($"Не корректно - минуты будильника, значение задано 0\n");
                }
            }
            get
            {
                return _ringMinute;
            }
        }
        public int RingHour
        {
            set
            {
                if (value >= 0 && value < 24)
                {
                    _ringHour = value;
                }
                else
                {
                    _ringHour = 0;
                    Console.WriteLine($"Не корректно - часы будильника, значение задано 0\n");
                }
            }
            get
            {
                return _ringHour;
            }
        }

        public int Minutes {
            set{
                if (value >= 0 && value < 60){
                    _minutes = value;
                }
                else
                {
                    _minutes = 0;
                    Console.WriteLine($"Не корректно - минуты, значение задано 0\n");
                }
            }
            get
            {
                return _minutes;
            } 
        }
        public int Hours
        {
            set
            {
                if (value >= 0 && value < 24)
                {
                    _hours = value;
                }
                else
                {
                    _hours = 0;
                    Console.WriteLine($"Не корректно - часы, значение задано 0\n");
                }
            }
            get
            {
                return _hours;
            }
        }

        public Alarm(int H, int M)
        {
            RingMinute = M;
            RingHour = H;
            _sound = "Ring";
        }
        public Alarm(int H,int M,string S)
        {
            RingMinute = M;
            RingHour = H;
            _sound = S;
        }
        public string Ring()
        {
            return _sound;
        }
        public override string ToString(){
            return ($"Будильник {RingHour} часов, {RingMinute} минут"); ;
        }
        public string Check()
        {
            if (RingHour == Hours && Minutes == RingMinute)
            {
                return Ring();
            }
            int Min, H = 0;
            if (RingMinute < Minutes)
            {
                Min = 60 + (RingMinute - Minutes);
                H--;
            }
            else
            {
                Min = RingMinute - Minutes;
            }
            if (RingHour < Hours)
            {
                H += 23 + RingHour - Hours;
            }
            else
            {
                H += RingHour - Hours;
            }
            if (H < 0)
            {
                H += 23;
            }
            return ($"{H} часов, {Min} минут осталось");
        }
    }
}
