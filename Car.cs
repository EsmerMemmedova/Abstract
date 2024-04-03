using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class Car : Vehicle
    {
        public string Brand { get;  }
        public string Model { get; }
        private int _maxSpeed;
        public int MaxSpeed
        {
            get { return _maxSpeed; }
            set { _maxSpeed = value; }
        }

        public Car(string brand, string model, int year) : base(year)
        {
            Brand = brand;
            Model = model;
        }
        public override void Showinfo()
        {
            Console.WriteLine($"Car:{Brand} {Model},Year:{Year},Color:{Color},MaxSpeed:{MaxSpeed}");
        }
    }
}
