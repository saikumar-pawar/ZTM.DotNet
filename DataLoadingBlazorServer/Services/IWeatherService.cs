using DataLoadingBlazorServer.DomainModels;

namespace DataLoadingBlazorServer.Services;

public interface IWeatherService
{
    Task<IEnumerable<WeatherForecast>> GetWeatherForecastsAsync();
}
