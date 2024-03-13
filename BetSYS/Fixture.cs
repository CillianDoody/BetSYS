using System;
using System.Collections.Generic;
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
        }
    }

}
