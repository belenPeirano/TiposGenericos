using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número: ");
            int n =  Convert.ToInt32(Console.ReadLine());
            int resultado1 = Factorial.FactFor(n);
            Console.WriteLine($"El factorial de {n} es: {resultado1}");
            
            Console.WriteLine("Ingrese un número: ");
            int N =  Convert.ToInt32(Console.ReadLine());
            int resultado2 = Factorial.FactWhile(N);
            Console.WriteLine($"El factorial de 5 es: {resultado2}");
        }
    }
}
