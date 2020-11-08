Pages
------
Person.razor - injects data using model, contains sql query and connection string (using iconfiguration which uses the ijson configuration file), loads data into the page

Models
-------
PersonModel.cs

appsetting.json - database configuration settings

Data library (project)
-----------------------
DataAccess.cs
IDataAccess.cs - interface

Packages
-------
Dapper
MySql.data
