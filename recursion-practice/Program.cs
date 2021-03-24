using System;

namespace recursion_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Process.SumaRecursiva(5));

            Console.WriteLine(Process.SumaDigitos(35));

            if (Process.NumeroPrimo(13))
            {
                Console.WriteLine("Es un numero primo");
            }
            else
            {
                Console.WriteLine("No es un numero primo");
            }
        }
    }
}
