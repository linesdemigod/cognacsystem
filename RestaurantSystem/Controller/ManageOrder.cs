using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Controller
{
    class ManageOrder : Database
    {

        public string id { get; set; }

        //for getCat from table
        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        public DataTable dat = new DataTable();
        private DataSet das = new DataSet();

        public DataTable datt = new DataTable();
        private DataSet dass = new DataSet();

        //READ DATA
        public void getOrder()
        {
            dt.Clear();
            string subsql = "SELECT CONCAT(users_fname, ' ', users_lname) FROM users WHERE users_id = orders.users_id";

            string sql = "SELECT ord_bill_number, ord_gross_amount, ord_vat_amount, ord_discount, ord_net_amount, (" + subsql + ") AS Cashier FROM orders ORDER BY ord_id DESC LIMIT 30";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
        }



        //READ DATA
        public void getFullOrder()
        {
            
            dat.Clear();
            string sql = "SELECT orders.ord_bill_number, product.pro_name, product.pro_price, order_item.ordit_quantity, order_item.ordit_amount, orders.ord_gross_amount, orders.ord_vat_amount, orders.ord_discount, orders.ord_net_amount from orders INNER JOIN order_item using (ord_id) INNER JOIN product USING (pro_id) WHERE date(orders.created_at) = curdate() ORDER BY orders.ord_id DESC";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(das);
            dat = das.Tables[0];
        }

        //get all the data from the Temporary Cart table in the db
        public void getTempCart()
        {

            datt.Clear();
            string sql = "SELECT * FROM tempcart";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(dass);
            datt = dass.Tables[0];
        }

        //Delete
        public void deleteOrder()
        {

            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "DELETE FROM orders WHERE ord_bill_number=@id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;

                    cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                    cmd.ExecuteNonQuery();

                    conn.Close();

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
           
        }

    }
}
