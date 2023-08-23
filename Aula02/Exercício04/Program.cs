namespace Exercício04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numero1, numero2, numero3, numero4, produtoDiferença;

            Console.WriteLine("digite o primeiro número: ");
            numero1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("digite o segundo número: ");
            numero2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("digite o terceiro número: ");
            numero3 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("digite o quarto número: ");
            numero4 = Convert.ToSingle(Console.ReadLine());

            produtoDiferença = (numero1 * numero2) - (numero3 * numero4);

            Console.WriteLine($"a diferença do produto entre as variáveis {numero1} * {numero2} e {numero3} * {numero4} é = " + produtoDiferença);
        }
    }
}