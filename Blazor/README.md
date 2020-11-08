Connecting C# to mysql
=======================

File > new project > c# > windows > blazor app
Select blazer server app, no authentication and click create

Create a class library which is separate from the project
-------------------------------------------------------------
In the project right click the solution and go to add > new project > class library search for class library and select class library (.net standard). enter a project name and click create. 
Delete the class that is automatically added to the project.
Add references - right click dependencies and select manage nuget packages, search for and install Dapper. Also install mysql.data which allows you to talk to
mysql database
Add a class to the project

Add dependency to project reference
------------------------------------
In the blazor project right click dependency and select add dependency to project referece and select the data library (project)

N.b you don't add a dependency from the data library to the blazor project.

Create a new page
-----------------
Right click the pages folder in the blazor project and select add > razor component (this is a blazor page). Enter a name and click add.

N.b. a raor page is differentto a razor component.

Query and add to database
-------------
In the class file enter

```
using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataLibrary
{
   public class DataAccess
    {
        // load data
        public List<T> LoadData<T, U>(string sql, U parameters, string connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                List<T> rows = connection.Query<T>(sql, parameters).ToList();

                return rows;
            }
        }

        // save data
        public void SaveData<T>(string sql, T parameters, string connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                connection.Execute(sql, parameters);

               
            }
        }
    
}
}
```
Add services to the container
----------------------------

In the startup.cs file add a using DataLibrary statement (this refers to the namespace you created) and then in the public IConfiguration Configuration section add the service

```
 services.AddSingleton<DataAccess>();
 ```

Create an interface
--------------------
In the class file hover over the class name and click ctrl + . and select extract interface.  Enter an interface name beginning ith i (or keep the default) and select public members to form interface.  

You now have an interface that matches the class. The benefit is that as you wil use this multiple times you always have it open rather than having to open and close it each time.

In the startup.c file change service to 

```
 services.AddSingleton<IDataAccess, DataAccess>();
 ```
 
 Await/async
 ===============
 Model to put the data into
 something to call
 variable to put it into
 
 In the blazor project create a models folder
 In the models folder add a new class e.g. PersonModel
 add properties to the model class N.b you can type prop and tab twice to automatically create a property.
