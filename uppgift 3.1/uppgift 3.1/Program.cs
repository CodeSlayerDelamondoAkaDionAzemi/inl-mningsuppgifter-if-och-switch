using System;
namespace Uppgift_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");
            int age = int.Parse(Console.ReadLine());
            if (age >=16 && age <=19)
            {
                Console.WriteLine("Du får delta i tävlingen");
            }
            else
            {
                Console.WriteLine("Du får inte delta i tävlingen");
            }
        }
    }
}
