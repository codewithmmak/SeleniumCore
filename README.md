![Test Automation using Selenium WebDriver, NUnit and C#](./images/NUnit-Automation-Framework.png?raw=true "Test Automation using Selenium WebDriver, NUnit and C#")

# Test Automation using Selenium WebDriver and C#
This is sample Test Automation framework designed using Selenium WebDriver, NUnit and C#. And in this framework we will see some basic working examples for learning.

## Features
    * This automation framework is designed using NUnit.
    * C# is used as programming language.
    * Reporting is implemented using `` npm module. This generates the report in html. Also it captures the screenshots.

## To Get Started

### Pre-requisites
    * Download and install Chrome or Firefox browser.
    * Download and install [.NET 5.0](https://dotnet.microsoft.com/download/dotnet/5.0)
    * Download and install any Text Editor like Visual Code
    * Install Extension in Visual Code
        * [PackSharp](https://marketplace.visualstudio.com/items?itemName=elsnoman.packsharp)
        * [C#](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp)

### Setup Scripts 
    * Clone the repository into a folder

## How Framework is setup like a advance user

### Open the Command Palette for each of these commands
    * `PackSharp: Create New Project` > select `Class Library` > call the Project "Framework"
    * `PackSharp: Create New Project` > select `Class Library` > call the Project "Royale"
    * `PackSharp: Create New Project` > select `NUnit 3 Test Project` > call the Project "Royale.Tests"
    * `PackSharp: Create New Project` > select `Solution File` > call the Project "StatsRoyale"

> NOTE: The Solution (.sln) file will manage the Project (.csproj) files while the Project files handle their own packages and dependencies. As you add things, this is all handled for you! Very cool.

### Add the Projects to the Solution. Run these commands in the Terminal:
    * `$ dotnet sln add Framework`
    * `$ dotnet sln add Royale`
    * `$ dotnet sln add Royale.Tests`

### Build the Solution so we know everything is working
    * `$ dotnet build`

### Clean all the projects
    * `$ dotnet clean`

### Run the Tests
    * `$ dotnet test`
    * This will run all the tests, but you only have one right now. It should pass.

### Console Test Results

### How to Generate HTML Report

## How to run tests in Docker

### Download and install Docker
    * Check version of docker `docker --version`

### How to find all the images in your system
    * Go to `http://hub.docker.com/`
    * Search for selenium images
    * Pull images
        * `docker pull selenium/hub`
        * `docker pull selenium/chrome`
        * `docker pull selenium/chrome-debug`
        * `docker pull selenium/firefox`
        * `docker pull selenium/firefox-debug`
    * Check all the version in your system `docker images`

### How to run docker-compose
    * `docker-compose up -d`

### How to find which are the images up and running
    * `docker ps -a`

### How to check local Grid in a browser?
    * `http://localhost:4444/grid/console`

### How to restart docker-compose
    * `docker-compose restart`

### How to stop docker-compose
    * `docker-compose down`

## Reference
    * https://codemag.com/Article/2009101/Interactive-Unit-Testing-with-.NET-Core-and-VS-Code