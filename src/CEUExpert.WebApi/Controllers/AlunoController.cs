using Microsoft.AspNetCore.Mvc;
using MediatR;
using System.Threading.Tasks;
using CEU.Aluno.Application.Commands;

namespace CEU.WebApi.Controllers
{
    [ApiController]
    [Route("api/alunos")]
    public class AlunoController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AlunoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Registrar([FromBody] RegistrarAlunoCommand command)
        {
            var resultado = await _mediator.Send(command);
            if (!resultado) return BadRequest();
            return Ok();
        }
    }
}