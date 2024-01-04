using Danilvar.Calculator.Responses;

namespace Danilvar.Calculator.Services;

public interface IWeatherService
{
    Task<GetCurrentResponse?> GetCurrentAsync(string q, string lang = "ru");
}