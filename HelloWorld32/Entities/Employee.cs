﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld32.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHours { get; set; }

        public Employee()
        {
        }

        public Employee(string name, int hours, double valuePerHours)
        {
            Name = name;
            Hours = hours;
            ValuePerHours = valuePerHours;
        }

        public virtual double Payment() // 'virtual' permite que o método seja sobrescrito.
        {
            return Hours * ValuePerHours;
        }

    }
}
