using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeDiagnostica
{
    class Cliente
    {
        public string Nome { get; }
        public Carrinho CarrinhoDeCompras { get; } = new Carrinho();

        public Cliente(string nome)
        {
            Nome = nome;
        }
    }
}
