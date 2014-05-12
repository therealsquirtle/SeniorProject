use DDchar
go

create table Abilities(
CharID int,
AID int identity(1,1) primary key,
base int,
enhancement int,
miscBonus int,
miscPenalties int,
modID int);

create table AbilityModifiers(
modID int identity(1,1) primary key,
Score int,
modifier varchar);

create table Armor(
charID int,
AItemID int identity(1,1) primary key,
Description varchar,
MaxDex int,
checkPen int,
weight int);

create table Character(
CharID int identity(1,1) primary key,
name varchar,
Pname varchar,
class varchar,
race varchar,
clevel int,
ECL int,
Size varchar,
gender varchar,
alignment varchar,
religon varchar,
height int,
cweight int,
cdescription varchar,
photo image,
touchAc int,
flatAC int,
hitPoints int,
experiencePoints int,
lightCarry int,
medCarry int,
heavyCarry int);
go