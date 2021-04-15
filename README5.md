C# Syntax
==========

Console.WriteLine();
Console.ReadLine();

Encapsulation - information hiding

passing data - assigning one value to another creates a copy. If the origina changes it does not affect the other.  Assignment copies reference not the content and the 
reference then accesses the content.

type of operator - tells the method the type of the object

protected - accessible only to inherited types otherwise its private
virtual - set a function to irtual to create a v table lookup of functions that can be calledin a class e.g. for properties that should be overwritten
abstract classes - can have same properties and methods and you can indicate properties/methods are abstract
can't just inherit functionality, you need to implement it.

Inheritance
===========
Anything that 'is a' is an inheritance e.g racing car IS A car.

The benefits of inheritance is that code reuse, ope closed (ability to extend an app without rewriting code, LISKOV, sincle responsibility)

base class - e.g. car. with methods and properties eg. max speed property, speed property and accelerate method
derived class - e.g racing car inherits from base class and may have its own attributes

Use override, protected, abstract and/or virtual on the class.

virtual - is available in the v lookup table. Also maes method able to be rewritten in derived class
protected - variable and fields are private but can only be accessed by inherited classes
abstract - base class is marked as abstract. Implementation not done in the base class it has to be overwritten in the derived class
sealed - can no longer be inherited from.

show inheritace e.g use: car can also override some properties from base class e.g. base.maxspeed this will return the max speed set in the base class

N.b. constructors are not inheritaed therefore you need to create an inheritance relationship

Interfaces
==========
A contract. Describes capabilities that 'things' need to have e.g. play, record, pause, stop, rewnd, fast forward. An interface is similar to an abstract class.

The benefits of an interface is that it allows for the definition of a code contract and enables decoupling e.g. changing parameter from a class to an interface parameter
i.e. works ith any object that implements the interface

A class can implement multiple interfaces by comma seperating them.

An interface can inherit from another interface

Interfaces should be as small as possible e.g. because a large interface may contain some methods that are not needed in some instances


The naming convenstion is to put an I in front of the interface name e.g. IAccelerable

```
public interface IAccelerable {
}
```

define properties and methods in the interface e.g max speed, speed, accelerable (int)

When creating a class to use the interface indicate that the interface is being implemented and provide implementations for the methods

N.b. classes can be unrelated to each other but all use the same interface therefore having the same capabilities.

One issue is if a class implements two interfaces and the two interfaces have a common method it is not clear what is being returned by each.  To resolve this you can prefix the methods with an id e.g. cs.Draw(); and id.Draw();

Static function 
---------------
Static function - function belongs to the class. e.g. static void main. To use it you do not need to create an instance of it to run it. 
You use e.g program.main();

To access static functions you need to create static variables. N.b. if it does not say static it belongs to member function.

Static methods
--------------
static methods belong to a class therefore you do not need to create an instance of it to use it. 

Static constructor
---------------------
a static constructor runs once e.g. look up and set an exchange rate

Function polymorphism
------------------------

You can create two of the same functions with the same type but accepting different parameters so that different forms of data achieve different behaviour. 
This is nown as method overloading. e.g.

```
static void SayHello (string name = "world") {
Console.WriteLine($"Hello {name}")
}

static void SayHello(string firstName string lastName) {
Console.WriteLine($"Hi {firstName}{lastName}")
}
```

Local variables
---------------
A local variable i a function needs to be initialised (i.e. value set) before usin e.g. int age = 21;

N.b if you use var instad of int the system will determine the type based on its value.

N.b. dynamic variable can be initialised to anything and can be changed

Built in types
---------------

A signed 8-bit, 16-bit, 32-bit or 64-bit integer can store negative values -128 to +128.  An unsigned integer annot store negative values only 0-255

integer types:
sbyte 8-bit signed integer
short 16-bit signed integer
int 32-bit signed integer
long 64-bit signed integer

binary range:
byte 8-bit unsigned integer
ushort 16-bit unsigned integer
uint 32-bit unsigned integer
ulong 64-bit unsigned integer

Floating point numbers
float
double
decimal

bool is valid true/false
char - single character - need to use single quotes not double and accepts a single character only.



N.b. you canot assign a hgh value bit iteger to a smaller one eg 16-bit to 8 bit

n.b. putting a M after literal values will return a decimal e.g. 0.1M + 0.2M will return 0.3

Types
-----
Value types - decimal, bool, int ad float.  Value types are based on a strut. value types do not support inheritance. you can check equality using Equals
e.g. (r1.Equals (r2).  To write your own value type you declare it as a struct (similar to how a class is set up). nullable value types - put a ? aftr type 
allows null state e.g double ? diamond = null;

Enums - enum is a user defined value type.  it is a definition of possible values. an enum can be declared as a data type e.g.

```
public enum Fueltype {
petrol, 
diesel, 
electric
}
```

N.b behind the scenes the data is given an id (0, 1, 2 etc) then to use it 

```
public Fueltype Fuel {get; set;}

car c = new Car() {
Fuel = FuelType.Electric
}
```

reference types - string and list.  Reference types are based on a class. Reference types do not check same content they only check reference.



Properties
-----------

fields (member properties) in a class should be private. you can access a private field by a code - public getters and setter properties.

N.b. private setter you can read but not set

@ indicates that / in a string should not be interpreted as an escape.

Const variable - data is fixed and the value does not change

constructor - setting the same of the data objects to construct the object. N.b blank constructor is created automatically. You can also define a constructor
passing in parameters

N.b. rather than duplicating constructors you can use : this e.g

public car (string reg, string make, string model) {
  registration = reg;
  Model = model;
  Make = make;
  }
  
public car (string reg) : this (reg, "", "") {
}

This is called constructor chaining.  The first constructor will construct the oject.

Generics
============

Array
-----

There are several ways to create an array. 

1. string array contains multiple data. Initialise the array.
e.g. string [] names = { "bill", "Mary", "Tom" }

N.b. you cannot add and remove elements from the array You need to use the resize function e.g.

Array.Resize<int>(ref names, 20)
  
2. Lists

uses system.collections.generic and allows you to create a list

```
List<int> age
```

you specify the type of list to use e.g. a list of inteers.  You then get the items by index position
4. Array lists

Uses system.collections and allow you to create array list. Arrays are fixed size, array list has functios tha t enables add, remove, clear, check contains etc.

```
names.Add("Fred")
```

LINQ
====
linq enables querying of e.g. lists, array, dictionaries using the foreach statement and extension methods - average, contains, count, sum etc.

e.g. numbers = {1,2,3}
decimal total = numbers.sum()

LINQ builds on top of the IEnumberable interface.

N.b. by adding entity framework you can also query databases.

To ue linq with a lambda function use an aggregator e.g.

new employee { first = "mary", last = "jones", age = 21}
new employee { first = "tom", last = "cooper", age = 14}

double total = employees.Average(emp => emp.age);

variable scope
-------------

Best practice to reduce scope to as small as you can using scope of class or a function to  reduce lines of code 



global variables - can be accessed by every part of the application

public void function - in a public void function the curly braces define the scope N.b. code outside the braces but within the same function cannot access the variables

block variables e.g used in for loop are useful to reduce the lifetie of the variable and reduce data to the smallest scope possible.

Evaluating variables
-------------------
You can use

1. if, else, else if or alternatively use the ternary operator
2. for loop or for each loop
3. while loop or do while lop
4. switch statement

Operators
--------
BODMAS - a acronym for the order of calculating - brackets, order (the power of), division, multiplication, addition, subtraction
the order is left to right

e.g. 2 + 5 * 3 = 17
(2+5) * 3 = 21

Storage/memory
--------------
stack - temporary store of data e.g when a function is executing. Limited sie therefore value types need to be small
heap - limitless. Can grow to fill memory of machine
Statics - stores static classes data and variables. Statics are held for the duation of the execution of the application

Ref and out
----------

ref - pass by refernece. can be changed 

when you pass an argument to a parameter you are copying the argument. It does not affect the original. e.g

```
static void Main (string[] args) {
DoSomething(x)
}

static void DoSomethig(int y) {
y = 99;
}
```
This is the same as y= x and then y = 99.


Nb if you want to change the original then use passing by refernce -
declare the parameter as a ref parameter and in the function call e.g.

```
static void DoSomething(ref int y) {}

```

Y is ow a refeece variable.

N.b. alternatives to references are in and out

in - in only outside function. cannot be assigned ithin the function

out - enforces requirement for y parameter variable to be initialised inside the called function

Parcial classes
--------------

partial classes can be written over seperate files. Use the same class name they will be compiled together as one class. Partial classes are used to split
a large complicated class

Dependency injection
======================
Aim to reduce fixed dependencies between classes. One reason is this makes testing difficult. One way to do this is to use an interface 
e.g. interface for logging to the console, file logger interface

Delegates
=========
delegate - a reference directly to a method (i.e. not pointing to the object 

e.g. in the main function use reference vairables - Action<string> myname = functionName;
  
A delegate can be passed around the application as an argument (i.e. passing functions to functions)

e.g. 

```
myname.Invoke("Fred")

static void SayHello (string name) {
  console.writeLine($"Hello {name}");
  }
```

An action delegate can point to a void method






