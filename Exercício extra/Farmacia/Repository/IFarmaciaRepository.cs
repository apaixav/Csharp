using Farmacia.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Repository
{
    public interface IFarmaciaRepository
    {
        public void CriarProduto(Produto produto);
        public void ListarProdutos();
        public void ConsultarporId(int id);
        public void AtualizarProduto(Produto produto);
        public void DeletarProduto(int id);


    }
}
