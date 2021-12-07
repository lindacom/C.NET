https://localhost:44375/api/products

Controllers 
=============

Products controller inherits from api contraoller. it specifies th various routes and methods e.g. GET, POST etc.
Create an accounts controlle file to register users

Add authorisation to controller
-----------------------------------
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
====================================
1. Right click the projet and select add > html page and name the page Register.html
2. In he content folder there is bootstrap.min.css. you can drag and drp it into the head section of the page to reference it.
3. In the body enter some code.

Add success modal 
-------------------------

5. In the body include code for the modal success message
6. Write the jquery code to display the success modal. This references two script files (jquery min.js and bootstrap min.js) which can be found in the scripts folder.
Also include a text/javascript script which will contain a document.ready function that will include the click event handler for the register button using it's id.

Use bootstrap alert to show validation errors
----------------------------------------------
Enter code for the alert.  
Add a clik handler in the document.ready function to close the alert
