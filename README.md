#Pierre's Bakery 

#### By Caroline Cerussi

#### Website for Pierre's bake shop, that alllows a user to navigate and see the list of flavor and treat options. If you login or register an account, you will then also have access to adding your own flavor or treat. 

## Technologies Used

* HTML
* CSS
* C#
* .NET
* ASP.NET CORE MVC
* Razor
* MySql
* MySql Workbench
* EF Core

## Description

Upon opening the webpage, the index home page will give you an option to view the flavor or treat lists, along with two links to login or register an account. In order to access capabilities of deleting, editing, or adding a flavor or treat, the user must be logged into their account, or register for one using an email and custom password. 

For the flavors and treats, you may add and assign a treat that holds a certain flavor, along with select treats to list under a flavor profile. To see which belong with which, you can click the hyperlinked name of the treat or flavor in its list to see all of its attributes. 

## Setup/Installation Requirements

Setup/Installation Requirements
Clone this repository to your desktop by executing git clone https://github.com/carolinecerussi/SweetnSpicy in your preferred terminal application.

In the terminal, cd into the /Shop/ directory then execute the dotnet restore command to auto-populate the project with an /obj/ directory and its required contents.

Ensure you have the following packages by running the following terminal commands for installing each: dotnet add package Microsoft.EntityFrameworkCore -v 6.0.0 dotnet add package Pomelo.EntityFrameworkCore.MySql -v 6.0.0-alpha.2 dotnet add package Microsoft.EntityFrameworkCore.Proxies -v 6.0.0

Create an 'appsettings.json' file in the project root and populate it with the following content, taking care to update with your unique database configurations: { "ConnectionStrings": { "DefaultConnection": "Server=localhost;Port=3306;database=sase-db;uid=root;pwd=[YOUR PASSWORD];" } }

NOTE: [password] should be replaced by your password. Do not include square brackets in final configuration.
Execute dotnet build in the terminal to automatically create the required /bin/ folder for the project.

To build out a database with a code first approach ensure the following packages have been installed/updated on your machine via these terminal commands: dotnet tool update --global dotnet-ef --version 6.0.0 dotnet add package Microsoft.EntityFrameworkCore.Design -v 6.0.0

To create a record, or snapshot, of the current database run the following command: dotnet ef migrations add Initial

NOTE: Repeat this command, after updating 'Initial' to whichever name best represents your new database snapshot, any time a change is made to the database.
Run the following command to update your database to reflect the recent migration data: dotnet ef database update

To start and run the app execute dotnet run from the /SweetAndSavoryExplorer/ directory or, optionally, dotnet watch run to start the app and cause it to rebuild and run after each saved change to the codebase.


## Known Bugs

* code is not broken, but some clickable links seem to show up blank in my localhost.

## License
[MIT]

Copyright (c) 2022 CAROLINE CERUSSI
