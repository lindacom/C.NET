C# is an object oriented language.

Objects
-------
Objects can have properties and methods that can be attached to it.

e.g. name.ToUpper();

Rucursion
----------
A method that calls itself.

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
Arrays are indicated by square brackets. You need to specify type. Arrays have a fixed size which is set when you create the array.  Arrays contain positions. 

N.b. you cannot mix types in an array

Array example
------------------

To create an array enter the following in a method:

```
// create new instance of the array
var groceryList = new string[3];

// add items to the array
groceryList[0] = "milk";
groceryList[1] = "cheese";
groceryList[2] = "Apples";

```

N.b. to make the array available enter public string [] groceryList outside of the method.

To crate an array and fill it at the same time:

var groceryList = new string [3] {"milk", "chese", "apples"}

To get items in the array by index:

groceryList[2] or
Console.WriteLine(groceryList[2]);

To resize the array:

array.Resize(ref groceryList, 6);

You can then add more items to the array. N.b. ref you can get a variable by reference.

To access all items in the array you can use a for each loop. e.g.

foreach (var grocery in groceryList) {
   Console.WriteLine(grocery);
   }

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

Filter data using system.linq
-------------------------------

```
public static string filename  @"c:\users\text.txt";

var start = "";
var end = "";

using (var text = new StreamReader(filename) {
var data = mydata.ReadRange(text, start, end);
}
```

Dictionary
-----------
A dictionary Uses key value pairs. Need to specify type of key and type of value. Keys must be unique. 

To create a dictionary:

var dictionaryWords = newDictionary<string, sring>();

To add to dictionary:

dictionaryWords.Add("var", "shorthand for variable");

To access dictionary item by key:

dictionaryWords["var"]

To count items in a dictionary:

dictionaryWords.count or
Console.WriteLine("Count: {0}", dictionaryWords.Count);

To return all keys in a dictionary:

dictionaryWords.keys

To find an item in the dictionary by key:

Console.WriteLine("Keyvalue:{0}, dictionaryWords["var"]);

To search for an item in the dictionary by either key or value:

Console.WriteLine(dictionaryWords.ContainsKey("var");
Console.WriteLine(dictionaryWords.ContainsValue("shorthand for variable");


Algorithms
============
An algorithm is a self contained sequence of actions that solve a task e.g performing calculations, data processing automated tasks. The various types of algorithms are:
1. Linked lists
2. Stack
3. Queue
4. Binary search
5. Linear search
  
Linked lists
--------------
There are many types of lined lists

singly linked list:
Adding items to beginning or end of list.

1. Create class
2. Create node class. In the node class enter data and then add node class ( to make it recursive)
3. Display content

Stack
-----
A stack is an abstract data type that serves as a collection of elements (things piled on top of each other). Two operations are push and pop.

push - add element to collection
pop - remove ost recently added item (last in first out)

To create a stack algorithm:
1. Create a class
2. In the class define variables e.g. max size, array, index of last position
3. Create constructor with settings eg. max size, array and index of last position settings
4. Create push method that takes in parameters. Check if array is full else add to array
5. Create pop method. Check if it is empty else remove one and return stack array

N.b .NET has methods that automatically write this algorithm - .Push() and .Pop() and .Peek which you can use instead of writing your own algorithm

Queue
------
Similar to stack a queue is a data structue that serves as a collection of elements. Two features - enqueue and dequeue (firt in first out)

To create  queue algorithm:
1 Create class with variables
2. Create a constructor

N.b. .NET has the .Enqueue() and .Dequeue() methods.

Binary search
-------------
Binary search finds the positio of a target value within a sorted array.  It continuously compares the target value to the middle element of the array and eliminates irrelevant
half of the array.  The search continues on the remaining half until value is found or it confirms that the value does not exist.

To create a binary search algorithm:
1. Create a function that accepts parameters
2. Set start to 0
3. Set end to n (length of array)
4. While start <= end /2 (to find the mid point)
5. If value < start (midpoint) then set end = mid -1 (to find the next new midpoint)
6. Else if value > array midpoint (to know whether to eliminate left or right side)

Linear search
--------------
Linear search searches the target value wthin a list.  It checks each element until the target is found (or no results). This type of search is less efficient

N.b  .NET has .IndexOf() method which searches for an object and returns index of the first item it finds.

While loop example - authentication
====================================
```
static void Main(string[] args) {
  var code = "";
  while code != "secret") {
     Console.WriteLine("what is the passcode?");
     code = Console.ReadLine();
     
     if (code != "secret") {
       Console.WriteLine("not authenticated");
       }
       
       }
       Console.WriteLine("authenticated);
       }
```

For loop example - counting
=============================
Counting up
------------
```
for (int i=1; i<=10; i++) {
  Console.WriteLine(i);
  }
```
Counting down
----------------
```
for (int i=10; i>=1; i--) {
  Console.WriteLine(i)
  }
```


Tutorials
==========
Build a C# .NET application in 60 minutes https://www.youtube.com/watch?v=GcFJjpMFJvI
Introduction to asp.net mvc https://www.youtube.com/watch?v=phyV-OQNeRM
