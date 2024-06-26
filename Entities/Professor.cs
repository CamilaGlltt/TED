namespace Faculdade.Entities
{
    public class Professor : Pessoa
    {
        public int ProfessorId { get; set; }
        public SituacaoFuncionario Situacao { get; set; }
        public ICollection<Disciplina> Disciplinas { get; set; }
    }
}
