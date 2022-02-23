using System;
using SistemaAcademico.Model;

namespace SistemaAcademico
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno objAluno = new Aluno(); //Aluno() método construtor
            Professor joao = new Professor();
            //int x;            
            //objAluno.cpf = 44328063870;
            //objAluno.dataNascimento = DateTime.Parse("25/09/1990");
            //joao.cpf = 221323;
            //objAluno.nome = "Maria";
            //joao.nome = "João Pedro";
            //
            //Console.WriteLine(objAluno.cpf);
            //Console.WriteLine(objAluno.nome);

            Console.WriteLine("Digite seu CPF");
            joao.cpf = Console.ReadLine();

            Console.WriteLine("Digite seu nome");
            joao.nome = Console.ReadLine();

            Console.WriteLine("Digite seu sálario");
            joao.salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite seu endereço:");
            joao.endereco = Console.ReadLine();

            Console.WriteLine("Digite seu telefone:");
            joao.telefone = Console.ReadLine();

            Console.WriteLine("Digite sua data de nascimento:");
            joao.dataNascimento = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("###############################");
            Console.WriteLine("Nome:" + joao.nome);
            Console.WriteLine("CPF:" + joao.cpf);
            Console.WriteLine("Sálario:" + joao.salario + 1000);
            Console.WriteLine("Endereço:" + joao.endereco);
            Console.WriteLine("Telefone:" + joao.telefone);
            Console.WriteLine("Data de Nascimento:" + joao.dataNascimento);
        }
    }
}
