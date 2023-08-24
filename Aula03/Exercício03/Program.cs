namespace Exercício03
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            int codigo;
            float quantidade, preço;

            Console.WriteLine("Escolha um dos produtos abaixo: ");

            Console.WriteLine("1 - Cachorro Quente ");
            Console.WriteLine("2 - X — Salada");
            Console.WriteLine("3 - X — Bacon");
            Console.WriteLine("4 - Bauru");
            Console.WriteLine("5 - Refrigerante");
            Console.WriteLine("6 - Suco de laranja");

            Console.WriteLine("Informe o código do produto: ");
            codigo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a quantidade: ");
            quantidade = Convert.ToSingle(Console.ReadLine());

            switch (codigo)
            {
                case 1:
                    preço = (quantidade * 10);
                    break;
                case 2:
                    preço = (quantidade * 15);
                    break;
                case 3:
                    preço = (quantidade * 18);
                    break;
                case 4:
                    preço = (quantidade * 12);
                    break;
                case 5:
                    preço = (quantidade * 8);
                    break;
                default:
                    preço = (quantidade * 13);
                    break;
            }
            if (codigo == 1)
            {
                Console.WriteLine($"Produto: Cachorro Quente ");
            }
            else if (codigo == 2)
            {
                Console.WriteLine($"Produto: X - Salada ");
            }
            else if(codigo == 3)
            {
                Console.WriteLine($"Produto: X - Bacon ");
            }
            else if (codigo == 4)
            {
                Console.WriteLine($"Produto: Bauru ");
            }
            else if (codigo == 5)
            {
                Console.WriteLine($"Produto: Refrigerante ");
            }
            else 
            {
                Console.WriteLine($"Produto: Suco de Laranja ");
            }
                Console.WriteLine($"E a compra teve valor total de : R${preço:0.00}");
        }
    }
}