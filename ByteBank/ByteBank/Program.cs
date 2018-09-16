using ByteBank.Funcionarios;
using ByteBank.Sistemas;
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
            LogarSistema();
            Console.ReadLine();
        }

        public static void InicializarPrograma()
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
            Diretor diretor = new Diretor("000.000.000-00");
            diretor.Nome = "Juliana";
            gerenciador.Registrar(diretor);
            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());
        }

        public static void LogarSistema()
        {
            Diretor diretor = new Diretor("000.000.000-00");
            diretor.Nome = "Juliana";
            diretor.Senha = "1234";

            SistemaInterno sistemaInterno = new SistemaInterno();
            sistemaInterno.Logar(diretor,"123");

        }

    }
}
