﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Class_Library
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }

        public Car()
        {
            Make = "nothing yet";
            Model = "nothing yet";
            Price = 0.00M;
        }

        public Car(string a, string b, decimal c)
        {
            Make = a;
            Model = b;
            Price = c;
        }

        override public string ToString()
        {
            return "Make:" + Make + " Model " + Model + " Price: $" + Price; 
        }

    }
}
