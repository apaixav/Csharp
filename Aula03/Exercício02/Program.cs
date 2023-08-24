namespace Exercício02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? nome;
            int idade, doacao;

            Console.WriteLine("Informe o seu nome");
            nome = Console.ReadLine();

            Console.WriteLine("Informe o sua idade");
            idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1 - Sim ");
            Console.WriteLine("2 - Não");

            Console.WriteLine("Já doou sangue uma vez ?:");
            doacao = Convert.ToInt32(Console.ReadLine());


            if (idade >= 18 && idade <= 69 && doacao == 1)
            {
                Console.WriteLine($"{nome} está apto a doar sangue");
            }
            else if (idade >= 18 && idade <= 69 && doacao == 2)
            {
                Console.WriteLine($"{nome} está apto a doar sangue");
            }
            else if (idade >= 60 && idade <= 69 && doacao == 2)
            {
                Console.WriteLine($"{nome} não está apto a doar sangue");
            }
            else
            {
                Console.WriteLine($"{nome} não está apto a doar sangue");
            }
        }
    }
}