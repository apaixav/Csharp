namespace ExercícioLista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cores = new List<string>();
                       
            while (cores.Count < 5)
            {
                Console.WriteLine("informe a cor: ");
                string? nome = Console.ReadLine();
                cores.Add(nome);
                Console.Clear();
            }

            Console.WriteLine("\nLista de cores :");
            foreach (var cor in cores)
            {
                Console.WriteLine(cor);
            }
            Console.WriteLine("\nOrdem de cores :");
            cores.Sort();

            foreach(var cor in cores)
            {
                Console.WriteLine(cor);
            }

        }
    }
}