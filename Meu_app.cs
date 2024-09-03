using System;
using MinhaBiblioteca;  // Importa a biblioteca

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();
            int resultado = calc.Somar(3, 4);
            Console.WriteLine($"Resultado da soma: {resultado}");
        }
    }
}