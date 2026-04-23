# Strategy Design Pattern

The **Strategy Design Pattern** is a behavioral design pattern that allows you to define a family of algorithms, encapsulate each one into a separate class, and make them interchangeable. It enables swapping behaviors at runtime independently from the clients that use them.

---

## 1. Core Concept

*   **Goal**: Separate **what** an object does from **how** it does it.
*   **Principle**: Favors **Composition over Inheritance**. Instead of using massive `if-else` or `switch` statements, a class delegates behavior to a separate strategy object.

### 🚗 Real-World Analogy
Think of a traveler going to the airport. The **Goal** is to reach the airport, but the **Strategy** could be:
*   Taking a taxi
*   Riding a bus
*   Driving a personal car

You are the **Context**, and you can switch strategies based on time or cost.

---

## 2. Key Components

*   **Strategy Interface**: A common interface that defines the method(s) all concrete strategies must implement.
*   **Concrete Strategies**: Different classes implementing the Strategy Interface with specific algorithms (e.g., `CreditCardPayment`, `PayPalPayment`).
*   **Context**: The class that uses the strategy. It maintains a reference to a strategy object and calls its methods without knowing the internal details.
*   **Client**: The external code that chooses which concrete strategy to pass to the Context.

---

## 3. When to Use It?

*   **Multiple Variations**: When related classes differ only in their behavior.
*   **Avoid Conditionals**: To replace large `switch` or `if-else` blocks that select behaviors.
*   **Isolate Logic**: To hide complex algorithm-specific data from business logic.
*   **Runtime Switching**: When you need to change an object's behavior while the program is running.

---

## 4. Example: Payment System

*   **Strategy Interface**: `PaymentStrategy` with a `pay(amount)` method.
*   **Concrete Strategy A**: `CreditCardStrategy` (processes card details).
*   **Concrete Strategy B**: `CryptoStrategy` (processes wallet address).
*   **Context**: `ShoppingCart` holds a `paymentMethod`.
*   **Workflow**: The user selects "Crypto" on the UI; the **Client** injects the `CryptoStrategy` into the `ShoppingCart`.

---

## Benefits
✅ **Clean Code**: Simplifies classes by moving complex behavior into separate strategies.  
✅ **Extensibility**: Add new strategies without modifying existing code (Open/Closed Principle).  
✅ **Flexibility**: Change algorithms at runtime by swapping strategy objects.
