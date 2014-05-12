use DDchar
go
CREATE TABLE AvgDex(
dexID int identity(1,1) primary key,
dexRace varchar,
dexAvg int,
dexAvgMod int,
);
CREATE TABLE Avgcon(
conID int identity(1,1) primary key,
conRace varchar,
conAvg int,
conAvgMod int,
);
CREATE TABLE AvgInt(
IntID int identity(1,1) primary key,
IntRace varchar,
IntAvg int,
IntAvgMod int,
);
CREATE TABLE Avgwis(
wisID int identity(1,1) primary key,
wisRace varchar,
wisAvg int,
wisAvgMod int,
);
CREATE TABLE Avgchar(
charID int identity(1,1) primary key,
charRace varchar,
charAvg int,
charAvgMod int,
);
go