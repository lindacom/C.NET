File > new project > asp.net core web application enter a name and click create
Select web application with no authentication and no docker.  Click create

Right click solution and select add > new project and select class library .net standard
Create a folder in the class library and add a class

Install entity framework
=========================

Right click dependencies of class library and select add > manage nuget packages and install Microsoft.EntityFrameworkCore.SqlServer

Create a data access folder and add a class and insert database sets e.g.

```
namespace EFDataAccessLibrary.DataAccess
{
   public  class PeopleContext : DbContext
    {
        public PeopleContext(DbContextOptions options) : base(options) { }

        public DbSet<Person> People { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Email> EmailAddresses { get; set; }
    }
}
```

Add a reference
---------------

In the project right click dependencies and select add > project reference and select the library

Configure services
------------------

In the startup.cs file configure services

Add connection string
----------------------
Add connction string to the appsettings.json file.

Create migration scripts
------------------------
create migration scripts for data access library. In visual studio go to view menu > other windows > package manager console. In the console eter Add-Migration
followed by a migration name. Press enter.  You wil get an error message because you need to add tooling to your project.

In the project riht click depndencies > manage nuget packages and search for and install Microsoft.EntityFrameworkCore.Tools

run the command again in the package manager console

Finished video at 30 mins

Create database
---------------
