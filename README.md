.NET consists of CLR (common language runtime) and class library.  You can use an IDE such as visual studio community (Install visual studio community from visualstudio.com and create a .NET project) or visual studio code.

Create a .NET project in Visual Studio Code
============================================

1. Open Viual Studio Code and go to file > open folder. Create a new folder and click select folder.
2. Open a terminal - view > terminal
3. Create a ne console project - In the terminal enter dotnet new console. A program.cs file containing a basic program, a <foldername>.csproj file and an obj directory will be created in the new project.
4. Ru the basic program - in the terminal enter dotnet run. The terminal displays the output.
  
Set up VS code for .NET debugging
-----------------------------------
1. Open the program.cs file
2. Install C# extensions - When you open a .cs file for the first tie you will get a message in VS code to install the recommended extensions for C#. Click install
3. After installation you will get another propt to add required assets to build and debug your project. Selet yes.

Add NuGet packages
------------------
1. In the terminal enter dotnet add package <name> --version <version>
  2. Open the <foldername>.csproj file. In the item group tag you will see an entry for the istalled package
  
Using package in your project
------------------------------
1. At the top of the program.cs file enter using <projectname>;

Framework Class Library (FCL)
=============================

CLR
===
.NET programmes are executed by the CLR.

JIT (just in time) converts compiled code into machine instructions


