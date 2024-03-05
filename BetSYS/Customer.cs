using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace BetSYS
{
    class Customer
    {
        int AccountID { get; set; }
        String Forename { get; set; }
        String Surname { get; set; }
        DateTime DOB { get; set; }
        String PhoneNumber { get; set; }
        String Email { get; set; }
        String Postcode { get; set; }
        Char Status {  get; set; }
        Double Balance { get; set; }

        public Customer(int AccountID, String Forename, String Surname, DateTime DOB, String PhoneNumber, String Email, String Postcode, Char Status, Double Balance) {
            this.AccountID = AccountID;
            this.Forename = Forename;
            this.Surname = Surname;
            this.DOB = DOB;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
            this.Postcode = Postcode;
            this.Status = Status;
            this.Balance = Balance;
        }

        public Customer()
        {
            this.AccountID = 0;
            this.Forename = "";
            this.Surname = "";
            this.DOB = DateTime.Today;
            this.PhoneNumber = "";
            this.Email = "";
            this.Postcode = "";
            this.Status = 'a';
            this.Balance = 0;
        }

        public Customer(String Email) {
            this.Email = Email;
        }
        public static int generateAccountID() {
            //open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            
            //selecting the highest value account ID
            String sqlQuery = "SELECT MAX(AccountID) FROM Customers";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader reader = cmd.ExecuteReader();

            int AccountID;
            reader.Read();

            if (reader.IsDBNull(0)){
                AccountID = 1;
            }
            else { 
                AccountID = Convert.ToInt32(reader.GetString(0)) + 1; 
            }
            conn.Close();

            return AccountID;
        }
        public void addCustomer() {
            //open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Inserting values into table
            String sqlQuery = "INSERT INTO Customers Values ('" +
                this.AccountID + "', '" +
                this.Forename + "', '" +
                this.Surname + "', '" +
                this.DOB.ToString("dd-MMM-yyyy") + "', '" +
                this.PhoneNumber + "', '" +
                this.Email + "', '" +
                this.Postcode + "', '" + 
                this.Status + "', '" +
                this.Balance + "')";

            //execute sql query
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //close db connection
            conn.Close();
        }
        public Boolean SearchAccount() {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            String sqlQuery = "SELECT * FROM Customers WHERE Email = '" + this.Email + "'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader reader = cmd.ExecuteReader();
            reader.Read();
            cmd.ExecuteNonQuery();

            if (!reader.HasRows) { 
                conn.Close();
                return false;
            }
            else {
                conn.Close();
                return true;
            }

            
        }
        public void CloseAccount () {
            Console.WriteLine(this.Email);
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            String sqlQuery = "UPDATE Customers SET Status = 'c' WHERE Email = '" + this.Email + "'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void TopUpBalance(double Balance) {
            this.Balance = Balance;
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            String sqlQuery = "SELECT Balance FROM Customers WHERE Email = '" + this.Email + "'";
            
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            double currentBalance = (double)cmd.ExecuteNonQuery();
            double newBalance = currentBalance + this.Balance;
            conn.Close();

            String sqlQuery2 = "UPDATE Customers SET balance = '" + newBalance + "' WHERE Email = '" + this.Email + "'";

            OracleCommand cmd2 = new OracleCommand(sqlQuery2, conn);
            conn.Open();


            cmd2.ExecuteNonQuery();
            conn.Close();
        }
    }
}


