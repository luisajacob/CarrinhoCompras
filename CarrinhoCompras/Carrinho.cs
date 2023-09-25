using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeDiagnostica
{
    class Carrinho
    {
        private List<Produto> produtos;

        public Carrinho()
        {
            produtos = new List<Produto>();
        }

        public void AdicionarProduto(Produto produto)
        {
            produtos.Add(produto);
        }

        public double CalcularTotal()
        {
            double total = 0;
            foreach (var produto in produtos)
            {
                total += produto.Preco;
            }
            return total;
        }
    }
}
