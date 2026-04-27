using System;

class Produto
{
    public string CodigoProduto;
    public string NomeProduto;
    public double Preco;
    public int QuantidadeEstoque;


    public void ReceberDados()
    {
        Console.Write("Digite o código do produto: ");
        CodigoProduto = Console.ReadLine();

        Console.Write("Digite o nome do produto: ");
        NomeProduto = Console.ReadLine();

        Console.Write("Digite o preço: ");
        Preco = double.Parse(Console.ReadLine());

        Console.Write("Digite a quantidade em estoque: ");
        QuantidadeEstoque = int.Parse(Console.ReadLine());
    }


    public void AdicionarEstoque()
    {
        Console.Write("Digite a quantidade para adicionar: ");
        int quantidade = int.Parse(Console.ReadLine());

        QuantidadeEstoque += quantidade;
        Console.WriteLine("Estoque atualizado com sucesso!");
    }

 
    public void RemoverEstoque()
    {
        Console.Write("Digite a quantidade para remover: ");
        int quantidade = int.Parse(Console.ReadLine());

        if (quantidade <= QuantidadeEstoque)
        {
            QuantidadeEstoque -= quantidade;
            Console.WriteLine("Remoção realizada com sucesso!");
        }
        else
        {
            Console.WriteLine("Estoque insuficiente!");
        }
    }

    public void MostrarProduto()
    {
        Console.WriteLine("\n=== DADOS DO PRODUTO ===");
        Console.WriteLine("Código: " + CodigoProduto);
        Console.WriteLine("Nome: " + NomeProduto);
        Console.WriteLine("Preço: R$ " + Preco.ToString("F2"));
        Console.WriteLine("Estoque: " + QuantidadeEstoque);
    }
}