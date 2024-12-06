using System;

namespace Exercicio3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Insira a identificação do Vendedor: ");
            string identificacao = Console.ReadLine();
            
            Console.WriteLine("Insira o código da peça: ");
            string codigo = Console.ReadLine();
            
            Console.WriteLine("Insira o preço unitário da peça: ");
            decimal precoUnitario = decimal.Parse(Console.ReadLine());
            
            Console.WriteLine("Insira a quantidade Vendida: ");
            int qntVendida = int.Parse(Console.ReadLine());
            
            decimal valorTotal = precoUnitario*qntVendida;
            
            decimal comissao = (valorTotal*0.05m);
            
            Console.WriteLine($"A comissão do vendedor {identificacao}, sobre o produto {codigo} é de: {comissao:F2}");
            
        }
    }
}