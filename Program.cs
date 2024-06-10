using System;
using Modelo;

class Program
{
    static void Main(string[] args)
    {
        Produto produto = new Produto("Camiseta", 29.99, 10);
        Console.WriteLine($"Valor total em estoque: R${produto.ValorEmEstoque():F2}");

        ProdutoPerecivel produtoPerecivel = new ProdutoPerecivel("Leite", 3.50, 5, DateTime.Now.AddDays(25));
        Console.WriteLine($"Valor total em estoque (perecível): R${produtoPerecivel.ValorEmEstoque():F2}");
    }
}
