using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_V7
{
    abstract public class Ship
    {
        public int passengers { get; set; }
        public int capacity { get; set; }

        public Ship(int cap, int pas)
        {
            this.passengers = pas;
            this.capacity = cap;
        }

        public void PrintPassengers()
        {
            Console.WriteLine("Максимальна кількість пасажирів: "+ passengers + " осіб.");
        }

        public void PrintCap()
        {
            Console.WriteLine("Грузопідйомність судна: " + capacity + " тонн.");
        }

        public void PrintInfo()
        {
            Console.WriteLine(this.GetType().Name);
            PrintPassengers();
            PrintCap();
        }


    }

    
}
