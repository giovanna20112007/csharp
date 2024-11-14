using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores.Classes
{
    public class Aluno
    {
        public string Nome { get; set; }

        public int Matrícula { get; set; }

        public int Idade { get; set; }

        public Aluno (string nome, int matr, int idade)
        {
            Nome = nome;
            Matrícula = matr;
            Idade = idade;
        }


        public void ExibirDadosAlunos()
        {
            Console.WriteLine(@$"
            Nome: {Nome}
            Matrícula: {Matrícula}
            Idade: {Idade}
            ");
            
        }
    }
}
