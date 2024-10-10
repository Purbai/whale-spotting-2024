using Microsoft.EntityFrameworkCore;
using WhaleSpotting.Models.Data;
using WhaleSpotting.Models.Request;
using WhaleSpotting.Models.Response;

namespace WhaleSpotting.Services;

public interface ISightingsService
{
    public Task CreateSighting(SightingsRequest sightingsRequest, int userId);
    public SightingListResponse GetApproved();
    public SightingListResponse GetUnapproved();
    public Task<Sighting> GetSightingById(int sightingId);
    public Task DeleteSighting(int sightingId, int userId);
    public Task UpdateSighting(SightingsRequest sightingsRequest, int sightingId, int userId);
    public Task ApproveSighting(int sightingId);
    public SingleSightingResponse GetSingleSightingResponse(int sightingId);
    public SightingListResponse GetUserApproved(int userId);
    public SightingListResponse GetUserUnapproved(int userId);
}

public class SightingsService : ISightingsService
{
    private readonly WhaleSpottingContext _context;
    private readonly IUserService _userservice;
    private readonly ISpeciesService _speciesservice;

    public SightingsService(WhaleSpottingContext context, IUserService userService, ISpeciesService speciesService)
    {
        _context = context;
        _userservice = userService;
        _speciesservice = speciesService;
    }

    public async Task CreateSighting(SightingsRequest sightingsRequest, int userId)
    {
        Sighting sighting = new Sighting()
        {
            UserId = userId,
            SpeciesId = sightingsRequest.SpeciesId,
            Latitude = sightingsRequest.Latitude,
            Longitude = sightingsRequest.Longitude,
            PhotoUrl = sightingsRequest.PhotoUrl,
            Description = sightingsRequest.Description,
            DateTime = sightingsRequest.DateTime,
            IsApproved = false
        };

        await _context.AddAsync(sighting);
        await _context.SaveChangesAsync();
    }

    public SingleSightingResponse GetSingleSightingResponse(int sightingId)
    {
        var singlesighting = GetSightingById(sightingId);

        SingleSightingResponse sighting = new SingleSightingResponse()
        {
            Id = singlesighting.Result.Id,
            UserId = singlesighting.Result.UserId,
            Username = singlesighting.Result.User.UserName,
            SpeciesId = singlesighting.Result.SpeciesId,
            SpeciesName = singlesighting.Result.Species.SpeciesName,
            Latitude = singlesighting.Result.Latitude,
            Longitude = singlesighting.Result.Longitude,
            PhotoUrl = singlesighting.Result.PhotoUrl,
            Description = singlesighting.Result.Description,
            DateTime = singlesighting.Result.DateTime,
            IsApproved = singlesighting.Result.IsApproved,
        };
        return sighting;
    }

    public SightingListResponse GetUserApproved(int userId)
    {
        List<Sighting> sightings = _context
            .Sightings.Include(u => u.User)
            .Include(p => p.Species)
            .Where(s => s.IsApproved && s.UserId == userId)
            .ToList();
        SightingListResponse sightingListResponse = new SightingListResponse();
        sightingListResponse.SetList(sightings);
        return sightingListResponse;
    }

    public SightingListResponse GetUserUnapproved(int userId)
    {
        List<Sighting> sightings = _context
            .Sightings.Include(u => u.User)
            .Include(p => p.Species)
            .Where(s => !s.IsApproved && s.UserId == userId)
            .ToList();
        SightingListResponse sightingListResponse = new SightingListResponse();
        sightingListResponse.SetList(sightings);
        return sightingListResponse;
    }

    public SightingListResponse GetApproved()
    {
        List<Sighting> sightings = _context
            .Sightings.Include(u => u.User)
            .Include(p => p.Species)
            .Where(s => s.IsApproved)
            .ToList();
        SightingListResponse sightingListResponse = new SightingListResponse();
        sightingListResponse.SetList(sightings);
        return sightingListResponse;
    }

    public SightingListResponse GetUnapproved()
    {
        List<Sighting> sightings = _context
            .Sightings.Include(u => u.User)
            .Include(p => p.Species)
            .Where(s => !s.IsApproved)
            .ToList();
        SightingListResponse sightingListResponse = new SightingListResponse();
        sightingListResponse.SetList(sightings);
        return sightingListResponse;
    }

    public async Task<Sighting> GetSightingById(int sightingId)
    {
        try
        {
            Sighting sighting = _context
                .Sightings.Include(u => u.User)
                .Include(p => p.Species)
                .Single(sighting => sighting.Id == sightingId);
            return sighting;
        }
        catch
        {
            throw new InvalidOperationException($"Sighting with ID {sightingId} not found");
        }
    }

    public async Task DeleteSighting(int sightingId, int userId)
    {
        Sighting sighting = await GetSightingById(sightingId);

        if (sighting.UserId != userId)
        {
            throw new UnauthorizedAccessException(
                $"User ID {userId} is not authorised to delete sighting {sightingId}"
            );
        }

        try
        {
            _context.Sightings.Remove(sighting);
            _context.SaveChanges();
        }
        catch
        {
            throw new InvalidOperationException($"Sighting with ID {sightingId} cannot be deleted");
        }
    }

    public async Task UpdateSighting(SightingsRequest sightingsRequest, int sightingId, int userId)
    {
        Sighting sighting = await GetSightingById(sightingId);

        if (sighting.UserId != userId)
        {
            throw new UnauthorizedAccessException(
                $"User ID {userId} is not authorised to delete sighting {sightingId}"
            );
        }

        sighting.SpeciesId = sightingsRequest.SpeciesId;
        sighting.Latitude = sightingsRequest.Latitude;
        sighting.Longitude = sightingsRequest.Longitude;
        sighting.PhotoUrl = sightingsRequest.PhotoUrl;
        sighting.Description = sightingsRequest.Description;
        sighting.DateTime = sightingsRequest.DateTime;
        sighting.IsApproved = false;

        try
        {
            _context.Sightings.Update(sighting);
            _context.SaveChanges();
        }
        catch
        {
            throw new InvalidOperationException($"Sighting with ID {sightingId} cannot be updated");
        }
    }

    public async Task ApproveSighting(int sightingId)
    {
        Sighting sighting = await GetSightingById(sightingId);

        if (!sighting.IsApproved)
        {
            sighting.IsApproved = true;

            try
            {
                _context.Sightings.Update(sighting);
                _context.SaveChanges();
            }
            catch
            {
                throw new InvalidOperationException($"Sighting with ID {sightingId} cannot be approved");
            }

            try
            {
                await _userservice.AddPoint(sighting.UserId.ToString());
                await _speciesservice.AddPointToSpecies(sighting.SpeciesId);
            }
            catch
            {
                throw new InvalidOperationException(
                    $"Point could not be added to user {sighting.UserId} for approved sighting {sightingId}"
                );
            }
        }
        else
        {
            throw new InvalidOperationException($"Sighting with ID {sightingId} already approved");
        }
        ;
    }
}
