# Clean Architecture with CQRS Pattern

### This is template and sample, and used pure .NET. I tried to biuld a simple structure.

This project is an implementation of the Clean Architecture with CQRS Pattern using .NET 8. 
The Clean Architecture provides a robust and flexible software design that can easily adapt to changes and maintainability. 
CQRS (Command Query Responsibility Segregation) pattern separates the application into two parts: Commands and Queries. 
Commands are responsible for modifying the state of the application while Queries are responsible for retrieving data from the application. The separation of concerns enables scalability and performance optimization for the application.
 

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

* .NET 8 SDK
* Visual Studio 2019 or Visual Studio Code

### Installing

1. Clone the repository:

```bash 
git clone https://github.com/dkalvex/WordMatrixFinder.git
```


2. Open the solution file CQRSProject.sln in Visual Studio.

3. Build the solution by pressing Ctrl + Shift + B or by navigating to Build -> Build Solution.

4. Run the application by pressing F5 or by navigating to Debug -> Start Debugging.

### Running the Tests

The project includes unit tests that can be run using the Test Explorer in Visual Studio or by running the following command in the terminal:


```bash 
dotnet test
```

## Technologies Used

* .NET 8
* xUnit
