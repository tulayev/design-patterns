# Memento Design Pattern

The **Memento design pattern** is a behavioral design pattern that allows you to capture and save the current state of an object so that it can be restored later without violating encapsulation. It is most famously used for implementing Undo/Redo functionality, checkpoints in games, or transaction rollbacks.

---

## 1. 🧱 The Three Core Components
The pattern is defined by three distinct roles:
*   **Originator** 🏗️: The "main" object that has an internal state. It creates the Memento and knows how to use it to restore itself.
*   **Memento** 📸: A small, immutable object that stores a snapshot of the Originator's state. It is "opaque" to other objects.
*   **Caretaker** 🗄️: The object responsible for keeping the Mementos safe. It doesn't know what is inside; it simply stores them (often in a stack).

---

## 2. 🔄 How It Works (The Sequence)
1.  **Save** 📥: Before performing an action, the Caretaker asks the Originator for a Memento.
2.  **Change** ✍️: The Originator’s state changes (e.g., the user types text).
3.  **Restore** 📤: To undo, the Caretaker hands the Memento back to the Originator to reset its state.

---

## 3. ✨ Key Benefits
*   **Preserves Encapsulation** 🔒: No need to make private fields public to save them.
*   **Simplifies the Originator** 🧠: The Originator doesn't need to track its own history.
*   **Version Control** ⏳: Easily allows navigating through different states (History).

---

## 4. 🌍 Common Real-World Examples
*   **Text Editors** 📝: When you press `Ctrl+Z`, the editor uses a Memento to restore the document.
*   **Video Games** 🎮: "Save States" or "Checkpoints" where health and inventory are captured.
*   **Database Transactions** 🗃️: Rolling back operations if an error occurs.

---

## 5. ⚠️ Drawbacks to Consider
*   **Memory Usage** 📉: If states are large and snapshots are many, RAM consumption can skyrocket.
*   **Performance** ⚡: Copying large amounts of data frequently can be slow.
*   **Complexity** 🧩: In some languages, it's hard to strictly hide Memento data from the Caretaker.
