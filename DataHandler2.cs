using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

public class DataHandler //Data Handler for BloodDonation
{
    public MySqlConnection conn;
    
    public DataHandler(string server, string database, string user, string password)
    {
        conn = new MySqlConnection("Server=" + server + ";Database=" + database + ";Uid=" + user + ";Pwd=" + password + ";");
    }
}
