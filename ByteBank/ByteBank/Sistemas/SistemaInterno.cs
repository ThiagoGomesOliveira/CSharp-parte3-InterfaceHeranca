using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ByteBank.Sistemas
{
   public class SistemaInterno
    {

        public bool Logar(Autenticavel funcionario , string senha)
        {
            bool funcionarioAutenticado = funcionario.Autenticar(senha);
            if (funcionarioAutenticado)
            {
                Console.WriteLine("Bem Vindo ao Sistema");
                return true;
            }
            Console.WriteLine("Senha Incorreta");
            return false;
        }



    }
}