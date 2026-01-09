using Microsoft.AspNetCore.Mvc;


namespace BearApi.Controllers;

[ApiController]
[Route("api/[controller]")]

public class BearsController : ControllerBase
{
    [HttpGet("{id}")]
    public IActionResult GetBear(int id)
    {
     return Ok ($"Bear With ID {id}");   
    }
    }