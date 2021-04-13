C# Syntax
==========

Console.WriteLine();
Console.ReadLine();

Encapsulation - information hiding

Static function 
---------------
Static functio - function belongs to the class. e.g. static void main. To use it you do not need to create an instance of it to run it. 
You use e.g program.main();

To access static functions you need to create static variables. N.b. if it does not say static it belongs to member function.

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

Array
-----

There are several ways to create an array. 

1. string array contains multiple data. Initialise the array.
e.g. string [] names = { "bill", "Mary", "Tom" }

N.b. you cannot add and remove elements from the array You need to use the resize function e.g.

Array.Resize<int>(ref names, 20)
  
2. Lists
3. Array lists

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





