using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeDiagnostica
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando alguns produtos
            Produto produto1 = new Produto("Camiseta", 35);
            Produto produto2 = new Produto("Calça", 50);
            Produto produto3 = new Produto("Tênis", 80);
            Produto produto4 = new Produto("Boné", 30);
            Produto produto5 = new Produto("Meia", 15);
            Produto produto6 = new Produto("Bolsa", 200);
            Produto produto7 = new Produto("Jaqueta", 90);
            Produto produto8 = new Produto("Chinelo", 20);
            Produto produto9 = new Produto("Moletom", 70);
            Produto produto10 = new Produto("Bermuda", 45);

            // Apresentando os produtos disponíveis para o usuário
            Console.WriteLine("Produtos disponíveis:");
            Console.WriteLine("1. Camiseta - R$ 25");
            Console.WriteLine("2. Calça - R$ 50");
            Console.WriteLine("3. Tênis - R$ 80");
            Console.WriteLine("4. Boné - R$ 30");
            Console.WriteLine("5. Meia - R$ 15");
            Console.WriteLine("6. Bolsa - R$ 200");
            Console.WriteLine("7. Jaqueta - R$ 90");
            Console.WriteLine("8. Chinelo - R$ 20");
            Console.WriteLine("9. Moletom - R$ 70");
            Console.WriteLine("10. Bermuda - R$ 45");

            // Criando um cliente
            Console.Write("\nNome: ");
            string nome = Console.ReadLine();
            Cliente cliente = new Cliente(nome);

            while (true)
            {
                Console.Write("Digite o número do produto para adicionar ao carrinho (ou 0 para finalizar): ");
                int escolha = Convert.ToInt32(Console.ReadLine());

                if (escolha == 0)
                    break;

                Produto produtoEscolhido = null;
                switch (escolha)
                {
                    case 1:
                        produtoEscolhido = produto1;
                        break;
                    case 2:
                        produtoEscolhido = produto2;
                        break;
                    case 3:
                        produtoEscolhido = produto3;
                        break;
                    case 4:
                        produtoEscolhido = produto4;
                        break;
                    case 5:
                        produtoEscolhido = produto5;
                        break;
                    case 6:
                        produtoEscolhido = produto6;
                        break;
                    case 7:
                        produtoEscolhido = produto7;
                        break;
                    case 8:
                        produtoEscolhido = produto8;
                        break;
                    case 9:
                        produtoEscolhido = produto9;
                        break;
                    case 10:
                        produtoEscolhido = produto10;
                        break;

                    default:
                        Console.WriteLine("Escolha inválida.");
                        continue;
                }

                cliente.CarrinhoDeCompras.AdicionarProduto(produtoEscolhido);
                Console.WriteLine($"Produto {produtoEscolhido.Nome} adicionado ao carrinho.");
            }

            // Calculando o valor total no carrinho do cliente
            double total = cliente.CarrinhoDeCompras.CalcularTotal();

            // Exibindo o valor total
            Console.WriteLine($"Total no carrinho de {cliente.Nome}: R$ {total:F2}");

            Console.ReadKey();
        }
    }
}
