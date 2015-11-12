using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_domowe_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string imie;
            Console.WriteLine("Podaj imię");
            imie = Console.ReadLine();
            int wiek;
            Console.WriteLine("Ile masz lat?");
            wiek = int.Parse(Console.ReadLine());
            string miasto;
            Console.WriteLine("Podaj miasto");
            miasto = Console.ReadLine();
            Console.WriteLine("Masz na imię: {0}", imie);
            Console.WriteLine("Masz: {0} lat", wiek);
            Console.WriteLine("Mieszkasz w {0} ", miasto);

            Console.ReadLine();
        }
    }
}
