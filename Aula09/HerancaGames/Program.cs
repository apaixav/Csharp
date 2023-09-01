using System.Net.Http.Headers;

namespace HerancaGames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Games g1 = new Games("Shadow of the Colossus", 5, 99.5, 12, 9.7);
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

            g2.Visualizar();*/


            VideoGame g1 = new VideoGame("Dark Souls", 2, 120.60, 13, 9.8, 1);
            VideoGame g2 = new VideoGame("Super Mario Bros", 0, 75.40, 10, 9.2,4);

            Jogo j1 = new Jogo("Detetive", 0, 130.00, 10, 8.7, 8);
            Jogo j2 = new Jogo("Banco Imobiliário", 0, 145.00, 10, 8.9, 4);

            g1.Visualizar();

            g2.Visualizar();

            j1.Visualizar();
            j2.Visualizar();

        }
    }
}