Create an MVC application
================================
1. In visual studio go to file > new project, select c# > web > asp.net web application (.net framework) and enter a project name and solution name
2. Select MVC template and keep setting as no authentication. Nuget packages are installed and application is ready.
3. Create a model, view and controller file and write code
2. Run the application
3.Publishing an MVC application - rght click and select publish

Nb. packages folder does not get checked into source control file. Pakcages.config file specifies packages needed and these are brought in when the application is built.

Errors
======
To turn errors off so users can't see error messages in the browser - in the web.config file enter

<customErrors mode="RemoteOnly"></customErrors> 

Views
=====

The errors page is located in views > shared > errors.cshtml and can be modified

views > global.aspx file - registers routes and bundles

views > _layout.cshtml - layout file for view pages

views > viewStart.cshtml - specifies layout file is the default layout
packages.config - nuget files are specified
