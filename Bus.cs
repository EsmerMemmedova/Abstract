using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public  class Bus : Vehicle
    {
        private int _passengerCount;
        //public int PessengerCount;
        public int PassengerCount
        {
            get 
            { return 
                    _passengerCount;
            }
            set { 
                _passengerCount = value;
            }
        }

       
        public Bus(int passengerCount, int year) : base(year)
        {
            PassengerCount = passengerCount;
        }

        public override void Showinfo()
        {
            Console.WriteLine($"Bus:Pessengercount:{PassengerCount},Color:{Color},Year:{Year}");
        }
    }
}
