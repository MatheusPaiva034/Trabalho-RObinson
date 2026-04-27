using System;

class ContaBancaria
{
    public string NumeroConta;
    public string NomeTitular;
    public double Saldo;

    public void ReceberDados()
    {
        Console.Write("Digite o número da conta: ");
        NumeroConta = Console.ReadLine();

        Console.Write("Digite o nome do titular: ");
        NomeTitular = Console.ReadLine();

        Console.Write("Digite o saldo inicial: ");
        Saldo = double.Parse(Console.ReadLine());
    }

    public void Depositar()
    {
        Console.Write("Digite o valor para depósito: ");
        double valor = double.Parse(Console.ReadLine());

        Saldo += valor;
        Console.WriteLine("Depósito realizado com sucesso!");
    }

    public void Sacar()
    {
        Console.Write("Digite o valor para saque: ");
        double valor = double.Parse(Console.ReadLine());

        if (valor <= Saldo)
        {
            Saldo -= valor;
            Console.WriteLine("Saque realizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente!");
        }
    }

    public void MostrarSaldo()
    {
        Console.WriteLine("\n=== DADOS DA CONTA ===");
        Console.WriteLine("Conta: " + NumeroConta);
        Console.WriteLine("Titular: " + NomeTitular);
        Console.WriteLine("Saldo: R$ " + Saldo.ToString("F2"));
    }
}