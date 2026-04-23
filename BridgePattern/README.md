# Bridge Design Pattern

The **Bridge design pattern** is a structural pattern that decouples an abstraction (high-level logic) from its implementation (low-level platform-specific code).

---

## 1. The Core Problem: Class Explosion

Imagine you are building an app with different **Shapes** (Circle, Square) and different **Colors** (Red, Blue).

### ❌ Using Inheritance
You would need classes like:
* `RedCircle`
* `BlueCircle`
* `RedSquare`
* `BlueSquare`

**The Issue:** If you add a new shape (Triangle) and a new color (Green), you now need to create several more classes. The total number of classes grows exponentially (**Shapes × Colors**).

---

## 2. The Solution: Decomposition

The Bridge pattern suggests moving from **inheritance to composition**. You split the single, complex hierarchy into two separate, simpler hierarchies:

1.  **Abstraction**: The high-level "control" layer (e.g., the `Shape`).
2.  **Implementation**: The platform or detail-specific layer (e.g., the `Color`).

The Abstraction holds a reference to an object of the Implementation hierarchy, acting as the **"bridge"** between them.

---

## 3. Key Components

*   **Abstraction**: Defines the high-level interface (e.g., `Shape`) and maintains a reference to an Implementor.
*   **Refined Abstraction**: Extends the Abstraction (e.g., `Circle`, `Square`).
*   **Implementor**: Defines the interface for all concrete implementations (e.g., `ColorAPI`).
*   **Concrete Implementations**: Provide the actual code for the Implementor interface (e.g., `RedColor`, `BlueColor`).

---

## Benefits

*   **Single Responsibility Principle**: You can focus on high-level logic in one part and platform details in another.
*   **Open/Closed Principle**: You can introduce new abstractions and implementations independently.
*   **Reduced Complexity**: Avoids the "class explosion" problem by using composition instead of deep inheritance.
