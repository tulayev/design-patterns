# Flyweight Design Pattern

The **Flyweight Design Pattern** is a structural design pattern primarily used to **minimize memory usage** by sharing common data between a large number of similar objects.

Instead of each object storing all its own data, it shares **intrinsic (common)** data with others, while **extrinsic (unique)** data is kept separate or passed in at runtime.

String interning mechanism in `.NET` is a flyweight design pattern implementation.

---

## 1. Key Concepts: Intrinsic vs. Extrinsic State

The pattern works by splitting an object's data into two categories:

### 🔹 Intrinsic State
- Constant  
- Context-independent  
- Shareable  

**Example:**  
In a game with 1,000,000 trees, the tree's **3D model and texture** are the same for every tree.  
This is the **Flyweight itself**.

---

### 🔹 Extrinsic State
- Unique to each instance  
- Context-dependent  

**Example:**  
- (x, y) coordinates  
- Height  
- Color tint  

These values vary per object and are supplied externally.

---

## 2. Core Components

A typical Flyweight implementation consists of:

### 🔹 Flyweight Interface
Defines how the object interacts with extrinsic state.

```csharp
void Draw(Position position);
