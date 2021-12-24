# Best Restaurant

#### An Application . 
#### Database Basic with C# 
#### By Jeff Terrell, Curtis Brooks & Kate Kiatsiri
---

## Technologies Used

- C#
- .Net
- ASP.NET Core
- Entity Framework Core
- MySqlConnector 
- LINQ
- Lambda

## Description

This is the practice lesson of week 10 at Epicodus web application with database for animal shelter to track animals in thier facility based on the animal type (such as cat or dog). Build out features that let a shelter worker:

* Add types of animals to the system. type should be a column on the animals table. A type could be a cat, dog, bunny or any other animal.
* Add an animal to the system. An animal should have a name, gender, date of admittance, and breed. When it gets added to the system, it should be added as a particular type.
* List animals by breed or type alphabetically.
* List animals starting with the ones who have been in the shelter the longest.

## Setup & Installation Instructions

* `$ dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0`
* `$ dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2`
* `$ dotnet add package Microsoft.EntityFrameworkCore.Proxies -v 5.0.0`


1. dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0
2. dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2
3. Clone github repository to local machine in desired directory <a href="https://github.com/JeffTerrell/animal-shelter-csharp"> Click here! </a>
4. Create .gitignore file in root directory add `*/appsettings.json` to the file
4. Create file appsettings.json in root directory in the project and add the code below and change the database to animal_shelter
```{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=to_do_list;uid=root;pwd=[YOUR-PASSWORD-HERE];"
    }
}
```
5. In the terminal open the directory,navigate to directory `AnimalShelter.Solution/AnimalShelter` run the command `$ dotnet restore` to create obj and bin directories
6. Run the command `$ dotnet build` to build and compile the project
7. To run the console application navigate to `AnimalShelter.Solution/AnimalShelter` folder in the terminal , and run the command `dotnet run` to see the web application.



## Known Bugs

No known issues

## License

#### [MIT](https://opensource.org/licenses/MIT) Copyright (c) _2021_ _Jeff Terrell, Curtis Brooks & Kate Kiatsiri_

## Contact Information

_If you have any questions please feel free to [Contact me](mailto:keidsiri@gmail.com)_

