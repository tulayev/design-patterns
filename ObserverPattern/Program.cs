using Newtonsoft.Json;
using ObserverPattern;
using ObserverPattern.Classes;

/*
The Observer Design Pattern is a behavioral software design pattern that establishes a one-to-many relationship between objects. 
It allows one object (the Subject) to automatically notify multiple other objects (Observers) whenever its state changes. 
Think of it like a YouTube Subscription: You (the Observer) subscribe to a channel (the Subject). 
When the channel uploads a new video, all subscribers are automatically notified. You don't have to keep checking the channel for updates; the updates come to you. 

1. Key Components. The pattern consists of four primary components: 
    Subject (Interface/Base Class): Provides an interface for attaching and detaching observer objects. It contains a list of its observers.
    Concrete Subject: The actual object being watched. When its state changes, it calls the notify() method to alert all registered observers.
    Observer (Interface): Defines an update() method that subjects use to notify them of changes.
    Concrete Observer: Implements the update() method to define what the observer should do when it receives a notification (e.g., update a UI, log data, or send an email). 

2. How It Works (The Workflow):
    Registration: Observers "subscribe" to a Subject by calling its registerObserver() method.
    Event Trigger: Something happens in the Subject that changes its state.
    Notification: The Subject iterates through its list of registered Observers and calls their update() methods.
    Reaction: Each Observer executes its own logic in response to the notification. 

3. Push vs. Pull Models:
    Push Model: The Subject sends detailed information about the change directly within the update(data) method. The observer doesn't need to ask for more.
    Pull Model: The Subject merely sends a notification ("Hey, I changed!"). The Observer then calls getter methods on the Subject to pull the specific data it needs. 

4. Why Use It? (Advantages):
    Loose Coupling: The Subject doesn't need to know anything about the concrete classes of its observers. It only knows they implement the Observer interface.
    Open/Closed Principle: You can add new types of observers without changing the Subject's code.
    Dynamic Relationships: Observers can be added or removed at runtime. 

5. Potential Pitfalls:
    Memory Leaks: Known as the "Lapsed Listener" problem. If you forget to unregister an observer, the Subject will keep a reference to it, preventing the garbage collector from cleaning it up.
    Order of Notification: Usually, you cannot guarantee the order in which observers are notified.
    Performance: If there are thousands of observers, a single state change can trigger a massive wave of synchronous updates, potentially slowing down the system. 

6. Real-World Examples:
    GUI Libraries: Button clicks (listeners) in Java Swing, JavaFX, or JavaScript.
    MVC Architecture: The "Model" is the Subject, and the "Views" are Observers that refresh when data in the model changes.
    Stock Market Apps: Multiple displays (phone app, desktop dashboard, ticker) all update simultaneously when a stock price changes.
    Social Media: Notifications sent to followers when a user posts a new update. 

7. Comparison: Observer vs. Pub-Sub
    While similar, they are not the same:
    Observer: The Subject and Observer usually know about each other (direct reference). It is typically synchronous and happens within a single application.
    Publish-Subscribe: Uses an intermediate "Message Broker." Publishers and Subscribers never know each other exists. It is often used in distributed systems (like RabbitMQ or Kafka) and is usually asynchronous. 
*/


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
