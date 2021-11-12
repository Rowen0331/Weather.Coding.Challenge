using System;
using System.Threading.Tasks;
using Weather.Coding.Challenge.Services.Interface;
using Weather.Coding.Challenge.Services.Model;

namespace Weather.Coding.Challenge
{
    class StartUp
    {
        private readonly IWeatherService _service;
        public StartUp(IWeatherService service)
        {
            _service = service;
        }

        public async Task RunAsync()
        {
            string zipCode = ConsoleWriter.InputAndReadZipCode();
            WeatherResponse response = await _service.GetWeatherAsync(zipCode);
            if(response.Request == null && response.Current == null && response.Location == null)
            {
                ConsoleWriter.ExitApplication();
            }
            ConsoleWriter.PrintOutput(response);
            Console.ReadLine();
        }
    }
}
