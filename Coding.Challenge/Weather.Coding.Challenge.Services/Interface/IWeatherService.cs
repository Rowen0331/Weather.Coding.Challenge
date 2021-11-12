using System.Threading.Tasks;
using Weather.Coding.Challenge.Services.Model;

namespace Weather.Coding.Challenge.Services.Interface
{
    public interface IWeatherService
    {
        Task<WeatherResponse> GetWeatherAsync(string zipCode);
    }
}
