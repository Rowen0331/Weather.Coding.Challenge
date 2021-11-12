using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Net.Http;
using Weather.Coding.Challenge.Services.Repository;
using Xunit;

namespace Weather.Coding.Challenge.UnitTest
{

    public class WeatherServiceTest
    {
        
        [Fact]
        public void TestWeatherServiceTest()
        {
            var mockhttpClient = new Mock<HttpClient>();
            var weatherService = new WeatherService(mockhttpClient.Object);
        }
    }
}
