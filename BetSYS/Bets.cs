using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetSYS
{
    class Bets
    {
        int BetID { get; set; }
        double BetAmount { get; set; }
        double BetOdds { get; set; }
        char BetStatus { get; set; }
        DateTime BetDate { get; set; }
        String Team { get; set; }
        int FixtureID { get; set; }
        int AccountID { get; set; }

        public Bets(int BetID, double BetAmount, double BetOdds, char BetStatus, DateTime BetDate, String Team, int FixtureID, int AccountID)
        {
            this.BetID = BetID;
            this.BetAmount = BetAmount;
            this.BetOdds = BetOdds;
            this.BetStatus = BetStatus;
            this.BetDate = BetDate;
            this.Team = Team;
            this.FixtureID = FixtureID;
            this.AccountID = AccountID;
        }

        public Bets(int AccountID)
        {
            this.AccountID = AccountID;
        }
        
        public Bets(String Team, int FixtureID)
        {
            this.Team = Team;
            this.FixtureID = FixtureID;
        }


        public static int generateBetID()
        {
            //open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //selecting the highest value fixture ID
            String sqlQuery = "SELECT MAX(BetID) FROM Bets";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader reader = cmd.ExecuteReader();

            int BetID;
            reader.Read();

            if (reader.IsDBNull(0))
            {
                BetID = 1;
            }
            else
            {
                BetID = Convert.ToInt32(reader.GetString(0)) + 1;
            }
            conn.Close();

            return BetID;
        }

        public void placeBet()
        {
            //open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Inserting values into table
            String sqlQuery = "INSERT INTO Bets Values ('" +
                this.BetID + "', '" +
                this.BetAmount + "', '" +
                this.BetOdds + "', '" +
                this.BetStatus + "', '" +
                this.BetDate.ToString("dd-MMM-yyyy") + "', '" +
                this.Team + "', '" +
                this.FixtureID + "', '" +
                this.AccountID + "')";

            //execute sql query
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //close db connection
            conn.Close();
        }

        public static DataSet fillBetIDs(int accountID) {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * FROM Bets WHERE accountID = " + accountID + " AND BetStatus = 'p'";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "BetID");

            //Close db connection
            conn.Close();

            return ds;
        }

        public static int getFixtureID(int betID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            String sqlQuery = "SELECT fixtureID FROM Bets WHERE BetID = " + betID;

            int fixtureID;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            OracleDataReader reader = cmd.ExecuteReader();

            reader.Read();

            fixtureID = Convert.ToInt32(reader.GetString(0));
            conn.Close();

            return fixtureID;
        }

        public static String displayTeamToWin(int betID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            String sqlQuery = "SELECT Team, BetOdds FROM Bets WHERE BetID = " + betID;

            String Team;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            OracleDataReader reader = cmd.ExecuteReader();

            reader.Read();

            Team = reader.GetString(0) + " to win @ " + reader.GetString(1);
            conn.Close();

            return Team;
        }
        public void refundBet(int betID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            String sqlQuery = "SELECT BetAmount, AccountID FROM Bets WHERE BetID = " + betID;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            OracleDataReader reader = cmd.ExecuteReader();

            double currentAmount;
            int accountID;
            reader.Read();

            currentAmount = Convert.ToDouble(reader.GetString(0));
            accountID = Convert.ToInt32(reader.GetString(1));

            conn.Close();
            String sqlQuery2 = "SELECT Balance FROM Customers WHERE accountID = " + accountID;

            OracleCommand cmd2 = new OracleCommand(sqlQuery2, conn);
            conn.Open();
            OracleDataReader reader2 = cmd2.ExecuteReader();

            double currentBalance;
            reader2.Read();

            currentBalance = Convert.ToDouble(reader2.GetString(0));
            double newBalance = currentBalance + currentAmount;

            conn.Close();

            String sqlQuery3 = "UPDATE Customers SET balance = " + newBalance + " WHERE AccountID = " + accountID;

            OracleCommand cmd3 = new OracleCommand(sqlQuery3, conn);
            conn.Open();


            cmd3.ExecuteNonQuery();
            conn.Close();
        }
        public void cancelBet(int betID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            String sqlQuery = "UPDATE Bets SET BetStatus = 'c' WHERE betID = '" + betID + "'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();


            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void payOutBet()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            String sqlQuery = "SELECT accountID FROM Bets WHERE Team = '" + this.Team + "' AND fixtureID = " + this.FixtureID;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            OracleDataReader reader = cmd.ExecuteReader();

            int accountID;
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    accountID = Convert.ToInt32(reader.GetString(i));

                    String sqlQuery2 = "Select Balance FROM Customers WHERE accountID = " + accountID;

                    OracleCommand cmd2 = new OracleCommand(sqlQuery2, conn);
                    OracleDataReader reader2 = cmd2.ExecuteReader();
                    reader2.Read();

                    int balance = Convert.ToInt32(reader2.GetString(i));

                    String sqlQuery3 = "Select BetAmount, BetOdds FROM Bets WHERE Team = '" + this.Team + "' AND fixtureID = " + this.FixtureID;

                    OracleCommand cmd3 = new OracleCommand(sqlQuery3, conn);
                    OracleDataReader reader3 = cmd3.ExecuteReader();
                    reader3.Read();

                    int amount = Convert.ToInt32(reader3.GetString(i));
                    double betOdds = Convert.ToDouble(reader3.GetString(i + 1));

                    double newBalance = balance + (amount * betOdds);

                    String sqlQuery4 = "UPDATE Customers SET balance = '" + newBalance + "' WHERE AccountID = " + accountID;

                    OracleCommand cmd4 = new OracleCommand(sqlQuery4, conn);

                    cmd4.ExecuteNonQuery();

                    String sqlQuery5 = "UPDATE Bets SET BetStatus = 'W' WHERE Team = '" + this.Team + "' AND fixtureID = " + this.FixtureID +
                        " AND AccountID = " + accountID;

                    OracleCommand cmd5 = new OracleCommand(sqlQuery5, conn);

                    cmd5.ExecuteNonQuery();
                }
            }
            conn.Close();
        }
        public void setBetStatus()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            String sqlQuery = "UPDATE Bets SET BetStatus = 'L' WHERE fixtureID = " + this.FixtureID + " AND BetStatus = 'p'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}
