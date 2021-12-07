Web API c# asp.net - code first and repository pattern
=======================================================

1. create the entity class
2. create the data context class
3. create repository classes and interfaces
4. create the web api using repository
5. consume web api in the web application

Create project
==============
1. select file > new
2. select other project types > visual studio solutions > blank solution
3. eter a project name

Create a class
--------------
1. right click solution and select add new project
2. select windows desktop > class library
3. enter a name
4. rename class file
5. in the class file create properties
6. right click references and select framework > system component model.data annotations and click ok

create repository class
-----------------------
1. right click project and select new folder - interface then add > new itemcode > interface
2. eter a name

This contains all the operations (add, edit, remove, get, find by id)

add another class
-----------------
1. add another class library for database operations
2. right click and select manage nuget packages
3. install entity framework

add another class
-----------------
1. right click and select add > class (to inherit from db context)
2. right click references and add reference - solution > projects

add another class
-------------------
1. right click add > class
2. eter a name - to handle default data

add another class
-----------------
1. right click and select add > new item > class. Select to perform CRUD operations a database inherits from repository with all properties implemented
