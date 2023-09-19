using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Síkidom
{
    internal class Negyzet : Síkidom
    {
        double aoldal;
        public Negyzet(double elsoparameter) : base("Négyzet", 4, elsoparameter,0)
        {
            this.aoldal = elsoparameter;
        }

        public override double Terulet()
        {
            return aoldal * aoldal;
        }
        public override double Kerulet()
        {
            return 4 * aoldal;
        }
    }
}
