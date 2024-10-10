using Microsoft.EntityFrameworkCore;
using WhaleSpotting.Models.Data;
using WhaleSpotting.Models.Request;
using WhaleSpotting.Models.Response;

namespace WhaleSpotting.Services;

public interface ISpeciesService
{
    public SpeciesResponse GetAllSpecies();
    public Task AddPointToSpecies(int speciesId);
    public Task<Species> GetSpeciesById(int speciesId);
}

public class SpeciesService : ISpeciesService
{
    private readonly WhaleSpottingContext _context;

    public SpeciesService(WhaleSpottingContext context)
    {
        _context = context;
    }

    public SpeciesResponse GetAllSpecies()
    {
        SpeciesResponse speciesResponse = new SpeciesResponse() { ListOfSpecies = _context.Species.ToList() };
        return speciesResponse;
    }

    public async Task<Species> GetSpeciesById(int speciesId)
    {
        try
        {
            Species species = _context.Species.Single(species => species.SpeciesId == speciesId);
            return species;
        }
        catch
        {
            throw new InvalidOperationException($"Species with ID {speciesId} not found");
        }
    }

    public async Task AddPointToSpecies(int speciesId)
    {
        Species species = await GetSpeciesById(speciesId);

        species.TotalSightings++;

        try
        {
            _context.Species.Update(species);
            _context.SaveChanges();
        }
        catch
        {
            throw new InvalidOperationException($"TotalSightings cannot be updated for species with ID {speciesId}");
        }
    }
}
