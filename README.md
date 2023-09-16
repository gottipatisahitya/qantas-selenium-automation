# Selenium UI automation framework using C# for Web application

## Introduction
This project is a demonstration of Selenium UI Test Automation solution for Automation Exercise web application 
C# is chosen as a preffered language with Git as source control.

## Pre-requisites/Tools 
1. IDE - Visual Studio 2022 or higher version. 
2. .Net framework version (6.0 or higher) should be installed. 
3. Nunit Test project is the chosen template for the framework. 
4. All package dependencies are handled through Nuget package manager (including the browser specific drivers).

## Test configuration and data
1. Test data configuration is driven through appsettings.json file.
2. All config values are prefilled in the appsetting.json file

## Assumptions
1. Tests are assumed to be executed in CI/CD. This solution supports overriding the local config settings from CI server's environment variables. 

## Test execution
Load the solution in Visual Studio 2022. Building the solution will restore all NuGet Packages and all Nunit tests will be displayed in Test Explorer.
Run the tests via the Test Explorer. 

Tests can also be executed via command line after restoring all the nuget packages using Visual Studio. 
Navigate to the project directory in the local system where the solution has been downloaded to and run the following command.

`dotnet test`
