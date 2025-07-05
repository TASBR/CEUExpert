using MediatR;

namespace CEU.Conteudo.Application.Commands
{
    public class CriarCursoCommand : IRequest<bool>
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public CriarCursoCommand(string nome, string descricao)
        {
            Nome = nome;
            Descricao = descricao;
        }
    }
}