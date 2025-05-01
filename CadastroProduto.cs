using System;

class Produto
{
    public string Nome;
    public double Preco;
    public int Quantidade;

    public double TotalEmEstoque()
    {
        return Preco * Quantidade;
    }
}

class CadastroProduto
{
    public static void Executar()
    {
        Produto[] produtos = new Produto[3];

        for (int i = 0; i < 3; i++)
        {
            produtos[i] = new Produto();

            Console.WriteLine($"\nProduto {i + 1}:");

            Console.Write("Nome: ");
            produtos[i].Nome = Console.ReadLine();

            Console.Write("Preço: ");
            produtos[i].Preco = Convert.ToDouble(Console.ReadLine());

            Console.Write("Quantidade: ");
            produtos[i].Quantidade = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("\nProdutos cadastrados:");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Nome: {produtos[i].Nome} | Preço: {produtos[i].Preco:C} | Quantidade: {produtos[i].Quantidade} | Total: {produtos[i].TotalEmEstoque():C}");
        }
    }
}
