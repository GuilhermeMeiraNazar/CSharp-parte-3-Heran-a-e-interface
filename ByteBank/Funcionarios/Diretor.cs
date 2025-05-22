using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : Funcionario // colocando "Dois pontos(:)" estou dizendo que Diretor é um funcionario
    {
        //Classes 

        //Metodo retornavel 
        public double GetBonificacao()
        {
            return Salario;
        }
    }
}

