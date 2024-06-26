using System.Collections.Generic;

namespace Faculdade.Entities
{
    public class Curso
    {
        public int CursoId { get; set; }
        public string Nome { get; set; }
        public TipoCurso Tipo { get; set; }
        public ICollection<Disciplina> Disciplinas { get; set; }
    }
}
