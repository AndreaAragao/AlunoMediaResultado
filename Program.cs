using Projetos07.App;
using System;

namespace Projetos07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            do
            {
                Console.WriteLine("Digite 1 para avaliar um aluno ou 0 para sair: \n");
                opcao = int.Parse(Console.ReadLine());
                if(opcao == 1)
                {
                    string nome;
                    double nota1, nota2, nota3;

                    Console.WriteLine("\nDigite o nome do aluno:");
                    nome = Console.ReadLine();

                    Console.WriteLine("\nDigite a primeira nota:");
                    nota1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("\nDigite a segunda nota:");
                    nota2 = double.Parse(Console.ReadLine());

                    Console.WriteLine("\nDigite a terceira nota:");
                    nota3 = double.Parse(Console.ReadLine());

                    Aluno aluno = new Aluno(nome, nota1, nota2, nota3);

                    Console.WriteLine(aluno);
                }
                else
                {
                    opcao = 0;
                }
            }
            while (opcao == 1);
        }
    }
}
