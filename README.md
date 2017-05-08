# Try .Net Mvc - Sample Project
This is a combination of the Try .Net MVC slides and challenges

## How to run this project

To run this code, just clone the repo and make sure you've got the following installed:

1. An IDE or text editor (like [Visual Studio Code](https://code.visualstudio.com/) which is what I used to update this project)
2. .NET Core, which you can directly from Microsoft's [.NET Core download page](https://www.microsoft.com/net/core)
3. If you're running from command line, goto to the project's root directory and type `dotnet restore` first, and then `dotnet run` to build and run the application so that it's available locally at http://localhost:5000.

## Differences between this project and what was in the course

1. The project was upgraded from .NET Core was RC1 to .NET Core 1.1. (This changed `using Microsoft.AspNet.Mvc;` to `using Microsoft.AspNet.Core.Mvc;` all other changes don't impact what was covered in the course)

2. Instead of both `Equipment` and `Character` using the `HomeController` and `Home` Index, they're using the `EquipmentController` and `CharacterController` respectively.

3. The navigation in the `_Layout.cshtml` file was updated to make both the Character and Equipment content accessible through the navigation for usability's sake. (this file was not discussed in Try .NET MVC)

## .NET auto-generated README

When you create a .NET project from a template, it auto-generates a README.  We've left the contents of that README below in case you're interested.  Have fun!

# Welcome to ASP.NET Core

We've made some big updates in this release, so it’s **important** that you spend a few minutes to learn what’s new.

You've created a new ASP.NET Core project. [Learn what's new](https://go.microsoft.com/fwlink/?LinkId=518016)

## This application consists of:

*   Sample pages using ASP.NET Core MVC
*   [Gulp](https://go.microsoft.com/fwlink/?LinkId=518007) and [Bower](https://go.microsoft.com/fwlink/?LinkId=518004) for managing client-side libraries
*   Theming using [Bootstrap](https://go.microsoft.com/fwlink/?LinkID=398939)

## How to

*   [Add a Controller and View](https://go.microsoft.com/fwlink/?LinkID=398600)
*   [Add an appsetting in config and access it in app.](https://go.microsoft.com/fwlink/?LinkID=699562)
*   [Manage User Secrets using Secret Manager.](https://go.microsoft.com/fwlink/?LinkId=699315)
*   [Use logging to log a message.](https://go.microsoft.com/fwlink/?LinkId=699316)
*   [Add packages using NuGet.](https://go.microsoft.com/fwlink/?LinkId=699317)
*   [Add client packages using Bower.](https://go.microsoft.com/fwlink/?LinkId=699318)
*   [Target development, staging or production environment.](https://go.microsoft.com/fwlink/?LinkId=699319)

## Overview

*   [Conceptual overview of what is ASP.NET Core](https://go.microsoft.com/fwlink/?LinkId=518008)
*   [Fundamentals of ASP.NET Core such as Startup and middleware.](https://go.microsoft.com/fwlink/?LinkId=699320)
*   [Working with Data](https://go.microsoft.com/fwlink/?LinkId=398602)
*   [Security](https://go.microsoft.com/fwlink/?LinkId=398603)
*   [Client side development](https://go.microsoft.com/fwlink/?LinkID=699321)
*   [Develop on different platforms](https://go.microsoft.com/fwlink/?LinkID=699322)
*   [Read more on the documentation site](https://go.microsoft.com/fwlink/?LinkID=699323)

## Run & Deploy

*   [Run your app](https://go.microsoft.com/fwlink/?LinkID=517851)
*   [Run tools such as EF migrations and more](https://go.microsoft.com/fwlink/?LinkID=517853)
*   [Publish to Microsoft Azure Web Apps](https://go.microsoft.com/fwlink/?LinkID=398609)

We would love to hear your [feedback](https://go.microsoft.com/fwlink/?LinkId=518015)
