namespace Exercício02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? nome;
            int idade;
            bool  sim = true, nao = false;

            Console.WriteLine("Informe o seu nome");
            nome = Console.ReadLine();

            Console.WriteLine("Informe o sua idade");
            idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Já doou sangue uma vez ?:");
             sim = Convert.ToBoolean(Console.ReadLine());



            if (idade >= 18 && idade <= 69 && sim)
            {
                Console.WriteLine($"{nome} está apto a doar sangue");
            }
            else if (idade >= 18 && idade <= 69 && nao)
            {
                Console.WriteLine($"{nome} está apto a doar sangue");
            }
            else if (idade >= 60 && idade <= 69 && nao)
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