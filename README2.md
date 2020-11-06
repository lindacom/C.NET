Create a Windows Console application
=====================================
1. In visual studio press esc to enter visual studio without creating a project
2. Go to file > new and select console app (.NET framework) and click next
3. Enter a project name and click create.
4. A program.cs file is created which has one main class called program.  
   The file also contains a namespace (a container for classes and functions.  By default this is the name of the application but you can change it). 
    At the top of the file are using statements e.g using System.  This uses namespaces from other programs that can be included in the class i the file e.g. console comes from the system namespace.
     static void Main(string[] args) is the entry point of the application
5. Write code in the Main() function
6. Press ctr + F5 to run the application

To get the executionable file to run the finished application

In the file directory where visual studio files are saved go to bin > debug and find the .exe file.  Copy the file and either send it to someone or paste it to the desktop and run the application from the desktop.

Program.cs file explained
--------------------------
Classes can contain functions (methods) and variables (properties)
void - return type of the application (nothing will be returned)
Static - when you use static it means that there are no instances, you are referring to the function itself
