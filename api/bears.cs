using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("api/controller")]
public class BearsController : ControllerBase
{
    [HttpGet("{id}")]
    public IActionResult GetBear(int id)
    {
        if (id <= 0)
        {
            return NotFound();
        }
        return Ok(new {id = id, name = "Bears!"});
    }
}

