using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Diretor : Funcionario
    {
        private string cpf;

        public string cadastroCPF()
        {
            Console.WriteLine("Informe Seu CPF");
            cpf = Console.ReadLine();
            return cpf;
        }
    }
}
