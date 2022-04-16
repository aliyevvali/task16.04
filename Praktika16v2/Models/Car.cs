using System;
using System.Collections.Generic;
using System.Text;

namespace Praktika16v2.Models
{
    class Car : Vehicle
    {

        private string _brand;
        private string _model;
        private double _maxSpeed;
        private int _year;
        private string _color;

        public string Brand 
        {
            get => _brand;
            set { if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) _brand = value; }
        }


        public string Model 
        {
            get => _model;
            set { if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) _model = value; }
        }
        public double MaxSpeed 
        {
            get => _maxSpeed;
            set { if (value > 0) _maxSpeed = value; }
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

        public Car(string brand,string model)
        {
            Brand = brand;
            Model = model;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($@"Brand -->{Brand}
Model -->{Model}
Max speed -->{MaxSpeed}
Color -->{Color}
Year -->{Year}");
        }
    }
}
