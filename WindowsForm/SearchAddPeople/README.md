Application to search and add people to the database
=====================================================

1. App.config - configuration file containing database connection string
2. Dashboard.cs - the form ui with click event code
3. DataAccess.cs - connect to and query the database
4. Helper.cs - gets the connection string
5. Person.cs - model containing information that matches database columns

Connect to and query database
-----------------------------

In the method enter using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("mySampleDb"))) to access the cnnection string in the helper file.

connection.Query - to query the database
connection.Execute - to insert into the database
