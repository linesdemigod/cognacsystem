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
    public partial class Updateproduct : KryptonForm
    {
        //Instance of manageuser class
        ManageProduct manageProduct = new ManageProduct();

        public Updateproduct(string id, string category, string item, string price, string description, string quantity)
        {
            InitializeComponent();

            txtMagId.Text = id;
            comboMagCategory.Text = category;
            txtMagName.Text = item;
            txtMagPrice.Text = price;
            txtMagDescription.Text = description;
            txtMagQuantity.Text = quantity;

            //get the category
            getCatData();
        }


        //get the values of the category 
        public void getCatData()
        {
            comboMagCategory.DataSource = null;
            manageProduct.getCat();
            comboMagCategory.DataSource = manageProduct.dat;
            comboMagCategory.DisplayMember = "cat_name";
            comboMagCategory.ValueMember = "cat_id";
        }



        public void updateProduct()
        {
            manageProduct.name = txtMagName.Text;
            manageProduct.price = txtMagPrice.Text;
            manageProduct.category = comboMagCategory.Text;
            manageProduct.description = txtMagDescription.Text;
            manageProduct.quantity = txtMagQuantity.Text;
            manageProduct.id = txtMagId.Text;

            //check if the textboxes are empty
            if (manageProduct.name == "" || manageProduct.price == "" || manageProduct.description == "" || manageProduct.quantity == "")
            {
                MessageBox.Show("Please Fill all Field");

                return;

            }

            manageProduct.updateProduct();
            MessageBox.Show("Product Updated");
            //clear textbox after successful insert
            manageProduct.name = txtMagName.Text = "";
            manageProduct.price = txtMagPrice.Text = "";
            //manageProduct.category = comboMagCategory.Text;
            manageProduct.description = txtMagDescription.Text = "";
            manageProduct.quantity = txtMagQuantity.Text = "";
            manageProduct.id = txtMagId.Text = "";
        }

        //update the record the button is pressed
        private void btnMagProduct_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult confirm = MessageBox.Show("Do you want to update? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    updateProduct();
                    //refresh the winform after successfully updating the account
                    getCatData();
                }

                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        //acept only numbers
        private void txtMagPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMagQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
