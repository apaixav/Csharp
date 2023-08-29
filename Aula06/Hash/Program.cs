namespace Hash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> setNomes = new HashSet<string>()
            {
                "Jõao",
                "Allan",
                "Robson",
                "Ingrid",
                "Robson",
                "Allan",

            };
            foreach (var nome in setNomes)
            { 
                Console.WriteLine(nome);
            }
            setNomes.Add("Samantha");
            setNomes.Add(null);
            setNomes.Add("Julia");

            foreach (var nome in setNomes)
            {
                Console.WriteLine(nome);
            }// Checa se existe um elemento no HashSet
            Console.WriteLine("O Nome Julia existe? " + setNomes.Contains("Julia"));

            // Remove um elemento da HashSet
            setNomes.Remove("João");

            setNomes.Add("Julia");

            foreach (var nome in setNomes)
            {
                Console.WriteLine(nome);
            }

            // Converter HashSet em uma List
            List<string> hashList = setNomes.ToList();

            hashList.Sort();

            foreach (var hash in hashList)
            {
                Console.WriteLine(hash);
            }

        }
    }
}