namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numero1, numero2;

            Console.WriteLine("digite o primeiro número: ");
            numero1=Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("digite o segundo número: ");
            numero2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine($"{numero1} + {numero2} = "+ (numero1 + numero2));
            Console.WriteLine($"{numero1} - {numero2} = " + (numero1 - numero2));
            Console.WriteLine($"{numero1} * {numero2} = " + (numero1 * numero2));

            if(numero2 > 0) 
                Console.WriteLine($"{numero1} / {numero2} = {0:##}" + (numero1 / numero2));
            else
                Console.WriteLine("Não existe divisão por zero!");

            Console.WriteLine($"{numero1} ^ {numero2} = " + Math.Pow(numero1, numero2));
            Console.WriteLine($"Raiz quadrade de {numero1} é = " + Math.Sqrt(numero1));
        }
    }
}