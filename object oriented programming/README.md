Classes
=======
A class describes the object - attributes e.g. speed, reg, make
A class has properties (protected, public, private)
A class can contain methods (functions) which defines behaviour e.g. add, cancel, accelerate, break

protected - this class and children can access the class. Manipulate objects of attribute only in certain ways.  Using protected provides more controle over access.
This is known as encapsulation - preventing data inside object bein manipulated.

Inheritance
-------------
A class can inherit from other classes (sub classing) using extends. This is useful for when properties are not standard.

Abstract classes
------------------
An abstract class can contain base for a sub class

Relationships
---------------
Aggregation - e.g. car and engine. An engine is fundamental part of the car

Anthropomorphism
---------------
Anthropomorphism is giving human characteristics to inanimate objects

Interface
------------
A class can use an interface.  An interface is used when classes share common bhaviour but no obvious superclass.

An interface defines capability - what an object can do.  An interface is created using the : symbol

Objects
==========
1. An object is  name e.g car
2. An object is based on a class
3. Each instance of a class
4. An object can be built using a constructor, passing arguments in and using the new keyword.

To create a new object write:

```
Account myAccount = new Account();

```
then enter myAccount. to access the attributes of the account class 

Constructors
-------------
A constructor can be static

Encapsulation
=============
Signalling restriction of access by mking the method private. The benefit is it stops this being changed.

Object composition and abstractions
=======================================
Object composition - combine types to build a complex class using a constructor
abstractions - uses an interface

Exceptions
===========
Throw an exception when code encounters abnorma condition that it cannot deal with. Exception can be wraped in a try catch statement

try - call the method
catch - throw exception

enables you to echo a message
exception can also be wrapped in an if statement for example if you wnt to restrict the number of add for instances of methods you can throw a message.

