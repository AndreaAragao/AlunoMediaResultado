using System;
using System.Collections.Generic;
using System.Text;

namespace Projetos07.App
{
    internal class Aluno
    {
        public string Nome { get; private set; }
        public double Nota1 { get; private set; }
        public double Nota2 { get; private set; }
        public double Nota3 { get; private set; }

        public Aluno(string nome, double nota1, double nota2, double nota3)
        {
            Nome = nome;
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;
        }

        private double calcularMedia()
        {
            return (Nota1 + Nota2 + Nota3) / 3;
        }

        private string calcularResultado()
        {
            if (calcularMedia() < 4)
            {
                return "Reprovado";
            }
            else if (calcularMedia() >= 4 && calcularMedia() < 6)
            {
                return "Exame Especial";
            }
            else
            {
                return "Aprovado";
            }
        }

        public override string ToString()
        {
            //return nome + " média " + (calcularMedia()).tostring("f2") + " " + calcularResultado(); 
            return $"{Nome} média {calcularMedia().ToString("F2")} {calcularResultado()}";
        }
    }
}
