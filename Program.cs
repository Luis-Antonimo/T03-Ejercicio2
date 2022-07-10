using System;

namespace T03Ejercicio2
{
    class Program
    {
        static void Main()
        {
            int n = 10;
            double a = 2000;
            char c = 'z';
            Console.WriteLine("Variable N: {0}", n);
            Console.WriteLine("Variable A: {0}", a);
            Console.WriteLine("Variable C: {0}", c);
            Console.WriteLine("{0} + {1} = {2}", n, a, n + a);
            Console.WriteLine("{0} - {1} = {2}", a, n, a - n);
            //Convertimos c en código ASCII
            Console.WriteLine("Valor numérico del carácter {0} = {1}", c, (int)c);
        }
    }
}