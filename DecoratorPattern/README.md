# Decorator Design Pattern

The **Decorator Design Pattern** is a structural design pattern that allows you to dynamically attach new behaviors and responsibilities to an object without altering its code or affecting other instances of the same class. Commonly referred to as a **Wrapper**, it provides a flexible alternative to subclassing for extending functionality.

---

## 1. Key Concept: Composition over Inheritance

In traditional inheritance, you extend a class at compile-time to add features. This often leads to a **"class explosion"** if you need many combinations of features (e.g., `BoldItalicUnderlinedText`, `BoldItalicText`, etc.). 

The Decorator pattern solves this by:
*   Wrapping the core object in one or more decorator classes.
*   Implementing the same interface as the object they wrap.
*   Allowing decorators to be **stacked indefinitely**.

---

## 2. Core Components

*   **Component (Interface)**: Defines the common interface for both the core object and the decorators.
*   **Concrete Component**: The original object that provides basic functionality (e.g., "Plain Coffee" or "Plain Text").
*   **Base Decorator**: An abstract class that implements the Component interface and holds a reference to a Component object. It delegates all work to the wrapped object.
*   **Concrete Decorators**: Classes that extend the Base Decorator and add specific features (e.g., `MilkDecorator`, `BoldDecorator`) before or after calling the wrapped object's method.

---

## 3. Real-World Analogies

### 🧥 Clothing
You are the **Concrete Component**. When it's cold, you wrap yourself in a "Sweater Decorator." If it rains, you add a "Raincoat Decorator" on top. Each layer adds a new property (warmth, waterproofing) without changing who you are.

### ☕ Coffee Shop
You start with a basic coffee. You can decorate it with milk, sugar, or whipped cream. Each "decorator" adds its own cost and description to the base beverage.

---

## Benefits

*   **Runtime Flexibility**: Add or remove responsibilities at runtime.
*   **Single Responsibility**: Divide a complex class that implements many variants of behavior into several smaller classes.
*   **Stackable**: You can combine several decorators to get a complex behavior.
