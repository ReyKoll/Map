USE Vehicles

CREATE TABLE vehicles(
	ID INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
	Vehicle_Name VARCHAR(50) NOT NULL,
	Latitude INT NOT NULL,
	Longitude INT NOT NULL
);