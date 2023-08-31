using ExercícioGames.Classe2;

namespace ExercícioGames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Games g1 = new Games("Shadow of the Colossus",5 ,99.5,12,9.7);

            g1.Visualizar();
            g1.SetPreço(150.00);
            g1.Visualizar();

            g1.Aumento(15.00);

            g1.Visualizar();

            g1.Desconto(1000);

            g1.Visualizar();
        }
    }
}