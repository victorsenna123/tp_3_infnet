using System;

namespace Modelo
{
    // Classe ProdutoPerecivel
    public class ProdutoPerecivel : Produto, Descontavel
    {
        private DateTime dataDeValidade;

        // Construtor
        public ProdutoPerecivel(string nome, double preco, int quantidade, DateTime dataDeValidade)
            : base(nome, preco, quantidade)
        {
            this.dataDeValidade = dataDeValidade;
        }

        // Sobrescrevendo o método ValorEmEstoque para aplicar desconto se a data de validade estiver próxima
        public override double ValorEmEstoque()
        {
            if (dataDeValidade < DateTime.Now.AddDays(30))
            {
                return base.ValorEmEstoque() * 0.8; // Aplica desconto de 20% se a data de validade estiver próxima
            }
            else
            {
                return base.ValorEmEstoque();
            }
        }

        // Método da interface Descontavel
        public new void AplicarDesconto(double porcentagem)
        {
            base.AplicarDesconto(porcentagem);
        }
    }
}
