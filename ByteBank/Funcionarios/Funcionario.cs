using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Funcionario
    {
        public static int TotalDeFuncionarios {  get; private set; }
        //Classe tipo
        // 0 - funcionario
        // 1 - diretor
        // 2 - designer
        //private int _tipo;

        //Classes 
        public string Nome {  get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        //Contrututor
        public Funcionario(double salario ,string cpf) 
        { 
            CPF = cpf;
            Salario = salario;

            TotalDeFuncionarios ++;
        }

        public virtual void AumentarSalario()
        {
            //Salario = Salario + (Salario * 0.10);
            //Salario = Salario *1.1;
            Salario *= 1.1;
        }

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
