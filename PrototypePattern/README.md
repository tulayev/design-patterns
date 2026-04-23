# Prototype Design Pattern

The **Prototype Design Pattern** is a creational pattern that creates new objects by cloning an existing instance (a prototype) rather than creating them from scratch. It is used to avoid expensive initialization costs, such as complex database queries or intensive calculations.

---

## 1. Key Components & Concepts

*   **Prototype Interface**: Defines a method, typically `clone()`, for cloning itself.
*   **Concrete Prototype**: Implements the cloning method to create a copy of its own state.
*   **Client**: Creates new objects by asking the prototype to clone itself, reducing dependency on concrete classes.

---

## 2. When to Use

*   When object initialization is **costly or complex** (e.g., heavy DB calls).
*   To avoid deep hierarchies of creator classes.
*   When you need copies of an object with **many different configurations**.
*   When you want to decouple client code from concrete subclasses.

---

## 3. Benefits

*   **Performance Optimization**: Reduces the need for expensive initialization (e.g., loading large datasets).
*   **Reduced Complexity**: Simplifies the creation of complex objects by cloning pre-built prototypes.
*   **Loose Coupling**: Clients can create new objects without knowing their specific concrete classes.

---

## 4. Common Examples

*   **Game Engines**: Cloning complex character or enemy objects during gameplay.
*   **Document Management**: Using a template as a prototype to create new documents, avoiding re-designing layouts.
*   **Configuration Management**: Creating varied configurations based on a default base setup.

---

### 💡 Prototype vs. Factory Method
While the Factory Method creates objects through inheritance, the **Prototype** pattern is used when the creation process is too complex or costly to re-run every time.
