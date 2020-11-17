You can use an IDE such as visual studio community (Install visual studio community from visualstudio.com and create a .NET project) or visual studio code.

Create a .NET project in Visual Studio Code
============================================

1. Open Viual Studio Code and go to file > open folder. Create a new folder and click select folder.
2. Open a terminal - view > terminal
3. Create a ne console project - In the terminal enter dotnet new console. A program.cs file containing a basic program, a <foldername>.csproj file and an obj directory will be created in the new project.
4. Ru the basic program - in the terminal enter dotnet run. The terminal displays the output.
  
Set up VS code for .NET debugging
-----------------------------------
1. Open the program.cs file
2. Install C# extensions - When you open a .cs file for the first tie you will get a message in VS code to install the recommended extensions for C#. Click install
3. After installation you will get another propt to add required assets to build and debug your project. Selet yes.

Add NuGet packages
------------------
1. In the terminal enter dotnet add package <name> --version <version>
  2. Open the <foldername>.csproj file. In the item group tag you will see an entry for the istalled package
  
Using package in your project
------------------------------
1. At the top of the program.cs file enter using <projectname>;

.NET consists of CLR (common language runtime) and class library.

Framework Class Library (FCL)
=============================

CLR
===
.NET programmes are executed by the CLR.

JIT (just in time) converts compiled code into machine instructions

C# classes
==========
Library class

Class properties
------------------
N.b. when setting class properties it is not best practice to leave them open e.g. string Name; because there is no encapsulation - anything in the application can get and set them.

You can add an auto property e.g. string Name {get; set; }

Class inheritance:

N.b. when several classe will share the same properties you can create a base class (with common properties) and then other classes can inherit from that base class. To inherit from class use : eg.

public class student : person

N.b. Create this base class as an abstract class to prevent developers from directly intantiating the base class

Access modifiers
----------------

Access modifiers can be applied to classes, methods and properties.

public - can be seen outside the class, private - can only be seen in the class, protected, internal

Constructors
----------------

Construcors run immediately when a class is instantiated. Put them after the properties.

public School() {}

You can put arguments inside the construtor

public School() {name = "myschool"; }

You can also pass arguments into the constructor

public School (string schoolName, string schoolNumber) {
name = schoolName;
number = schoolNumber;
}

Methods
=======
Properties are used to store data. Methods are used to manipulate the data.
Nb. if a method does not return any data you can use void instead of return statement

Function bodied expressions can be used for simple returns. use => to indicate what should be returned instead of { return }

Abstract methods
----------------
You can create an abstract method within a class when you don't want it to be used directly. 

Abstract methods have to be overritten in subclass. Any class that inherits this class will need to use this abstract method (with code inside the metod).

N.b. you dont put code within the function. e.g.

public abstract float computeAge();

N.b. when the method from the baseclass is used in another class you can use override to override the setting in from the base class.

Virtual methods
----------------
 virtual methods can be created in baseclass and used in sub class. Virtual mthods can also be overritten in the subclass.
 
 Interfaces
 ============
 Interfaces require a class to implement certain properties and methods (similar to abstract class).  Objects can use multiple interfaces but they can only inherit from one class.
 
 1. Right click on library class > add > new item
 2. Find interface in the list
 3. Enter a name for the interface best practice is to start with an I e.g. IScored.
 4. Define properties that you want to appear on the objects taht use this interface N.b no code just structure
 
 To use an interface use : after the class name e.g. public class Science : IScored 
 
 You can use more than one interface by separating them with a comma.  N.b you can have base class and interface together separated by comma.
 
 Unit testing
 ==============
 Test driven development (TDD)
 ------------------------------
 
 1. Create or change code
 2. Create a repeatable test
 3. Review the results
 
 Test all methods in your code
 Can be automaed as part of continuos integration (CI) process using a tool like Jenkins.
 
 To write a unit test in visual studio:
 1. Create a class library
 2. Crate new test project - C# > test > unit test project
 
 N.b. to add more tsts go to add new item > test > basic unit test
 
 3. Write a test in unit test1.cs file. Using class library use assert statement to verify actual results copared to test results.
 
 ```
 public void testMethod1() {
    var testInstance = new class1();
    var testResult = testInstance.AddTwo(9, 5);
    Assert.AreEqual(testResult, 14, 'I expected 14');
    }
 ```
 
 N.b. to test an array length - Assert.AreEqual(testInstance.grocerList.length, 4)
 to test array position - Assert.AreEqual(testInstance.grocerList[1], "milk")
 
 4. In class1.cs file enter methods
 
 ```
 public int AddTwo(int a, int b) {
    return a+b;
    }
 ```
 
 5. Save all files
 6. Run test - test > run > all tests.  A test explorer window will open showing pass and fails.  Click to see details of test.
 
 N.b. classes need to be public to allow you to test them outside of the project.




