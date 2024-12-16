using System;

create namespace CalculadoraSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Bem-vindo à calculadora simples!\n");
                Console.WriteLine("\nDigite uma opção:\n1 - Soma\n 2 - Subtração\n3 - Multiplicação\n4 - Divisão\n5 - Sair");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Funcoes.soma();
                        break;
                    case "2":
                        Funcoes.subtracao();
                        break;
                    case "3":
                        Funcoes.multiplicacao();
                        break;
                    case "4":
                        Funcoes.divisao();
                        break;
                    case "5":
                        Console.WriteLine("Saindo...")
                        return;
                    default:
                        Console.WriteLine("Opção inválida, insira novamente.");
                        break;
                }
            }
        }
    }

    internal class Funcoes
    {
        public static void soma()
        {
            Console.WriteLine("Insira um número para somar: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira outro número: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"A soma dos números {num1} e {num2} é: {num1 + num2}");
        }

        public static void subtracao()
        {
            Console.WriteLine("Insira um número para subtrair: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira outro número: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"A subtração dos números {num1} e {num2} é: {num1 - num2}");
        }

        public static void multiplicacao()
        {
            Console.WriteLine("Insira um número para multiplicar: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira outro número: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"A Multiplicação dos números {num1} e {num2} é: {num1 * num2}");
        }

        public static void divisao()
        {
            Console.WriteLine("Insira um número para ser dividido: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira outro número: ");
            double num2 = double.Parse(Console.ReadLine());

            if (num2 == 0)
            {
                Console.WriteLine("Erro: não é possível dividir por zero.");
            } 
            else 
            {
                Console.WriteLine($"A divisão do número {num1} por {num2} é: {num1 / num2}");
            }

            
        }
    }
}