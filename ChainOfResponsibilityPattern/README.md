# Chain of Responsibility Design Pattern

The **Chain of Responsibility** is a behavioral design pattern that passes requests along a chain of handlers. Upon receiving a request, each handler decides either to process it or pass it to the next handler in the chain. This decouples the sender from the receiver, allowing multiple objects a chance to handle the request.

---

## 🏗️ Key Components & Concepts

*   **Handler Interface**: Defines a method for handling requests and optionally a method for setting the next handler.
*   **Base Handler (Optional)**: An optional class for storing the boilerplate code for linking handlers.
*   **Concrete Handlers**: Contains the actual logic to process requests or pass them along.
*   **Chain Setup**: The client sets up the sequence of handlers at runtime based on application needs.

---

## 🎯 Usage Scenario

Use this pattern when your program needs to process different kinds of requests in various ways, but the exact types of requests and their sequences are unknown beforehand.

---

## ✅ Pros and Cons

### Pros
*   **Decoupling**: Sender does not need to know which specific handler will process the request.
*   **Flexibility (Open/Closed Principle)**: New handlers can be introduced without breaking existing client code.
*   **Responsibility Separation**: Each handler focuses on one specific task (Single Responsibility Principle).

### Cons
*   **Uncertainty**: Requests might go unhandled if they reach the end of the chain without a match.
*   **Debugging Difficulty**: Tracing the flow of requests through multiple handlers can be challenging.

---

## 🌍 Real-World Examples

*   **Middleware in Web Frameworks**: Systems like Django process HTTP requests through steps like authentication, logging, and session management.
*   **Event Handling**: UI events (clicks/keypresses) that propagate up a component tree until handled.
*   **Support Systems**: A ticket system moving from Level 1 Support → Manager → Director.
