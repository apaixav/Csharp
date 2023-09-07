using Farmacia.Model;
using Farmacia.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Farmacia.Controller
{
    public class ProdutoController : IFarmaciaRepository
    {

        private readonly List<Produto> listaProduto = new();
        int id = 0;

        public void AtualizarProduto(Produto produto)
        {
            var buscaProduto = BuscarNaCollection(produto.GetId());

            if (buscaProduto is not null)
            {
                var index = listaProduto.IndexOf(buscaProduto);

                listaProduto[index] = produto;

                Console.WriteLine($"O Produto Id {produto.GetId()}, foi atulizado com sucesso!");
            }
        }

    

        public void ConsultarporId(int id)
        {
            var produto = BuscarNaCollection(id);

            if (produto is not null)
            {
                produto.Visualizar();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"A conta numero {id}, não foi encontrada");
                Console.ResetColor();
            }
        }

            public void CriarProduto(Produto produto)
            {
                listaProduto.Add(produto);
                Console.WriteLine($"O Produto de id {produto.GetId()} foi criado com sucesso"); ;
            }

            public void DeletarProduto(int id)
            {
                var produto = BuscarNaCollection(id);

                if (produto is not null)
            {
                if (listaProduto.Remove(produto) == true)
                    Console.WriteLine($"O Produto de id{id} foi apagado com suceso!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"O Produto de id {id}, não foi encontrado");
                Console.ResetColor();
            }
        }

            public void ListarProdutos()
            {
                foreach (var produto in listaProduto)
                {
                    produto.Visualizar();
                }
            }

        public int GerarId()
        {
            return ++id;
        }

        public Produto? BuscarNaCollection(int id)
        {
            foreach (var produto in listaProduto)
            {
                if (produto.GetId() == id)
                    return produto;
            }

            return null;
        }
    }
}
