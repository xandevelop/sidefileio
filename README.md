SideFileIO is a lightweight C# library for deserializing and working with .side test files created by Selenium IDE. It provides a strongly typed object model and utility functions to manipulate test data programmatically.

# Features

Deserialize .side JSON into C# objects

Support for commands, tests, suites, and full project metadata

Compatible with Selenium IDE version 2.0+ schema

Easy integration into test runners or test analysis tools

# Installation
Clone the repository and add a reference to Xandevelop.SideFileIO in your project:

```
git clone https://github.com/xandevelop/sidefileio.git
```
Or reference the project directly in your .csproj:

```
<ProjectReference Include="Xandevelop.SideFileIO/Xandevelop.SideFileIO.csproj" />
```

# Usage Examples
## Load a Side file and interrogate it
```csharp
using Xandevelop.SideFileIO;
using System.IO;

string json = File.ReadAllText("MyTestProject.side");
Side side = Side.FromJson(json);

// Access metadata
Console.WriteLine($"Project: {side.Name}, Version: {side.Version}");

// List all test names
foreach (var test in side.Tests)
{
    Console.WriteLine($"Test: {test.Name}, Commands: {test.Commands.Count}");
}
```

## Load and Save a Side File
```csharp
// Load
var side = Side.FromJson(File.ReadAllText("project.side"));

// Modify
side.Name = "Updated Project";

// Save
File.WriteAllText("new.side", side.ToJson());
```
