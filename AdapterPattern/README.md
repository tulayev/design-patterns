# Adapter Design Pattern

The **Adapter Pattern** is a structural design pattern that allows objects with incompatible interfaces to collaborate.

It acts as a bridge between two incompatible interfaces by converting one interface into another that a client expects.

---

## 📌 Key Idea

> *Getting the interface you want from the interface you have.*

---

## 🧩 Key Components

### 1. Target (Interface)
The interface that the client expects and uses.

### 2. Adapter
A class that:
- Implements the **Target** interface  
- Wraps an instance of the **Adaptee**  
- Translates calls into a format the adaptee understands  

### 3. Adaptee
The existing class with an incompatible interface that needs to be adapted.

### 4. Client
The code that interacts only with the **Target** interface.

---

## ⚙️ Implementation Approaches

### 🔹 1. Object Adapter (Composition) — *Recommended*

- Uses **composition** (has-a relationship)
- The adapter contains an instance of the adaptee
- More flexible and widely used (especially in languages like Java, C#)

```text
Client → Target → Adapter → Adaptee