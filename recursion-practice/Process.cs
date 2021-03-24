using System;
using System.Collections.Generic;
using System.Text;

namespace recursion_practice
{
    class Process
    {
        
        public static int SumaRecursiva(int numero)
        {
            if (numero == 0)
            {
                return 0;
            }
            return numero + SumaRecursiva(numero - 1);
        }

        public static int SumaDigitos(int numero)
        {
            if (numero == 0)
            {
                return 0;
            }
            else
            {
                return numero % 10 + SumaDigitos(numero /= 10);
            }
        }

        public static bool NumeroPrimo(int num, int divisor = 2)
        {
            if (num / 2 < divisor)
            {
                return true;
            }
            else
            {
                if (num % divisor == 0)
                {
                    return false;
                }
                else
                {
                    return NumeroPrimo(num, divisor + 1);
                }
            }
        }
    }
}
