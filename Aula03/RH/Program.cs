namespace RH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? nome;
            int cargo;
            float salario, reajuste;


            Console.WriteLine("Informe o seu nome:" );
            nome = Console.ReadLine();

            Console.WriteLine("1 - Supervisor ");
            Console.WriteLine("2 - Diretor");
            Console.WriteLine("3 - Gerente");
            Console.WriteLine("4 - Outros");

            Console.WriteLine("Informe o seu cargo: ");
            cargo = Convert.ToInt32(Console.ReadLine());
                
            Console.WriteLine("Informe o seu salário: ");
            salario = Convert.ToSingle(Console.ReadLine());

            switch (cargo)
            {
                case 1:
                    reajuste = (salario * 7) / 100;
                    break;
                case 2:
                    reajuste = (salario * 9) / 100;
                    break;
                case 3:
                    reajuste = (salario * 5) / 100;
                    break;
                default:
                    reajuste = (salario * 12) / 100;
                    break;
            }
            Console.WriteLine($"O reajuste do salário do(a) funcionario(a) {nome} é de: {reajuste}");
            Console.WriteLine($"O novo salário do(a) funcionario(a) {nome} é de: {reajuste + salario}");
        }
    }
}