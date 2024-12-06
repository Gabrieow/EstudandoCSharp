using System;

namespace Exercicio1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Insira o valor de Celsius: ");
            int Celsius = int.Parse(Console.ReadLine());
            
            double Calculo = Celsius * 1.8 + 32;
            
            Console.WriteLine($"O valor de {Celsius} em Fahrenheit é: {Calculo}");
            
        }
    }
}