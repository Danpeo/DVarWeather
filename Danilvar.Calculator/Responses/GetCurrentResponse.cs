using Danilvar.Calculator.Models;

namespace Danilvar.Calculator.Responses;

public class GetCurrentResponse
{
    public Location Location { get; set; }
    public Current Current { get; set; }
}