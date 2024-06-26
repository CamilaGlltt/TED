namespace Faculdade.Entities
{
    public class Matricula
    {
        public int MatriculaId { get; set; }
        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }
        public int DisciplinaId { get; set; }
        public Disciplina Disciplina { get; set; }
    }
}
