using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Funcionario : Pessoa
    {
        public string cep;
        protected string cargo;
        protected string turno;
        private string registro;
        private string dataNasc;
        protected string salario;

        public string CadastrarCep()
        {
            Console.WriteLine("Informe seu cep");
            cep = Console.ReadLine();
            return cep;
        }

        public string CadastrarCargo() {


            Console.WriteLine("Informe seu Cargo");
            cargo = Console.ReadLine();
            return cargo;
        }

        public string CadastrarTurno() {


            Console.WriteLine("Informe seu turno");
            turno = Console.ReadLine();
            return turno;
        }

        public string CadastrarRegistro() {


            Console.WriteLine("Informe seu Número de Registro");
            registro = Console.ReadLine();
            return registro;
        }

        public string CadastrarNascimento() {


            Console.WriteLine("Informe Sua Data de Nascimento");
            dataNasc = Console.ReadLine();
            return dataNasc;
        }

        public string CadastrarSalario() { 
           

            Console.WriteLine("Informe Seu Salário");
            salario = Console.ReadLine();
            return salario ;
            

        }
    }
}
