using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Fixture(int fixtureID, String Team1, String Team2, double OddsTeam1, double OddsTeam2, DateTime FDate, String FTime, int score1, int score2) {
            this.fixtureID = fixtureID;
            this.Team1 = Team1;
            this.Team2 = Team2;
            this.OddsTeam1 = OddsTeam1;
            this.OddsTeam2 = OddsTeam2;
            this.FDate = FDate;
            this.FTime = FTime;
            this.score1 = score1;
            this.score2 = score2;
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
        }

        public Fixture(int fixtureID) { 
            this.fixtureID = fixtureID;
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
            String sqlQuery = "SELECT * FROM Fixtures";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "FixtureID");

            //Close db connection
            conn.Close();

            return ds;
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
                this.score2 + "')";

            //execute sql query
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //close db connection
            conn.Close();
        }
        public string displayFixture(int fixtureID) {
            this.fixtureID = fixtureID;
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            String sqlQuery = "SELECT Team1 FROM Fixtures WHERE FixutreID = " + this.fixtureID;
            String sqlQuery2 = "SELECT Team2 FROM Fixtures WHERE FixutreID = " + this.fixtureID;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            OracleDataReader reader = cmd.ExecuteReader();

            reader.Read();

            String Team1 = reader.GetString(0);
            String Team2 = reader.GetString(1);
            conn.Close();

            String label = Team1 + "vs " + Team2;

            return label;
        }
    }

}
