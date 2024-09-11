using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Gerente : Funcionario
    {
        protected string setor;

        public string informeSetor()
        {
            Console.WriteLine("Informe seu Setor de Gerencia");
            setor = Console.ReadLine();
            return setor;
        }
    }
}
