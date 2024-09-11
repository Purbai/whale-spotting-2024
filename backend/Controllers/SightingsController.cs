using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using WhaleSpotting.Models.Data;
using WhaleSpotting.Models.Request;
using WhaleSpotting.Models.Response;
using WhaleSpotting.Services;

namespace WhaleSpotting.Controllers;

[ApiController]
[Route("/sightings")]
public class SightingsController : Controller
{
    private readonly ISightingsService _sightingService;

    public SightingsController(ISightingsService sightingService)
    {
        _sightingService = sightingService;
    }

    [HttpPost("create")]
    public async Task<IActionResult> Create(SightingsRequest sightingRequest)
    {
        try
        {
            await _sightingService.CreateSighting(sightingRequest);
            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("")]
    public ActionResult<SightingListResponse> GetApproved()
    {
        try
        {
            SightingListResponse sightings = _sightingService.GetApproved();
            return Ok(sightings);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("sighting={sightingId}&user={userId}")]
    public async Task<IActionResult> Delete([FromRoute] int sightingId, int userId)
    {
        try
        {
            await _sightingService.DeleteSighting(sightingId, userId);
            return Ok();
        }
        catch (UnauthorizedAccessException ex)
        {
            return Unauthorized(ex.Message);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
