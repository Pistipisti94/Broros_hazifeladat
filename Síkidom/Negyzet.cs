using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Síkidom
{
    internal class Negyzet : Síkidom
    {
        public Negyzet(int aoldal, int boldal, int terulet, int kerulet) : base("Négyzet", "4", aoldal, boldal, terulet, kerulet)
        {
        }
    }
}
