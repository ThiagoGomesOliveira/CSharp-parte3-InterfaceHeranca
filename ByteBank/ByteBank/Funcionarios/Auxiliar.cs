﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Auxiliar : Funcionario
    {

        public Auxiliar(string cpf) : base(cpf,2000)
        {
            this.Cpf = cpf;
        }
    }
}