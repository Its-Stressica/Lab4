using System;

namespace Lab4_V7
{
    class Program
    {
        static void Main(string[] args)
        {
            Ferry ferry = new Ferry(2000, 100);
            ferry.PrintInfo();
            Console.WriteLine(" ");


            Frigate frig = new Frigate(1500, 200, 2);
            frig.PrintInfo();
            frig.BOOM();
            Console.WriteLine(" ");


            BigShip cargo = new BigShip(1000, 80);
            cargo.PrintInfo();
            Console.WriteLine(" ");


            Warship war = new Warship(2000, 250, 8);
            war.PrintInfo();
            war.BOOM();
            Console.WriteLine(" ");

            
        }
    }
}
