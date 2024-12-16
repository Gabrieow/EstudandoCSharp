using System;

create namespace JogoDeAdivinhacao
{
    internal class Program
    {
        static void Main(string [] args)
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(100);
            int palpite = 0

            do{
                Console.WriteLine("Insira um número de 0 a 100 para adivinhar o número aleatório: ");
                palpite = int.Parse(Console.ReadLine());
                if (palpite != numeroAleatorio){
                    Console.WriteLine("Você errou, insira outro número novamente: ");
                } else{
                    Console.WriteLine("Você acertou!");
                }
            } while (palpite != numeroAleatorio);

            // acho que seria interessante fazer uma interface gráfica com windows forms dps, mas como é um programa simples não sei se vou fazer kkkkkk

        }
    }
}
