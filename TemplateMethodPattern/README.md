# Template Method Design Pattern

The **Template Method Pattern** is a behavioral design pattern that defines the "skeleton" of an algorithm in a base class but lets subclasses override specific steps without changing the overall structure.

---

## 🍞 The Bread Analogy
Imagine you are baking various types of bread. The high-level process is always:  
**Mix** -> **Knead** -> **Rise** -> **Bake**.

While the sequence never changes, the way you mix (ingredients) or the duration of baking varies between sourdough and rye. The Template Method pattern captures that fixed sequence while leaving the details to the specific bread types.

---

## 🏗️ Core Components

*   **Abstract Class**: Defines the Template Method (the fixed algorithm) and declares abstract methods for the variable steps.
*   **Template Method**: A concrete method in the base class that calls the algorithm's steps in a specific order. It is often marked as `final` (or non-virtual) to prevent reordering.
*   **Primitive Operations**: Abstract methods that must be implemented by subclasses to provide specific behavior.
*   **Hooks**: Optional methods with a default implementation. Subclasses can "hook into" the algorithm if needed, but aren't forced to.

---

## 🏠 Real-World Analogy: Building a House
In a housing development, every house follows the same construction blueprint:
*   **Fixed Steps**: Foundation, Framing, Plumbing, Wiring.
*   **Variable Steps**: Exterior finish (brick vs. wood), interior paint colors, flooring type.

The "algorithm" is fixed—you can't paint the walls before laying the foundation—but owners can customize the finishing touches.

---

## ⚙️ When to Use It
*   **Consistency**: Ensure a specific sequence of steps is always followed.
*   **Code Reuse**: When multiple classes share almost identical algorithms.
*   **Inversion of Control**: The base class "calls back" into subclasses (The Hollywood Principle: *"Don't call us, we'll call you"*).

---

## ⚖️ Template Method vs. Strategy Pattern


| Feature | Template Method | Strategy |
| :--- | :--- | :--- |
| **Mechanism** | Inheritance | Composition |
| **Customization** | Changes **parts** of an algorithm | Swaps the **entire** algorithm |
| **Binding** | Static (Compile-time) | Dynamic (Runtime) |

---

## 💻 Implementation Example (C#)

This example shows how a data mining application handles different file formats using a shared processing skeleton.

```csharp
public abstract class DataMiner
{
    // Template Method
    public void ProcessData()
    {
        OpenFile();
        ExtractData();
        ParseData();
        AnalyzeData();
        CloseFile();
    }

    // Steps which should be implemented by subclasses
    protected abstract void OpenFile();
    protected abstract void ExtractData();
    protected abstract void ParseData();
    protected abstract void CloseFile();

    private void AnalyzeData()
    {
        Console.WriteLine("Analyzing data...");
    }
}
```

📍 **Note**: Ensure subclasses do not override the main template method to preserve the algorithm's integrity.
