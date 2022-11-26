using Newtonsoft.Json;
using ObserverPattern;

var timer = new PeriodicTimer(TimeSpan.FromSeconds(1));

double lat = 41.31244017712797;
double lon = 69.27972650724607;
string apiKey = FileReader.GetApiKey;

string url = $"https://api.openweathermap.org/data/2.5/weather?lat={lat}&lon={lon}&appid={apiKey}&units=metric";

while (await timer.WaitForNextTickAsync())
{
    using var client = new HttpClient();
    string res = await client.GetStringAsync(url);
    
    var json = JsonConvert.DeserializeObject<ForecastData>(res, JsonSettings.GetSetings());
}
