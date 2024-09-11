using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        
            static void Main(string[] args)
            {

                Console.WriteLine("Bem vindo ao sistema de cadastro");
                Console.WriteLine("Digite 1- para cadastrar uma pessoa ");
                Console.WriteLine("Digite 2 - para cadastrar clientes");
                Console.WriteLine("Digite 3- para cadastrar Funcionarios ");
                Console.WriteLine("Digite 4 - para cadastrar gerentes");
                Console.WriteLine("Digite 5- para cadastrar um novo diretor");

                int num = int.Parse(Console.ReadLine());

                switch (num)
                {
                    case 1:
                        Pessoa pessoa = new Pessoa();

                        pessoa.CastrarTelefone();
                        pessoa.CadastrarEmail();
                        pessoa.CadastrarCpf();
                        break;
                    case 2:
                        Cliente cliente = new Cliente();
                        cliente.CastrarTelefone();
                        cliente.CadastrarEmail();
                        cliente.CadastrarCpf();
                        cliente.AlterarTipo();
                        cliente.AlterarEndereco();
                        break;
                    case 3:
                        Funcionario funcionarios = new Funcionario();
                        funcionarios.CadastrarSalario();
                        funcionarios.CastrarTelefone();
                        funcionarios.CadastrarCargo();
                        funcionarios.CadastrarTurno();
                        funcionarios.CadastrarEmail();
                        funcionarios.CadastrarCpf();
                        funcionarios.CadastrarRegistro();
                        funcionarios.CadastrarNascimento();
                        funcionarios.CadastrarCep();
                        break;
                    case 4:
                        Gerente gerente = new Gerente();
                        gerente.CadastrarSalario();
                        gerente.CastrarTelefone();
                        gerente.CadastrarCargo();
                        gerente.CadastrarTurno();
                        gerente.CadastrarEmail();
                        gerente.CadastrarCpf();
                        gerente.CadastrarRegistro();
                        gerente.CadastrarNascimento();
                        gerente.CadastrarCep();
                        gerente.informeSetor();
                        break;
                    case 5:
                        Diretor diretor = new Diretor();
                        diretor.CadastrarSalario();
                        diretor.CastrarTelefone();
                        diretor.CadastrarCargo();
                        diretor.CadastrarTurno();
                        diretor.CadastrarEmail();
                        diretor.CadastrarCpf();
                        diretor.CadastrarRegistro();
                        diretor.CadastrarNascimento();
                        diretor.CadastrarCep();
                        break;
                    





            }
            }
        
    }
}
