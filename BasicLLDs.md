# Low Level Design

## OOPS
* It is method to write a code with a well structured manner, easy to understand, we could reuse the code, its extensible. Lot of advantages are there for OOPS.
* `Class` is a blue print or template to create a objects. `Objects` are a real world entity. Simple class is a concept and to map this concept to a real world by objects.

### Encapsulation
* Which means to `bind` the properties togetherly into a single entity, **ie) data binding**. 
* Also gives access restrictions to the data members and methods.

### Abstraction
* To hide the **internal implementation** from the service.
* With the help of `interface`, we just give the interface to the service, and it can utilize our code, that is without exposing our structure and everything.

### Inheritance
* Mainly it helps for Resuse the codes.
* One class can use the properties and methods of another class simply by inheriting.
* If we create object by child class then also we can able to access base class methods.
```C#
    class User{
        public string Name;
        public void Character(){};
    }  

    class Employee : User{
        public void GiveMoney(){};
    }

    class Customer : User{
        public void AcceptMoney(){};
    }

    User kishore = new Employee();
    kishore.Character();
```
* Types => Single, Multiple(two parents), Multilevel(more levels), Hierarchial, Hybrid

### Polymorphism
* Many Representation, one method can give **different behaviour** by passing different `parameters`.
* A function or an operator perform differently in different situation is polymorphism.
* Technically, we can say that when a function shows different behaviors when we pass different types and numbers of input values, then it is called Polymorphism in C#.
> -------------Real time example
- If we take water and boils at 100 celsius then it will be transformed into Gas.
- If we place inside the freezer it would change into solid as Ice uh.
- If we use in the room temperature it remains in the liquid state.
> -------------Compile time polymorphism:
* If the function call and the function execution is complete during the code compilation.
* In Method overloading, during compile time it will decide which function is gonna call. hence these decisions are done in the compile time itself.
* Binding => link between function call and the function body
* this binding also done in compile time so it is called as early binding.
> -------------Run time polymorphism
* In dynamic polymorphism, the behavior of a method is decided at runtime.
* The Parent Class and the Child class have the same method implementation. So, in this case, we will be able to know at runtime from which class the method is going to be executed.

## SOLID Principles

### Single Responsibility Principle
* One method is completely responsible for **one purpose** as well as class.
* But it is `Subjective`, based on the scenario, it will depends on the requirements

### Open Closed Principle
> Open for Extension and Closed for Modification
* If we wrote some code, then it would be able to add some other feature at future but we could do any modification on old code.

### Lyskov's Substitution Principle
* We could not force the child to do the implementation for methods.
* And we cannot alter the parent's behaviour.

### Interface Seggregation Principle
* Interface also having only the necessary methods based on the child, not having the unrelevent methods.

### Dependency Inversion Principle
* High Module not completely based on the low module, it should be communicate through a interface.

## Has a Relationship (Aggregation and Composition)
* If a class is completely depends upon it's base class then it is `Composition` **(partOff)**, and if the class still exist, even if the parent dies then it is `Aggregation`. But both will come under **has a**.
* Eg, Person has a heart and Person has a Book.
* In this case, without person, heart won't be there(**Composition**). But without person book can exist (**Aggregation**).
* So for many to many relationship, even if one side is died, then there must be other side possible. Hence at many to many scenario, there is no **Composition**.
* For one to one, it's based on the situation and it's `subjective` too.

## UML Diagram
![UML Diagram](https://github.com/rkishore1207/LLD-HLD/assets/146698138/49309642-d612-462f-a0e8-6e940ae61911)
* `Dotted line` is for **Implements**, that is derived class is force to implements the base class's methods.
* **Association** => Unidirectional and Bidirectional.
* One box is divided into three parts, **Name -> Data Members -> Methods**
    - Plus is for Public
    - Minus is for Private
    - Hash is for Protected
    - There also return type for methods, that is after colon
    - Underline emphasize Static
## Design Patterns
* It is a `solution` to a commonly occurs **problem**, and it is like a `template` to lot of problems and these patterns are proved and well tested.
* Design Patterns approach is completely based upon `Solid Principles`.
    - Creational DP
    - Structural DP
    - Behavioral DP
### Simple Factory DSP
![Simple Factory DSP](https://github.com/rkishore1207/LLD-HLD/assets/146698138/ed7bdb41-9e65-4df4-88b3-bde7a44f69c2)

* Creation of similar type objects taken place in the `Factory`.
* `Client` is nothing but, those who use the (utilize) the Factory and get the object.
* Hence client does not **depend on the low level**, by the *interface (abstraction)* it can get the necessary object from the factory.

### Factory Method
* Why we go for factory method is, simple factory violating the `open closed` solid principle.
* Because, if new object is need to create then we have the **modify the factory**, for to add new case condition.
* So, in Factory Method we created separate factory class for each object and implements the `IFactory` interface.

### Prototype Pattern
* There are two prototype patterns, Shallow and Deep clone.
* To create the same instance of original object into copy, for that purpose we are using clone, here client doesn't know how that clonning process is happening.
* At `Shallow Clone`, we are clonning the object and create two different references, but if we change the parent class in one of the object, it will change on all the objects.
![Shallow Clone](https://github.com/rkishore1207/LLD-HLD/assets/146698138/f46a3608-0ea6-4172-9a77-c495e2e05249)

* `Deep shallow` is overcome that problem, that is it will clone all the parent class as well at the **child clonned object**.

### Singleton Pattern
* Create only one object for entire process, eg, find tab in visual studio, which is common for all tabs.
* There are two cases => Lazy initialization and early initialization.
* There is one scenario, it will going to create **multiple object**, that is while `multithreaded` case it may create lot of objects.
* Hence for that case, we could use `Locker`. This is called **Lazy initialization**. `(Doubly Checked Locking)`
* Where as normal case is **Early initialization**, that is not care about *multi threading*.

### Command Design Pattern
* It can converts **requests** or simple patterns into `objects`.
    1. Command Interface -> abstract method `execute()`.
    2. Concrete commands that inherit the interface.
        1. It will create binding between **action and receiver**
    3. *Receiver* -> Performing the operation.
    4. *Invoker* -> Asking command to carry on the request.