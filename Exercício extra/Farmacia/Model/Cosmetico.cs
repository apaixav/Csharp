using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Model
{
    public  class Cosmetico : Produto
    {
        private string fragrancia;

        public Cosmetico(int id, string nome, int tipo, decimal preco, string fragrancia) : base(id, nome, tipo, preco)
        {
            this.fragrancia = fragrancia;
        }

        public string GetFragrancia()
        { 
            return fragrancia; 
        }
        public void SetFrangrancia(string fragrancia)
        {
            this.fragrancia= fragrancia;
        }
        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Tipo de Fragrância: {this.fragrancia}");

        }
    }
}
