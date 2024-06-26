namespace Faculdade.Entities
{
    public class Disciplina
    {
        public int DisciplinaId { get; set; }
        public string Nome { get; set; }
        public TipoDisciplina Tipo { get; set; }
        public int CursoId { get; set; }
        public Curso Curso { get; set; }
    }
}
