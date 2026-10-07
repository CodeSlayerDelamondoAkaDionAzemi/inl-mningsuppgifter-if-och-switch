using System;
namespace Uppgift3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in två tal snälla NU!");
            double tal1 = double.Parse(Console.ReadLine());
            double tal2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Välj ett räknesätt");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Multiplikation");
            Console.WriteLine("4. Division");

            string operation = Console.ReadLine();

            double summa = 0;
            switch (operation)
            {
                case "1":
                    summa = tal1 + tal2;
                    break;
                case "2":
                    summa = tal1 - tal2;
                    break;
                case "3":
                    summa = tal1 * tal2;
                    break;
                case "4":
                    summa = tal1 / tal2;
                    break;
                default:
                    Console.WriteLine("Ogiltigt räknesätt");
                    break;
            }
            Console.WriteLine("Resultat: " + summa);
        }
    }
}
