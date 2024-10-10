namespace WhaleSpotting.Models.Request;

public class SpeciesRequest
{
    public int SpeciesId { get; set; }
    public string SpeciesName { get; set; }
    public string ExampleLink { get; set; }
    public string TailPictureLink { get; set; }
    public string WikiLink { get; set; }
    public float TotalSightings { get; set; }
}
