namespace ExercicioFOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0, par = 0, impar = 0;


            for (int contador = 1; contador <= 10; contador++)
            {                              
                Console.WriteLine("Digite mais um número: ");
                numero = Convert.ToInt32(Console.ReadLine());
                

                if (numero % 2 == 0)
                {
                    par += 1;
                }
                else
                {
                    impar += 1;
                }
            }
            Console.WriteLine($"Existem {par} pares ");
            Console.WriteLine($"Existem {impar} impares");


        }
    }
}