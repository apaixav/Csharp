namespace Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int[] vetor2 = new int[5];

            string[] vetor3 = { "Allan", "Ingrid", "João", "Gabriel", "Shomara", "Karina", "Jacque", "Ingrid" };

             for (int indice = 0; indice < 10; indice++)
            {
                Console.WriteLine($"Vetor1 [{indice}] = {vetor1[indice]}");
            }
            /*Console.WriteLine("\n");
            for (int indice = 0; indice < 5; indice++)
            {
                Console.Write($"Vetor2 [{indice}] = ");
                vetor2[indice] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n");

            Array.Sort(vetor2);

            for (int indice = 0; indice < vetor2.Length; indice++)
            {
                Console.WriteLine($"Vetor2 [{indice}] = {vetor2[indice]}");
            }
            Console.WriteLine("\n");

            Array.Reverse(vetor2);

            for (int indice = 0; indice < vetor2.Length; indice++)
            {
                Console.WriteLine($"Vetor2 [{indice}] = {vetor2[indice]}");
            }         

            Array.Sort(vetor3);

            for (int indice = 0; indice < vetor3.Length; indice++)
            {
                Console.WriteLine($"Vetor2 [{indice}] = {vetor3[indice]}");
            }

            Console.WriteLine(Array.IndexOf(vetor3, "Ingrid"));

            Console.WriteLine(Array.BinarySearch(vetor3, "Ingrid"));

            for (int indice = 0; indice < vetor1.Length; indice++)
            {
                if (vetor1[indice] %2 == 0 )
                Console.WriteLine($"Vetor1 [{indice}] = {vetor1[indice]}");*/
        }
    }
        

}