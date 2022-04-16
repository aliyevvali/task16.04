using System;
using System.Collections.Generic;
using System.Text;

namespace Praktika16v2.Models
{
    abstract class Vehicle
    {
        public abstract string Color { get; set; }
        public abstract int Year { get; set; }
        public abstract void ShowInfo();

        
    }
}
