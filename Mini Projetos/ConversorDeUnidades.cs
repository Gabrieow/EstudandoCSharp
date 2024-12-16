using System;

create namespace ConversorDeUnidades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Bem-Vindo ao Sistema conversor de unidades!\n");
                Console.WriteLine("\nEscolha uma opção para prosseguir:\n1 - Conversão de temperatura\n2 - Conversão de medidas\n3 - Conversão de Tempo\n4 - Convertor Fiduciário\n5 - Sair\n");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Você escolheu: Conversão de temperatura.\n\n");
                        Funcoes.temperatura();
                        break;
                    case "2":
                        Console.WriteLine("Você escolheu: Conversão de medidas.\n\n");
                        Funcoes.medidas();
                        break;
                    case "3":  
                        Console.WriteLine("Você escolheu: Conversão de tempo.\n\n");
                        Funcoes.tempo();
                        break;
                    case "4":
                        Console.WriteLine("Você escolheu: Convertor Fiduciário.\n\n");
                        Funcoes.fiduciario();
                        break;
                    case "5":
                        Console.WriteLine("Saindo...")
                        return;
                    default:
                        Console.WriteLine("Opção Inválida, insira novamente: ")
                        break;
                }
            }
        }
    }

    internal class Funcoes
    {
        public static void temperatura()
        {
            Console.WriteLine("Escolha uma das opções:\n1 - Converter ºC em ºF\n2 - Converter ºF em ºC\n3 - Converter ºK em ºC\n4 - Converter ºK em ºF\n");
            string opcaomenu = Console.ReadLine();
            double valor;

            switch (opcaomenu)
            {
                case "1":
                    Console.WriteLine("Insira o valor em ºC: ");
                    double valor = double.Parse(Console.ReadLine());
                    Console.WriteLine($"A Conversão de {valor}ºC para ºF é: {(valor * 9/5) + 32}ºF.");
                    break;  

                case "2":
                    Console.WriteLine("Insira o valor em ºF: ");
                    double valor = double.Parse(Console.ReadLine());
                    Console.WriteLine($"A Conversão de {valor}ºF para ºC é: {(valor - 32) * 5/9}ºC.");
                    break;

                case "3":
                    Console.WriteLine("Insira o valor em ºK: ");
                    double valor = double.Parse(Console.ReadLine());
                    Console.WriteLine($"A Conversão de {valor}ºK para ºC é: {valor - 273.15}ºC.");
                    break;

                case "4":
                    Console.WriteLine("Insira o valor em ºK: ");
                    double valor = double.Parse(Console.ReadLine());
                    Console.WriteLine($"A Conversão de {valor}ºK para ºF é: {(valor - 273.15) * 9/5 + 32}ºF.");
                    break;
            }
        }

        public static void medidas()
        {
            Console.WriteLine("Escolha uma das opções:\n1 - Converter KM para M\n2 - Converter M para CM\n3 - Converter CM para MM\n4 - Converter MM para KM\n5 - Converter MM para M\n6 - Converter MM para CM\n");
            string opcaomenu = Console.ReadLine();
            double valor;

            switch (opcaomenu)
            {
                case "1":
                    Console.WriteLine("Insira o valor em KM: ");
                    double valor = double.Parse(Console.ReadLine());
                    Console.WriteLine($"A Conversão de {valor}KM para M é: {valor * 1000}M.");
                    break;

                case "2":
                    Console.WriteLine("Insira o valor em M: ");
                    double valor = double.Parse(Console.ReadLine());
                    Console.WriteLine($"A Conversão de {valor}M para CM é: {valor * 100}CM.");
                    break;

                case "3":
                    Console.WriteLine("Insira o valor em CM: ");
                    double valor = double.Parse(Console.ReadLine());
                    Console.WriteLine($"A Conversão de {valor}CM para MM é: {valor * 10}MM.");
                    break;

                case "4":
                    Console.WriteLine("Insira o valor em MM: ");
                    double valor = double.Parse(Console.ReadLine());
                    Console.WriteLine($"A Conversão de {valor}MM para KM é: {valor / 1000000}KM.");
                    break;

                case "5":
                    Console.WriteLine("Insira um valor em MM: ");
                    double valor = double.Parse(Console.ReadLine());
                    Console.WriteLine($"A conversão de {valor}MM para M é: {valor / 1000}M.");
                    break;

                case "6":
                    Console.WriteLine("Insira um valor em MM: ");
                    double valor = double.Parse(Console.ReadLine());
                    Console.WriteLine($"A conversão de {valor}MM para CM é: {valor / 10}CM.");
                    break;

                default:
                    Console.WriteLine("Opção inválida.")
                    break;
            }
        }

        public static void tempo()
        {
            Console.WriteLine("Escolha uma das opções:\n1 - Converter Horas para Minutos\n2 - Converter Minutos para Segundos\n3 - Converter Segundos para Minutos\n4 - Converter Segundos para Horas\n");
            string opcaomenu = Console.ReadLine();
            int valor;

            switch (opcaomenu)
            {
                case "1":
                    Console.WriteLine("Insira o valor em Horas: ");
                    int valor = int.Parse(Console.ReadLine());
                    Console.WriteLine($"A conversão de {valor}H para Min é: {valor * 60}min.");
                    break;

                case "2":
                    Console.WriteLine("Insira o valor em minutos: ");
                    int valor = int.Parse(Console.ReadLine());
                    Console.WriteLine($"A conversão de {valor}min para Seg é: {valor * 60}seg.");
                    break;

                case "3":
                    Console.WriteLine("Insira o valor em segundos: ");
                    int valor = int.Parse(Console.ReadLine());
                    Console.WriteLine($"A conversão de {valor}seg para Min é: {valor / 60}min.");
                    break;

                case "4":
                    Console.WriteLine("Insira o valor em segundos: ");
                    int valor = int.Parse(Console.ReadLine());
                    Console.WriteLine($"A Conversão de {valor}seg para H é: {(valor / 60) / 60}h.");
                    break;

                default:
                    Console.WriteLine("Opção Inválida.")
                    break;
            }
        }

        public static void fiduciario()
        {
            Console.WriteLine("Insira a cotação atual do Dólar: ");
            decimal cotDolar = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Insira a cotação atual do Euro: ");
            decimal cotEuro = decimal.Parse(Console.ReadLine());

            Console.WriteLine("\nEscolha uma das opções:\n1 - Converter R$ em U$\n2 - Converter R$ em €\n3 - Converter U$ em R$\n4 - Converter € em R$\n");
            string opcaomenu = Console.ReadLine();
            decimal valor;

            switch (opcaomenu)
            {
                case "1":
                    Console.WriteLine("Insira o valor em R$: ");
                    decimal valor = decimal.Parse(Console.ReadLine());
                    Console.ReadLine($"O valor de {valor}R$ em U$ é: {valor / cotDolar}U$.");
                    break;

                case "2":
                    Console.WriteLine("Insira o valor em R$: ");
                    decimal valor = decimal.Parse(Console.ReadLine());
                    console.ReadLine($"O valor de {valor}R$ em € é: {valor / cotEuro}€.");
                    break;

                case "3":
                    Console.WriteLine("Insira o valor em U$: ");
                    decimal valor = decimal.Parse(Console.ReadLine());
                    Console.ReadLine($"O valor de {valor}U$ em R$ é: {valor * cotDolar}R$.");
                    break;

                case "4":
                    Console.WriteLine("Insira o valor em €: ");
                    decimal valor = decimal.Parse(Console.ReadLine());
                    Console.ReadLine($"O valor de {valor}€ em R$ é: {valor * cotEuro}R$.");
                    break;

                default:
                    console.WriteLine("Opção Inválida.")
                    break;
            }
        

        }

    }
}