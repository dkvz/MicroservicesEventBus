# Microservices Event Bus experiment
IN PROGRESS

## Requirements
- .NET 6+
- Won't work without the ASP.NET runtime, usually called `aspnet-runtime` on Linux

## Setup
I'm using the `webapi` project template for both services.

Git ignore file created by running `dotnet new gitignore`.

## Running the project


## API structure
* I left the Swagger config in Program.cs except I removed the check for development mode.
* I add a HomeController that just serves Swagger.
* Business endpoints are on other controllers.