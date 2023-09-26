using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testek
{
    internal class Kocka : Testek
    {
        double Aparameter;

        public Kocka(double egy) : base("Kocka", egy, 0, 0)
        {
            this.Aparameter = egy;
        }

        public override double Felszin()
        {
            return 6 * Aparameter * Aparameter;
        }

        public override double Terfogat()
        {
            return Aparameter * Aparameter * Aparameter;
        }
    }
}
