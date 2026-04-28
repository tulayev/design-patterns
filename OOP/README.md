# 🏛️ The 4 Pillars of OOP

Object-Oriented Programming (OOP) is built on four core principles that help create modular, reusable, and maintainable software.

---

## 1. 🔒 Encapsulation (Data Hiding)
Encapsulation is the bundling of data and the methods that act on that data into a single unit (a class), while restricting direct access to some of the object's components.
*   **How it works**: Internal details are kept private. You interact with the object only through a public interface (like getters and setters).
*   **Analogy**: 🏧 **An ATM**. You use the screen and buttons to withdraw cash, but you can't reach inside and touch the actual stacks of money or the internal wiring.
*   **Benefit**: Protects data from accidental corruption and makes the code easier to manage.

## 2. 🧩 Abstraction (Complexity Hiding)
Abstraction means showing only the essential features of an object and hiding the complex background implementation details.
*   **How it works**: It focuses on **what** an object does rather than **how** it does it.
*   **Analogy**: 🏎️ **A Gas Pedal**. You know that pressing it makes the car move faster. You don't need to understand fuel injection or combustion to drive.
*   **Benefit**: Reduces complexity and allows developers to focus on high-level logic.

## 3. 🌲 Inheritance (Code Reuse)
Inheritance allows a new class (child) to acquire the properties and behaviors of an existing class (parent).
*   **How it works**: It creates a hierarchy. The child class "is-a" version of the parent and can add its own unique features without rewriting the basics.
*   **Analogy**: 🧬 **DNA**. Just as a child inherits traits like eye color from their parents but still has their own unique personality, a `SmartPhone` inherits features from a `BasicPhone`.
*   **Benefit**: Eliminates redundant code and establishes clear relationships between objects.

## 4. 🎭 Polymorphism (Many Forms)
Polymorphism allows objects of different classes to be treated as instances of a common parent class, where a single action can behave differently depending on the object.
*   **How it works**: 
    *   **Overriding**: A child class provides its own version of a parent's method.
    *   **Overloading**: Methods have the same name but different inputs.
*   **Analogy**: 📢 **The "Speak" Command**. If you tell a dog to speak, it barks 🐕. If you tell a cat, it meows 🐈. The command is the same, but the result depends on who is performing it.
*   **Benefit**: Makes code highly flexible and allows you to add new types of objects without breaking existing code.
