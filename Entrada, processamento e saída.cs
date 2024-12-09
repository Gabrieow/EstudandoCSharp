namespace Exercícios
{

    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Selecione uma opção de 1 a 10 para exibir um exercício ou 0 para sair do menu.");
                string opcao = Console.ReadLine();
                
                switch (opcao)
                {
                    case "1":
                        Exercicios.Exercicio01();
                        break;
                    case "2" :
                        Exercicios.Exercicio02();
                        break;
                    case "3":
                        Exercicios.Exercicio03();
                        break;
                    case "4" :
                        Exercicios.Exercicio04();
                        break;
                    case "5" :
                        Exercicios.Exercicio05();
                        break;
                    case "6":
                        Exercicios.Exercicio06();
                        break;
                    case "7":
                        Exercicios.Exercicio07();
                        break;
                    case "8":
                        Exercicios.Exercicio08();
                        break;
                    case "9":
                        Exercicios.Exercicio09();
                        break;
                    case "10" :
                        Exercicios.Exercicio10();
                        break;
                    case "0":
                        Console.WriteLine("Encerrando menu.");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida, insira novamente.");
                        break;
                        
                }
            }
        }
    }
    
    
    internal class Exercicios
    {

        public static void Exercicio01()
        {
            Console.WriteLine("Crie um programa que converta graus Celsius em graus Fahrenheit.\n");
            Console.WriteLine("Insira o valor de Celsius: ");
            int celsius = int.Parse(Console.ReadLine());
            
            double calculo = celsius * 1.8 + 32;
            
            Console.WriteLine($"O valor de {celsius} em Fahrenheit é: {calculo}");
        }
        
        public static void Exercicio02()
        {
            Console.WriteLine("Crie um programa que solicite a cotação do dólar e faça a conversão de dólar para reais.\n");
            Console.WriteLine("Insira a cotação do Dólar (exemplo: 6,07): ");
            decimal cotDolar = decimal.Parse(Console.ReadLine());
            
            Console.WriteLine("Insira um valor em Dólar: ");
            decimal valorDolar = decimal.Parse(Console.ReadLine());
            
            decimal conversao = valorDolar * cotDolar;
            
            Console.WriteLine($"O valor de {valorDolar} dólares em reais é de R${conversao:F2}");
        }
        
        public static void Exercicio03()
        {
            Console.WriteLine("Crie um código que calcule a comissão de um vendedor, apresentando a identificação do vendedor, do produto e o valor da comissão.\n");
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
        
        public static void Exercicio04()
        {
            Console.WriteLine("Crie um programa que calcule a quantidade de litros gastos em uma viagem de um carro que possui a autonomia de 12km/L. Solicite o tempo gasto em horas, velocidade média em km/h e depois apresente-os junto à quantidade de litros gastos.\n");
            Console.WriteLine("Insira o tempo gasto na viagem (em horas): ");
            double tempoGasto = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a velocidade média (em km/h): ");
            double velocidadeMedia = double.Parse(Console.ReadLine());

            double valorDistancia = tempoGasto * velocidadeMedia;
            double litrosGastos = valorDistancia / 12;
            
            Console.WriteLine($"Velocidade média: {velocidadeMedia}km/h\nDistancia percorrida: {valorDistancia}km\nTempo gasto: {tempoGasto} horas\nQuantidade de litros gastos: {litrosGastos:F2}L");
        }
        
        public static void Exercicio05()
        {
            Console.WriteLine("Crie um programa que calcule o estoque médio de uma peça.\n");
            Console.WriteLine("Insira o estoque mínimo da peça: ");
            int estoqueMinimo = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o estoque máximo da peça: ");
            int estoqueMaximo = int.Parse(Console.ReadLine());

            int estoqueMedio = (estoqueMaximo + estoqueMinimo) / 2;
            
            Console.WriteLine($"O estoque médio é de {estoqueMedio} peças.");
        }

        public static void Exercicio06()
        {
            Console.WriteLine("Crie um programa que transforme graus Fahrenheit em graus Celsius.\n");
            
            Console.WriteLine("Insira o valor em graus Fahrenheit: ");
            double grausF = double.Parse(Console.ReadLine());

            double grausC = (grausF - 32) * 5 / 9;

            Console.WriteLine($"A conversão de {grausF}ºF em Celsius é de {grausC}ºC");
        }

        public static void Exercicio07()
        {
            Console.WriteLine("Crie um programa que calcule e apresente o volume de uma lata de óleo.\n");
            
            Console.WriteLine("Insira o valor da circunferência da lata: ");
            decimal circunferencia = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Insira a altura da lata: ");
            decimal altura = decimal.Parse(Console.ReadLine());

            decimal volume = 3.14159m * circunferencia * altura;
            
            Console.WriteLine($"O volume da lata é de: {volume}L");
        }

        public static void Exercicio08()
        {
            Console.WriteLine(
                "Faça um algoritmo que leia a idade de uma pessoa em anos, meses e dias e escreva a idade dessa pessoa expressa apenas em dias. Considerar ano com 365 dias e mês com 30 dias.\n");

            Console.WriteLine("Insira a data de hoje no formato dd/MM/yyyy: ");
            string dataHoje1 = Console.ReadLine();
            Console.WriteLine("Insira a data do seu nascimento no formato dd/MM/yyyy: ");
            string dataNascimento1 = Console.ReadLine();

            if (DateTime.TryParse(dataHoje1, out DateTime dataHoje2) &&
                DateTime.TryParse(dataNascimento1, out DateTime dataNascimento2))
            {
                if (dataNascimento2 > dataHoje2)
                {
                    Console.WriteLine("A data de nascimento não pode ser no futuro!");
                }

                TimeSpan diferenca = dataHoje2 - dataNascimento2;
                int idadeEmDias = diferenca.Days;
                
                Console.WriteLine($"Você viveu aproximadamente {idadeEmDias} dias.");

            }
            else
            {
                Console.WriteLine("Você especificou os valores de maneira incorreta.");
            }
        }

        public static void Exercicio09()
        {
            Console.WriteLine("Insira o primeiro número inteiro:");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo número inteiro:");
            int numero2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"{numero1} == {numero2}: {numero1 == numero2}");
            Console.WriteLine($"{numero1} != {numero2}: {numero1 != numero2}");
            Console.WriteLine($"{numero1} > {numero2}: {numero1 > numero2}");
            Console.WriteLine($"{numero1} < {numero2}: {numero1 < numero2}");
            Console.WriteLine($"{numero1} >= {numero2}: {numero1 >= numero2}");
            Console.WriteLine($"{numero1} <= {numero2}: {numero1 <= numero2}");
        }
        
        public static void Exercicio10()
        {
            Console.WriteLine("Escreva um programa que leia três números inteiros e calcule e mostre a média ponderada desses números. Os pesos para o cálculo da média são: 2 para o primeiro número, 3 para o segundo número e 5 para o terceiro número.\n");
            
            Console.WriteLine("Insira o primeiro valor: ");
            decimal valor1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo valor: ");
            decimal valor2 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Insira o terceiro valor: ");
            decimal valor3 = decimal.Parse(Console.ReadLine());

            decimal mediaPonderada = ((valor1 * 2) + (valor2 * 3) + (valor3 * 5)) / 10;
            
            Console.WriteLine($"A média ponderada dos valores {valor1}, {valor2} e {valor3} é de: {mediaPonderada}");
        }
    }
}

