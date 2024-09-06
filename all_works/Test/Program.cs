using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Xml.Linq;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var knight = new Knight("Вася", 100, 10);

            using (var sw = new StreamWriter("C:\\Users\\Я\\Desktop\\Test", false))
            {
                sw.WriteLine($"Меня зовут {knight.Name}\nУ меня {knight.HP} хп\nУ меня {knight.DMG} урона");
            }

            using (var sr = new StreamReader("C:\\Users\\Я\\Desktop\\Test"))
            {
                var text = sr.ReadToEnd();
                Console.Write(text);
            }
        }
    }
}
