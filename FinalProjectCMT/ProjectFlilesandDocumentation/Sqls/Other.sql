use DDchar
go
create table racialAdjust(
AdjID int identity(1,1) primary key,
Race varchar,
favoredClass varchar);

create table racialTraits(
RTID int identity(1,1) primary key,
size varchar,
speed varchar,
extraFeat varchar,
extraSkillPt int);

create table Classes(
classID int identity(1,1) primary key,
class varchar, 
HDType varchar);

create table Bonuses(
BonusID int identity(1,1) primary key,
lvl int,
XD int,
CSMaxRanks int,
CCMaxRanks int,
Feat varchar,
Abiltiy varchar,
ScoreIncrease int);

create table Fighter(
FightID int identity(1,1) primary key,
FLvl int,
FBaseAttckBon int,
FFortSave int,
FWillSave int,
FSpecial int);