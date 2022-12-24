# _Hair Salon_

#### By: _**David Gamble**_

#### _This is a web app for Eau Claire's Salon which allows the user to add/view/edit/delete stylists and clients belonging to the stylists._

## Technologies Used

* _C#_
* _.NET 6_
* _ASP.NET Core MVC 6_
* _Entity Framework Core_
* _MySql_
* _MS Tests_

## Description

_This is a web app for Eau Claire's Salon which allows the user to add/view/edit/delete stylists and clients belonging to the stylists.  All of the information is stored in a MySql database which is updated by the user.  The user can add and remove stylists to a list of stylists where they can click the name of a stylist and view thier corresponding clients.  The user can also add and remove clients associated to thier stylist.  All of the stylist and clients information can be edited as well.  The app also contains a search function which allows the user to search the clients and displays the matching clients with their stylists._

## Setup/Installation Requirements

* _Clone the repository to your desktop from: https://github.com/DavidDGamble/HairSalon.Solution.git_
* _From the MySql workbench, under the Administration tab, click Data Import/Restore under MANAGEMENT_
* _Under Import Options, choose the Import from Self-Contained File and select the david_gamble.sql file located in the HairSalon directory in HairSalon.Solution_
* _Under Default Schema to be Imported To, click the New... button and enter hair_salon as the name of schema to create_
* _At the bottom of Select Database Objects to Import (only available for Project Folders), change the drop down from Dump Structure and Data to Dump Structure Only_
* _After completing the last 3 steps, click the Start Import buttom located in the bottom right corner_
* _Create appsettings.json file in Hair Salon directory and add the code below replacing [USERNAME] with your MySql username and [PASSWORD] with your MySql password._
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=hair_salon;uid=[USERNAME];pwd=[PASSWORD];"
  }
}
```
* _Run the following dotnet commands below in the HairSalon directory to run project_
```
dotnet restore
```
```
dotnet watch run
```

## Known Bugs

* _No known issues_

## License

_Copyright (c) 2022 David Gamble_

_Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:_

_The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software._

_THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE._
