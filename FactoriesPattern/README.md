# Factory Design Patterns

The **Factory** design patterns are creational patterns that abstract the process of object instantiation, allowing a system to remain independent of how its objects are created. The two primary types are **Factory Method** and **Abstract Factory**.

---

## 1. Factory Method Pattern

The Factory Method pattern defines an interface for creating an object but allows subclasses to decide which class to instantiate. It **"defers"** instantiation to subclasses.

*   **Key Idea**: Use inheritance. A base class provides a method signature (the "factory method"), and subclasses override it to return a specific type of product.

### Structure
*   **Creator (Base Class)**: Declares the factory method. It may also contain business logic that relies on the product.
*   **Concrete Creator**: Overrides the factory method to return a specific Concrete Product.

**Example**: A `Logistics` class has a `createTransport()` method. The `RoadLogistics` subclass overrides it to return a `Truck`, while `SeaLogistics` returns a `Ship`.

---

## 2. Abstract Factory Pattern

The Abstract Factory pattern provides an interface for creating **families of related or dependent objects** without specifying their concrete classes.

*   **Key Idea**: Use composition/object delegation. You create a **"factory of factories."** The client code is given a factory object, which it then uses to create a set of related products.

### Structure
*   **Abstract Factory (Interface)**: Declares a set of methods for creating different products (e.g., `createButton()`, `createCheckbox()`).
*   **Concrete Factory**: Implements these methods to produce a specific suite of products (e.g., a `WindowsFactory` creates Windows-style buttons and checkboxes).

**Example**: A GUI toolkit that supports multiple themes. A `MacFactory` produces Mac buttons and Mac scrollbars, ensuring the UI remains consistent.

---

## 💡 Summary Comparison


| Feature | Factory Method | Abstract Factory |
| :--- | :--- | :--- |
| **Focus** | One product | A family of related products |
| **Mechanism** | Inheritance (Subclassing) | Object Composition |
| **Complexity** | Simple | Higher (requires more interfaces) |
