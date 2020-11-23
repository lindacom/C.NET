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
Results should be returne
