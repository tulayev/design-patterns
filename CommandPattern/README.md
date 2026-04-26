# Command Design Pattern

The Command Design Pattern is a behavioral design pattern that turns a request into a stand-alone object. This object contains all the information about the request, including the action to be performed, the target object (receiver), and any necessary parameters.

---

## 💡 Core Concept

In traditional object-oriented design, a sender of a request calls a method on a receiver directly. This creates a tight coupling between them. The Command pattern introduces a layer of indirection: the sender (**Invoker**) triggers a **Command** object, which then executes the logic on the **Receiver**.

### Real-world Analogy: Restaurant Order
* **You (Client):** Decides what to eat.
* **Order (Command):** A slip of paper with your request (dish name, table number).
* **Waiter (Invoker):** Takes your order and places it in the kitchen queue.
* **Chef (Receiver):** Receives the slip and performs the actual cooking.

---

## 🏗️ The Four Key Components


| Component | Responsibility |
| :--- | :--- |
| **Command Interface** | Defines a single `execute()` method (and optionally `undo()`). |
| **Concrete Command** | Implements the interface; binds a specific action to a Receiver. |
| **Receiver** | The class containing the actual business logic to perform the operation. |
| **Invoker** | Triggers the command; holds a reference to a command and calls its execution. |

---

## ✅ When to Use It

* **Undo/Redo**: Store a stack of command objects to iterate backward and call `undo()`.
* **Queueing/Scheduling**: Place commands in a queue to be executed later (job schedulers, thread pools).
* **Macro Commands**: Create a "Master Command" that executes a list of multiple commands at once.
* **Logging**: Maintain a history of command objects for auditing or system recovery.

---

## ⚖️ Pros and Cons

### Advantages
* **Decoupling**: Senders and receivers are completely independent.
* **Single Responsibility**: Separates classes that invoke operations from those that perform them.
* **Open/Closed Principle**: Introduce new commands without breaking existing code.

### Disadvantages
* **Complexity**: Can clutter code with many small, specific command classes.
* **Memory Usage**: Every action requires a new object, which can be heavy for long histories.
