BlazorApp
==========
An application to display people from the database. Enables CRUD - create people, read people, update people and delete people. Uses my sql database. Nb. check connection string.

N.b the data to be added etc. to the table is contained within the code
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
