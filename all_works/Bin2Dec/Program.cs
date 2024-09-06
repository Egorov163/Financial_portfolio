using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bin2Dec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var numb = new Dictionary<int, string>()
            //{
            //    {0,"00110000" },
            //    {1,"00110001" },
            //    {2,"00110010" },
            //    {3,"00110011" },
            //    {4,"00110100" },
            //    {5,"00110101" },
            //    {6,"00110110" },
            //    {7,"00110111" },
            //    {8,"00111000" }
            //};

            //while (true)
            //{
            //    if (int.TryParse(Console.ReadLine(), out int result))
            //    {
            //        Console.WriteLine(numb[result]);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Попробуй ещё раз");
            //    }
            //}


            const int TheDegreeOfTheNumber = 2;

            var input = int.Parse(Console.ReadLine());
            int sum = 0;

            for (; input > 0;)
            {
                input = input / 10;
                
                sum += input;

                Console.WriteLine(sum);
            }

            //в степени
            //Console.WriteLine(Math.Pow(input, TheDegreeOfTheNumber));

        }
    }
}
