using ApiRelacionamento.Service.ServiceContract;
using ApiRelacionamentos.Domain.BusinessObjects;
using ApiRelacionamentos.Repository.Repository.RepositoryContract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace ApiRelaci0namentos.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ItemController : ControllerBase
{
    
    private readonly IPedidoService _pedidoService;
    public ItemController(IPedidoService pedidoService)
    {
        _pedidoService = pedidoService;
    }
    [HttpPost]
    public async Task<ActionResult> Post()
    {
        var item = new Item()
        {
            Nome = "Torta",
            Preco = 3
        };
        await _pedidoService.CriarPedido(1, item);
        return Ok();
    }
}
