
using Xunit;
using CEU.Content.Domain.Entidades;

namespace CEU.Content.Tests
{
    public class CursoTests
    {
        [Fact]
        public void DeveCriarCursoComNome()
        {
            var curso = new Curso { Nome = "Curso de Teste", ConteudoProgramatico = "TDD, DDD, CQRS" };
            Assert.Equal("Curso de Teste", curso.Nome);
        }
    }
}
