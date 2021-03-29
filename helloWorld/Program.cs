using System;
    
namespace helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Today it's " + DateTime.Now.ToString() + " But what day is it?");

            if (Console.ReadLine() == "Monday")
            {
                Console.WriteLine("Alrighty then! Time for some monday tunes!");
            } else if (Console.ReadLine() == "Tuesday")
            {
                Console.WriteLine("Club going up! On a ...");
            } else if (Console.ReadLine() == "Wednesday")
            {
                Console.WriteLine("Midweek vibes!");
            } else if (Console.ReadLine() == "Thursday")
            {
                Console.WriteLine("The third day");
            } else if (Console.ReadLine() == "Friday")
            {
                Console.WriteLine("TGIF");
            }

        }
    }
}
