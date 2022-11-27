using Newtonsoft.Json;
using ObserverPattern;
using ObserverPattern.Classes;

var timer = new PeriodicTimer(TimeSpan.FromSeconds(30));
double lat = 41.31244017712797;
double lon = 69.27972650724607;
string apiKey = FileReader.GetApiKey;
string url = $"https://api.openweathermap.org/data/2.5/weather?lat={lat}&lon={lon}&appid={apiKey}&units=metric";
using var client = new HttpClient();
var weatherData = new WeatherData();
var currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);

while (await timer.WaitForNextTickAsync())
{
    string res = await client.GetStringAsync(url);
    var json = JsonConvert.DeserializeObject<ForecastData>(res, JsonSettings.GetSetings());
    weatherData.SetMeasurements(json.Main.Temp, json.Main.Humidity, json.Main.Pressure);
}
