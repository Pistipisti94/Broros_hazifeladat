using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Síkidom
{
    internal class Teglalap : Síkidom
    {
        double aoldal;
        double boldal;
        public Teglalap(double elsoparameter, double masodikparameter) : base("Téglalap", 4, elsoparameter, masodikparameter)
        {
            this.aoldal = elsoparameter;
            this.boldal = masodikparameter;
        }

        public override double Terulet()
        {
            return 2 * aoldal + 2 * boldal;
        }
        public override double Kerulet()
        {
            return 2 * (aoldal + boldal);
        }
    }
}
