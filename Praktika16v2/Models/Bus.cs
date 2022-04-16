using System;
using System.Collections.Generic;
using System.Text;

namespace Praktika16v2.Models
{
    class Bus : Vehicle
    {
        private int _passengerCount;
        private string _color;
        private int _year;
        public int PassengerCount
        {
            get => _passengerCount;
            set { if (value > 0 && value < 60) _passengerCount = value; }
        }
        public override string Color
        {
            get => _color;
            set { if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) _color = value; }
        }
    
        public override int Year
        {
            get => _year;
            set { if (value > 0) _year = value; }
        }

        public Bus(int passengerCount)
        {
            PassengerCount = passengerCount;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($@"Color -->{Color},
Year -->{Year}
Passenger count -->{PassengerCount}");
        }
    }
}
