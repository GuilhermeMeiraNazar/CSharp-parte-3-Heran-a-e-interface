using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Funcionario
    {
        //Classe tipo
        // 0 - funcionario
        // 1 - diretor
        // 2 - designer
        //private int _tipo;

        //Classes 
        public string Nome {  get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        //Metodo retornavel 
        //public Funcionario(int tipo)
        //{
        //    _tipo = tipo;
        //}
        public virtual double GetBonificacao() //GetBonificacao principal com a palavra reservada virtual 
        {
           return Salario * 0.10;
        }
    }
}
