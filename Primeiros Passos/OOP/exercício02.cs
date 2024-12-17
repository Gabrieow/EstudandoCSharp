// Crie um classe chamada Pessoa com os atributos: "Nome(string)" e "Idade(int)".
// Adicione dois construtores: um Padrão (sem parâemtros) e um Sobrecarga que aceita nome e idade como parâmetros
// No Main, crie dois objetos usando os dois construtores e exiba os valores dos atributos.

using System;

namespace OOP
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa()
        {
            Nome = "John Doe";
            Idade = 20;
        }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public void ExibirInformacoes()
        {
        Console.WriteLine($"Nome: {Nome}\nIdade: {Idade}");
        }

    }

    internal class Program
    {
        public static void Main()
        {
            Pessoa eu = new Pessoa("Gabriel", 21);
            eu.ExibirInformacoes();

            Pessoa indigente = new Pessoa();
            indigente.ExibirInformacoes();
        }
    }
}