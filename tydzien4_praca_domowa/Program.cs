using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tydzien4_praca_domowa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź liczbę całkowitą: ");
            var inputNumber = GetIntNumber();
            if(inputNumber % 2 == 0)
            {
                Console.WriteLine("Liczba parzysta!");
            }
            else
            {
                Console.WriteLine("Liczba nieparzysta!");
            }
            Console.ReadLine();
        }

        private static int GetIntNumber()
        {
            while (true)
            {
                if(!int.TryParse(Console.ReadLine(), out int retNumber))
                {
                    Console.WriteLine("Błędne wprowadzenie, wprowadź liczbę całkowitą: ");
                    continue;
                }
                return retNumber;
            }
        }
    }
}
