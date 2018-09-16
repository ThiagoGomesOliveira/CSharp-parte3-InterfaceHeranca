using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistemas
{
    public class Autenticavel: Funcionario
    {

        public string Senha { get; set; }

        public Autenticavel(string cpf, double salario) : base(cpf, salario)
        {

        }


        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }


        public override double GetBonificacao()
        {
            throw new NotImplementedException();
        }

        public override void AumentarSalario()
        {
            throw new NotImplementedException();
        }
    }
}
