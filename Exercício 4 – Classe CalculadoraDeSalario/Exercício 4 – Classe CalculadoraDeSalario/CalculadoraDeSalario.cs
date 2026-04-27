using System;

class CalculadoraDeSalario
{
    public string NomeFuncionario;
    public double SalarioBase;
    public double SalarioFinal;

    public void ReceberDados()
    {
        Console.Write("Digite o nome do funcionário: ");
        NomeFuncionario = Console.ReadLine();

        Console.Write("Digite o salário base: ");
        SalarioBase = double.Parse(Console.ReadLine());

    
        SalarioFinal = SalarioBase;
    }


    public void CalcularAumento(double percentual)
    {
        double aumento = SalarioFinal * (percentual / 100);
        SalarioFinal += aumento;

        Console.WriteLine("Aumento aplicado!");
    }


    public void CalcularDesconto(double percentual)
    {
        double desconto = SalarioFinal * (percentual / 100);
        SalarioFinal -= desconto;

        Console.WriteLine("Desconto aplicado!");
    }

    public void MostrarSalario()
    {
        Console.WriteLine("\n=== DADOS DO FUNCIONÁRIO ===");
        Console.WriteLine("Nome: " + NomeFuncionario);
        Console.WriteLine("Salário Base: R$ " + SalarioBase.ToString("F2"));
        Console.WriteLine("Salário Final: R$ " + SalarioFinal.ToString("F2"));
    }
}