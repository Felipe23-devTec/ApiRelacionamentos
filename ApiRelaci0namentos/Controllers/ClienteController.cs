using ApiRelaci0namentos.Model;
using ApiRelacionamentos.Domain.BusinessObjects;
using ApiRelacionamentos.Repository.Repository.RepositoryContract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiRelaci0namentos.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ClienteController : ControllerBase
{
    private readonly IClienteRepository _clienteRepository;

    public ClienteController(IClienteRepository clienteRepository)
    {
        _clienteRepository = clienteRepository;
    }

    [HttpPost]
    public async Task<ActionResult> Post([FromBody]ClienteModel clienteModel)
    {
        if (clienteModel != null)
        {
            var cliente = new Cliente()
            {
                Nome = clienteModel.Nome,
                Email = "felipe@gmail.com",
                Telefone = "0393459"
            };
            await _clienteRepository.AdicionarCliente(cliente);

            return Ok();
        }
        else
        {
            return BadRequest();
        }
    }
}
