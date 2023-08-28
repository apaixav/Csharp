namespace ExercícioVetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor1 = { 2, 5, 1, 3, 4, 9, 7, 8, 10, 6 };
            int compara = 0;


                Console.WriteLine("Digite um número: ");
            compara = Convert.ToInt32(Console.ReadLine());


            for (int indice = 0; indice < vetor1.Length; indice++)
            {
                if (compara == vetor1[indice])
                {
                    Console.WriteLine($"O número {compara}, está na posição:{indice}");
                }

                else
                {
                    Console.WriteLine($"O número {compara}, não foi encontrado");
                    break;
                }
            }
        }
    }
}