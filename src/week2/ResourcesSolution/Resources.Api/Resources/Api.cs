using Microsoft.AspNetCore.Mvc;

namespace Resources.Api.Resources;

public class Api : ControllerBase
{
    [HttpGet("/resources")]
    public async Task<ActionResult> GetAllResources()
    {
        return Ok();
    }
}
