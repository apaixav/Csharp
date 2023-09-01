using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaGames
{
    public class Games
    {

        private string nome;
        private int genero;
        private double preco;
        private int classificacao;
        private double nota;

        public Games(string nome, int genero, double preco, int classificacao, double nota)
        {
            this.nome = nome;
            this.genero = genero;
            this.preco = preco;
            this.classificacao = classificacao;
            this.nota = nota;
        }

        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }
        public double GetPreço()
        {
            return preco;
        }

        public void SetPreço(double preco)
        {
            this.preco = preco;
        }
        public bool Desconto(double valor)
        {
            if (valor > (0.25 * this.preco))
            {
                Console.WriteLine("O desconto não é possivel");
                return false;
            }

            this.SetPreço(this.preco - valor);
            return true;
        }

        public void Aumento(double valor)
        {
            this.SetPreço(this.preco + valor);
        }

        public int GetClassificação()
        {
            return classificacao;
        }

        public void SetClassificação(int classificacao)
        {
            this.classificacao = classificacao;
        }


        public double GetNota()
        {
            return nota;
        }

        public void SetOlho(double nota)
        {
            this.nota = nota;
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
                    genero = "Terror";
                    break;
                case 2:
                    genero = "Hack'n slash";
                    break;
                case 3:
                    genero = "Esportes";
                    break;
                case 4:
                    genero = "Rpg";
                    break;

                default:
                    genero = "Outros";
                    break;

            }

            Console.WriteLine("*******************************");
            Console.WriteLine("Dados do Jogo");
            Console.WriteLine("*******************************");
            Console.WriteLine($"Nome do Jogo:{this.nome} ");
            Console.WriteLine($"Cpf do Jogo: {genero} ");
            Console.WriteLine($"Preço do Jogo: " + (this.preco).ToString(format: "C"));
            Console.WriteLine($"Classificação do Jogo:" + "+" + this.classificacao);
            Console.WriteLine($"Nota do Jogo: {this.nota}" + "/10");

        }

    }
}