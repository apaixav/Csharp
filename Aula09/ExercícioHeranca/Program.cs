namespace ExercícioHeranca
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Cliente c1 = new Cliente("Lucas", "93333-3333", 27, "email@outolook.com", 1);
            Cliente c2 = new Cliente("Clara", "91111-1111", 22, "email@hotmail.com", 2);

            c1.Visualizar();
            c1.SetIdade(36);
            c1.Visualizar();
    
            c1.SetGenero(3);

            c1.Visualizar();

            c2.Visualizar();

            c2.SetGenero(5);

            c2.Visualizar();

            PessoaFisica pf1 = new PessoaFisica("Roberta", "95555-5555", 27, "email@gmail.com", 2,"XXX.XXX.XXX-XX");
            PessoaFisica pf2 = new PessoaFisica("Claudio", "96666-6666", 27, "email@gmail.com", 4, "XXX.XXX.XXX-XX");
            PessoaJuridica pj1 = new PessoaJuridica("Juliano", "94444-4444", 19, "email@hotmail.com", 3, "XX.XXX.XXX/0001-XX.");
            PessoaJuridica pj2 = new PessoaJuridica("Paulo", "97777-7777", 19, "email@outlook.com", 1, "XX.XXX.XXX/0001-XX.");

            pf1.Visualizar();
            pf2.Visualizar();

            pj1.Visualizar();
            pj2.Visualizar();
        }
    }
}