C# is an object oriented language.

Objects
-------
Objects can have properties and methods that can be attached to it.

e.g. name.ToUpper();

Declaring variable
------------------
Declare variable by prefixing it with the type e.g. 

String name = "Mary"; 
int age = 35;

Another way to declare a variable is using the var keyword e.g

var name = "Mary";

Working with strings
---------------------
string methods:
Removing spaces - name.Trim()
Convert to lowercase - name.ToLower()
Get a string from within string.  Needs starting position and length - name.Subsring(4, 8)  

.ToString()

String properties:
name.length

Parsing strings as numbers:
Tryparse can be used to test a number before using it.  Tryparse returns either true or false. e.g. try to parse a number and then output it to the result variable if successful:

int result;
int.TryParse("12345", out result)

The result true will be returned.  To use the number enter the variable name result.

Using enumerators:
Enumerators can be used to access variable properties by name rather than position. You declare it with enum keyword followed by ame and values e.g

enum weekDays {Monday, Tuesday, Wednesday, Thursday, Friday};
var someDay = weekDays.Monday;

Working with dates and times
----------------------------
Today's date - DateTie.Now
Setting a specific date - var birthday = new DateTime(1967, 12, 19);

N.b. you can also add hours, minutes and seconds e.g. new DateTime(1967, 12, 19, 9, 51, 32);

Date calculation
Subtraction - var difference = DateTime.Now - birthday; 
Nb. this gives you a timespan object.  To calculate the number of days you can write 
difference.Days or 
difference.Days / 365 to get the years

N.b. other formatting options available are .hours, .minutes, .localtime, .ToFielTime

Addition - To add minutes enter
difference.AddMinutes(134)



Concatination
--------------
There are two different ways to concatinate variables and strings

Console.WriteLine(name + "is " + age); 

or using placeholders in the correct order

Console.WriteLine("{0} is {1}",name,age);

Formatting concatination:
var city = "Dallas";
var temporature = 103.4f;
var currentDt = DateTime.Now;

string.Format("Welcome to {0}. The time is {1:t}. The temperature is {2:0.00}.", city, currentDt, temperature)

N.b :t converts the date and time to just display the time. :T would give the longer time format with the seconds on the end. :0.00 formats to two decimal places.

Working with numbers
---------------------
To increment a number by more than one use += e.g.

age += 5;
age -= 4;

You can use the math class to perform calculations. The math class has various functions that can be added to it. e.g. 

To round up - Math.Round(5.2) or Math.Ceiling(5.8)
To round down - Math.Floor(5.8)

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
Introduction to asp.net mvc https://www.youtube.com/watch?v=phyV-OQNeRM
