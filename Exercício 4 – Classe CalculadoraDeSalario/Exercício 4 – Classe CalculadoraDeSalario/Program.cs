using System;

class Program
{
    static void Main(string[] args)
    {
        CalculadoraDeSalario funcionario = new CalculadoraDeSalario();

        funcionario.ReceberDados();

        int opcao;
        double percentual;

        do
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1 - Aplicar aumento");
            Console.WriteLine("2 - Aplicar desconto");
            Console.WriteLine("3 - Mostrar salário");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite o percentual de aumento: ");
                    percentual = double.Parse(Console.ReadLine());
                    funcionario.CalcularAumento(percentual);
                    break;

                case 2:
                    Console.Write("Digite o percentual de desconto: ");
                    percentual = double.Parse(Console.ReadLine());
                    funcionario.CalcularDesconto(percentual);
                    break;

                case 3:
                    funcionario.MostrarSalario();
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