Application Name: MvcPillow
Application Author: Esta Cimo
Creation Date: 2023-10-13 1208 ISO

Created the MvcPillow application as well as the GitHub repository for it

0107
Tested the build
Test was successful. The application is running

0111
Created a new view file About.cshtml
In the Views/Shared/_Layout.cshtml file, added the About links

0121
Updated HomeController.cs to include the About() method
I will return to update the About page at a later time

0158
Added Pillow.cs class to the Models folder

0213
Added the properties (Id, Size, Purpose, Density, Color, Shape, Material, Price)

1324
Updated the Data folder and the MvcPillowContext.cs file

1354
Made changes to Startup.ConfigureServices and added a connection string in the appsettings.json file

1401
Added a new scaffolded item which created a pillows controller Controllers/PillowsController.cs
as well as the Razor view files Create, Delete, Details, Edit and Index in Views/Pillows

1404
Ran the following commands in the PMC: 
Add-Migration InitialCreate
Update-Database

1405
Tested build. Build failed
Changed asp-controller and asp-action attributes for the MvcPillow anchor tag
Retested build. Build running successfully