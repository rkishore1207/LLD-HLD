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