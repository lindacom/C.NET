Api
====
An api returns a json response

File structure
------------------
Startup.cs - api configuration
controller - action methods for api
DTO - gets data

N.b. local db is a free dbms that comes ith visual studio.  You can also use a free version of sql server that runs on Windows

https:/microsoft.com/en-us/sql-server/sql-server-downloads

Startup.cs file contains confiuration for api. The api configuration contains settings
Default api route added to routes list
default route pattern

```
private static void ConfigureWebApi(IAppBuilder app, HttpConfiguration config) {
  app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);
  
  config.Routes.MapHttpRoute(
     name: "DefaultApi",
     routeTemplate: "api/{controller}/{id}",
     defaults: new { id = RouteParameter.Optional }
     };
     app.UseWebApi(config);
     }
```

Routing:
if you want to enable name to be entered at end of url as a route parameter instead of id you can add

config.Routes.MappHttpRoute(
name: "DefaultNameApi"
routeTemplate: "api/{controller}/{name}",
defaults: new { name = RouteParameter.Optiona }
),


Arguments
---------
In a console application you can add credentials to a project e.g. api key

1. Right click the project then select properties > debug
2. In the application arguments box enter api key (In this box you could also enter filename and any other arguments).  The arguments will be assed every time the application runs.

Access aruments
----------------
In the program.cs file access arguments by their posibion in the application arguments box e.g

var apiKey = args[0];

Access api url
--------------
Access the url and add parameters

Parameter binding
===================
from the url path you can add query parameters or you can add parameters to the request body.

Query parameters
------------------
N.b. you can add parameters in the get method and then enter query string in th url when calling the api

Request body
------------
N.b. when you want to make several queries the url string will be too long therefore you can create a query in the body of the request instead.

DTO object
===========
DTO object = data transfer object (inputs and outputs for api endpoints)
This is an alternative to using data entities so you only send fields you need

1. Create a folder called DTOs 
2. create a class called SearchRequestDto. The namespace will be the project name.dtos folder.
3. Create proerties in the class e.g. min and max pric

```
namespace myProject.DTOs {
public class SearchRequestDto {
   public decimal MinPrice {get; set; } = decimal.MinValue;
   public decimal MaxPrice {get; set; } = decimal.MaxValue;
   }
   {
```
4. In the method of the main class create a method that takes DTO as a parameter

```
public List <tour> PostSearch (SearchRequestDto request) {
var query = context.Tours.AsQueryable()
.where(i =>Price >= request.MinPrice && i.Price <= request.MaxPrice)
return query.ToList();
}
```

In postman make a post request and enter properties e.g. min and max price in the body tab.

N.b. to edit a record add the id in the parameter of the method e.g put(int id, Tour tour)
and in postman make a put request with the id in the url and properties in the body tab.

Put one of the followng in the parameter of a method 
[fromody]
[fromUri]

e.g. pubblic List <tour>PostSearch([fromBody]SearchRequestDto request) to make it specific where the query parameters are to come from.

Testing controller actions in Postman
--------------------------------------
The controller file contains get, post, put, patch and delete actions. 



```
public class myController : ApiController {
  public IHttpActionResult Get() {
     return Ok("Get");
     }
      public IHttpActionResult Post() {
     return Ok("Post");
     }
      public IHttpActionResult Put() {
     return Ok("Put");
     }
      public IHttpActionResult Patch() {
     return Ok("Patch");
     }
      public IHttpActionResult Delete() {
     return Ok("Delete");
     }
     }
```
1. Run the project
2. In postman access the url using the various actions.

http verb attributes
-------------------
In the name of the method in the controller file you need to include the http verb (get put delete etc) however web api allows you to target a http verb for a method without needing to use it in the name of the method

1. In the controller use the http attribute before the method

[httpPost]
puboic List <tour>SearchTour([fromBody]SearchRequestDto request)

2. In postman do a post request

N.b. if you are using a non-standard verb, the accept verbs attribue allows you to list them for use e.g. 

[AcceptVerbs("flag", "fly")]
public void myAction() {
}

Return values
-------------
Returning data from pi. Return types:

1. return void - returns nothing
2. return HttpResponseMessage
3. return IHttpActionResult
4. return objects as a list of objects

To use return values:
1. Implement api controller
2 Before the method enter [httpPost]
3. In the method use IHttpAction result e.g.

Public IHttpActionResult SearchTours([fromBody]TourSearchRequestDto request)

N.b. in the method you can use return helper ethods eg BadRequest()

Validating models
==================
Uses attributes from System.ComponentModel.DataAnnotations namespace to mark up models or tos.
Asks asp.net to validate them using the model state property of the controller base class - base.ModelState.IsValid

N.b. There are many built in Data Annotations validation attributes

Json.NET
=========
Json.net is a serialisation library that web api uses by default.  Json.net has various settings

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

Using formats other than Json
===============================
Built in web api xml serialisers:
xml serializer
DataContract Serializer - newer and faster however you need to mark all fields to be serialised

To use xml serializer:
1. In the web api configuration method enter
config.Formatters.xmlFormatter.use xmlSeializer = true
2. in postman in the headers tab change content type and accept field to application/xml

Results are returned as xml instead of json

Get a list from a database
==========================
To do an entity framework query you need to add an entity framework contet e.g. private AppDataCntext _context = new ApDataContext();
You can then use this context in a method to create a query variable.

```
public List<tour> Get() {
  var query = _contet.Tours.AsQueryable(),
  return query.ToLit();
  }
```

1. Start project
2. Make get request in postman.
Results should be returned

Attribute routing
=====================
Instead of changing the ai config fil you can create inline attribute routing  To enable routing by attribute
1. Before the method enter e.g
[Route("api/tour{id:int})] - this path must match an integer
or
[Route("api/tour/{name}")]

N.b. you can use e.g. (RoutePrefix("api/tour")] so that all routes in the file will use the prefix

N.b. if you co not want to use the prefix for one or more methods you can escape the prefix using a tide symbol ~ before the uri (route string)

Data serialisation and model binding
========================================
models and Dtos
------------------
Sending and receiving an object that represents a row in the database (serialised and deserialised between and object in json)

client app -> rest call -> api app -> orm call -> database

Dto - transporting data in and out of api.  Include only objects you need.  DTOs are better for performance and security.
Model - exposes all CRUD operations

To create a controller:
1. Go to controllers > add > controller
2. Select web api2 controller with actions using entity framework and click add
3. Select model class data context is selected already Check use asynchrynous controller actions
4. Click add

Documenting and testing your api
=================================
You can create automated documentation for api.

1. In visual studio use // to create an xml comment in the file
2. Go to properties > build
3. Check xml documentation file (compiler creates api documentation)
4. Open nuget package manager. Install microsoft.aspNet.webapi.helppage to project
5. In the global.asax file enter areaRegistration.RegisterAllAreas(); in the application start method
6. In the helperPageConfig.cs file uncomment configsetDocumentationProvider and change xm filename

When you launch site compiler provides help file at the url /help

N.b. you can alternatively document your api using swagger  Install swashbuckle.core nuget package.



