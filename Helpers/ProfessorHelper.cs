using System;
using Faculdade.Entities;

namespace Faculdade.Helpers
{
    public static class ProfessorHelper
    {
        public static void ImprimirDetalhes(Professor professor)
        {
            Console.WriteLine($"ID: {professor.ProfessorId}");
            Console.WriteLine($"Nome: {professor.Nome}");
            Console.WriteLine($"Situação: {professor.Situacao}");
        }
    }
}
