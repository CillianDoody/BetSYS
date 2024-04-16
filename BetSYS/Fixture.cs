using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetSYS
{
    class Fixture
    {
        int fixtureID { get; set; }
        String Team1 { get; set; }
        String Team2 { get; set; }
        double OddsTeam1 { get; set; }
        double OddsTeam2 { get; set; }
        DateTime FDate { get; set; }
        String FTime {  get; set; }
        int score1 { get; set; }
        int score2 { get; set; }
        char betStatus { get; set; }

        public Fixture(int fixtureID, String Team1, String Team2, double OddsTeam1, double OddsTeam2, DateTime FDate, String FTime, int score1, int score2, char betStatus) {
            this.fixtureID = fixtureID;
            this.Team1 = Team1;
            this.Team2 = Team2;
            this.OddsTeam1 = OddsTeam1;
            this.OddsTeam2 = OddsTeam2;
            this.FDate = FDate;
            this.FTime = FTime;
            this.score1 = score1;
            this.score2 = score2;
            this.betStatus = betStatus;
        }
        public Fixture()
        {
            this.fixtureID = 0;
            this.Team1 = "";
            this.Team2 = "";
            this.OddsTeam1 = 0.00;
            this.OddsTeam2 = 0.00;
            this.FDate = DateTime.Today;
            this.FTime = "";
            this.score1 = 0;
            this.score2 = 0;
            this.betStatus = 'U';
        }

        public Fixture(int FixtureID, DateTime FDate, String FTime)
        {
            this.fixtureID = FixtureID;
            this.FDate = FDate;
            this.FTime = FTime;
        }

        public Fixture(int FixtureID)
        {
            this.fixtureID = FixtureID;
        }
        public static DataSet fillTeams()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * FROM Teams";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "teams");

            //Close db connection
            conn.Close();

            return ds;
        }
        public static DataSet fillTimes()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * FROM FixtureTimes";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "FixtureTimes");

            //Close db connection
            conn.Close();

            return ds;
        }

        public static DataSet fillFixtureIds()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * FROM Fixtures WHERE FStatus = 'U'";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "FixtureID");

            //Close db connection
            conn.Close();

            return ds;
        }

        public static DataSet fillFixtureTeam1(int fixtureID)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT Team1 FROM Fixtures WHERE FixtureID = " + fixtureID;

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "Team1");

            //Close db connection
            conn.Close();

            return ds;
        }

        public static DataSet fillFixtureTeam2(int fixtureID)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT Team2 FROM Fixtures WHERE FixtureID = " + fixtureID;

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "Team2");

            //Close db connection
            conn.Close();

            return ds;
        }

        public static double fillOddsTeam1(int fixtureID)
        {
            //open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //selecting the highest value fixture ID
            String sqlQuery = "SELECT OddsTeam1 FROM Fixtures WHERE fixtureID = " + fixtureID;
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader reader = cmd.ExecuteReader();

            double OddsTeam1;
            reader.Read();

            OddsTeam1 = Convert.ToDouble(reader.GetString(0));

            conn.Close();

            return OddsTeam1;
        }

        public static double fillOddsTeam2(int fixtureID)
        {
            //open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //selecting the highest value fixture ID
            String sqlQuery = "SELECT OddsTeam2 FROM Fixtures WHERE fixtureID = " + fixtureID;
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader reader = cmd.ExecuteReader();

            double OddsTeam1;
            reader.Read();

            OddsTeam1 = Convert.ToDouble(reader.GetString(0));

            conn.Close();

            return OddsTeam1;
        }


        public static int generateFixtureID()
        {
            //open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //selecting the highest value fixture ID
            String sqlQuery = "SELECT MAX(FixtureID) FROM Fixtures";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader reader = cmd.ExecuteReader();

            int FixtureID;
            reader.Read();

            if (reader.IsDBNull(0))
            {
                FixtureID = 1;
            }
            else
            {
                FixtureID = Convert.ToInt32(reader.GetString(0)) + 1;
            }
            conn.Close();

            return FixtureID;
        }

        public void addFixture()
        {
            //open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Inserting values into table
            String sqlQuery = "INSERT INTO Fixtures Values ('" +
                this.fixtureID + "', '" +
                this.Team1 + "', '" +
                this.Team2 + "', '" +
                this.OddsTeam1 + "', '" +
                this.OddsTeam2 + "', '" +
                this.FDate.ToString("dd-MMM-yyyy") + "', '" +
                this.FTime + "', '" + 
                this.score1 + "', '" +
                this.score2 + "', '" + 
                this.betStatus + "')";

            //execute sql query
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //close db connection
            conn.Close();
        }
        public static String displayFixture(int fixtureID) {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            String sqlQuery = "SELECT Team1, Team2 FROM Fixtures WHERE FixtureID = " + fixtureID + " AND FStatus = 'U'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            OracleDataReader reader = cmd.ExecuteReader();

            reader.Read();

            String Team1 = reader.GetString(0);
            String Team2 = reader.GetString(1);
            conn.Close();

            String label = Team1 + " vs " + Team2;

            return label;
        }
        public void updateFixture()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            String sqlQuery = "UPDATE Fixtures SET FDate =  '" + this.FDate.ToString("dd-MMM-yyyy") + 
                "', FTime = '" + this.FTime + "' WHERE FixtureID = " + this.fixtureID;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();


            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void AdjustOddsTeam1() {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            String sqlQuery = "SELECT OddsTeam1, OddsTeam2 FROM Fixtures WHERE FixtureID = " + this.fixtureID;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            OracleDataReader reader = cmd.ExecuteReader();

            double currentTeam1Odds;
            double currentTeam2Odds;
            reader.Read();

            currentTeam1Odds = Convert.ToDouble(reader.GetString(0));
            currentTeam2Odds = Convert.ToDouble(reader.GetString(1));

            double newTeam1Odds = currentTeam1Odds - 0.01;
            if(newTeam1Odds < 1.00)
            {
                newTeam1Odds = 1.00;
            }
            double newTeam2Odds = currentTeam2Odds + 0.01;
            conn.Close();

            String sqlQuery2 = "UPDATE Fixtures SET OddsTeam1 =  " + newTeam1Odds +
                ", OddsTeam2 = " + newTeam2Odds + " WHERE FixtureID = " + this.fixtureID;

            OracleCommand cmd2 = new OracleCommand(sqlQuery2, conn);
            conn.Open();


            cmd2.ExecuteNonQuery();
            conn.Close();
        }

        public void AdjustOddsTeam2()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            String sqlQuery = "SELECT OddsTeam1, OddsTeam2 FROM Fixtures WHERE FixtureID = " + this.fixtureID;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            OracleDataReader reader = cmd.ExecuteReader();

            double currentTeam1Odds;
            double currentTeam2Odds;
            reader.Read();

            currentTeam1Odds = Convert.ToDouble(reader.GetString(0));
            currentTeam2Odds = Convert.ToDouble(reader.GetString(1));

            double newTeam2Odds = currentTeam2Odds - 0.01;
            if (newTeam2Odds < 1.00)
            {
                newTeam2Odds = 1.00;
            }
            double newTeam1Odds = currentTeam1Odds + 0.01;
            conn.Close();

            String sqlQuery2 = "UPDATE Fixtures SET OddsTeam1 =  " + newTeam1Odds +
                ", OddsTeam2 = " + newTeam2Odds + " WHERE FixtureID = " + this.fixtureID;

            OracleCommand cmd2 = new OracleCommand(sqlQuery2, conn);
            conn.Open();


            cmd2.ExecuteNonQuery();
            conn.Close();
        }

        public static String displayTeam1(int fixtureID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            String sqlQuery = "SELECT Team1 FROM Fixtures WHERE FixtureID = " + fixtureID + " AND FStatus = 'U'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            OracleDataReader reader = cmd.ExecuteReader();

            reader.Read();

            String Team1 = reader.GetString(0);
            conn.Close();

            String label = Team1;

            return label;
        }

        public static String displayTeam2(int fixtureID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            String sqlQuery = "SELECT Team2 FROM Fixtures WHERE FixtureID = " + fixtureID + " AND FStatus = 'U'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            OracleDataReader reader = cmd.ExecuteReader();

            reader.Read();

            String Team2 = reader.GetString(0);
            conn.Close();

            String label = Team2;

            return label;
        }

        public void updateFixtureStatus()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            String sqlQuery = "UPDATE Fixtures SET FStatus = 'P' WHERE FixtureID = " + this.fixtureID;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();


            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void displayFixtures(DataGridView dataGrid)
        {
            OracleConnection conn = new OracleConnection( DBConnect.oraDB);

            String sqlQuery = "SELECT * FROM Fixtures WHERE FStatus = 'U'";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();

            OracleDataReader reader = cmd.ExecuteReader();

            if(dataGrid.Columns.Count == 0)
            {
                dataGrid.Columns.Add("Team1", "Team1");
                dataGrid.Columns.Add("Team2", "Team2");
                dataGrid.Columns.Add("FDate", "FDate");
                dataGrid.Columns.Add("FTime", "FTime");
            }
            dataGrid.Rows.Clear();

            while(reader.Read())
            {
                dataGrid.Rows.Add(reader["Team1"], reader["Team2"], 
                    reader["FDate"].ToString().Substring(0,10), reader["FTime"].ToString());
            }
        }
    }

}
