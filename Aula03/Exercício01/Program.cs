namespace Exercício01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Informe o primeiro número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0 && numero > 0) {
                Console.WriteLine($"O número {numero} é par e positivo");
            }
            else if (numero % 2 == 1 && numero > 0) {
                Console.WriteLine($"O número {numero} é ímpar e positivo");
            }
            else if (numero % 2 == 1 && numero < 0) {
                Console.WriteLine($"O número {numero} é ímpar e negativo");
            }
            else
            {
                Console.WriteLine($"O número {numero} é par e negativo");
            }
        }
    }
}
