// Crie uma classe chamada ContaBancaria com os atributos privaods: NumeroConta(int), Titular(string), Saldo(double).
// Adicione propriedades: Saldo(apenas leitura (get)), Titular(leitura e escrita).
// Adicione métodos: Depositar(double valor) adiciona ao saldo, Sacar(double valor) subtrai do saldo (apenas se o valor não for maior que o saldo).
// No Main, teste criando uma conta, depositando e tentando sacar valores.

namespace OOP
{
    public class ContaBancaria
    {
        private int numeroConta;
        private string titular;
        private double saldo;

        public ContaBancaria(int numeroConta, string titular, double saldoInicial)
        {
            this.numeroConta = numeroConta;     // descobri q tem q usar "this." quando o nome do atributo e do parâmetro sao iguais, se nao, nao funciona
            this.titular = titular;
            saldo = saldoInicial;
        }
        public string Titular
        {
            get { return titular; }
            set { titular = value; }
        }

        public double Saldo
        {
            get { return saldo;}
        }
        
        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                saldo += valor;
                Console.WriteLine($"Depósito realizado. Saldo atual: R${saldo:F2}");
            }
            else
            {
                Console.WriteLine("O valor do depósito não pode ser negativo.");
            }
        }

        public void Sacar(double valor)
        {
            if (saldo < valor)
            {
                Console.WriteLine("Não é possível sacar um valor maior do que está em sua conta.");
            } 
            else if (valor > 0)
            {
                ContaBancaria.Saldo = Saldo - valor; 
                Console.WriteLine($"Saque realizado. Saldo atual: R${saldo:F2}");
            }
            else
            {
                Console.WriteLine("O valor do saque não pode ser negativo.");
            }
            
        }
    }

    internal class Program
    {
        public static void Main()
        {
            ContaBancaria eu = new ContaBancaria(89584, "Gabriel", 500);
            eu.Depositar(500);
            eu.Sacar(1100);
            eu.Sacar(900);
        }
    }
}