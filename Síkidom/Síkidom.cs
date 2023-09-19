using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Síkidom
{
    internal class Síkidom
    {
        public string neve;
        public string szogekszama;
        public int aoldal;
        public int boldal;
        public int terulet;
        public int kerulet;

        public override string ToString()
        {
            return this.neve;
        }
        public Síkidom(string neve, string szogekszama, int aoldal, int boldal, int terulet, int kerulet)
        {
            this.neve = neve;
            this.szogekszama = szogekszama;
            this.aoldal = aoldal;
            this.boldal = boldal;
            this.terulet = terulet;
            this.kerulet = kerulet;
        }
    }
}
