using System;
using System.Diagnostics.SymbolStore;
namespace Uppgift3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vill du hyra vår bil?");
            string svar = Console.ReadLine();
            int timmar = 0;
            if (svar.ToLower()=="ja")
            {
                Console.WriteLine("Hur många timmar vill du hyra bilen?");
                timmar = int.Parse(Console.ReadLine());
            }
            else if (svar.ToLower() == "nej")
            {
                Console.WriteLine("Okej, tack för att du kollade!");
                return;
            }
            else
            {
                Console.WriteLine("Ogiltigt svar. Vänligen svara med 'ja' eller 'nej'.");
                return;
            }
            int totalKostnad = timmar * 80;
            if (totalKostnad > 950)
            {
                Console.WriteLine("Den maximala hyran per dag är 950 kr.");
            }
            else
            {
                Console.WriteLine($"Total kostnad: {totalKostnad} kr");
            }
        }
    }
}
