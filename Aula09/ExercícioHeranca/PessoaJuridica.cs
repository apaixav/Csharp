using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioHeranca
{
    public class PessoaJuridica : Cliente
    {

        private string cnpj;
        public PessoaJuridica(string nome, string telefone, int idade, string email, int genero, string cnpj)
            : base(nome, telefone, idade, email, genero)
        {
            this.cnpj = cnpj;
        }
        public string GetCnpj()
        {
            return cnpj;
        }

        public void SetCnpj(string cnpj)
        {
            this.cnpj = cnpj;
        }
        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Cnpj do Cliente: {cnpj}");
        }
    }
}
