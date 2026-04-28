# Mediator Design Pattern

The **Mediator** design pattern is a behavioral pattern that reduces chaotic dependencies between objects by restricting direct communication between them and forcing them to collaborate only via a central mediator object.

---

## 1. 🧠 Core Concept
Instead of dozens of objects (called "colleagues") talking directly to each other—creating a "spaghetti" of connections—they all send their messages to one mediator. The mediator then decides which other objects should receive the information or perform an action.

*   **Analogy**: ✈️ **Air Traffic Control (ATC)**. Pilots of airplanes approaching an airport don't talk to each other to decide who lands first. Instead, they all talk to the ATC tower. The tower (Mediator) coordinates the planes (Colleagues) to prevent collisions.

---

## 2. 🏗️ Key Components
*   **Mediator Interface**: Defines the communication contract (usually a `notify` or `send` method).
*   **Concrete Mediator**: Implements the interface and coordinates the colleagues. It knows all the colleague objects and their relationships.
*   **Colleague Classes**: The individual components. They only know about the mediator and never communicate with each other directly.

---

## 3. 🎯 When to Use It
*   **Tight Coupling**: When it's hard to change a class because it's linked to too many other classes.
*   **Reuse Issues**: When you can't reuse a component in another app because it depends on specific "colleagues" from the original app.
*   **Complex GUI Logic**: If a "Submit" button needs to check a checkbox, validate a text field, and enable a spinner, a mediator can handle these interactions so the button doesn't have to "know" about the other fields.

---

## 4. ⚖️ Advantages & Disadvantages

### ✅ Advantages (Pros)
*   **Loose Coupling**: Components become independent and easier to test/reuse.
*   **Centralized Control**: Interaction logic is in one place, following the **Single Responsibility Principle**.
*   **Simplified Maintenance**: You can change how objects interact without touching the objects themselves.

### ❌ Disadvantages (Cons)
*   **Huge Object Risk**: The mediator can become overly complex as it tries to handle every interaction.
*   **Maintenance**: If not carefully designed, the mediator itself can become hard to maintain.
*   **Performance**: There is a tiny overhead due to the extra layer of communication.

---

## 5. 🔄 Comparison with Similar Patterns
*   **Observer**: Usually a one-to-many relationship. Mediator handles complex, many-to-many communication where participants might need to talk back and forth.
*   **Facade**: Provides a simplified interface to a whole subsystem. The subsystem is unaware of the Facade. In Mediator, colleagues *know* they are talking to a mediator.
*   **Command**: Establishes unidirectional connections. Mediator eliminates direct connections entirely in favor of a central hub.
