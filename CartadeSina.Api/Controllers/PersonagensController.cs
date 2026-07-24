using Microsoft.AspNetCore.Mvc;

namespace CartadeSina.Api.Controllers;

[ApiController]
[Route("api/personagens")]
public class PersonagensController : ControllerBase
{
    [HttpGet]
    public IActionResult Listar()
    {
        return Ok("Endpoint de personagens funcionando!");
    }
}
