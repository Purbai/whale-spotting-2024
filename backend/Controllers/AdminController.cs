using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WhaleSpotting.Services;

namespace WhaleSpotting.Controllers;

[ApiController]
[Authorize(Roles = "Admin")]
[Route("/admin")]
public class AdminController(ISightingsService sightingsService, IUserService userService) : Controller
{
    private readonly ISightingsService _sightingsService = sightingsService;

    private readonly IUserService _userService = userService;

    [HttpPut("approve/sighting={sightingId}")]
    public async Task<IActionResult> ApproveSighting([FromRoute] int sightingId)
    {
        try
        {
            await _sightingsService.ApproveSighting(sightingId);
            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpGet("users")]
    public async Task<IActionResult> GetAllUsers()
    {
        try{
            await _userService.GetAllUsers();
            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}
