# Adapter Design Pattern

The **Adapter** is a structural design pattern that allows objects with incompatible interfaces to collaborate. It acts as a wrapper, "getting the interface you want from the interface you have."

---

## 1. Key Components

*   **Target (Interface)**: The domain-specific interface that the client code uses.
*   **Adapter**: A class that implements the Target interface and wraps the Adaptee.
*   **Adaptee**: The existing class with an incompatible interface that needs adapting.
*   **Client**: The code that collaborates with objects adhering to the Target interface.

---

## 2. Implementation Approaches

### 🏗️ Object Adapter (Composition)
The adapter contains an instance of the adaptee class. This is the **preferred approach** because it uses composition, making it more flexible and compatible with most languages (like Java or C#).

### 🧬 Class Adapter (Inheritance)
The adapter inherits from the adaptee class and implements the target interface. This requires **multiple inheritance**, which is not supported in all programming languages (e.g., supported in C++, but not in Java).

---

## Why use Adapter?

*   **Integration**: Allows legacy code to work with modern classes without changing the original source.
*   **Flexibility**: You can create different adapters for different incompatible classes.
*   **Single Responsibility**: You separate the interface or data conversion logic from the primary business logic.

---

## Real-world Analogy
A classic example is a **Power Adapter**. If you have a US-style plug (Adaptee) but are in a European outlet (Target), you use an adapter to bridge the gap so your device can get power.
