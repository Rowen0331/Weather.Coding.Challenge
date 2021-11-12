using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using Weather.Coding.Challenge.Services.Interface;
using Weather.Coding.Challenge.Services.Repository;

namespace Weather.Coding.Challenge
{

    class Program
    {
        private static readonly string _baseUrl = "http://api.weatherstack.com";
        public static async Task Main(string[] args) =>
            await ConfigureServices(args).
                  GetService<StartUp>()!.
                  RunAsync();

        private static ServiceProvider ConfigureServices(string[] args)
        {
            var services = new ServiceCollection();
            services.AddHttpClient<IWeatherService, WeatherService>(c => c.BaseAddress = new System.Uri(_baseUrl));
            services.AddTransient<StartUp>();
            return services.BuildServiceProvider();
        }
    }
}
