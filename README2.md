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

Working with files
-----------------------
ETL - extract, transform, load

Extract - Use system.IO - used to extract data from files.  Tryparse and error handling
Transform - LINQ - Language integrated query to query data and filter data

Read data from a file
------------------------------
```
private static string filename = @"c:\users\text.txt";

public void sampleFile() {
using (var text = new StreamReader(filename)) {
text.ReadLine();
var data = mydata.ReadAll(text);
}
}
```

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

Flow control
=============

Evaluationg conditions
------------------------

Alternate if/else formats:

```
public bool myColor(string color) {
   if color.ToLower() == "red") {
       result = 'primary'
       } else {
       }
```

The ternary operator:

return (color.ToLower() == "red") ? true:false;

Switch statemets:

```
public string secondaryOrPrimary(string color) {
   var result = "";
   switch(color.ToLower()) {
     case "red" : result = "primary";
     break;
     case "blue" : result = "primary";
     break;
     }
     return result;
     }
```

N.b. at the end of the cases you can add a default for it none of the colours match 

default: result = "secondary";
break;

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

Generate a random number
-------------------------
You can generate a random number using the random object new Random()

To generate a random number between one and ten

Random random = new Random();

int correctNumber = random.Next(1, 10);

Arrays and colections
=============================
Arrays
------
Arrays are indicated y square brackets. You need to specify type. Arrays have a fixed size which is set when you create the array.  Arrays contain positions. 

N.b. you cannot mix types in an array

To create an array enter the following in a method:

```
var groceryList = new string[3];

groceryList[0] = "milk";
groceryList[1] = "cheese";
groceryList[2] = "Apples";

```

N.b. to make the array available enter public string [] groceryList outside of the method.

To crate an array and fill it at the same time:

var groceryList = new string [3] {"milk", "chese", "apples"}

To get items in the array by index:

groceryList[2]

To resize the array:

array.Resize(ref groceryList, 6);

You can then add more items to the array. N.b. ref you can get a variable by reference.

Multidimensional array
-----------------------

To create an array with three rows and four values(coluns similar to a spreadsheet):

```
var multi = new int[3,4] {
{0, 1, 2, 3}
{4, 5, 6, 7}
{8, 9, 10, 11}
};
```

You can access the multi array by row and position e.g multi [2,3] will return 11.

Lists
-----
No need to specify size. Uses system.collection.gneric. Before method ener public List<string> sauces{get; set;}
  
To create a list:

var awesomeSauces = new List<string>();
  
To add to list:

awesomeSauces.add("tobasco");

To get an item

awesomeSauces[0]

N.b. you can also sort (sort() to sort alphabetically) and reverse items in a list.

Linq
----
Language integrated query - to operate on lists and collections

.sum()
.Average()
.Where(item -> item >=3) - this will return items in list that are greater or equal to three

Dictionary
-----------
Need to specify type of key and type of value. Keys must be unique. Uses key value pairs.

To create a dictionary:

var dictionaryWords = newDictionary<string, sring>();

To add to dictionary:

dictionaryWords.Add("var", "shorthand for variable");

To access dictionary item by key:

dictionaryWords["var"]

To count items in a dictionary:

dictionaryWords.count

To return all keys in a dictionary:

dictionaryWords.keys
  



Tutorials
==========
Build a C# .NET application in 60 minutes https://www.youtube.com/watch?v=GcFJjpMFJvI
Introduction to asp.net mvc https://www.youtube.com/watch?v=phyV-OQNeRM
