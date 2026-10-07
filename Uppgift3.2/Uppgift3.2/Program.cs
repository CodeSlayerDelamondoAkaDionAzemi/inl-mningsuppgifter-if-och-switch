using System;
using System.ComponentModel.Design;
namespace Uppgift3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej, har du tagit studenten?");
            string svar = Console.ReadLine();
            if (svar.ToLower() == "ja") 
            Console.WriteLine("Bra och nu hur gammal är du?");
            else if (svar.ToLower() == "nej")
            {
                Console.WriteLine("Tyvärr, vi letar efter andra kandidater");
                return;
            }
            else
            {
                Console.WriteLine("Ogiltigt svar, vänligen svara med 'ja' eller 'nej'");
                return;
            }
            int svar2 = int.Parse(Console.ReadLine());
            if (svar2 >=18 && svar2 <=22)
            {
                Console.WriteLine("Vi vill gärna anställa dig");
            }
            else
            {
                Console.WriteLine("Vi letar tyvärr efter andra kandidater");
            }
        }
    }

    
}

