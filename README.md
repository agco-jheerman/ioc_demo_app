# ioc_demo_app

This project is a very basic example of implementing an Inversion-of-Control(IoC) Container pattern for a .net core console app
The solution targets .Net core 3.1 framework since that is the highest supported version in AWS Lambda as of the release
of this demo solution

## Installing .net core
```bash
# Download the latest .net sdk and runtime
brew install --cask dotnet-sdk
```

## Download and install older runtimes
https://dotnet.microsoft.com/download/dotnet-core

## Build the solution
```bash
# To build and target the .net core 3.1 framework
dotnet build -f netcoreapp3.1

# The default target framework is .net core 3.1, so this command will work as well
dotnet build
```

## Run the solution
```bash
dotnet run
```

## Run unit tests
```bash
dotnet test ioc_demo.Tests/ 
```
