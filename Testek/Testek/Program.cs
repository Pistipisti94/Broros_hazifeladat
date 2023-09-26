using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testek
{
    internal class Program
    {
        static List<Testek> testeks = new List<Testek>();
        static void Main(string[] args)
        {
            testeks.Add(new Kocka(10));
            testeks.Add(new Henger(5, 1.1));
            testeks.Add(new Téglatest(10, 20, 30));

            foreach (var item in testeks)
            {
                Console.WriteLine($"{item} - Felszín: {item.Felszin()} - Térfogat: {item.Terfogat()}");
            }
            Console.WriteLine("Program vége.");
        }
       
    }
}
