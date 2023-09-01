using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaGames
{
    public class VideoGame : Games
    {
        private int console;
        public VideoGame(string nome, int genero, double preco, int classificacao, double nota, int console)
            : base(nome, genero, preco, classificacao, nota)
        {
            this.console = console;
        }
        public int GetConsole()
        {
            return console;
        }

        public void SetConsole(int console)
        {
            this.console = console;
        }

        public override void Visualizar()
        {
            string console = "";

            switch (this.console)
            {
                case 1:
                    console = "Xbox";
                    break;
                case 2:
                    console = "PlayStation";
                    break;
                case 3:
                    console = "Pc";
                    break;
                case 4:
                    console = "Nintendo Switch";
                    break;

                default:
                    console = "Outros";
                    break;

            }
            base.Visualizar();
            Console.WriteLine($"O Console do jogo é :{console}");

        }
    }
}
