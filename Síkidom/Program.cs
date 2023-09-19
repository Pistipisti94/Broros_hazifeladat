using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Síkidom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Síkidom> síkidoms = new List<Síkidom>();
            síkidoms.Add(new Negyzet(10));
            síkidoms.Add(new Teglalap(10,2));
            síkidoms.Add(new Kor(5));

            foreach (var item in síkidoms)
            {
                Console.WriteLine($"{item} - {item.Terulet()} - {item.Kerulet()}");
            }

            Console.ReadKey();
        }
    }
}
