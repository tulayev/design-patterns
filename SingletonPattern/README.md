# Singleton Design Pattern

The **Singleton Design Pattern** is a creational design pattern that ensures a class has only one instance while providing a global point of access to that instance. It is one of the most widely used—and debated—patterns in software engineering.

---

## 1. Core Principles

A class must meet three criteria to be considered a Singleton:
*   **Private Constructor**: Prevents other classes from instantiating the class using the `new` operator.
*   **Static Instance Variable**: A private static variable that holds the single instance of the class.
*   **Public Static Method**: Often called `getInstance()`, this serves as the global access point. It returns the existing instance or creates it if it doesn't exist.

---

## 2. Why is it often called an "Anti-Pattern"?

The "anti-pattern" label comes from side effects that arise when Singletons are overused or used as a shortcut for global variables.

### ❌ Violation of SOLID Principles
*   **Single Responsibility (SRP)**: The class manages both its business logic and its own lifecycle/instance count.
*   **Dependency Inversion (DIP)**: Classes depend on a concrete class rather than an abstraction, making it hard to swap implementations.

### 🧪 Testing Nightmares
*   **Persistent State**: State carries over between tests. If Test A changes a value, Test B may fail, making tests dependent on execution order.
*   **Hidden Dependencies**: Dependencies aren't visible in constructors, making "simple" unit tests trigger complex background processes.
*   **Mocking Difficulty**: Private constructors and static access make it extremely hard to replace with "mock" versions.

### ⚠️ Technical Drawbacks
*   **Global Variable in Disguise**: Makes data flow hard to track; any part of the code can change state at any time.
*   **Concurrency Issues**: Implementing thread-safety (e.g., "double-checked locking") is error-prone and can cause bottlenecks.
*   **Scalability**: A Singleton is only unique within one process. In distributed cloud environments, each server will have its own "singleton."
*   **Refactoring**: Moving away from a Singleton once it's used in hundreds of places is a massive, error-prone task.

---

## Summary
While useful for things like **Logging** or **Configuration**, Singletons should be used sparingly. Modern development often prefers **Dependency Injection** to manage object lifecycles.
