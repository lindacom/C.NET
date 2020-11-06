.NET consists of CLR (common language runtime) and class library.  You can use an IDE such as visual studio community.

Install visual studio community from visualstudio.com

CLR
===
.NET programmes are executed by the CLR.

JIT (just in time) converts compiled code into machine instructions



Program.cs file explained
--------------------------
Classes can contain functions (methods) and variables (properties)
void - return type of the application (nothing will be returned)
Static - when you use static it means that there are no instances, you are referring to the function itself

Declaring variable
------------------
Declare variable by prefixing it with the type e.g. 

String name = "Mary"; 
int age = 35;

Concatination
--------------
There are two different ways to concatinate variables and strings

Console.WriteLine(name + "is " + age); or using placeholders in the correct order
Console.WriteLine("{0} is {1}",name,age);

Change text colour in console
-----------------------------
Console.ForegroundColor = ConsoleColor.Green;

write code here

Console.ResetColor();

User input
----------
To enable user input enter console.ReadLine();
To put user input into a variable enter string input = Console.ReadLine();
To use the variable containing input enter Console.WriteLine("Hello {0}, let's play",input);

To detect if input is a number

guess = 0;

if(!int.Tryparse(input, out guess)) {
console.WriteLine("please enter an actual number");
}

To put input into the guess variable as an integer

guess = Int32.Parse(input);

Generate a random numbr
-------------------------
You can generate a random number using the random object new Random()

To generate a random number between one and ten

Random random = new Random();

int correctNumber = random.Next(1, 10);

Tutorials
==========
Build a C# .NET application in 60 minutes https://www.youtube.com/watch?v=GcFJjpMFJvI
