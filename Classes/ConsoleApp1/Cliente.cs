using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Cliente : Pessoa
    {
        protected string tipo;
        protected string endereco;
        private string cpf;


        public string AlterarTipo()
        {
            Console.WriteLine("Qual é o tipo de cliente ?");
            tipo = Console.ReadLine();
            return tipo;
        }

        public string AlterarEndereco()
        {
            Console.WriteLine("Qual o novo endereço ?");
            endereco = Console.ReadLine();
            return endereco;
        }
    }
}
