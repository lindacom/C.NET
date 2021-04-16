Linq and Entity framework - queryin databases
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
