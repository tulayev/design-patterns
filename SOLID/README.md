# SOLID Principles

**SOLID** is a mnemonic acronym for five design principles intended to make software designs more understandable, flexible, and maintainable.

---

## 1. S: Single Responsibility Principle (SRP)
> **"A class should have one, and only one, reason to change."**

Every class should focus on a single task or functionality. If a class has multiple responsibilities (e.g., processing data AND saving it to a database), it becomes harder to maintain and test.

*   **Solution**: Split diverse responsibilities into separate, specialized classes.

---

## 2. O: Open/Closed Principle (OCP)
> **"Software entities should be open for extension, but closed for modification."**

You should be able to add new functionality to a system without changing existing code. This prevents introducing bugs into already tested and working logic.

*   **Solution**: Use interfaces and abstract classes to allow new implementations to be plugged in.

---

## 3. L: Liskov Substitution Principle (LSP)
> **"Objects in a program should be replaceable with instances of their subtypes without altering the correctness of that program."**

A derived class (subclass) must be able to stand in for its base class without breaking the application. The subclass should enhance behavior, not restrict or fundamentally change it.

*   **Classic Violation**: A `Square` class inheriting from `Rectangle` and overriding the width/height logic in a way that breaks expectations for a rectangle.

---

## 4. I: Interface Segregation Principle (ISP)
> **"Many client-specific interfaces are better than one general-purpose interface."**

Clients should not be forced to depend on methods they do not use. Large "fat" interfaces should be split into smaller, more specific ones.

*   **Solution**: Create multiple, focused interfaces so that implementing classes only need to care about the methods that are relevant to them.

---

## 5. D: Dependency Inversion Principle (DIP)
> **"Depend upon abstractions, not concretions."**

High-level modules (business logic) should not depend on low-level modules (database, file system, APIs). Both should depend on abstractions (interfaces).

*   **Solution**: Use **Dependency Injection**. Instead of a class creating its own dependency (`new MySQLDatabase()`), the dependency should be passed in as an interface.

---

## 💡 Summary
By following SOLID, developers can avoid:
*   **Rigidity**: Code that is hard to change.
*   **Fragility**: Code where changes break unrelated parts.
*   **Immobility**: Code that cannot be reused due to tight coupling.
