using System;
using Faculdade.Enums;

namespace Faculdade.Entities
{
    public abstract class Pessoa : Entidade
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public Sexo? Sexo { get; set; }
        public EstadoCivil? EstadoCivil { get; set; }
        public CorOuRaca? CorOuRaca { get; set; }
    }
}
