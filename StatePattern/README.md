# State Design Pattern

The **State Design Pattern** is a behavioral software pattern that allows an object to change its behavior when its internal state changes. Essentially, the object appears to "change its class" because it acts differently depending on its current mode or status.

---

## 🎯 Core Concept
Instead of one massive class trying to handle every possible state with messy `if-else` or `switch` statements (e.g., `if (state == "OUT_OF_STOCK")`), you create separate classes for each state. 

The main object, called the **Context**, holds a reference to a "current state" object and delegates all work to it.

---

## 🧱 Participants
*   **Context**: The primary object that the client interacts with. It maintains a reference to the current state.
*   **State Interface**: A common interface or abstract class defining operations all states must support.
*   **Concrete States**: Individual classes that implement specific behavior for a particular state.

---

## 🥤 Real-World Analogy: Vending Machine
Think about how a vending machine behaves differently based on its condition:
*   **No Money**: If you press "Dispense," it does nothing.
*   **Has Money**: If you press "Dispense," it drops your snack.
*   **Out of Stock**: If you press "Dispense," it shows an error light.

The method call is always the same (`PressButton`), but the outcome changes because the machine's internal state has changed.

---

## ✅ Why Use It?
*   **Avoids "Conditional Hell"**: No need for hundreds of lines of `if (state == ...)` checks.
*   **Single Responsibility**: Each state-related behavior is isolated in its own class.
*   **Open/Closed Principle**: You can add a new state (e.g., `MaintenanceMode`) just by creating a new class without touching existing logic.

---

## ⚠️ When to Avoid It
*   **Simple Logic**: If your object only has two states (like an On/Off toggle), a simple `bool` or `enum` is better.
*   **Class Explosion**: If you have dozens of states, you will end up with a large number of files which can be harder to navigate.

---

## ⚖️ State vs. Strategy


| Feature | Strategy | State |
| :--- | :--- | :--- |
| **Intent** | Choose *how* to do something (e.g., sorting algorithm). | Change behavior based on *internal lifecycle*. |
| **Transition** | Usually set once and doesn't change. | Object automatically transitions between states. |
| **Awareness** | Strategies rarely know about each other. | States often trigger transitions to other states. |

---

## 💻 Structural Example (C#)

```csharp
// State Interface
public interface IState {
    void Handle(Context context);
}

// Context
public class Context {
    public IState CurrentState { get; set; }
    public Context(IState state) => CurrentState = state;
    public void Request() => CurrentState.Handle(this);
}
```
