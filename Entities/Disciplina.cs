namespace Faculdade.Entities
{
    public class Disciplina
    {
        public class Disciplina : Entidade
        public int DisciplinaId { get; set; }
        public string Nome { get; set; }
        public TipoDisciplina Tipo { get; set; }
        public int CursoId { get; set; }
        public Curso Curso { get; set; }
        public int ProfessorId { get; set; }

    public List<Matricula> Matriculas { get; } = new();
    }
}
