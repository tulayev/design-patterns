# Proxy Design Pattern

The **Proxy Design Pattern** is a structural pattern that provides a placeholder for another object to control access, manage its lifecycle, or add functionality (like caching or logging) without modifying the original object.

---

## 🏗️ Key Components

*   **Subject Interface**: Defines the common methods for both the `RealSubject` and `Proxy`.
*   **RealSubject**: The actual object that performs the core business logic.
*   **Proxy**: Implements the `Subject` interface, holds a reference to the `RealSubject`, and controls access to it.
*   **Client**: Interacts with the Proxy, often unaware it is not the RealSubject.

---

## 🛠️ Common Proxy Variants

*   **Virtual Proxy**: Implements lazy initialization for resource-intensive objects, delaying creation until necessary.
*   **Protection Proxy**: Manages access control, ensuring only authorized clients can use the RealSubject.
*   **Remote Proxy**: Manages communication with an object located in a different address space or server.
*   **Caching Proxy**: Caches results of expensive operations to enhance performance.

---

## 📊 Pros and Cons

### Pros
*   **Enhanced Security**: Controls who can access the object.
*   **Efficient Resource Management**: Supports lazy loading.
*   **Access Control**: Easy to manage the lifecycle of the service object.

### Cons
*   **Complexity**: Introduces new classes into the code.
*   **Overhead**: May cause a slight performance delay due to the extra layer.

---

## 🔄 Key Differences


| Pattern | Focus |
| :--- | :--- |
| **Decorator** | Focuses on adding or enhancing functionality. |
| **Proxy** | Focuses on controlling access to the object. |
| **Adapter** | Changes the interface to make it compatible with others. |
