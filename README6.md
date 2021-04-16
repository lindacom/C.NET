Linq and Entity framework - querying databases
=============================================
Etity framework is similar to an object relational mapper (ORM). integrates into sql server.

You can ither take a database first or a code first approach to design.

Linq keywords nd methods
-------------------------
The of type linq ethod is used to filter all elements of type T e.g

```
var dogs = mammals.oftype<dog>();
```
the let keyword allows you to define a locally-scoped, type inferred varial=be

Linq queries
---------------

Read a file line by line

```
var query = from s in File.ReadAllLines("people.txt")
```

N.b. in visual studio the file.readalllnes method uses system.IO

use the split function to split string based o the specifier identified as seperate elements in the array

```
let fields = s.split(',')
```

arse each line from the file into variables in the linq query

```
let firstname = fields[0]
let lastname = fields[1]

```
join together 

```
select new {firstName, lastName};
```

loop through

```
foreach(var result in result) {
  console.WriteLine($"{result.firstName} {result.lastName}");
  }
```

Loading data in code
---------------------
There are various options for loadig data:

lazy loading - loads data as you access it. eg. useful for one to many relationships

```
public class zoo {
  public virtual Icollection<animal>Animals {get; set;}
  }
  ```
  
Eager loading - as you loop through it returns all data at once

```
foreach(zoo zoo in ctx.2005Include(z=>.Animals)) {
}
```

Explicit loding - useful for colletions and loading specific child collections

```
ctx.Entry(200).collection(z =>z.Animals).Load();
```

Exception handling
======================
if code has exception error the application will stop running. (N.b. web app will redirect to a default error page.) When code has error an exception objct is created and works backwards through the code to find the point in the code that cn handle the exception.

You need to handle the exception to prevent the user experiencing this eror and to stop the application from crashing.

1. run code in debug
2. add a try/catch block to the code

```
try {
  DoSomething();
  }
  catch (exception err) {
  Console.riteLine("Error has occurred");
  }
  ```

catch exception - enables access to the exception error message.  used to log errors, retry what has failed. N.b it is not mandatory to have any code in the catch block.

N.b. adding throw; to the catch block it will continue moving upwards

returning 0 indicates success and any other number indicates fail.

The base class of every exception is exception. 

You can add finally block after try catch for code that will always execute even if there is an exception.

guard statement
---------------
you can protect a function by using a guard statement to throw your own exception

```
static void DoSomething(string data) {
  int value;
    if(!int.TryParse(data, out value)) {
      throw new exception ("data must be numeric");
      }
```

Events
=======
event - place an event in a class, type or struct to notify that something has happened in the object. buttons have events on them e.g click, mouse move etc.

subscribe to event
code responds to button click (execute code method)
add a delegate reference to handle click method
evnt handler delegate is designed to point to event handling code
event handling code is always void and always has two arguments - object and args

```
void HandleClick(object sender, EvntArgs args) {
}
```
