using ComponentFactory.Krypton.Toolkit;
using RestaurantSystem.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem.View.user
{
    public partial class Manageproduct : KryptonForm
    {
        //Instance of manageuser class
        ManageProduct manageProduct = new ManageProduct();

        public Manageproduct()
        {
            InitializeComponent();

            //refresh the winform after successfully updating the account
            getProductData();

            setupUserAccess();
        }


        //validate Admin and manager
        public void setupUserAccess()
        {

            //instances of the permission class
            Permissions permit = new Permissions();

            int userLoggedInRole = Convert.ToInt32(Form1.Login_role);

            permit.getDashboardPriviledge(); //call the method in the permission class
           

            switch (userLoggedInRole)
            {
                case 2:
                    dataGridViewProduct.Columns["Delete"].Visible = permit.DeleteProduct;

                    break;
                default:

                    break;
            }

        }

        //method to put the data to the gridviewdata
        public void getProductData()
        {

            manageProduct.getProduct();
            dataGridViewProduct.DataSource = manageProduct.dt;

        }



        private void dataGridViewProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == -1) return;

                //code the delete
                if (dataGridViewProduct.Columns[e.ColumnIndex].HeaderText == "Delete")
                {
                    DialogResult confirm = MessageBox.Show("Are you sure you want to delete? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirm == DialogResult.Yes)
                    {


                        int id;
                        id = Convert.ToInt32(dataGridViewProduct.Rows[e.RowIndex].Cells["ID"].Value);
                        manageProduct.id = id.ToString();
                        if (Convert.ToInt32(manageProduct.id) > 0)
                        {
                            //call the deleteUser method in the manageuser class
                            manageProduct.deleteProduct();
                            MessageBox.Show("Product deleted");
                            getProductData();
                        }

                    }
                }


                //code for the update
                if (dataGridViewProduct.Columns[e.ColumnIndex].HeaderText == "Update")
                {

                    string id, category, item, price, description, quantity;

                    id = dataGridViewProduct.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                    category = dataGridViewProduct.Rows[e.RowIndex].Cells["Category"].Value.ToString();
                    item = dataGridViewProduct.Rows[e.RowIndex].Cells["Item"].Value.ToString();
                    price = dataGridViewProduct.Rows[e.RowIndex].Cells["Price"].Value.ToString();
                    description = dataGridViewProduct.Rows[e.RowIndex].Cells["Description"].Value.ToString();
                    quantity = dataGridViewProduct.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();

                    Updateproduct user = new Updateproduct(id, category, item, price, description, quantity);
                    user.ShowDialog();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        //method to the filter the product based on the value entered in the textbox
        #region Search
        public void search()
        {
            DataView dv = manageProduct.dt.DefaultView;
            dv.RowFilter = string.Format("pro_name LIKE '%" + txtProductSearch.Text.Trim() + "%'");
            dataGridViewProduct.DataSource = dv.ToTable();
        }
        #endregion

        private void btnRefreshes_Click(object sender, EventArgs e)
        {
            getProductData();
        }

        private void txtProductSearch_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
