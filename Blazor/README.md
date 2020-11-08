Connecting C# to mysql
=======================

File > new project > c# > windows > blazor app
Select blazer server app, no authentication and click create

Create a class library which is separate from the project
-------------------------------------------------------------
In the project right click the solution and go to add > new project > class library search for class library and select class library (.net standard). enter a project name and click 
create. 
Delete the class that is automatically added to the project.
Add references - right click dependencies and select manage nuget packages, search for and install Dapper. Also install mysql.data which allows you to talk to
mysql database
Add a clas to the project
