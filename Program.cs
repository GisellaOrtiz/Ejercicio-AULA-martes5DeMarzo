
using AREAS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO2AULA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creado por : Ortiz Terezon, Gisella Margarita");

            Variables obj1 = new Variables();
            Console.WriteLine("Digite el valor de la ALTURA");
            obj1.SetALTURA(double.Parse(Console.ReadLine()));
            Console.WriteLine("Digite el valor de la BASE");
            obj1.SetBASE(double.Parse(Console.ReadLine()));

            PERIMETRO obj2 = new PERIMETRO();
            obj2.CalcularPerimetro(obj1.GetALTURA(),obj1.GetBASE());
            Console.ReadKey();

       
        }
    }
}
