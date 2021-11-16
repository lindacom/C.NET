Install .NET 6
=================
check existing installation by entering dotnet --list-sdks in the terminal
If you have an old vrsion download the latest from https://dotnet.microsoft.com/download

Create a project using ASP.NET Core Web API
================================================
Create and open a folder in visual studio code
in the terminal enter the command dotnet new webapi -f net5.0
To build the project enter dotnet run in the terminal
copy the localhost address into a browser and add /weatherforecast to the end of the url. You will see data in the browser.
Open a new terminal and enter the command dotnet tool install -g Microsoft.dotnet-httprepl --version 5.0.2 to install a command line tool that will be
used to make http requsts to the web api.
connect to the web api by running the command httprepl followed by the localhost address.  enter ls to view the available endpoints. Use the cd command to navigate to 
the weatherForecast directory. You will see the available apis for this endpoint. eter the cmmand get to make a get request. quite the session by entering exit
