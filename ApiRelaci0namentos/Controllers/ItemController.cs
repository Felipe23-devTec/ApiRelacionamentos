using ApiRelacionamentos.Repository.Repository.RepositoryContract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace ApiRelaci0namentos.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ItemController : ControllerBase
{
    private readonly IITemRepository _iTemRepository;

    public ItemController(IITemRepository iTemRepository)
    {
        _iTemRepository = iTemRepository;
    }

    [HttpPost]
    public async Task<ActionResult> Get()
    {
        return Ok();
    }
}
