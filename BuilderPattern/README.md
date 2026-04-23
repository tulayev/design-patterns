# Builder Design Pattern

The **Builder Design Pattern** is a creational design pattern that allows you to construct complex objects step by step. It separates the construction logic of an object from its final representation, enabling the same construction process to create different types and variations of an object.

---

## 1. The Core Problem

In software development, you often encounter the **"Telescoping Constructor"** anti-pattern. This happens when a class has many optional fields, leading to multiple constructors with increasing numbers of parameters.

### ❌ The Problem: Hard to Read and Maintain
```java
User(String name) { ... }
User(String name, int age) { ... }
User(String name, int age, String email) { ... }
User(String name, int age, String email, String address) { ... }
```

### ✅ The Solution
Using the Builder pattern avoids this mess by allowing you to set only the parameters you need, in any order, while keeping the final object immutable.

---

## 2. Key Components

*   **Product**: The complex object that is being built (e.g., a House or an HTTP Request).
*   **Builder Interface**: Defines the steps required to build the product.
*   **Concrete Builder**: Implements the building steps and keeps track of the object's current state.
*   **Director (Optional)**: A separate class that defines the order in which to execute the building steps. Useful for pre-defined "recipes" (e.g., "Standard Laptop" vs. "Gaming Laptop").
*   **Client**: The code that initiates the building process.

---

## Benefits

*   **Cleaner Code**: Eliminates long, confusing constructor parameter lists.
*   **Immutability**: The final product can be made immutable once construction is complete.
*   **Step-by-Step Control**: Allows you to defer construction steps or run them recursively.
