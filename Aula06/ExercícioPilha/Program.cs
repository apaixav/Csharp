using System;

namespace ExercícioPilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> pilha = new Stack<string>();
            int opcao;
            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("*********************************************");
                Console.WriteLine("");
                Console.WriteLine("\t1 - Adicionar Livros na pilha");
                Console.WriteLine("\t2 - Listar todos os Livros");
                Console.WriteLine("\t3 - Retirar livro da pilha");
                Console.WriteLine("\t0 - Sair");
                Console.WriteLine("");
                Console.WriteLine("*********************************************");
                Console.WriteLine("\n");
                Console.WriteLine("\tEscolha uma das opções: ");
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Nome do livro: ");
                        string? nome = Console.ReadLine();
                        pilha.Push(nome);
                        Console.WriteLine($"O livro '{nome}', foi adicionado!");
                        Console.Clear();
                        break;

                    case 2:
                        Console.WriteLine("Lista de livros na pilha: \n");
                        foreach(var livro in pilha)
                        {
                            Console.WriteLine($"'{livro}'");
                        }
                       
                        break;
                       

                    case 3:
                        if (pilha.Count > 0)
                        {
                            pilha.Pop();
                            foreach (var livro in pilha)
                            {
                                Console.WriteLine($"'{livro}'");
                            }
                            Console.WriteLine("\nO Livro foi retirado da pilha!");
                        }

                        else
                        {
                            Console.WriteLine("\n A pilha está vazia!!");
                        }
                       
                        break;

                    case 0:
                        Console.WriteLine("Programa Finalizado!!");
                        break;

                    default:
                        Console.WriteLine("Opção invalida");
                        break;

                }
            } while (opcao != 0);
        }
    }
}
