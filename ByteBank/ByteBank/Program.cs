using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
            Funcionario funcionario = new Funcionario();
            funcionario.Nome = "Thiago Gomes Oliveira";
            funcionario.Cpf = "xxx.xxx.xxx-xx";
            funcionario.Salario = 2000;

            Diretor diretor = new Diretor();
            diretor.Nome = "Juliana";
            diretor.Cpf = "xxx.xxx.xxx-xx";
            diretor.Salario = 5000;

            gerenciador.Registrar(funcionario);
            gerenciador.Registrar(diretor);

            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());
            Console.ReadLine();
        }
    }
}
