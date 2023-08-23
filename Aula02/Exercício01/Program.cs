namespace Exercício01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float salario = 10000, abono = 1000, salarioNovo;

            salarioNovo = salario + abono;

            Console.WriteLine($"O salário de R${salario}, junto como o abono de R${abono} entrega novo salário de de: " + "R$" + salarioNovo);
            
        }
    }
}