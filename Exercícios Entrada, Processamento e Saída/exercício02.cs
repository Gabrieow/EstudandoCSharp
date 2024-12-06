using System;

namespace Exercicio2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Insira a cotação do Dólar: ");
            decimal cotDolar = decimal.Parse(Console.ReadLine());
            
            Console.WriteLine("Insira um valor em Dólar: ");
            decimal valorDolar = decimal.Parse(Console.ReadLine());
            
            decimal conversao = valorDolar * cotDolar;
            
            Console.WriteLine($"O valor de {valorDolar} em reais é de R${conversao}");
            
        }
    }
}