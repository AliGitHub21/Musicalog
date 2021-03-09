# Musicalog Test Project

> The goal of this project is to develop a web application that allows users to keep a catalogue of music albums.
> This will allow listing, create, edit or deleting albums from the catalog.

## Table of contents

- [Technologies](#technologies)
- [Setup](#setup)
- [Features](#features)
- [Limitations](#limitations)
- [Improvement](#improvement)
- [Status](#status)
- [Contact](#contact)

## Technologies

```
* 3-tier Architecture
* C# - vesrion 7.0
* .Net(Core) - version 5.0
* Entity Frameqork Core
* Repository Pattern (Design Pattern)
* SQL Server
```

## Setup

```
- Download the source code and open it with your choice of IDE.
- change the connectionString setting in 'appsettings.json' file based on your Sql Server database connection and save the file
- Follow the instruction below based on your machine operating system:
>* Windows:
    1) Change into '../Musicalog.Presentation/' directory from your integrated terminal
    2) Run command: Enable-Migrations
    3) Run command: Add-Migration InitialCreate
    4) Run command: Update-Database
>* MacOs:
    1) Change into '../Musicalog.Presentation/' directory from your integrated terminal
    2) Run command: dotnet ef migrations add InitialCreate -s ../Musicalog.Presentation/
    3) Run Command: dotnet ef database update -s ../Musicalog.Presentation/
- Run the application from IDE
```

## Features

> - The application allows user to create,edit and delete an album form catalogue.
> - The list of created albums have sorting and pagination feature enabled on the client-side
> - Adding serach feature to the list is also possible by changing the javascript function provided for loading data-table

## Improvement

> - Implementing modern javascript framework(Angular or React) fro the front-end
> - Adding security features(JWT, etc )to the application
> - Adding Dapper ORM to the implementation for read operations

## Limitations

> - Did not use standard .Net(4.7) for this application due to limitation of available shell commands for entity framework 6 from Apple Macbook machine and 'Visual Studio for Mac' IDE.
> - Not able to integrate WCF service as requirement suggest due to lack of available Microsoft project template/libraries.

## Status

```
Project is: _finished_
```

## Contact

Created by Ali Rezaei - feel free to contact me! [ali.rezaei@Hotmail.co.uk](Hotmail.co.uk)
