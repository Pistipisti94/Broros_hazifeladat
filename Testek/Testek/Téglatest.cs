using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testek
{
    internal class Téglatest : Testek
    {
        double Aparameter;
        double Bparameter;
        double Cparameter;

        public Téglatest(double egy, double ketto, double harom) : base("Téglatest", egy, ketto, harom)
        {
            this.Aparameter = egy;
            this.Bparameter = ketto;
            this.Cparameter = harom;
        }

        public override double Felszin()
        {
            return 2 * (Aparameter * Bparameter + Bparameter * Cparameter + Cparameter * Aparameter);
        }

        public override double Terfogat()
        {
            return Aparameter * Bparameter * Cparameter;
        }
    }
}
