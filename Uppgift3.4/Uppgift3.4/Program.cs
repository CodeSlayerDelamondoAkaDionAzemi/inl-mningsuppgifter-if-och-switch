using System;
namespace Uppgift3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många minuter är din favorit låt?");
            int minutes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hur många sekunder är din favorit låt?");
            int seconds = Convert.ToInt32(Console.ReadLine());
            int totalSeconds = minutes * 60 + seconds;
            if (totalSeconds >= 165 && totalSeconds <= 260)
            {
                Console.WriteLine("Din favorit låt får spelas i radio stationen.");
            }
            else
            {
                Console.WriteLine("Din favorit låt får tyvärr inte spelas i radio stationen.");


            }
        }
    }
}
