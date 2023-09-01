using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioHeranca
{
    public class Cliente
    {
        private string telefone;
        private int idade;
        private string nome;
        private string email;
        private int genero;

        public Cliente(string nome, string telefone, int idade, string email, int genero)
        {
            this.telefone = telefone;
            this.idade = idade;
            this.nome = nome;
            this.email = email;
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
            return telefone;
        }

        public void SetTelefone(string telefone)
        {
            this.telefone = telefone;
        }

        public int GetIdade()
        {
            return idade;
        }

        public void SetIdade(int idade)
        {
            this.idade = idade;
        }


        public string GetEmail()
        {
            return email;
        }

        public void SetEmail(string email)
        {
            this.email = email;
        }
        
        public int GetGenero()
        {
            return genero;
        }

        public void SetGenero(int genero)
        {
            this.genero = genero;
        }

        public virtual void Visualizar()
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
            Console.WriteLine($"Nome do cliente: {this.nome} ");
            Console.WriteLine($"Cpf do Cliente: {this.telefone} ");
            Console.WriteLine($"Idade do Cliente: {this.idade} ");
            Console.WriteLine($"Olhos do Cliente: {this.email}");
            Console.WriteLine($"Gênero do Cliente: {genero} ");

        }

    }
}