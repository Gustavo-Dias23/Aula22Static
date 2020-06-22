using System;

namespace Aula22Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"A quantia inserida de dólares equivale a R${Conversor.ConverterDolarReal(23f)}.");
            Console.WriteLine($"A quantia inserida de reais equivale a ${Conversor.ConverterRealDolar(50)}.");
            Console.WriteLine($"A quantia inserida de euros equivale a R${Conversor.ConverterEuroReal(10f)}.");
            Console.WriteLine($"A quantia inserida de reais equivale a {Conversor.ConverterRealEuro(50f)} euros.");
            Console.ResetColor();
        }
    }
}
