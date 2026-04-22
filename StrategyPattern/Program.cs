using StrategyPattern;
using StrategyPattern.Weapons;

/*
The Strategy Design Pattern is a behavioral design pattern that allows you to define a family of algorithms, 
encapsulate each one into a separate class, and make them interchangeable. 
This pattern lets the algorithm vary independently from the clients that use it, effectively allowing you to swap behaviors at runtime. 
The Strategy pattern is based on the principle of Composition over Inheritance. 
Instead of a class implementing multiple behaviors itself (often via massive if-else or switch statements), it "delegates" that behavior to a separate "strategy" object. 

1. Core Concept:
    Goal: Separate what an object does from how it does it.
    Analogy: Think of a traveler going to the airport. The "goal" is to reach the airport, but the "strategy" could be taking a taxi, riding a bus, or driving a personal car. You are the "Context," and you can switch between these transportation "Strategies" based on time or cost. 

2. Key Components. The pattern typically involves four parts:
    Strategy Interface: A common interface or abstract class that defines the method(s) all concrete strategies must implement.
    Concrete Strategies: Different classes that implement the Strategy Interface. Each contains a specific version of the algorithm (e.g., CreditCardPayment, PayPalPayment).
    Context: The class that uses the strategy. It maintains a reference to a strategy object and calls its method but doesn't know the internal details of the algorithm.
    Client: The external code that chooses which concrete strategy to pass to the Context. 

3. When to Use It?
    Multiple Variations: You have many related classes that differ only in their behavior.
    Avoid Conditionals: Your code has a large switch or if-else block that selects different behaviors for the same task.
    Isolate Logic: You want to hide complex algorithm-specific data from the business logic.
    Runtime Switching: You need to change the behavior of an object while the program is running. 

4. Example: Payment System. Imagine an e-commerce app that supports multiple payment methods.
    Strategy Interface: PaymentStrategy with a method pay(amount).
    Concrete Strategy A: CreditCardStrategy implements pay using card details.
    Concrete Strategy B: CryptoStrategy implements pay using a wallet address.
    Context: ShoppingCart has a field paymentMethod. When you click "Checkout," it calls paymentMethod.pay(total).
    Client: The user selects "Crypto" on the UI; the client then injects the CryptoStrategy into the ShoppingCart.
*/


Character valkyrae = new Valkyrae();
valkyrae.SetWeaponBehavior(new AxeBehavior());
valkyrae.Fight();

Character gopnik = new Gopnik();
gopnik.SetWeaponBehavior(new KnifeBehavior());
gopnik.Fight();

Character knight = new Knight();
knight.SetWeaponBehavior(new SwordBehavior());
knight.Fight();
