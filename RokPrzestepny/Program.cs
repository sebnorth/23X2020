using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RokPrzestepny
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Podaj rok: ");
            //int.TryParse(Console.ReadLine(), out int rok);

            Obliczenia.CzyDanyRokJestPrzestepny(2020);
            Obliczenia.CzyDanyRokJestPrzestepny(2021);
            Obliczenia.CzyDanyRokJestPrzestepny(2022);
            Obliczenia.CzyDanyRokJestPrzestepny(2023);
            Obliczenia.CzyDanyRokJestPrzestepny(2024);



            Console.ReadKey();
        }
    }
}
