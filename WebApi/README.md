Api
====
An api returns a json response

Arguments
---------
In a console application you can add credentials to a project e.g. api key

1. Riht click the project then select properties > debug
2. In the application arguments box enter api key (In this box you could also enter filename and any other arguments).  The arguments will be assed every time the application runs.

Access aruments
----------------
In the program.cs file access arguments by their posibion in the application arguments box e.g

var apiKey = args[0];

Access api url
--------------
Access the url and add parameters

Parse json response with JArray 
-----------------------------------
Install the newtonsoft json package

```
public static void getfaces(string data) {
var faces = JArrayParse(data);
for each (var face in faces) {
var id = (string) face ['faceid'];
}
}
```
