using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Pessoa
    {
        public string nome;
        protected string email;
        private string cpf;
        protected string telefone;



        public string CadastrarEmail()
        {
            Console.WriteLine("Qual é o novo E-mail ?");
            email = Console.ReadLine();
            return email;
        }
        public string CastrarTelefone()
        {
            Console.WriteLine("Qual é o novo telefone?");
            telefone = Console.ReadLine();
            return telefone;
        }

        public string CadastrarCpf()
        {
            Console.WriteLine("Qual é o novo cpf ?");
            cpf = Console.ReadLine();
            return cpf;
        }
    }
}
