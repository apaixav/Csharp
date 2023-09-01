using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaGames
{
    public class Jogo : Games
    {
        private int pecas;
        public Jogo(string nome, int genero, double preco, int classificacao, double nota, int pecas)
            : base(nome, genero, preco, classificacao, nota)
        {
            this.pecas = pecas;
        }
        public int GetPeças()
        {
            return pecas;
        }

        public void SetPeças(int pecas)
        {
            this.pecas = pecas;
        }
        public override void Visualizar()
        {

            base.Visualizar();
            Console.WriteLine($"O número de peças do jogo é:{this.pecas}");
        }
    }
}
