using System;
using Faculdade.Entities;

namespace Faculdade.Helpers
{
    public static class AlunoHelper
    {
        public static void ImprimirDetalhes(Aluno aluno)
        {
            Console.WriteLine($"ID: {aluno.AlunoId}");
            Console.WriteLine($"Nome: {aluno.Nome}");
            Console.WriteLine($"Situação: {aluno.Situacao}");
            Console.WriteLine($"Data de Matrícula: {aluno.DataMatricula}");
        }
    }
}
