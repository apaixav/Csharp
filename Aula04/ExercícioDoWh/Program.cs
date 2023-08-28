namespace DoWh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 1 , soma = 0;

            do
            {
                Console.WriteLine("Digite um número: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero > 0)
                {
                  
                    soma += numero;
                }


            } while (numero != 0);
         
            


            Console.WriteLine($"A soma dos numeros positivos é: {soma}");
        }
    }
}