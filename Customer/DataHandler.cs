using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace Customer
{
    class DataHandler
    {

        
        /*static int Main(string[] args)
        {
            DataHandler dt = new DataHandler("localhost", "BoomBroom", "root", "root");
            //dt.addCustomer("Atlas", "Brin", "M", "Widowed", "1960-02-15", "Davao", "Professor", "AdDU", "23214221", "2324242", "1652");
            bool u =  dt.updateCustomer("Atlas", "Brin", "M", "Widowed", "1960-02-15", "Davao", "Professor", "AdDU", "23214221", "2324242", "1652", "1652");
            Console.WriteLine(u);
            return 0;
        }*/

        public MySqlConnection conn;

        public DataHandler(string server, string database, string user, string password)
        {
            conn = new MySqlConnection("Server=" + server + ";Database=" + database + ";Uid=" + user + ";Pwd=" + password + ";");
        }

        public bool addCustomer(string fn, string ln, string gender, string civilStatus, string bDate, string homeAdd, string jobDesc, string workAdd, string telNum, string pNum, string PIN) 
        {
            if (!pinExists(PIN))
            {
                String q = "INSERT INTO customer(customerFName, customerLName, gender, civilStatus, birthDate, homeAddress, jobDescription, workingAddress, telNumber, phoneNumber, pinNumber) VALUES " +
                    "('" + fn + "', '" + ln + "', '" + gender + "', '" + civilStatus + "', '" + bDate + "', '" + homeAdd + "', '" + jobDesc + "', '" + workAdd + "', '" + telNum + "', '" + pNum + "', '" + PIN + "');";
                conn.Open();
                MySqlCommand com = new MySqlCommand(q, conn);
                int rowsAffected = com.ExecuteNonQuery();
                conn.Close();
                Console.Write(q);
                if (rowsAffected > 0) return true;
            }

            return false;
            
        }

        public bool pinExists(String PIN)
        {
            conn.Open();
            MySqlCommand com = new MySqlCommand("SELECT PINNumber FROM customer WHERE PINNumber = '" + PIN + "';", conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            conn.Close();
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }


        public bool updateCustomer(string fn, string ln, string gender, string civilStatus, string bDate, string homeAdd, string jobDesc, string workAdd, string telNum, string pNum, string PIN, string currentPIN)
        {
            if (!pinExists(PIN))
            {
                string q = "UPDATE customer SET customerFName = '" + fn + "', customerLName = '" + ln + "', gender = '" + gender + "', civilStatus = '" + civilStatus + "', birthDate = '" + bDate + "', " +
                    "homeAddress = '" + homeAdd + "', jobDescription = '" + jobDesc + "', workingAddress = '" + workAdd + "', telNumber = '" + telNum + "', phoneNumber = '" + pNum + "', pinNumber = '" + PIN + "' " +
                    "WHERE pinNumber = '" + currentPIN + "';";

                conn.Open();
                MySqlCommand com = new MySqlCommand(q, conn);
                int rowsAffected = 0;

                try
                {
                    rowsAffected = com.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return false; //is this line needded?
                }
                finally
                {
                    conn.Close();
                }

                if (rowsAffected > 0)
                    return true;

            }

            return false; //PIN already in use
        }

        public int getCustomerID(string PIN)
        {
            if (!pinExists(PIN))
                return -1;
            return int.Parse(getCustomerProfile(PIN)[0]);
        }

        public string[] getCustomerProfile(string PIN) //highly discouraged from using index [0] as it contains ID as string
        { 
            if (!pinExists(PIN)) return null;

            string q = "SELECT * from customer WHERE pinNumber = '" + PIN + "';";
            conn.Open();
            MySqlCommand com = new MySqlCommand(q, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            conn.Close();

            string[] customerProfile = new string[dt.Columns.Count];
            for(int i = 0; i < customerProfile.Length; i++)
            {
                customerProfile[i] = dt.Rows[0][i].ToString();
            }

            foreach(string s in customerProfile)
                Console.Write(s +" ");

            return customerProfile;
        }

        public bool addCard(string cardNumber, string bank)
        {
            if (!cardExists(cardNumber)){
                string q = "INSERT INTO card(cardNumber, bank) VALUES ('" + cardNumber + "','" + bank + "');";
                conn.Open();
                MySqlCommand com = new MySqlCommand(q, conn);
                int rowsAffected = com.ExecuteNonQuery();
                conn.Close();
                Console.Write(q);
                if (rowsAffected > 0) return true;
            }
            return false;
        }

        public bool cardExists(string cardNumber)
        {
            conn.Open();
            MySqlCommand com = new MySqlCommand("SELECT cardID from card WHERE cardNumber = '" + cardNumber + "';", conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            conn.Close();
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }

        public int getCardID(string cardNumber)
        {
            if (!cardExists(cardNumber))
                return -1; //bad coding style actually. Gah. it's the easy way tho.

            return int.Parse(getCardDetails(cardNumber)[0]);
        }

        public string[] getCardDetails(string cardNumber) //highly discouraged from using index [0] as it contains ID as string
        {
            if (cardExists(cardNumber)) return null;

            string q = "SELECT * from card WHERE cardNumber = '" + cardNumber + "';";
            conn.Open();
            MySqlCommand com = new MySqlCommand(q, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            conn.Close();

            string[] cardDetails = new string[dt.Columns.Count];
            for (int i = 0; i < cardDetails.Length; i++)
            {
                cardDetails[i] = dt.Rows[0][i].ToString();
            }

            foreach (string s in cardDetails)
                Console.Write(s + " ");

            return cardDetails;
        }

        public bool addAccountCard(int accID, int cardID)
        {
            String q = "INSERT INTO account_card(accID, cID) VALUES (" + accID + "," + cardID + ");";
            conn.Open();
            MySqlCommand com = new MySqlCommand(q, conn);
            int rowsAffected = com.ExecuteNonQuery();
            conn.Close();
            Console.Write(q);
            if (rowsAffected > 0) return true;
            return false;
        }

        


       





    }
}
