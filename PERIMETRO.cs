using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AREAS
{
    public class PERIMETRO
    {
        public double P;
        public double CalcularPerimetro(double a, double b)
        {
            P = (a*b)*2;
            Console.WriteLine("PERIMETRO : " + P);
            return P;
        }
    }
}
