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

--Populating table FixtureTimes
INSERT INTO FixtureTimes (FixtureTime)
VALUES
('12:30');
INSERT INTO FixtureTimes (FixtureTime)
VALUES
('14:00');
INSERT INTO FixtureTimes (FixtureTime)
VALUES
('15:00');
INSERT INTO FixtureTimes (FixtureTime)
VALUES
('15:30');
INSERT INTO FixtureTimes (FixtureTime)
VALUES
('16:30');
INSERT INTO FixtureTimes (FixtureTime)
VALUES
('17:30');
INSERT INTO FixtureTimes (FixtureTime)
VALUES
('20:00');

--Populating table Fixtures.
INSERT INTO Fixtures (FixtureID, Team1, Team2, OddsTeam1, OddsTeam2,
Fdate, FTime, Score1, Score2)
VALUES
('1', 'Newcastle United', 'West Ham United', 1.40, 3.33,
'30-MAR-2024', '12:30', '0', '0');
INSERT INTO Fixtures (FixtureID, Team1, Team2, OddsTeam1, OddsTeam2,
Fdate, FTime, Score1, Score2)
VALUES
('2', 'Bournemouth', 'Everton', 1.40, 3.33,
'30-MAR-2024', '15:00', '0', '0');
INSERT INTO Fixtures (FixtureID, Team1, Team2, OddsTeam1, OddsTeam2,
Fdate, FTime, Score1, Score2)
VALUES
('3', 'Chelsea', 'Burnley', 1.40, 3.33,
'30-MAR-2024', '15:00', '0', '0');
INSERT INTO Fixtures (FixtureID, Team1, Team2, OddsTeam1, OddsTeam2,
Fdate, FTime, Score1, Score2)
VALUES
('4', 'Nottingham Forest', 'Crystal Palace', 1.40, 3.33,
'30-MAR-2024', '15:00', '0', '0');
INSERT INTO Fixtures (FixtureID, Team1, Team2, OddsTeam1, OddsTeam2,
Fdate, FTime, Score1, Score2)
VALUES
('5', 'Sheffield United', 'Fulham', 1.40, 3.33,
'30-MAR-2024', '15:00', '0', '0');
INSERT INTO Fixtures (FixtureID, Team1, Team2, OddsTeam1, OddsTeam2,
Fdate, FTime, Score1, Score2)
VALUES
('6', 'Tottenham Hotspur', 'Luton Town', 1.40, 3.33,
'30-MAR-2024', '15:00', '0', '0');
INSERT INTO Fixtures (FixtureID, Team1, Team2, OddsTeam1, OddsTeam2,
Fdate, FTime, Score1, Score2)
VALUES
('7', 'Aston Villa', 'Wolverhampton Wanderers', 1.40, 3.33,
'30-MAR-2024', '17:30', '0', '0');
INSERT INTO Fixtures (FixtureID, Team1, Team2, OddsTeam1, OddsTeam2,
Fdate, FTime, Score1, Score2)
VALUES
('8', 'Brentford', 'Manchester United', 1.40, 3.33,
'30-MAR-2024', '20:00', '0', '0');
INSERT INTO Fixtures (FixtureID, Team1, Team2, OddsTeam1, OddsTeam2,
Fdate, FTime, Score1, Score2)
VALUES
('9', 'Liverpool', 'Brighton and Hove Albion', 1.40, 3.33,
'31-MAR-2024', '14:00', '0', '0');
INSERT INTO Fixtures (FixtureID, Team1, Team2, OddsTeam1, OddsTeam2,
Fdate, FTime, Score1, Score2)
VALUES
('10', 'Manchester City', 'Arsenal', 1.40, 3.33,
'31-MAR-2024', '16:30', '0', '0');

COMMIT;