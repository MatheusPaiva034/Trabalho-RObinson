using System;

class Program
{
    static void Main(string[] args)
    {
        Produto produto = new Produto();

        produto.ReceberDados();

        int opcao;

        do
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1 - Adicionar estoque");
            Console.WriteLine("2 - Remover estoque");
            Console.WriteLine("3 - Mostrar produto");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    produto.AdicionarEstoque();
                    break;

                case 2:
                    produto.RemoverEstoque();
                    break;

                case 3:
                    produto.MostrarProduto();
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