using Microsoft.AspNetCore.Mvc;
using MediatR;
using System.Threading.Tasks;
using CEU.Pagamento.Application.Commands;

namespace CEU.WebApi.Controllers
{
    [ApiController]
    [Route("api/pagamentos")]
    public class PagamentoController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PagamentoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Processar([FromBody] ProcessarPagamentoCommand command)
        {
            var resultado = await _mediator.Send(command);
            if (!resultado) return BadRequest();
            return Ok();
        }
    }
}