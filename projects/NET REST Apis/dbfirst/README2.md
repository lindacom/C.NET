https://localhost:44375/api/products

Controllers 
=============

Products controller inherits from api contraoller. it specifies th various routes and methods e.g. GET, POST etc.

Add authorisation
--------------------
To add authorisation to a route add [Authorize] attribute at the top of the class declaration so that all actions will need to be authenticated.

```
namespace MyProject.Controllers
{
    [Authorize]
    public class productsController : ApiController
    {
```

when you access the route in the browser you will receive an authorization denied message

Create registration page
-----------------------------
Right click the projet and select add > html page and name the page Register.html
In he content folder there is bootstrap.min.css. you can drag and drp it into the head section of the page to reference it.
In the body enter some code.
