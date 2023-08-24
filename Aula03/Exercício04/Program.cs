namespace Exercício04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numero1, numero2, operacao;
            int codigo;

            Console.WriteLine("digite o primeiro número: ");
            numero1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("digite o segundo número: ");
            numero2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Escolha uma das operações abaixo: ");

            Console.WriteLine("1 - Soma ");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");

            Console.WriteLine("Informe o código do produto: ");
            codigo = Convert.ToInt32(Console.ReadLine());

            switch (codigo)
            {
                case 1:
                    operacao = (numero1 + numero2);
                    break;
                case 2:
                    operacao = (numero1 - numero2);
                    break;
                case 3:
                    operacao = (numero1 * numero2);
                    break;
                default:
                    operacao = (numero1 / numero2);
                    break;
            }
            if (codigo == 1)
            {
                Console.WriteLine($"{numero1} + {numero2} = {operacao}");
            }
            else if (codigo == 2)
            {
                Console.WriteLine($"{numero1} - {numero2} = {operacao}");
            }
            else if (codigo == 3)
            {
                Console.WriteLine($"{numero1} * {numero2} = {operacao}");
            }
            else
            {
                Console.WriteLine($"{numero1} / {numero2} = {operacao}");
            }
        }
    }
}