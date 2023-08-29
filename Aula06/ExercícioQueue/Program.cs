namespace ExercícioQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> menu = new Queue<string>();
            int opcao;

            do
            {
                Console.WriteLine("*********************************************");
                Console.WriteLine();
                Console.WriteLine("1 - Adicionar Cliente na Fila");
                Console.WriteLine("2 - Listar todos os Clientes");
                Console.WriteLine("3 - Remover Cliente da Fila");
                Console.WriteLine("0 - Sair");
                Console.WriteLine();
                Console.WriteLine("*********************************************");
                opcao = Convert.ToInt32(Console.ReadLine());


                switch (opcao)
                {
                    case 1:
                     
                         Console.WriteLine("digite o nome :\n");
                         string? nome = Console.ReadLine();
                         menu.Enqueue(nome);
                         break;
                     
                    case 2:
                        
                        Console.WriteLine("os clientes são :\n");
                            foreach (var cliente in menu)
                            {
                                Console.WriteLine(cliente);
                            }
                        break;

                    case 3:
                        if (menu.Count > 0)
                        {
                            menu.Dequeue();
                            foreach (var cliente in menu)
                            {
                                Console.WriteLine(cliente);
                            }
                            Console.WriteLine("O Cliente foi chamado");
                        }

                        else
                        {
                            Console.WriteLine("A fila está vazia");
                        }
                        break;

                    case 0:
                        Console.WriteLine("O Programa foi finalizado");
                        break;

                    default:
                        Console.WriteLine("Opção invalida");
                        break;
                }

            } while (opcao != 0);



        }


    }
}