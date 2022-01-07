# Doctor's Office Web Application

#### By Anna Pittman, Katie Pundt, & Liz Thomas

#### _An application for office admins to track patients in a doctor's office._

## Technologies Used
* _HTML_
* _CSS_
* _C#_
* _.NET_
* _ASP.NET_
* _Entity_
* _Razor_
* _Node_
* _SQL_
* _MySQL Workbench_

## Description
_This web application was created for office admins at a doctor's office to track specialties, doctors, and patients at a medical practice. It allows the admin to create new specialties, doctors, and patients as well as assign doctors to specialties and patients to doctors._

## Setup/Installation Instructions
* Download, install, and configure MySQL
* Open the terminal on your desktop
* Once in the terminal, use it to navigate to your desktop folder
* Once inside your desktop folder, use the command `git clone https://github.com/ekthomas25/DoctorsOffice.Solution.git`
* After cloning the project, navigate into it using the command `cd DoctorsOffice.Solution/DoctorsOffice`
* Create a file named "appsettings.json" in the `DoctorsOffice` directory
* Add the following code to appsettings.json and add your MySQL user ID and password:
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=doctors_office;uid=[YOUR MYSQL USER ID];pwd=[YOUR MYSQL PASSWORD];"
  }
}
```
* Then run the command `dotnet ef database update`
* Then run the command `dotnet restore` to install project dependencies
* Then run the command `dotnet run` to run the project in the browser

## Known Bugs
* _No known issues_

## License
_MIT License: https://opensource.org/licenses/MIT_

Copyright (c) _2021_ _Anna Pittman, Katie Pundt, & Liz Thomas_