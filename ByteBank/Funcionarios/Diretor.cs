using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : Funcionario // colocando "Dois pontos(:)" estou dizendo que Diretor é um funcionario
    {
        public Diretor(string cpf) : base(cpf)
        {
        }

        //Classes 

        //Metodo retornavel 
        public override double GetBonificacao() //GetBonificacao sendo rescrito pelo override 
        {
            return Salario + base.GetBonificacao(); // estou usando base para referenciar o GetBonificacao base que esta dentro do funcionario, para que não fique em um loop de GetBonificacao chamando outro GetBonificacao
        }
    }
}

