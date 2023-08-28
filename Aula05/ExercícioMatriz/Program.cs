namespace ExercícioMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3,3];
            int somap = 0,somad=0;


            for (int indiceLinha = 0; indiceLinha < Math.Sqrt(matriz.Length); indiceLinha++)
            {
                for (int indiceColuna = 0; indiceColuna < Math.Sqrt(matriz.Length); indiceColuna++)
                {
                    Console.Write($"informe o número[{indiceLinha}, {indiceColuna}] = ");
                    matriz[indiceLinha, indiceColuna] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int indiceLinha = 0; indiceLinha < Math.Sqrt(matriz.Length); indiceLinha++)
            {
                for (int indiceColuna = 0; indiceColuna < Math.Sqrt(matriz.Length); indiceColuna++)
                {
                    if (indiceLinha == indiceColuna)
                    {
                        Console.WriteLine($"A matriz principal é = {matriz[indiceLinha, indiceColuna]}");                    
                            somap += matriz[indiceLinha, indiceColuna];
                       
                    }
                    
                }
            }
            for (int indiceLinha = 0; indiceLinha < matriz.GetLength(0); indiceLinha++)
            {
                for (int indiceColuna = 0; indiceColuna < matriz.GetLength(1); indiceColuna++)
                {

                    if ((indiceColuna + indiceLinha) == (matriz.GetLength(0) - 1))
                    {
                        Console.WriteLine($"A matriz secundária é = {matriz[indiceLinha, indiceColuna]}");
                        somad += matriz[indiceLinha, indiceColuna];
                    }
                }
            }

                Console.WriteLine($"a soma da diagonal principal é: {somap}");
                Console.WriteLine($"a soma da diagonal secundária é: {somad}");
        }
    }
}