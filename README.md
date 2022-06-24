# Map

In this project you able to write longitude & latitude of vehicle. This coordinates will **add** to a table in database and add a point on map. 

Also you can **edit**, **delete** this row(s). Basic SQL features :smile:

### Microsoft SQL Server 2019
 
 For create a connection with project and MS SQL Management Studio 2019 :
``` C#
using System.Data.SqlClient;

SqlConnection _connection = new SqlConnection(@"YOUR DBMS CORE NAME;
Initial Catalog=YOUR CATALOG NAME;
Integrated Security=true");
```
 
 ##### SQL scripts
 + Database create
 ```SQL
 CREATE DATABASE Vehicles 
 ```
 + Table create
 ```SQL
 USE Vehicles

CREATE TABLE vehicles(
	ID INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
	Vehicle_Name VARCHAR(50) NOT NULL,
	Latitude INT NOT NULL,
	Longitude INT NOT NULL
);
```
+ Insert Into table
```SQL
USE Vehicles

INSERT INTO Vehicles(
	Vehicle_Name,
	Latitude,
	Longitude
) 
VALUES(
	'Vehicle 1',
	50,
	45
)
```
+ Select all from database
```SQL
USE Vehicles

SELECT * FROM Vehicles
```
___

### GMap.Net
To add a Gmap.Net NuGet package use (WinForms version):  
[this link](https://www.nuget.org/packages/GMap.NET.WinForms)
or .NET CLI
```
> dotnet add package GMap.NET.WinForms --version 2.1.6
```
___
### Clone
``` 
git clone https://github.com/ReyKoll/Map.git
```
___
