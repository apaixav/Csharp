namespace Exercício02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3, nota4, media;

            Console.WriteLine("digite a primeira nota: ");
            nota1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("digite a segunda nota: ");
            nota2 = Convert.ToSingle(Console.ReadLine());
            
            Console.WriteLine("digite a terceira nota: ");
            nota3 = Convert.ToSingle(Console.ReadLine());
            
            Console.WriteLine("digite a quarta nota: ");
            nota4 = Convert.ToSingle(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            Console.WriteLine($"A média da {nota1} + {nota2} + {nota3} + {nota4} é = " + media);


        }
    }
}