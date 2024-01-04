using System.Net;
using System.Net.Http.Json;
using Danilvar.Calculator.Responses;

namespace Danilvar.Calculator.Services;

public class WeatherService : IWeatherService
{
    private readonly HttpClient _httpClient;
    private const string ApiKey = "0238369d03394013894122527240401";

    public WeatherService(IHttpClientFactory factory)
    {
        _httpClient = factory.CreateClient("ServerApi");
    }

    public async Task<GetCurrentResponse?> GetCurrentAsync(string q, string lang = "")
    {
        try
        {
            string baseUrl = $"current.json?q={q}&key={ApiKey}";
            string fullUrl = string.IsNullOrEmpty(lang) ? baseUrl : baseUrl + $"&lang={lang}";

            HttpResponseMessage response = await _httpClient.GetAsync(fullUrl);

            if (response.IsSuccessStatusCode)
            {
                if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    return default;

                return await response.Content.ReadFromJsonAsync<GetCurrentResponse>();
            }


            string message = await response.Content.ReadAsStringAsync();
            throw new HttpRequestException($"Http status code: {response.StatusCode} message: {message}");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}