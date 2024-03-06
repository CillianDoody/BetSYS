--dropping tables
DROP TABLE Fixtures;
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
TeamID varchar2(3) NOT NULL,
TeamName varchar2(25) NOT NULL,
CONSTRAINT PK_TeamID PRIMARY KEY (TeamID));

--Creating table Fixtures
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

--Populating table Customers
INSERT INTO Customers (AccountID, Forename, Surname, DOB, PhoneNumber,
Email, Postcode, Status, Balance)
VALUES
('1', 'Cillian', 'Doody', '24-JUN-2002', '0874667264',
'cillian@gmail.com', 'p51k1c6', 'a', 0.00);
INSERT INTO Customers (AccountID, Forename, Surname, DOB, PhoneNumber,
Email, Postcode, Status, Balance)
VALUES
('2', 'Samir', 'Boussoufa', '23-SEP-1942', '0854206969',
'samir@gmail.com', 'v92y568', 'a', 0.00);
INSERT INTO Customers (AccountID, Forename, Surname, DOB, PhoneNumber,
Email, Postcode, Status, Balance)
VALUES
('3', 'Mark', 'Hennessey', '23-MAY-1942', '0837428254',
'mark@gmail.com', 'v31xj45', 'a', 0.00);
INSERT INTO Customers (AccountID, Forename, Surname, DOB, PhoneNumber,
Email, Postcode, Status, Balance)
VALUES
('4', 'Jack', 'Leonard-Sexton', '10-MAR-2002', '0852062320',
'jack@gmail.com', 'v94cyf8', 'a', 0.00);
INSERT INTO Customers (AccountID, Forename, Surname, DOB, PhoneNumber,
Email, Postcode, Status, Balance)
VALUES
('5', 'Lara', 'Krimmer', '07-MAY-2004', '0894771239',
'lara@outlook.com', 'v92hh27', 'a', 0.00);
INSERT INTO Customers (AccountID, Forename, Surname, DOB, PhoneNumber,
Email, Postcode, Status, Balance)
VALUES
('6', 'Bryan', 'Murphy', '20-JAN-2003', '0834649095',
'smurfyboy3000@gmail.com', 'v92na40', 'a', 0.00);

--Populating table Teams.
INSERT INTO Teams (TeamID, TeamName)
VALUES
('1', 'Arsenal');
INSERT INTO Teams (TeamID, TeamName)
VALUES
('2', 'Aston Villa');
INSERT INTO Teams (TeamID, TeamName)
VALUES
('3', 'Bournemouth');
INSERT INTO Teams (TeamID, TeamName)
VALUES
('4', 'Brentford');
INSERT INTO Teams (TeamID, TeamName)
VALUES
('5', 'Brighton and Hove Albion');
INSERT INTO Teams (TeamID, TeamName)
VALUES
('6', 'Burnley');
INSERT INTO Teams (TeamID, TeamName)
VALUES
('7', 'Chelsea');
INSERT INTO Teams (TeamID, TeamName)
VALUES
('8', 'Crystal Palace');
INSERT INTO Teams (TeamID, TeamName)
VALUES
('9', 'Everton');
INSERT INTO Teams (TeamID, TeamName)
VALUES
('10', 'Fulham');
INSERT INTO Teams (TeamID, TeamName)
VALUES
('11', 'Liverpool');
INSERT INTO Teams (TeamID, TeamName)
VALUES
('12', 'Luton Town');
INSERT INTO Teams (TeamID, TeamName)
VALUES
('13', 'Manchester City');
INSERT INTO Teams (TeamID, TeamName)
VALUES
('14', 'Manchester United');
INSERT INTO Teams (TeamID, TeamName)
VALUES
('15', 'Newcastle United');
INSERT INTO Teams (TeamID, TeamName)
VALUES
('16', 'Nottingham Forest');
INSERT INTO Teams (TeamID, TeamName)
VALUES
('17', 'Sheffield United');
INSERT INTO Teams (TeamID, TeamName)
VALUES
('18', 'Tottenham Hotspur');
INSERT INTO Teams (TeamID, TeamName)
VALUES
('19', 'West Ham United');
INSERT INTO Teams (TeamID, TeamName)
VALUES
('20', 'Wolverhampton Wanderers');

COMMIT;