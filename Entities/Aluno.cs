using System;
using Faculdade.Enums;

namespace Faculdade.Entities
{
    public class Aluno : Pessoa
    {
        public int AlunoId { get; set; }
        public SituacaoAluno Situacao { get; set; }
        public DateTime DataMatricula { get; set; }
        public ICollection<Matricula> Matriculas { get; set; }
    }
}
