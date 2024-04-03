using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public abstract class Vehicle
    {
        public string Color { get; set; }
        public int Year { get; }

        public Vehicle(int year) 
        {
            Year=year;
        }
        public abstract void Showinfo();
    }

}
