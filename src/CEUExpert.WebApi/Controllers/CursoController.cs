using Microsoft.AspNetCore.Mvc;
using MediatR;
using System.Threading.Tasks;
using CEU.Conteudo.Application.Commands;

namespace CEU.WebApi.Controllers
{
    [ApiController]
    [Route("api/cursos")]
    public class CursoController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CursoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Criar([FromBody] CriarCursoCommand command)
        {
            var resultado = await _mediator.Send(command);
            if (!resultado) return BadRequest();
            return Ok();
        }
    }
}