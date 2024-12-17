// Crie uma classe chamada Carro com os atributos "Marca (string)", "Modelo (string)" e "Ano (int)".
// Adicione um método chamado ExibirDetalhes() que imprime os detalhes do carro no console
// No Main, instancie um objeto da classe Carro e atribua valores aos atributos, depois chame o método ExibirDetalhes().

using System;

namespace OOP
{
    public class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }

        public Carro(string marca, string modelo, int ano)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Marca: {Marca}\nModelo: {Modelo}\nAno: {Ano}")
        }
    }

    internal class Program
    {
        static void Main()
        {
            Carro ferrari = new Carro("Ferrari", "296 GTB", 2023);
            ferrari.ExibirDetalhes();
        }
    }
}
    
