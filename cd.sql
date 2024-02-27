DROP TABLE Fixtures;
DROP TABLE Teams;
DROP TABLE Customers;

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

CREATE TABLE Teams(
TeamID varchar2(3) NOT NULL,
TeamName varchar2(25) NOT NULL,
CONSTRAINT PK_TeamID PRIMARY KEY (TeamID));

CREATE TABLE Fixtures(
FixtureID varchar2(10) NOT NULL,
Team1 varchar2(25) NOT NULL,
Team2 varchar2(25) NOT NULL,
OddsTeam1 varchar2(25) NOT NULL,
OddsTeam2 varchar2(25) NOT NULL,
Fdate date NOT NULL,
FTime TIMESTAMP NOT NULL,
Score1 numeric(2),
Score2 numeric(2),
CONSTRAINT PK_FixtureID PRIMARY KEY (FixtureID));