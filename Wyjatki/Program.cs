using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyjatki
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int X = 10;
                int Y = Convert.ToInt32(Console.ReadLine());
                int wynik = X / Y;
            }
            catch (DivideByZeroException uchwyt)
            {

                // throw;
                Console.WriteLine(uchwyt.Message);
            }

            catch (Exception uchwyt)
            
            {
                Console.WriteLine(uchwyt.Message);
            
            }

            finally
            {

                Console.WriteLine("Program rusza dalej");
                try
                {
                    double dzielnik, iloraz;
                    dzielnik = Convert.ToDouble(Console.ReadLine());
                    if (dzielnik == 0)
                        throw new DivideByZeroException("Dzielnik nie może mieć wartość zero!!!");
                    iloraz = 10.2 / dzielnik; Console.WriteLine(iloraz);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Komunikat wyjatku: {0}", ex.Message);
                }

            }

            Console.ReadKey();

        }
    }
}
