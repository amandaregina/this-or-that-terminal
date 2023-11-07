using System;
using System.Collections.Generic;


namespace ThisOrThat
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Isso:");
            string thisValue = Console.ReadLine();

            Console.WriteLine("Aquilo:");
            string thatValue = Console.ReadLine();

            string valueReturned = ReturnThisOrThat(thisValue, thatValue);

            Console.WriteLine($"O escolhido foi: {valueReturned}");
        }

        static string ReturnThisOrThat(string value1, string value2)
        {
            Random random = new Random();
            var thisOrThat = new List<string> { value1, value2 };
            return (thisOrThat[random.Next(thisOrThat.Count)]);
        }
    }
}
