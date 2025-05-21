using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    internal class Diretor
    {
        //Classes 
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        //Metodo retornavel 
        public double GetBonificacao()
        {
            return Salario;
        }
    }
}

