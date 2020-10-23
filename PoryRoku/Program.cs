using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoryRoku
{
    class Program
    {
        //Defincja typu wyliczoniowego
        enum PoryRoku : byte { Wiosna, Lato, Jesien, Zima }

        static void Main(string[] args)
        {
            PoryRoku sezon;
            Console.WriteLine("Podaj swoją ulubioną porę roku:");
            Console.WriteLine("\t0 - Wiosna\n\t1 - Lato\n\t2 - Zima\n\t3 - Jesień");
            int i = Convert.ToInt32(Console.ReadLine());
            sezon = (PoryRoku)i;    //Konieczna konwersja

            Console.WriteLine("Twoja ulubiona pora roku to {0}", sezon);

            Console.ReadKey();
        }
    }

}
