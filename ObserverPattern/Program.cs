var timer = new PeriodicTimer(TimeSpan.FromSeconds(30));

string sampleUrl = "https://api.openweathermap.org/data/3.0/onecall?lat=41.31244017712797&lon=69.27972650724607&appid=b153b73eb55746c68bd20ddc56c657cf";

while (await timer.WaitForNextTickAsync())
{
    
}
