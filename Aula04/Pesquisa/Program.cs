﻿namespace Pesquisa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome, continua = "S";
            int idade, esporte, futebol = 0, voleibolM18 = 0, basquetebolM18 = 0;

            do
            {
                Console.WriteLine("Digite o seu nome: ");
                nome = Console.ReadLine();

                Console.WriteLine("Digite o sua idade: ");
                idade = Convert.ToInt32(Console.ReadLine());

                do
                {
                    Console.WriteLine("Digite o seu esporte favorito (1- futebol / 2- Volei / 3- Basquete/ 4- Outros): ");
                    esporte = Convert.ToInt32(Console.ReadLine());
                } while (esporte < 1 || esporte > 4);

                if (esporte == 1)
                    futebol++;

                if (esporte == 2 && idade > 18)
                    voleibolM18++;

                if (esporte == 3 && idade < 18)
                    basquetebolM18++;

                Console.WriteLine("Deseja continuar? (S/N): ");
                continua = Console.ReadLine().ToUpper();

            } while (continua.Equals("S"));

            Console.WriteLine($"Total de pessoas que gostam de futebol: {futebol}");
            Console.WriteLine($"Total de pessoas que gostam de voleibol maiores de 18 anos: {voleibolM18}");
            Console.WriteLine($"Total de pessoas que gostam de basquetebol menores que 18 anos: {basquetebolM18}");
        }
    }
}