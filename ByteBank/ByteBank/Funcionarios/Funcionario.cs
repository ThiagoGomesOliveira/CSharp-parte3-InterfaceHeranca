using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
   public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario( string cpf, double salario)
        {
            TotalDeFuncionarios++;
            this.Cpf = cpf;
            this.Salario = salario;
        }

        public abstract double GetBonificacao();
        
        public abstract void AumentarSalario();

    }
}
