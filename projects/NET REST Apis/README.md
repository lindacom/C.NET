Visual Studio
===============

Web API C# asp.net - database first approach using scaffolding

1. set up an sql server database
2. Create model using entity framework 
3. create web api using scaffolding
4. consume web api in browser to test content
5. consume web api in the application

SQL server
============
Set up database and table

Create a project
=================
1. select asp.net web application (.net framework) and click next. N.b. net core is for Linux and Mac
2. enter a project name and click create
3. click web api ensure no authentication is ticked. Click create

Add dependencies - entity framework
--------------------------------------
1. right click project name and select manage nuget packages
2. search entity framework
3. select and click install
4. right click project and select rebuild

Create model
--------------
1. Right click model folder, select add > new item
2. click data tab and select ado.net entity data model
3. click add
4. Choose model contents - select EF designer from database and click next
5. click new connections button (to create connection to the database server)
6. select ms sql server.  click continue
7. select the database from dropdown list
8. click test connection. click ok
9. click ok
10. click next on connection string page to accept defaults
11. expand tables > dbo and select table
12. click finsh

A data model will be added to the project

create a controller
---------------------
N.b. home controller inherits from controller and is MVC. Controller files inherit from API controller. The values controller file is an example file

1. Right click controllers folder and select add > new controller
2. select web api 2 controller with actions, using entity framework and click add
3. select model class name from the dropdown
4. select data context class from the dropdow and click add

The API is now created

Launch project
==============
1. Click IIS express button in the menu bar and add the /api endpoint to the url.  N.b. you may need to choose a browser.

In the internet explorer browser you will get a message to open or save a .json file. Select open.  Array of json objects is displayed in notepad
In the Chrome broswer and in Firefox XML of database content will be displayed 

Consume API
=============
1. Create a web application in the project solution.


Tutorials
=================
Getting tarted with asp net api
https://www.youtube.com/watch?v=FHjB1qEoDE8
