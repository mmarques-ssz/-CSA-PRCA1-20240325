using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projSoma
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            string aux;

            Console.Write("Digite um numero: ");
            aux = Console.ReadLine();
            a = int.Parse(aux);

            Console.Write("Digite outro numero: ");
            aux = Console.ReadLine();
            b = int.Parse(aux);

            c = a + b;

            Console.Write("A soma dos números é: ");
            Console.WriteLine(c);
            Console.WriteLine();

        }
    }
}
