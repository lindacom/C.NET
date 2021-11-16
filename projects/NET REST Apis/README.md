Install .NET 6
=================
1. check existing installation by entering dotnet --list-sdks in the terminal
2. If you have an old vrsion download the latest from https://dotnet.microsoft.com/download

Create a project using ASP.NET Core Web API
================================================
1. Create and open a folder in visual studio code
2. in the terminal enter the command dotnet new webapi -f net5.0
3. To build the project enter dotnet run in the terminal
4. copy the localhost address into a browser and add /weatherforecast to the end of the url. You will see data in the browser.
5. Open a new terminal and enter the command dotnet tool install -g Microsoft.dotnet-httprepl --version 5.0.2 to install a command line tool that will be
6. used to make http requsts to the web api.
7. connect to the web api by running the command httprepl followed by the localhost address.  enter ls to view the available endpoints. Use the cd command to navigate to 
8. the weatherForecast directory. You will see the available apis for this endpoint. eter the cmmand get to make a get request. quit the session by entering exit
9. To shut down the web api go to the dotnet terminal and press ctrl + c
