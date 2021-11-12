using Microsoft.AspNetCore.WebUtilities;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;
using Weather.Coding.Challenge.Services.Interface;
using Weather.Coding.Challenge.Services.Model;

namespace Weather.Coding.Challenge.Services.Repository
{
    public class WeatherService : IWeatherService
    {
        private readonly HttpClient _client;
        private const string API_KEY = "efb60a1c73af3b2b52cda211ecbe9024";
        public WeatherService(HttpClient client)
        {
            _client = client;
        }
        public async Task<WeatherResponse> GetWeatherAsync(string zipCode)
        {
            try
            {
                WeatherResponse result = null;
                var query = new Dictionary<string, string>
                {
                    ["access_key"] = API_KEY,
                    ["query"] = zipCode,
                };
                string requestUri = QueryHelpers.AddQueryString("/current", query);
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, requestUri);
                HttpResponseMessage response = await _client.GetAsync(requestUri);
                if (!response.IsSuccessStatusCode)
                {
                    return null;
                }
                result = await response.Content.ReadFromJsonAsync<WeatherResponse>();
                return result;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
