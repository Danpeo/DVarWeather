namespace Danilvar.Calculator.Models;

public class Location
{
    public string Name { get; set; }
    public string Region { get; set; }
    public string Country { get; set; }
    public float Lat { get; set; }
    public float Lon { get; set; }
    public string Tz_Id { get; set; }
    public int LocaltimeEpoch { get; set; }
    public string LocalTime { get; set; }
}