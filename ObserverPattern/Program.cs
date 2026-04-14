using Newtonsoft.Json;
using ObserverPattern;
using ObserverPattern.Classes;

var timer = new PeriodicTimer(TimeSpan.FromSeconds(30));
var lat = 41.31244017712797;
var lon = 69.27972650724607;
var apiKey = FileReader.GetApiKey;
var url = $"https://api.openweathermap.org/data/2.5/weather?lat={lat}&lon={lon}&appid={apiKey}&units=metric";

using var client = new HttpClient();

var weatherData = new WeatherData();
var currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);

while (await timer.WaitForNextTickAsync())
{
    var res = await client.GetStringAsync(url);
    var json = JsonConvert.DeserializeObject<ForecastData>(res, JsonSettings.GetSetings());

    weatherData.SetMeasurements(json.Main.Temp, json.Main.Humidity, json.Main.Pressure);
}
