using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioHeranca
{
    public class PessoaFisica : Cliente
    {
        private string cpf;
        public PessoaFisica(string nome, string telefone, int idade, string email, int genero,  string cpf)
            : base(nome, telefone, idade, email, genero)
        {
            this.cpf = cpf;
        }
        public string GetCpf()
        {
            return cpf;
        }

        public void SetCpf(string cpf)
        {
            this.cpf = cpf;
        }
        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Cpf do Cliente: {cpf}");

        }
    }
}
