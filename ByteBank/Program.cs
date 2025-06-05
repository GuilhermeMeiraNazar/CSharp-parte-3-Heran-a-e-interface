using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionarios;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario("2688598892");
            carlos.Nome = "Carlos";
            carlos.Salario = 2000;
            gerenciador.Registrar(carlos);

            Diretor roberta = new Diretor("79926865584");
            roberta.Nome = "Roberta";
            roberta.Salario = 5000;
            gerenciador.Registrar(roberta);

            Funcionario RobertaTeste = roberta;
            Console.WriteLine("Bonificação de uma referencia de direito " + roberta.GetBonificacao());
            Console.WriteLine("Bonificação de uma referencia de direito " + RobertaTeste.GetBonificacao());

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine("Total de bonificações: " + gerenciador.GetBonificacao());

            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            Console.ReadLine();
        }
    }
}
//teste