using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor :Funcionario
    {
        
        public Diretor(string cpf) : base(cpf,5000)
        {
         
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
        public override double GetBonificacao()
        {
            return this.Salario;
        }
    }
}
