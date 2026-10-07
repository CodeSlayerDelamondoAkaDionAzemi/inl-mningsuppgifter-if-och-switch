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
            if (operation == "1")
            {
                summa = tal1 + tal2;
            }
            else if (operation == "2")
            {
                summa = tal1 - tal2;
            }
            else if (operation == "3")
            {
                summa = tal1 * tal2;
            }
            else if (operation == "4")
            {
                summa = tal1 / tal2;
            }
            Console.WriteLine("Resultat: " + summa);
        }
    }
}
