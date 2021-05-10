using System;

namespace ViaSat.Strings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    namespace ConsoleApp1
    {
        class Program
        {
            static void Main(string[] args)
            {

                while (true)
                {
                    DoWork();
                }
            }

            public static void DoWork()
            {
                Console.WriteLine("Scrivi una qualunque serie di numeri divisi da un qualunque tipo di separatore e qualunque numero di caratteri.");
                string input = Console.ReadLine();
                decimal result = 0;
                decimal[] numbers = Regex.Matches(input, @"[0-9]{1,}?,{1}?\d+|[0-9]{1,}").Select(x => Convert.ToDecimal(x.Value)).ToArray();

                if (numbers.Where(x => x < 0).Any())
                {
                    Console.WriteLine("negatives not allowed");
                }
                else
                {
                    foreach (decimal item in numbers)
                    {
                        if (item == 0)
                            result += 0;
                        else if (item > 1000)
                            result += 2;
                        else
                            result += Convert.ToDecimal(item);
                    }

                    Console.WriteLine(result);
                }
            }
        }
    }
}
