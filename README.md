# _Eau Claire's Salon_

#### By: Ella Tanttu

#### _This is an MVC application that displays a webpage which will track stylists and their client lists._

## Technologies Used
* C#
* ASP.NET Core MVC
* MySQL
* Entity
* NuGet
* LINQ
* Bootstrap CSS

## Description

`HairSalon DB Table will go here`

TBD

### Setup/Installation Requirements
1. Download or clone github repository to local machine in desired directory - https://github.com/ellajtanttu/HairSalon.Solution
2. If downloaded, extract .zip contents to desired directory
3. Navigate to and open directory with Visual Studio Code
4. Within the terminal, navigate to HairSalon/ and create a file named `appsettings.json`
5. Add the following code to your new file, but add your own password to `USERPASSWORD`
  ```
  {
  "ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Port=3306;database=ella_tanttu;uid=root;pwd=USERPASSWORD;"
    }
  }
  ```
6. Install required packages by navigating to HairSalon.Solution/HairSalon/ and typing `$ dotnet restore`.
7. Compile the file by navigating to HairSalon.Solution/HairSalon/ and typing  `$ dotnet build`
8. Run the program by navigating to HairSalon.Solution/HairSalon/ and typing `$ dotnet run`

### Setup/Installation Database
* Open MqSql Workbench and connect to localhost:3306
* In the Navigator > Administration window, select Data Import/Restore
* In Import Options select Import from Self-Contained File
* Select `ella_tanttu.sql`
* In `Import Progress` click `Start Import`
* Run `$ dotnet build` and `$ dotnet run` in terminal

## Known Bugs

No known issues

## License

_MIT Copyright (c) 2021 Ella Tanttu_
_https://opensource.org/licenses/MIT_

## Contact Information

_Ella Tanttu ellajtanttu@gmail.com_