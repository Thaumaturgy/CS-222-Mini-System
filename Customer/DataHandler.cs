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


        public bool updateCustomer(int customerID, string fn, string ln, string gender, string civilStatus, string bDate, string homeAdd, string jobDesc, string workAdd, string telNum, string pNum, string PIN)
        {
                string q = "UPDATE customer SET customerFName = '" + fn + "', customerLName = '" + ln + "', gender = '" + gender + "', civilStatus = '" + civilStatus + "', birthDate = '" + bDate + "', " +
                    "homeAddress = '" + homeAdd + "', jobDescription = '" + jobDesc + "', workingAddress = '" + workAdd + "', telNumber = '" + telNum + "', phoneNumber = '" + pNum + "', pinNumber = '" + PIN + "' "+
                    "WHERE customerID = "+customerID+";";

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

            return false; 
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

        public bool addPayment(int accountID, double paymentAmount, string paymentDate)
        {
            int rowsAffected = 0;
            if (accountExists(accountID)) {
                string q = "INSERT INTO payment(accountID, paymentAmount, paymenDate VALUES (" + accountID + "," + paymentAmount + ",'" + paymentDate + "');";
                conn.Open();
                MySqlCommand com = new MySqlCommand(q, conn);
                rowsAffected = com.ExecuteNonQuery();

                double moneyLentWithInterest = double.Parse(getAccountDetails(accountID)[2]);
                
                //if(getTotalPaymentOfAccount(accountID) == ss
                conn.Close();
            }

            return rowsAffected > 0;
            

        }

        public bool addCard(string cardNumber, string bank)
        {
            int rowsAffected = 0;
            if (!cardExists(cardNumber, bank)){
                string q = "INSERT INTO card(cardNumber, bank) VALUES ('" + cardNumber + "','" + bank + "');";
                conn.Open();
                MySqlCommand com = new MySqlCommand(q, conn);
                rowsAffected = com.ExecuteNonQuery();
                conn.Close();
            }

            return rowsAffected > 0;
        }

        public bool cardExists(string cardNumber, string bank)
        {
            conn.Open();
            MySqlCommand com = new MySqlCommand("SELECT cardID from card WHERE cardNumber = '" + cardNumber + "' AND bank = '"+ bank +"';", conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            conn.Close();
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }

        public int getCardID(string cardNumber, string bank)
        {
            if (!cardExists(cardNumber, bank))
                return -1; //bad coding style actually. Gah. it's the easy way tho.

            return int.Parse(getCardDetails(cardNumber, bank)[0]);
        }

        public string[] getCardDetails(string cardNumber, string bank) //highly discouraged from using index [0] as it contains ID as string
        {
            if (!cardExists(cardNumber, bank)) return null;

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

        

        public bool hasPaidMoreThanHalf(int customerID) //Paid more than half of Loan in each account?
        {
            
            string[,] allAccounts = getAllAccountsByCustomer(customerID);

            bool paidMoreThanHalf = true;
            for(int i = 0; i < allAccounts.GetLength(0); i++)
            {
                int accountID = int.Parse(allAccounts[i, 0]);
                
                if (allAccounts[i, 4] != "Paid") //Continues if account is not yet fully paid
                {
                    //Checks if Account A has a total payment less than half of the moneyLent in that account
                    if (getTotalPaymentOfAccount(accountID) < double.Parse(allAccounts[i, 2]) / 2)
                    {
                        paidMoreThanHalf = false; //Cannot add if total payment is less than half of moneyLent
                        break;
                    }
                }
            }
            return paidMoreThanHalf;
        }

        public double getTotalMoneyLentOfCustomer(int customerID, int status)
        {
            //statuses:
            // -1 = Paid
            // 0 = Paid and Active
            // 1 = Active

            string s;
            if (status == -1)
                s = " AND account.status = 'Paid';";
            else if (status == 1)
                s = " AND account.status = 'Active';";
            else
                s = ";";

            string q = "SELECT SUM(moneyLent) FROM account WHERE customerID = " + customerID + s;

            conn.Open();
            MySqlCommand com = new MySqlCommand(q, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            conn.Close();

            double total = 0;
            if (dt.Rows[0][0].ToString().Length == 0)
                total = 0;
            else
                total = double.Parse(dt.Rows[0][0].ToString());

            return total;
        }


        public double getTotalBalanceOfCustomer(int customerID)
        {
            //The Status of the Accounts don't matter as long as status is 0 OR 1.
            double totalBalance = getTotalMoneyLentOfCustomer(customerID, 0) + getTotalInterestOfCustomer(customerID, 0) - getTotalPaymentsOfCustomer(customerID, 0);
            return totalBalance;
        }



        public double getTotalInterestOfCustomer(int customerID, int status)
        {
            string s;
            if (status == -1)
                s = " AND account.status = 'Paid';";
            else if (status == 1)
                s = " AND account.status = 'Active';";
            else
                s = ";";

            string q = "SELECT SUM(interest*moneyLent) FROM account JOIN customer ON account.customerID = customer.customerID"+
                " WHERE customer.customerID = "+ customerID + s;

            conn.Open();
            MySqlCommand com = new MySqlCommand(q, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            conn.Close();

            double total = 0;
            if (dt.Rows[0][0].ToString().Length == 0)
                total = 0;
            else
                total = double.Parse(dt.Rows[0][0].ToString());

            return total;
        }

        public double getTotalPaymentsOfCustomer(int customerID, int status)
        {
            string s;
            if (status == -1)
                s = " AND account.status = 'Paid';";
            else if (status == 1)
                s = " AND account.status = 'Active';";
            else
                s = ";";

            //ASSUMES AN ACCOUNT EXISTS FOR CUSTOMER! -CAUGHT

            string q = "SELECT SUM(paymentAmount) FROM account JOIN customer ON account.customerID = customer.customerID "+
                "JOIN payment ON payment.accountID = account.accountID WHERE customer.customerID = "+ customerID + s;

            conn.Open();
            MySqlCommand com = new MySqlCommand(q, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            conn.Close();

            double total = 0;
            if (dt.Rows[0][0].ToString().Length == 0)
                total = 0;
            else
                total = double.Parse(dt.Rows[0][0].ToString());

            return total;
        }


        //REDUNDANT PIECE OF CODE

        /*public double getTotalPaymentsOfAccount(int accountID)
        {
            string q = "SELECT SUM(paymentAmount)FROM account JOIN payment"+
                " ON account.accountID = payment.accountID WHERE account.accountID = " + accountID + ";";

            conn.Open();
            MySqlCommand com = new MySqlCommand(q, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            conn.Close();

            double total = 0;
            if (dt.Rows[0][0].ToString().Length == 0)
                total = 0;
            else
                total = double.Parse(dt.Rows[0][0].ToString());

            return total;
        }*/

        public bool accountExists(int accountID)
        {
            string q = "SELECT accountID from account WHERE accountID = " + accountID + ";";
            conn.Open();
            MySqlCommand com = new MySqlCommand(q, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            conn.Close();

            return dt.Rows.Count > 0;
        }

        public bool addAccount(int customerID, double moneyLent, string entryDate, string status, double interest)
        {
            //yyyy-mm-dd
            int rowsAffected = 0;
            if (hasPaidMoreThanHalf(customerID))
            {
                String q = "INSERT INTO account(customerID, moneyLent, entryDate, status, interest) VALUES " +
                        "(" + customerID + ", " + moneyLent + ", '" + entryDate + "', '" + status + "', " + interest + ");";

                conn.Open();
                MySqlCommand com = new MySqlCommand(q, conn);
                rowsAffected = com.ExecuteNonQuery();
                conn.Close();
                Console.Write(q);
            }

            return rowsAffected > 0;
        }

        public bool updateAccountStatus(int accountID, string status)
        {
            string q = "UPDATE account SET status = '" + status + "' WHERE accountID = " + accountID + ";";

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

            return rowsAffected > 0;
        }

        public string[] getAccountDetails(int accountID)
        {
            string q = "SELECT * from account WHERE accountID = '" + accountID + "';";
            conn.Open();
            MySqlCommand com = new MySqlCommand(q, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            conn.Close();

            string[] accountDetails = new string[dt.Columns.Count];
            for (int i = 0; i < accountDetails.Length; i++)
            {
                accountDetails[i] = dt.Rows[0][i].ToString();
            }

            /*foreach (string s in accountDetails)
                Console.Write(s + " ");*/

            return accountDetails;
        }
        public string[,] getAllAccountsByCustomer(int customerID) //WEIRD 2D Array. Watch out!
        {
            DataTable dt = getAllAccountsByCustomerDataTable(customerID);

            Console.WriteLine("Customer " + customerID + " has n accounts: " + dt.Rows.Count);

            string[,] allAccounts = new string[dt.Rows.Count, dt.Columns.Count] ;
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                    allAccounts[i,j] = dt.Rows[i][j].ToString();
            }

            return allAccounts;
        }
        
        public DataTable getAllAccountsByCustomerDataTable(int customerID)
        {
            string q = "SELECT * from account WHERE customerID = " + customerID + ";";
            conn.Open();
            MySqlCommand com = new MySqlCommand(q, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            conn.Close();

            return dt;
        }

        public DataTable getAllAccountsByCustomerDataTable(string customerPIN)
        {
            string q = "SELECT accountID, account.customerID, moneyLent, entryDate, status, interest FROM "
                + "account JOIN customer ON account.customerID = customer.customerID WHERE pinNumber = '" + customerPIN + "';";

           // string q = "SELECT * from account WHERE pinNumber = '" + customerPIN + "';";
            conn.Open();
            MySqlCommand com = new MySqlCommand(q, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            conn.Close();

            return dt;
        }


        public DataTable getAllCustomersDataTable()
        { //REMOVE HH:MM:SS from Date Object When selecting!!!
            string q = "SELECT * from customer;";
            conn.Open();
            MySqlCommand com = new MySqlCommand(q, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            conn.Close();

            return dt;
        }

        public int numberOfActiveAccounts(int customerID)
        {
            string q = "SELECT * from account WHERE customerID = " + customerID + " AND status = 'Active';";
            conn.Open();
            MySqlCommand com = new MySqlCommand(q, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            conn.Close();

            return dt.Rows.Count;

        }

        public double getInterestAmount(int accountID)
        {
            string[] accDetails = getAccountDetails(accountID);
            /*DateTime entryDate = getEntryDate(accountID);
            int monthsElapsed = ((DateTime.Now.Year - entryDate.Year) * 12 + DateTime.Now.Subtract(entryDate).Days) / 30; //Approximation
            Console.WriteLine("months elapsed: " + monthsElapsed);
            double interestAmount = monthsElapsed * double.Parse(accDetails[5]) * double.Parse(accDetails[2]);*/

            double interestAmount = double.Parse(accDetails[5]) * double.Parse(accDetails[2]);

            return interestAmount;

        }

        public DateTime getEntryDate(int accountID)
        {
            string[] accDetails = getAccountDetails(accountID);
            Console.WriteLine(accDetails[3]);
            //Weird Date format? dd/mm/yyyy??? WEIRD
            int day = int.Parse(accDetails[3].Substring(0, 2));
            Console.WriteLine("Day: " + day);

            int month = int.Parse(accDetails[3].Substring(3, 2));
            Console.WriteLine("Month: " + month);
            
            int year = int.Parse(accDetails[3].Substring(6, 4));
            Console.WriteLine("Year: " + year);
            DateTime entryDate = new DateTime(year, month, day);

            return entryDate;
        }

        public DateTime getBDate(string customerPIN)
        {
            string[] customerProfile = getCustomerProfile(customerPIN);

            Console.WriteLine(customerProfile[5]);
            //Weird Date format? dd/mm/yyyy??? WEIRD
            int day = int.Parse(customerProfile[5].Substring(0, 2));
            Console.WriteLine("Day: " + day);

            int month = int.Parse(customerProfile[5].Substring(3, 2));
            Console.WriteLine("Month: " + month);

            int year = int.Parse(customerProfile[5].Substring(6, 4));
            Console.WriteLine("Year: " + year);
            DateTime bDate = new DateTime(year, month, day);

            return bDate;
        }


        public DataTable getAllPaymentsByAccountDataTable(int accountID)
        {
            string q = "SELECT accountID, paymentAmount, paymentDate from payment WHERE accountID = " + accountID + ";";
            conn.Open();
            MySqlCommand com = new MySqlCommand(q, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            conn.Close();

            return dt;
        }

        public double getTotalPaymentOfAccount(int accountID)
        {
            string q = "SELECT SUM(paymentAmount) from payment WHERE accountID = " + accountID + ";";
            conn.Open();
            MySqlCommand com = new MySqlCommand(q, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            conn.Close();

            Console.WriteLine("DT ROW " + dt.Rows[0][0].ToString() + "ROW COUNT: "+ dt.Rows.Count);
            double total = 0;
            if (dt.Rows[0][0].ToString().Length == 0)
                total = 0;
            else
                total = double.Parse(dt.Rows[0][0].ToString());
            Console.WriteLine(total);
            return total;
        }

        /*public DataTable getAllAccountsWithStatus(bool isActive)
        {
            string status;
            if (isActive)
                status = "Active";
            else
                status = "Paid";

            string q = "SELECT * FROM boombroom.customer join boombroom.account ON customer.customerID = account.customerID WHERE account.status = '" + status + "';";

            MySqlCommand com = new MySqlCommand(q, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            conn.Close();

            return dt;
        }*/

        public DataTable searchCustomers(string fn, string ln, bool isActive)
        {
            string q;
            if (isActive)
                q = "SELECT DISTINCT customer.customerID, customerFName, customerLName, gender, civilStatus,"
                + " birthDate, homeAddress, jobDescription, workingAddress, telNumber, phoneNumber, pinNumber"
                + " FROM customer JOIN account ON customer.customerID = account.customerID"
                + " WHERE account.status = 'Active' AND customerFName LIKE '%" + fn + "%' AND customerLName LIKE '%" + ln + "%';";
            else
                q = "SELECT DISTINCT customer.customerID, customerFName, customerLName, gender, civilStatus,"
                +" birthDate, homeAddress, jobDescription, workingAddress, telNumber, phoneNumber, pinNumber"
                +" FROM customer WHERE customerID NOT IN (SELECT DISTINCT customer.customerID"
                +" FROM customer JOIN account ON customer.customerID = account.customerID"
                + " WHERE account.status = 'Active')  AND customerFName LIKE '%" + fn + "%' AND customerLName LIKE '%" + ln + "%';";


            /*string q = "SELECT customer.customerID, customerFName, customerLName, gender, civilStatus,"+
                " birthDate, homeAddress, jobDescription, workingAddress, telNumber, phoneNumber, pinNumber"+
                " FROM customer join account ON customer.customerID = account.customerID"+
                " WHERE account.status = '" + query +"' AND customerFName LIKE '%"+fn+"%' AND customerLName LIKE '%" +ln + "%';";*/
                //account.status = 'status'IS WRONG CONDITION!

            MySqlCommand com = new MySqlCommand(q, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            conn.Close();

            return dt;

        }

        public bool customerIsActive(string customerPIN)
        {
            string q = "SELECT COUNT(*) FROM customer JOIN account ON customer.customerID = account.customerID WHERE status = 'Active' AND pinNumber = '" + customerPIN + "';";


            MySqlCommand com = new MySqlCommand(q, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            conn.Close();

            int numberOfActiveAccounts = int.Parse(dt.Rows[0][0].ToString());
            
            return numberOfActiveAccounts > 0;
        }

        /*public double getTotalMoneyLentOfCustomer(int customerID)
        {
            string q = "SELECT SUM(moneyLent) from account WHERE customerID = " + customerID + ";";
            conn.Open();
            
            MySqlCommand com = new MySqlCommand(q, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            conn.Close();

            Console.WriteLine("DT ROW " + dt.Rows[0][0].ToString() + "ROW COUNT: " + dt.Rows.Count);
            double total = 0;
            if (dt.Rows[0][0].ToString().Length == 0)
                total = 0;
            else
                total = double.Parse(dt.Rows[0][0].ToString());

            return total;
        }*/

        /*public bool addPayment(int accountID, double paymentAmount, DateTime paymentDate)
        {
            //if totalpaymentOfaccount + paymentAmount > moneyLent
            int day = paymentDate.Day;
            int month = paymentDate.Month;
            int year = paymentDate.Year;
            string q = "INSERT INTO payment(accountID, paymentAmount, paymentDate) VALUES(" + accountID + ", " 
                + paymentAmount + ", '" + month + "-" + day + "-" + year + "');";


        }*/

        public bool addCardToAccount(int accountID, string cardNumber, string bank)
        {
            if (!cardExists(cardNumber, bank))
            {
                string q = "INSERT INTO card(cardNumber, bank) VALUES ('cardNumber', 'bank');";
                conn.Open();
                MySqlCommand com = new MySqlCommand(q, conn);
                com.ExecuteNonQuery();
                conn.Close();
            }

            int cardID = getCardID(cardNumber, bank);

            bool success = addAccountCard(accountID, cardID);
            return success;
        }

        
        public bool addAccountCard(int accID, int cardID)
        {
            String q = "INSERT INTO account_card(accID, cID) VALUES (" + accID + "," + cardID + ");";
            conn.Open();
            MySqlCommand com = new MySqlCommand(q, conn);
            int rowsAffected = com.ExecuteNonQuery();
            conn.Close();

            return rowsAffected > 0;
        }

        public int getLastInsertedIDOfAccounts()
        {
            string q = "SELECT MAX(accountID) FROM account;";
            MySqlCommand com = new MySqlCommand(q, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            conn.Close();

            int lastID = -1;
            if (dt.Rows[0][0].ToString().Length == 0) //If Row 0 Cell 0 has no content, set lastID = -1;
                lastID = -1;
            else
                lastID = int.Parse(dt.Rows[0][0].ToString());

            return lastID;
        }
    }
}
