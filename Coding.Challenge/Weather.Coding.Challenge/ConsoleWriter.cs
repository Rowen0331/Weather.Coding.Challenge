using System;
using System.Linq;
using Weather.Coding.Challenge.Services.Model;

namespace Weather.Coding.Challenge
{
    public static class ConsoleWriter
    {
        public static void ExitApplication()
        {
            Console.WriteLine("Press any key to exit application..");
            Console.ReadLine();
        }

        public static void PrintOutput(WeatherResponse response)
        {
            //Check if should I go outside?
            Console.WriteLine("Should I go outside?");
            bool isShouldGoOutside = response.Current.Wind_Speed > 15 && !response.Current.Weather_Descriptions.Any(a => a.ToLower().Contains("rain"));
            Console.WriteLine(isShouldGoOutside ? "Yes" : "No");

            //Check if should I wear sunscreen?
            Console.WriteLine("Should I wear sunscreen?");
            bool isShouldWearSunScreen = !response.Current.Weather_Descriptions.Any(a => a.ToLower().Contains("rain"));
            Console.WriteLine(isShouldWearSunScreen ? "Yes" : "No");

            //Check if can I fly my kite?
            Console.WriteLine("Can I fly my kite?");
            bool isCanIFlyKite = response.Current.Uv_Index > 3;
            Console.WriteLine(isCanIFlyKite ? "Yes" : "No");
        }
        public static string InputAndReadZipCode()
        {
            Console.Write("Please input zipcode: ");
            string zipCode = Console.ReadLine();
            return zipCode;
        }
    }
}
