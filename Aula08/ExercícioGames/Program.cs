using ExercícioGames.Classe2;

namespace ExercícioGames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Games g1 = new Games("Shadow of the Colossus",5 ,99.5,12,9.7);
            Games g2 = new Games("Elden Ring", 4, 299.90, 17, 9.1);


            g1.Visualizar();
            g1.SetPreço(150.00);
            g1.Visualizar();

            g1.Aumento(15.00);

            g1.Visualizar();

            g1.Desconto(1000);

            g1.Visualizar();

            g2.Visualizar();                      

            g2.Aumento(20.00);

            g2.Visualizar();

            g2.Desconto(70);

            g2.Visualizar();
        }
    }
}