using ObserverPattern.Interfaces;

namespace ObserverPattern.Classes
{
    public class WeatherData : ISubject
    {
        private readonly List<IObserver> _observersList;

        private float _temperature;
        
        private float _humidity;
        
        private float _pressure;

        public WeatherData()
        {
            _observersList = new();
        }

        public void RegisterObserver(IObserver observer) =>
            _observersList.Add(observer);

        public void RemoveObserver(IObserver observer) =>
            _observersList.Remove(observer);

        public void NotifyObservers()
        {
            foreach (var observer in _observersList)
            {
                observer.Update(_temperature, _humidity, _pressure);
            }
        }

        public void MeasurementsChanged() =>
            NotifyObservers();

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
        }
    }
}
