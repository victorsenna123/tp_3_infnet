using System;

namespace Modelo
{
    // Classe Produto
    public class Produto : Descontavel
    {
        private string nome;
        private double preco;
        private int quantidade;

        // Construtor
        public Produto(string nome, double preco, int quantidade)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;
        }

        // Propriedades (getters e setters)
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        // Método para calcular o valor total do estoque
        public virtual double ValorEmEstoque()
        {
            return preco * quantidade;
        }

        // Método da interface Descontavel
        public void AplicarDesconto(double porcentagem)
        {
            preco -= preco * porcentagem / 100;
        }
    }
}
