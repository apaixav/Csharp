namespace Exercício03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float salarioBruto, adicional, horas, descontos, salarioLiquido;

            Console.WriteLine("O salário bruto é de quantos reais ?:  ");
            salarioBruto = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("O adicional noturno é de quantos reais ?: ");
            adicional = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("O valor pago pelas horas extras é de quantos reais ?: ");
            horas = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Os descontos são de quantos reais ?: ");
            descontos = Convert.ToSingle(Console.ReadLine());

            salarioLiquido = salarioBruto + adicional +( horas * 5) - descontos;

            Console.WriteLine($"O salário líquido é de = " + "R$" + salarioLiquido);
        }
    }
}