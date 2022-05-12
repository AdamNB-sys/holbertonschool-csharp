# 0x07 C# - Test Driven Development


**TDD basics, unit testing, NUnit, and class libraries**


## Learning Objectives

* What are solutions in VSCode
* How are solutions different from projects in VSCode
* What is a class library
* What is a unit test
* How to create and run tests using NUnit
* What is the Arrange, Act, Assert methodology
* How to effectively name your unit tests
* How to utilize the TDD approach
* How to consider edge cases


## More Info

For each task in this project:

1. Create task directory (ex: `0-add`)
2. Inside that directory, run `dotnet new sln`
3. Create a new directory for your task solution based on the namespace given (ex: `MyMath`). This directory will hold your new standard class library.
4. Inside that directory, run `dotnet new classlib`. Rename the resulting `.cs` file after the namespace (ex: `MyMath.cs`)
5. Enable XML documentation by adding `<DocumentationFile>bin\$(Configuration)\$(TargetFramework)\$(AssemblyName).xml</DocumentationFile>` to MyMath.csproj
    * The target framework for this standard class library should be `netstandard2.0`
6. Change directory back to the root directory of the task (ex: `0-add`) and run `dotnet sln add <classlibrary/classlibrary.csproj>` (ex. `dotnet sln add MyMath/MyMath.csproj`)
7. Create a new directory for your tests based on the namespace given plus `.Tests` (ex: `MyMath.Tests`). This directory will hold your test library.
    * The target framework for this library should be `netcoreapp2.1`
8. Inside that directory, `run dotnet new nunit`. Rename the resulting `.cs` file after the namespace of classes you are testing plus `.Tests` (ex: `MyMath.Tests.cs`)
9. To add your class library as a dependency to the project, run `dotnet add reference <../classlibrary/classlibrary.csproj>` (ex: `dotnet add reference ../MyMath/MyMath.csproj`)
10. In the task’s root directory, run `dotnet sln add <testlibrary/testlibrary.csproj` (ex: `dotnet sln add MyMath.Tests/MyMath.Tests.csproj`)
11. If you’d like to run your class library method in a console application, create a new directory and run `dotnet new console` inside it. Run `dotnet add reference <../classlibrary/classlibrary.csproj>` and you can then call your class library methods inside the console application.
