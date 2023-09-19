using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Síkidom
{
    abstract class Síkidom
    {
        public string neve;
        public int szogekszama;
        public double elsoparameter;
        public double masodikparameter;
        

        public override string ToString()
        {
            return this.neve;
        }
        abstract public double Terulet();
        abstract public double Kerulet();

        public Síkidom(string neve, int szogekszama, double elsoparameter, double masodikparameter)
        {
            this.neve = neve;
            this.szogekszama = szogekszama;
            this.elsoparameter = elsoparameter;
            this.masodikparameter = masodikparameter;
        }
    }
}
