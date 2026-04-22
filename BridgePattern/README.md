# Bridge Design Pattern

The **Bridge Pattern** is a structural design pattern that decouples an **abstraction** (high-level logic) from its **implementation** (low-level platform-specific code), allowing both to vary independently.

---

## 📌 Key Idea

> *Separate abstraction from implementation so they can evolve independently.*

---

## 🚨 The Core Problem: Class Explosion

Imagine you are building an application with:

- **Shapes** → Circle, Square  
- **Colors** → Red, Blue  

### ❌ Using Inheritance

You would need:

- `RedCircle`, `BlueCircle`
- `RedSquare`, `BlueSquare`

### ⚠️ The Issue

If you add:
- A new shape → `Triangle`
- A new color → `Green`

You must create many more classes.

> 🔥 Total classes grow exponentially:  
> **Shapes × Colors**

---

## ✅ The Solution: Decomposition

The Bridge pattern replaces inheritance with **composition** by splitting the system into two independent hierarchies:

### 1. Abstraction
- Represents the high-level control layer  
- Example: `Shape`

### 2. Implementation
- Represents platform-specific or detail logic  
- Example: `Color`

### 🔗 The Bridge

The abstraction **holds a reference** to the implementation, connecting the two hierarchies.

```text
Abstraction → Implementor
