using System;
using Faculdade.Entities;

namespace Faculdade.Helpers
{
    public static class CursoHelper
    {
        public static void ImprimirDetalhes(Curso curso)
        {
            Console.WriteLine($"ID: {curso.CursoId}");
            Console.WriteLine($"Nome: {curso.Nome}");
            Console.WriteLine($"Tipo: {curso.Tipo}");
        }
    }
}
