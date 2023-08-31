using ExercícioObjeto.Classe;

namespace ExercícioObjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente("Lucas", "267.593.722-64", 27, true, 1);
            Cliente c2 = new Cliente("Clara", "726.953.271-46", 22, true, 2);

            c1.Visualizar();
            c1.SetIdade(36);
            c1.Visualizar();

            c1.Dois(false);

            c1.Visualizar();

            c1.SetGenero(3);

            c1.Visualizar();

            c2.Visualizar();
            
            c2.Dois(true);

            c2.Visualizar();

            c2.SetGenero(2);

            c2.Visualizar();
        }
    }
}