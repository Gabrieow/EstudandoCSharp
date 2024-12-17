// Crie uma classe chama Animal com os atributos: Nome(string) e o método EmitirSom() que imprime "Som genérico".
// Crie duas classes derivadas: Cachorro que sobrescreve o método EmitirSom() para imprimir "Au au!" e Gato que sobrescreve para imprimir "Miau!".
// No Main, crie bojetos de Cachorro e Gato e chame o método EmitirSom().

namespace OOP
{
    public class Animal
    {
        public string Nome { get; set; }
        
        class Animal(string nome)
        {
            Nome = nome;
        }

        public void EmitirSom()
        {
            Console.WriteLine("Som genérico.");
        }
    }

    public class Cachorro : Animal
    {
        public Cachorro(string nome) : base(nome) {}
        public override void EmitirSom()
        {
            Console.WriteLine("Au au!");
        }
    }

    public class Gato : Animal
    {
        public Gato(string nome) : base(nome) {}
        public override void EmitirSom()
        {
            Console.WriteLine("Miau!");
        }
    }

    internal class Program
    {
        public static void Main()
        {
            Cachorro koda = new Cachorro("Koda");
            Gato bola = new Gato("Bola de Neve");

            koda.EmitirSom();
            bola.EmitirSom();
        }
    }

}
