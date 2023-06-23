CREATE DATABASE AirplanesDBOne
GO
USE AirplanesDBOne
GO



CREATE TABLE Cities(
[Id] INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
[Name] NVARCHAR(50) NOT NULL
)

GO
create table Schedules(
[Id] INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
[StartDate] DATETIME NOT NULL,
[CityId] INT FOREIGN KEY REFERENCES Cities(Id) NOT NULL
)

GO
create table Pilots(
[Id] INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
[Name] NVARCHAR(50) NOT NULL,
[Surname] NVARCHAR(50) NOT NULL,
)

GO
create table Airplanes(
[Id] INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
[Model] NVARCHAR(50) NOT NULL,
[PassengerCount] INT DEFAULT(0) NOT NULL,
[PilotId] INT FOREIGN KEY REFERENCES Pilots(Id) NOT NULL 
)


GO
CREATE TABLE FlightTypes(
[Id] INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
[Type] NVARCHAR(20) NOT NULL
)
GO
CREATE TABLE Tickets(
[Id] INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
[CityId] INT FOREIGN KEY REFERENCES Cities(Id),
[AirplaneId] INT FOREIGN KEY REFERENCES Airplanes(Id),
[ScheduleId] INT FOREIGN KEY REFERENCES Schedules(Id),
[FlightTypeId] INT FOREIGN KEY REFERENCES FlightTypes(Id),
)
GO
INSERT INTO Cities([Name])
VALUES ('Mancester'),('Milan'),('Paris'),('Dubai')
GO
INSERT INTO Schedules ([StartDate],[CityId]) 
VALUES ('2023-03-12 07:00:00',1),('2023-08-20 14:30:00',1),('2023-08-25 18:45:00',1),
	   ('2023-06-01 05:00:00',2),('2023-02-25 16:00:00',2),('2023-08-30 07:00:00',2),
	   ('2023-06-31 15:00:00',3),('2023-04-31 17:00:00',3),('2023-08-07 19:00:00',3),
	   ('2023-06-23 12:00:00',4),('2023-05-23 10:00:00',4),('2023-08-18 22:00:00',4)
GO
insert into Pilots ([Name],[Surname]) 
values ('Yaver', 'Hasanli'),('Esger', 'Namazov'),('Famil', 'Babayev')

GO
insert into Airplanes ([Model],[PassengerCount],[PilotId]) 
values ('COMAC ARJ21' , 1600, 2),('Embraer E JET', 8, 2),('UAC  Tupolev Tu-214 ', 100, 3)
GO
insert into FlightTypes ([Type]) 
values ('Eco'),('Buisness'),('Premium')
