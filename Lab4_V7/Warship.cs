using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_V7
{
    public class Warship : Ship
    {
        public int NumOfWeapons { get; set; }

        public Warship(int cap, int pas, int NumOfWeapons) :base (cap, pas)
        {
            this.NumOfWeapons = NumOfWeapons;
        }

        public virtual void BOOM()
        {
            Console.WriteLine("Вистрілило " + NumOfWeapons + " гармат");
        }

        public void PrintNumOfWeap()
        {
            Console.WriteLine("Судно має " + NumOfWeapons + " гармат.");
        }

        public new void PrintInfo()
        {
            base.PrintInfo();
            PrintNumOfWeap();
        }

    }

    


}
