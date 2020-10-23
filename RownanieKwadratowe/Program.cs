using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RownanieKwadratowe
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                double pierwiastekdelta, a, b, c, x1, x2, x0, delta;

                Console.WriteLine("Podaj a");
                a = Convert.ToInt32(Console.ReadLine());
                if (a == 0) throw new Exception("Proszę podać a <> 0");
                
                
                
                Console.WriteLine("Podaj b");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Podaj c");
                c = Convert.ToInt32(Console.ReadLine());

                delta = (b * b) - (4 * a * c);

                pierwiastekdelta = Math.Sqrt(delta);

                if (delta > 0)
                {
                    x1 = (-b + pierwiastekdelta) / (2 * a);
                    x2 = (-b - pierwiastekdelta) / (2 * a);
                    Console.WriteLine("x1 = {0}, x2 = {1}", x1, x2);
                }

                else

                    if (delta == 0)
                {
                    x0 = -b / (2 * a);
                    Console.WriteLine("x0 = {0}", x0);
                }

                else
                {

                    Console.WriteLine("Rownanie sprzeczne");

                }
            }
            catch (Exception uchwyt)
            {

                // throw;
                Console.WriteLine(uchwyt.Message);
            }
            Console.ReadKey();

        }
    }
}
