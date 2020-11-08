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
Add a class to the project

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
