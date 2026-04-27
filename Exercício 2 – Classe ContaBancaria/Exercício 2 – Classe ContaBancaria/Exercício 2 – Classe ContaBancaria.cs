using System;

class Program
{
    static void Main(string[] args)
    {
        ContaBancaria conta = new ContaBancaria();

        conta.ReceberDados();

        int opcao;

        do
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1 - Depositar");
            Console.WriteLine("2 - Sacar");
            Console.WriteLine("3 - Mostrar Saldo");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    conta.Depositar();
                    break;

                case 2:
                    conta.Sacar();
                    break;

                case 3:
                    conta.MostrarSaldo();
                    break;

                case 0:
                    Console.WriteLine("Encerrando...");
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

        } while (opcao != 0);

        Console.ReadKey();
    }
}