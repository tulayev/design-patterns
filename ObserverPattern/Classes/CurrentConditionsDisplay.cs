using ObserverPattern.Interfaces;

namespace ObserverPattern.Classes
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private readonly ISubject _weatherData;

        private float _temperature;

        private float _humidity;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            Display();
        }

        public void Display() =>
            Console.WriteLine($"Current conditions: {_temperature}C and {_humidity}%");
    }
}
