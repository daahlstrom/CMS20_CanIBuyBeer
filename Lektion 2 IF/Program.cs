using System;
// om ålder > 17 och location == "krogen" och om leg == "J" och om promille < 1.0 JA 
//  om ålder > 19 och location == "systemet"JA och om leg == "J" och om promille < 1.0 JA

namespace Lektion_2_IF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Superduper beer calculator 1.0");
            Console.Write("Hur gammal är du? ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Location (systemet eller krogen) ");
            string location = Console.ReadLine();
            location = location.ToLower();
            Console.Write("Har du legg med dig (J/N)? ");
            string legg = Console.ReadLine();
            Console.Write("Vilken promillehalt har du?: ");
            decimal promille = Convert.ToDecimal(Console.ReadLine());

            bool canIBuyBeer = false;
            if (legg == "J" && promille < 1.0m)
            {
                if (location == "krogen" && age > 15)
                {
                    canIBuyBeer = true;
                }
                else if (location == "systemet" && age > 19)
                {
                    canIBuyBeer = true;
                }
            }
            if (canIBuyBeer)
                Console.WriteLine("Japp du får köpa öl.");
            else
                Console.WriteLine("Nej du får inte köpa öl.");
         
        }
    }
}
