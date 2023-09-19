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
            síkidoms.Add(new Negyzet(4,0,4,2));
            síkidoms.Add(new Teglalap());
            síkidoms.Add(new Kor());

            foreach (var item in síkidoms)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
