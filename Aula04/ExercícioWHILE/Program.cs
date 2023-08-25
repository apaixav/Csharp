namespace ExercícioWHILE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float idade = 1, mais50 = 0, menos21 = 0;


            while (true)
            {
                Console.WriteLine("Digite a idade ");
                idade = Convert.ToSingle(Console.ReadLine());
                idade++;
                if (idade <= 0)
                    break;

                if (idade > 50)
                {
                    mais50 += 1;
                }
                else if (idade < 21)
                {
                    menos21 += 1;
                }
            }
            Console.WriteLine($"O total de pessoas maiores de 50 anos é de:{mais50} ");
            Console.WriteLine($"O total de pessoas menores de 21 anos é de:{menos21} ");

        }
    }
}
