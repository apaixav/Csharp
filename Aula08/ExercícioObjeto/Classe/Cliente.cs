using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExercícioObjeto.Classe
{
    public class Cliente
    {
        private string cpf;
        private int idade;
        private string nome;
        private bool olho;
        private int genero;

        public Cliente(string nome,string cpf, int idade , bool olho, int genero)
        {
            this.cpf = cpf;
            this.idade = idade;
            this.nome = nome;
            this.olho = olho;
            this.genero = genero;
        }

        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }
        public string GetCpf()
        {
            return cpf;
        }

        public void SetCpf(string cpf)
        {
            this.cpf = cpf;
        }

        public int GetIdade()
        {
            return idade;
        }

        public void SetIdade(int idade)
        {
            this.idade = idade;
        }


        public bool GetOlho()
        {
            return olho;
        }

        public void SetOlho(bool olho)
        {
            this.olho = olho;
        }
        public bool Dois(bool olhos)
        {
            if (this.olho = olhos )
            {
            Console.WriteLine($" {olhos} /O cliente é considerado padrão");
            return true;
            }
              Console.WriteLine($" {olhos} /O cliente não é um cliente padrão");
               return false;

        }

        public int GetGenero()
        {
            return genero;
        }

        public void SetGenero(int genero)
        {
            this.genero = genero;
        }

        public void Visualizar()
        {
            string genero = "";

            switch (this.genero)
            {
                case 1:
                    genero = "Masculino";
                    break;
                case 2:
                    genero = "Feminino";
                    break;
                case 3:
                    genero = "Transgênero";
                    break;
                case 4:
                    genero = "Genero neutro";
                    break;

                default:
                    genero = "Outros";
                    break;

            }

            Console.WriteLine("*******************************");
            Console.WriteLine("Dados do Cliente");
            Console.WriteLine("*******************************");
            Console.WriteLine($"Nome do cliente:{this.nome} ");
            Console.WriteLine($"Cpf do Cliente: {this.cpf} ");
            Console.WriteLine($"Idade do Cliente: {this.idade} ");
            Console.WriteLine($"Olhos do Cliente: {this.olho}");
            Console.WriteLine($"Gênero do Cliente: {genero} ");

        }
        
    }
}
