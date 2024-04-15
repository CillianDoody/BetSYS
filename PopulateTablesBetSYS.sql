--Populating table Customers
INSERT INTO Customers (AccountID, Forename, Surname, DOB, PhoneNumber,
Email, Postcode, Status, Balance)
VALUES
('1', 'Cillian', 'Doody', '24-JUN-2002', '0874667264',
'cillian@gmail.com', 'p51k1c6', 'a', 499.00);
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
INSERT INTO Teams (TeamName)
VALUES
('Arsenal');
INSERT INTO Teams (TeamName)
VALUES
('Aston Villa');
INSERT INTO Teams (TeamName)
VALUES
('Bournemouth');
INSERT INTO Teams (TeamName)
VALUES
('Brentford');
INSERT INTO Teams (TeamName)
VALUES
('Brighton and Hove Albion');
INSERT INTO Teams (TeamName)
VALUES
('Burnley');
INSERT INTO Teams (TeamName)
VALUES
('Chelsea');
INSERT INTO Teams (TeamName)
VALUES
('Crystal Palace');
INSERT INTO Teams (TeamName)
VALUES
('Everton');
INSERT INTO Teams (TeamName)
VALUES
('Fulham');
INSERT INTO Teams (TeamName)
VALUES
('Liverpool');
INSERT INTO Teams (TeamName)
VALUES
('Luton Town');
INSERT INTO Teams (TeamName)
VALUES
('Manchester City');
INSERT INTO Teams (TeamName)
VALUES
('Manchester United');
INSERT INTO Teams (TeamName)
VALUES
('Newcastle United');
INSERT INTO Teams (TeamName)
VALUES
('Nottingham Forest');
INSERT INTO Teams (TeamName)
VALUES
('Sheffield United');
INSERT INTO Teams (TeamName)
VALUES
('Tottenham Hotspur');
INSERT INTO Teams (TeamName)
VALUES
('West Ham United');
INSERT INTO Teams (TeamName)
VALUES
('Wolverhampton Wanderers');

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
Fdate, FTime, Score1, Score2, FStatus)
VALUES
('1', 'Newcastle United', 'West Ham United', 1.40, 3.33,
'30-MAR-2024', '12:30', '0', '1', 'P');
INSERT INTO Fixtures (FixtureID, Team1, Team2, OddsTeam1, OddsTeam2,
Fdate, FTime, Score1, Score2, FStatus)
VALUES
('2', 'Bournemouth', 'Everton', 1.69, 2.50,
'30-MAR-2024', '15:00', '0', '0', 'U');
INSERT INTO Fixtures (FixtureID, Team1, Team2, OddsTeam1, OddsTeam2,
Fdate, FTime, Score1, Score2, FStatus)
VALUES
('3', 'Chelsea', 'Burnley', 1.50, 3.00,
'30-MAR-2024', '15:00', '0', '0', 'U');
INSERT INTO Fixtures (FixtureID, Team1, Team2, OddsTeam1, OddsTeam2,
Fdate, FTime, Score1, Score2, FStatus)
VALUES
('4', 'Nottingham Forest', 'Crystal Palace', 1.80, 2.50,
'30-MAR-2024', '15:00', '0', '0', 'U');

--Populating bets table
INSERT INTO Bets (BetID, BetAmount, BetOdds, BetStatus, BetDate, Team, FixtureID,
AccountID)
VALUES
('1', 5, 1.50, 'w', '30-JAN-2022', 'Chelsea', '3', '4');
INSERT INTO Bets (BetID, BetAmount, BetOdds, BetStatus, BetDate, Team, FixtureID,
AccountID)
VALUES
('2', 20, 1.69, 'l', '26-AUG-2022', 'Bournemouth', '2', '5');
INSERT INTO Bets (BetID, BetAmount, BetOdds, BetStatus, BetDate, Team, FixtureID,
AccountID)
VALUES
('3', 10, 2.50, 'p', '30-JAN-2023', 'Crystal Palace', '4', '1');
INSERT INTO Bets (BetID, BetAmount, BetOdds, BetStatus, BetDate, Team, FixtureID,
AccountID)
VALUES
('4', 500, 3.33, 'c', '14-APR-2024', 'West Ham United', '1', '3');
INSERT INTO Bets (BetID, BetAmount, BetOdds, BetStatus, BetDate, Team, FixtureID,
AccountID)
VALUES
('5', 10, 2.50, 'p', '30-JAN-2023', 'Crystal Palace', '4', '2');
INSERT INTO Bets (BetID, BetAmount, BetOdds, BetStatus, BetDate, Team, FixtureID,
AccountID)
VALUES
('6', 10, 2.50, 'p', '30-JAN-2023', 'Crystal Palace', '4', '3');
INSERT INTO Bets (BetID, BetAmount, BetOdds, BetStatus, BetDate, Team, FixtureID,
AccountID)
VALUES
('7', 10, 2.50, 'p', '30-JAN-2023', 'Nottingham Forest', '4', '4');

COMMIT;