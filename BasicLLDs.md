# Low Level Design

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