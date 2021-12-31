using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Controller
{
    class Database
    {

        public MySqlConnection conn;
        public MySqlCommand cmd;
        public MySqlDataReader rd;


        public Database()
        {
            
                string dbSource = "localhost";
                string port = "3306";
                string user = "root";
                string db = "foodjoint";
                string ssl = "None";
                string connection = "datasource=" + dbSource + ";port=" + port + ";user Id=" + user + ";password=;database=" + db + ";SSL Mode=" + ssl + "";

                conn = new MySqlConnection(connection);
                cmd = conn.CreateCommand();
            
            
            
        }
    }
}
