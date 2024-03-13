--dropping tables
DROP TABLE Fixtures;
DROP TABLE FixtureTimes;
DROP TABLE Teams;
DROP TABLE Customers;

--Creating table Customers
CREATE TABLE Customers(
AccountID varchar2(10) NOT NULL,
Forename varchar2(20) NOT NULL,
Surname varchar2(20) NOT NULL,
DOB date NOT NULL, 
PhoneNumber varchar2(10), 
Email varchar2(40) NOT NULL, 
Postcode varchar2(7) NOT NULL, 
Status char(1) NOT NULL, 
Balance numeric(7,2) DEFAULT 0,
CONSTRAINT PK_AccountID PRIMARY KEY (AccountID));

--Creating table Teams
CREATE TABLE Teams(
TeamName varchar2(25) NOT NULL,
CONSTRAINT PK_TeamName PRIMARY KEY (TeamName));

--Creating table FixtureTimes
CREATE TABLE FixtureTimes (
FixtureTime char(5) NOT NULL,
CONSTRAINT PK_FixtureTime PRIMARY KEY (FixtureTime));

--Creating table Fixtures
CREATE TABLE Fixtures(
FixtureID varchar2(10) NOT NULL,
Team1 varchar2(25) NOT NULL,
Team2 varchar2(25) NOT NULL,
OddsTeam1 numeric(4,2) NOT NULL,
OddsTeam2 numeric(4,2) NOT NULL,
Fdate date NOT NULL,
FTime char(5) NOT NULL,
Score1 numeric(2),
Score2 numeric(2),
CONSTRAINT PK_FixtureID PRIMARY KEY (FixtureID),
FOREIGN KEY (FTime) REFERENCES FixtureTimes(FixtureTime),
FOREIGN KEY (Team1) REFERENCES Teams(TeamName),
FOREIGN KEY (Team2) REFERENCES Teams(TeamName));

COMMIT;