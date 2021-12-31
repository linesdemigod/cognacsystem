using ComponentFactory.Krypton.Toolkit;
using RestaurantSystem.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem.View.waiter
{
    public partial class Viewproduct : KryptonForm
    {

        //Instance of ViewProduct class
        ViewProduct manageProduct = new ViewProduct();

        public Viewproduct()
        {
            InitializeComponent();
        }
        

        //method to put the data to the gridviewdata
        public void getProductData()
        {
            
            manageProduct.getProductData();
            dataGridViewProduct.DataSource = manageProduct.dtView;
        }

      
        
        //it fires the search function when a character is entered in the textbox
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            search();
        }
        

        //method to the filter the product based on the value entered in the textbox
        public void search ()
        {
            
            DataView dv = manageProduct.dtView.DefaultView;
            dv.RowFilter = string.Format("Food LIKE '%" + txtSearch.Text.Trim() +"%'" );
            dataGridViewProduct.DataSource = dv.ToTable();
        }

        //it calls the function when the winform is loaded
        private void Viewproduct_Load(object sender, EventArgs e)
        {
            getProductData();
        }

        

        
    }
}
