namespace Nivel_02___Estruturas_Condicionais
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
            Console.WriteLine("Leia dois valores inteiros para as variáveis A e B, efetue a troca dos valores entre as variáveis e apresente os valores trocados.\n");
            
            Console.WriteLine("Insira um valor inteiro para A: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira um valor inteiro para B: ");
            int b = int.Parse(Console.ReadLine());
            
            int temp = a;
            a = b;
            b = temp;
            
            Console.WriteLine($"O valor de A agora é {a} e o valor de B agora é {b}.");
        }
        public static void Exercicio02()
        {
            Console.WriteLine("Escreva um programa que leia um número inteiro e exiba o seu módulo;\nO módulo de um número x é:\nx se x é >= 0\nx * (-1) se x < 0.\n");
            
            Console.WriteLine("Insira um número inteiro saber seu módulo: ");
            int num = int.Parse(Console.ReadLine());

            if (num >= 0)
            {
                Console.WriteLine($"O módulo de {num} é {num}.");
            } else
            {
                Console.WriteLine($"O módulo de {num} é {num*(-1)}");
            }
        }
        public static void Exercicio03()
        {
            Console.WriteLine("Escreva um programa uqe leia 3 números inteiros e imprima na tela os valores em ordem decrescente.\n");

            int[] numeros = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Insira um número Inteiro: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(numeros);  // organiza em forma crescente
            Array.Reverse(numeros);  // dá reverse na ordem crescente transformando em decrescente

            Console.WriteLine("Lista do vetor em ordem decrescente: ");
            foreach (int numero in numeros) // foreach é basicamente um "for numero in numeros:" em python, só q forach só serve pra coleções IEnumerables (arrays, listas, etc)
            {
                Console.WriteLine(numero);
            }

        }
        public static void Exercicio04()
        {
            Console.WriteLine("Escreva um programa que leia dois números e apresente a diferença do maior para o menor.\n");
            
            Console.WriteLine("Insira um número inteiro");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira um número inteiro: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                int diferenca = num2 - num1;
                Console.WriteLine($"A diferença entre os números {num1} e {num2} é de: {diferenca}.");
            }
            else
            {
                int diferenca = num1 - num2;
                Console.WriteLine($"A diferença entre os números {num1} e {num2} é de: {diferenca}.");
            }
        }
        public static void Exercicio05()
        {
            Console.WriteLine("Escreva um programa que leia quatro notas de um aluno e apresente uma mensagem se foi aprovado, se está em recuperação ou reprovado.\n");
            
            Console.WriteLine("Insira as quatro notas das avaliações (uma por vez): ");
            int nota1 = int.Parse(Console.ReadLine());
            int nota2 = int.Parse(Console.ReadLine());
            int nota3 = int.Parse(Console.ReadLine());
            int nota4 = int.Parse(Console.ReadLine());

            double media = (nota1 + nota2 + nota3 + nota4) / 4.0;

            if (media >= 6)
            {
                Console.WriteLine("Aprovado.");
            }
            else if (media >= 3)
            {
                Console.WriteLine("Recuperação.");
            }
            else
            {
                Console.WriteLine("Reprovado.");
            }
        }
        public static void Exercicio06()
        {
            Console.WriteLine("Faça um programa que leia um número. Se for positivo, armazene-o em A; Se for negativo, armazene-o em B. No final, apresente o resultado.\n");
            
            Console.WriteLine("Insira um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                int a = numero;
                Console.WriteLine($"O número {a} é maior que 0.");
            }
            else
            {
                int b = numero;
                Console.WriteLine($"O número {b} é menor que 0.");
            }
        }
    }
}
