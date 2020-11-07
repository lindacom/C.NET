Create a window form app
========================

File > new project and select c# > windows > windows form app (.net framework)
Enter project name and solution name and click create
A form1.cs file is created

Sql server database tables and stored procedures

Connection string
helper
model

create a model
-------------

The model is used to get data from the database and add to the database

Right click model add > class enter name and click add
enter properties that match the database table

```
     public string FirstName { get; set; }
        public string LastName { get; set; }
```
Set up connection string helper
----------------------------------

add connection string to App.config file

Create a helper file to pull infor out of the App.config file. 

Create helper
-------------
Right click the project and select add > class.  Enter a name and click add. Make this a public static class.

```
 public static string CnnVal(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
```
Right click references and select add reference.In assemblies menu select framework. In the search type configuration and select system.configuration and click add.  In the Helper file hovr over the configurationManager text and select using System.configuration.

Add connection string
---------------------
add connection string to App.config file in the configuration section of the file add connection string tags

To get a connection string go to connectionstrings.com and click the link for sql server and clcik .net frameork data provider for sql server. Select server version and copy code for either trusted (already authenticated) or standard security (username and password for the database required)

Paste the connecion string Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;

Change server name or enter. for localhost and eter database name, id and password

Create UI
-----------
In the form.cs file click toolbox menu and drag a listbox into the form. In the properties box enter a name for this element.

Add a button.  Double click the button to add an event. e.g. call database and search

Add a class to the project with a method for the data access.

```
 public List<Person> GetPeople(string firstName)
        {
            throw new NotImplementedException();
        }
 ```
 
 In the form.cs file call the method
 
 ```
  public partial class Dashboard : Form
    {
        List<Person> people = new List<Person>();
        public Dashboard()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            people = db.GetPeople(LastNameText.Text);
        }
    }
        ```
