using Microsoft.AspNetCore.Mvc;


namespace ProductClientHub.Api.Controllers;

[Route("api/[controller]")]
[ApiController]


public class ClientController : ControllerBase
{
    [HttpPost]
    public IActionResult Register()
    {
        return Ok();
    }

    [HttpPut]
    public IActionResult Update()
    {
        return Ok();
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok();
    }

    [HttpDelete]
    public IActionResult Delete()
    {
        return Ok();
    }


}