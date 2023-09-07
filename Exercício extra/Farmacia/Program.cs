using Farmacia.Controller;
using Farmacia.Model;
using System;
using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Farmacia
{
    public class Program
    {
        private static ConsoleKeyInfo consoleKeyInfo;
        static void Main(string[] args)
        {
            int opcao = 0, id, tipo;
            string nome, generico, fragrancia;
            decimal preco;

            ProdutoController produto = new();

            Medicamento m1 = new Medicamento(52, "benzetacil", 1, 150, "generico");

            produto.CriarProduto(m1);

            while (true)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
                Console.WriteLine("                                             ");
                Console.WriteLine("            FARMÁCIA DO FRAJOLA              ");
                Console.WriteLine("                                             ");
                Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
                Console.WriteLine("                                             ");
                Console.WriteLine("          1- Criar Produto                   ");
                Console.WriteLine("          2- Listar Todos os Produtos        ");
                Console.WriteLine("          3- Consultar Produto por Id        ");
                Console.WriteLine("          4- Atualizar Produto               ");
                Console.WriteLine("          5- Deletar Produto                 ");
                Console.WriteLine("          6- Sair                            ");
                Console.WriteLine("                                             ");
                Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
                Console.WriteLine("Entre com a opção desejada:                  ");
                Console.WriteLine("                                             ");
                Console.ResetColor();
                opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 6)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nFarmácia do Frajola - Sua sáude em primeiro lugar!");
                    Console.ResetColor();
                    System.Environment.Exit(0);
                }

                switch (opcao)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Crie o Produto: \n");
                        Console.ResetColor();

                        Console.WriteLine("Digite o Número do Id:");
                        id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o Nome do Produto:");
                        nome = Console.ReadLine();
                        do
                        {
                            Console.WriteLine("Digite o Tipo do Produto:");
                            tipo = Convert.ToInt32(Console.ReadLine());

                        } while (tipo != 1 && tipo != 2);

                        Console.WriteLine("Digite o Preço do Produto:");
                        preco = Convert.ToDecimal(Console.ReadLine());

                        switch (tipo)
                        {

                            case 1:
                                Console.WriteLine("Digite o Genérico do Produto::");
                                generico = Console.ReadLine();
                                produto.CriarProduto(new Medicamento(id, nome, tipo, preco, generico));
                                break;
                            case 2:

                                Console.WriteLine("Digite a Fragância do Produto");
                                fragrancia = Console.ReadLine();

                                produto.CriarProduto(new Cosmetico(id, nome, tipo, preco, fragrancia));
                                break;
                        }

                        Console.ForegroundColor = ConsoleColor.Green;
                        KeyPress();
                        Console.ResetColor();
                        break;

                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Lista dos Produtos: \n");
                        Console.ResetColor();

                        produto.ListarProdutos();

                        Console.ForegroundColor = ConsoleColor.Green;
                        KeyPress();
                        Console.ResetColor();
                        break;

                    case 3:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Consulta da id do Produto: \n");
                        Console.ResetColor();

                        Console.WriteLine("Digite o Id do Produto: ");
                        id = Convert.ToInt32(Console.ReadLine());

                        produto.ConsultarporId(id);

                        Console.ForegroundColor = ConsoleColor.Green;
                        KeyPress();
                        Console.ResetColor();
                        break;

                    case 4:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Atualização do Produto: \n");
                        Console.ResetColor();

                        Console.WriteLine("Digite o Id do Produto: ");
                        id = Convert.ToInt32(Console.ReadLine());

                        var produtos = produto.BuscarNaCollection(id);

                        if (produtos is not null)
                        {

                            Console.WriteLine("Digite o Nome do Produto:");
                            nome = Console.ReadLine();
                            do
                            {
                                Console.WriteLine("Digite o Tipo do Produto:");
                                tipo = Convert.ToInt32(Console.ReadLine());

                            } while (tipo != 1 && tipo != 2);

                            Console.WriteLine("Digite o preço do Produto:");
                            preco = Convert.ToDecimal(Console.ReadLine());

                            tipo = produtos.GetTipo();
                            switch (tipo)
                            {

                                case 1:
                                    Console.WriteLine("Digite o Genérico do Produto:");
                                    generico = Console.ReadLine();

                                    produto.AtualizarProduto(new Medicamento(id, nome, tipo, preco, generico));
                                    break;
                                case 2:

                                    Console.WriteLine("Digite a Fragância do Produto");
                                    fragrancia = Console.ReadLine();

                                    produto.CriarProduto(new Cosmetico(id, nome, tipo, preco, fragrancia));
                                    break;
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine($"O Produto de id {id}, não foi encontrada");
                            Console.ResetColor();
                        }
                        Console.ForegroundColor = ConsoleColor.Green;
                        KeyPress();
                        Console.ResetColor();
                        break;



                    case 5:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Deletar o Produto: \n");
                        Console.ResetColor();

                        Console.WriteLine("Digite o id do produto: ");
                        id = Convert.ToInt32(Console.ReadLine());

                        produto.DeletarProduto(id);

                        Console.ForegroundColor = ConsoleColor.Green;
                        KeyPress();
                        Console.ResetColor();
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Opção inválida");
                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.Green;
                        KeyPress();
                        Console.ResetColor();
                        break;

                }
                static void KeyPress()
                {
                    do
                    {

                        Console.WriteLine("Pressione enter para continuar!");
                        consoleKeyInfo = Console.ReadKey();
                    } while (consoleKeyInfo.Key != ConsoleKey.Enter);













                }
            }
        }
    }
}
