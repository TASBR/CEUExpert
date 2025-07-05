using CEU.Core.Domain.Entities;
using CEU.Core.Domain.Exceptions;

namespace CEU.Conteudo.Domain.Entidades
{
    public class Curso : EntidadeBase
    {
        public string Nome { get; private set; }
        public string Descricao { get; private set; }

        public Curso(string nome, string descricao)
        {
            if (string.IsNullOrWhiteSpace(nome)) throw new DomainException("Nome inválido");
            if (string.IsNullOrWhiteSpace(descricao)) throw new DomainException("Descrição inválida");

            Nome = nome;
            Descricao = descricao;
        }
    }
}