using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class FuncionarioAutenticavel : Funcionario , IAutenticavel
    {

        public string Senha { get; set; }

        public FuncionarioAutenticavel( string cpf, double salario) : base (cpf,salario)
        {

        }

        public override void AumentarSalario()
        {
            throw new NotImplementedException();
        }

        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }

        public override double GetBonificacao()
        {
            throw new NotImplementedException();
        }
    }
}
