using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    internal class OpenWeatherMapAPI
    {
        public static void GetTempFromZipCode()
        {
           
            var appsettingsText = File.ReadAllText("appsettings.json");
            var apiKey = JObject.Parse(appsettingsText)["VidyaKey"].ToString();

            Console.WriteLine("Let's get the temp from your city! Please enter your zip code:");
            var zip = Console.ReadLine();
            
            var url = $"http://api.openweathermap.org/data/2.5/weather?zip={zip}&appid={apiKey}";
            
            var client = new HttpClient();

            var weatherResponse = client.GetStringAsync(url).Result;
            
            var temp = JObject.Parse(weatherResponse)["main"]["temp"].ToString();
       
            Console.WriteLine($"The temperature in your city is {temp}.");
        }

    }
}
