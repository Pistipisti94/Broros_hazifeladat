using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Síkidom
{
    internal class Kor : Síkidom
    {
        double sugar;
        public Kor(double elsoparameter) : base("Kör", 0, elsoparameter, 0)
        {
            this.sugar = elsoparameter;
        }
        public override double Terulet()
        {
            return 2 * this.sugar * Math.PI;
        }
        public override double Kerulet()
        {
            return 2 * Math.PI * this.sugar;
        }

    }
}
