using ComponentFactory.Krypton.Toolkit;
using System;
using RestaurantSystem.Controller;
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
    public partial class Order : KryptonForm
    {
        //instance of the order class
        Orders order = new Orders();

        AddProduct product = new AddProduct();

        //variables for the datagrid
        int Key = 0;
        string productName;
        
        double productPrice;
        int addNewRow = 1;

        public Order()
        {
            InitializeComponent();

        }


        //method to put the data to the gridviewdata left side
        #region datagrid
        public void getProductData()
        {
            order.getProductData();
            dataGridViewProduct.DataSource = order.dt;
        }
        #endregion

        //method to the filter the product based on the value entered in the textbox
        #region Search
        public void search()
        {
            DataView dv = order.dt.DefaultView;
            dv.RowFilter = string.Format("Food LIKE '%" + txtProduct.Text.Trim() + "%'");
            dataGridViewProduct.DataSource = dv.ToTable();
        }
        #endregion

        //method to the filter the product based on category
        #region Search by category
        public void searchByCategory()
        {
            DataView dv = order.dt.DefaultView;
            dv.RowFilter = string.Format("Cat = '" + comboSearchFilter.Text.Trim() + "'");
            dataGridViewProduct.DataSource = dv.ToTable();
        }
        #endregion

        //method to put the data to the combobox
        #region Load category
        public void getCatData()
        {
            //comboCategory.DataSource = null;
            product.getCat();
            comboSearchFilter.DataSource = product.dt;
            comboSearchFilter.DisplayMember = "cat_name";
            comboSearchFilter.ValueMember = "Cat_id";
        }
        #endregion

        //method like the constructor
        #region load winform
        private void Order_Load(object sender, EventArgs e)
        {
            //load the left datagridview
            getProductData();

            //get the current VAT 
            vatValueToLabel();

            //generate unique ID to the tempcart
            generateUniqueId();

            //get all the various category to the combobox
            getCatData();
        }
        #endregion

        #region AUTOCOMPLETE
        /*
                public void autoCom()
                {

                    order.searchDat();
                    AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

                    coll.Add(order.result);

                    txtProduct.AutoCompleteMode = AutoCompleteMode.Suggest;
                    txtProduct.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    txtProduct.AutoCompleteCustomSource = coll;


                } */
        #endregion

        //VAT value to the label
        #region Vat label
        public void vatValueToLabel()
        {
            order.getTaxValue();
            label7.Text = "VAT(" + order.dbVat + "%)";
        }
        #endregion

        //filter the datagrid at the left to the value provided in the textbox
        #region search product
        private void txtProduct_TextChanged(object sender, EventArgs e)
        {
            search();
        }
        #endregion

        //select the values from the datagrid to the right datagrid
        #region datagrid cellcontentclicked
        private void dataGridViewProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //GET SELECTED DATA
            DataGridView senderGrid = (DataGridView)sender;


            try
            {
                if (dataGridViewProduct.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    //select the product name and price from the gridtable
                    txtId.Text = (dataGridViewProduct.Rows[e.RowIndex].Cells[0].Value.ToString());

                    productName = (dataGridViewProduct.Rows[e.RowIndex].Cells[1].Value.ToString());
                    productPrice = (Convert.ToDouble(dataGridViewProduct.Rows[e.RowIndex].Cells[2].Value.ToString()));

                    //Set the default value of the Quantity Textbox to 0
                    txtQuantity.Text = "";

                    //assign the value of the row click to the various textbox
                    txtRate.Text = (dataGridViewProduct.Rows[e.RowIndex].Cells[2].Value.ToString());
                    txtSelectedProduct.Text = (dataGridViewProduct.Rows[e.RowIndex].Cells[1].Value.ToString());
                    txtAmount.Text = (dataGridViewProduct.Rows[e.RowIndex].Cells[2].Value.ToString());
                    txtProductDesc.Text = (dataGridViewProduct.Rows[e.RowIndex].Cells[4].Value.ToString());
                    txtStock.Text = (dataGridViewProduct.Rows[e.RowIndex].Cells[3].Value.ToString());
                    //focus on the Quantity Textbox
                    txtQuantity.Select();

                    if (productName == "")
                    {
                        Key = 0;
                    }
                    else
                    {
                        Key = Convert.ToInt32(dataGridViewProduct.Rows[0].Cells[0].Value.ToString());
                    }
                }
            }

            catch (Exception)
            {


            }

        }
        #endregion

        //invoke the function which insert data to the bill datagridview when the button is clicked
        #region Add Item Button Clicked
        private void btnAddItem_Click(object sender, EventArgs e)
        {

            
            //editDataGrid();
            //invoke function
            setDataGridBill();

            //load the left datagridview
            getProductData();

            //generate unique number
            generateUniqueId();


        }
        #endregion

        //calculate the subtotal
        #region calculate subtotal
        public void calcSubTotal()
        {
            try
            {
                double result;

                result = Convert.ToDouble(txtAmount.Text) + Convert.ToDouble(txtSubTotal.Text);

                txtSubTotal.Text = result.ToString("0.00");
            }
            catch (Exception)
            {


            }

        }
        #endregion

        

        //method to insert data to the billGridView when add item button is click
        #region Set the DataGrid
        public void setDataGridBill()
        {
            try
            {

                int stock = string.IsNullOrEmpty(txtStockLeft.Text) ? 0 : int.Parse(txtStockLeft.Text);

                if (Key == 0)
            {
                MessageBox.Show("Select a product");
                return;
            }
            else if (txtSelectedProduct.Text == "")
            {
                MessageBox.Show("Select a Product");
                return;
            }
            else if (txtQuantity.Text == "" || txtQuantity.Text == "0")
            {
                MessageBox.Show("Enter the Quantity");
                return;
            }
            else if (stock < 0)
            {
                MessageBox.Show("Out of stock");

                return;
            }
            else
            {
                //calc the subtotal in the right gridview
                double subTotalGrid = Convert.ToDouble(txtQuantity.Text) * productPrice;

                //call the function to calculate the subtotal
                calcSubTotal();

                    //to decrease the stock at the db
                    decreaseStockQty();

                    //insert into tempcart
                    insertIntoTempCart();

                    //calculate the subtotal in the textbox
                    //subTotalAmount = subTotalAmount + subTotalGrid;               

                    //insert row to datagrid whenever add item is clicked
                    DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dataGridViewBill);
                newRow.Cells[0].Value = addNewRow;
                newRow.Cells[1].Value = productName;
                newRow.Cells[2].Value = txtQuantity.Text;
                newRow.Cells[3].Value = productPrice;
                newRow.Cells[4].Value = txtProductDesc.Text;
                newRow.Cells[5].Value = subTotalGrid; //insert it into datagridviewbill
                newRow.Cells[6].Value = txtId.Text;
                newRow.Cells[7].Value = txtStockLeft.Text;
                    newRow.Cells[8].Value = lblUniqueId.Text;
                    dataGridViewBill.Rows.Add(newRow);
                addNewRow++;

                    //calculate the subtotal below the right datagridviewon the right side
                    //txtSubTotal.Text = subTotalAmount.ToString();

                    //clear the textbox when the additem button is clicked
                    clearTextBox();
            }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        //clear the various textBox
        #region Clear various textBox
        private void clearTextBox()
        {
            //clear the textbox when the additem button is clicked
            txtRate.Text = "";
            txtAmount.Text = "";
            txtQuantity.Text = "";
            txtSelectedProduct.Text = "";
            txtProductDesc.Text = "";
            txtId.Text = "";
            txtStock.Text = "";
            txtStockLeft.Text = "";
        }
        #endregion

        //handle the delete row function when clicked
        #region delete row handler
        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            //resetStockBackToProduct();
            
            //increase stock in the product table
            increaseStockQty();

            //delete from the tempcart
            deletefromTempCart();

            removeCell();
            //load datagrid
            getProductData();
        }
        #endregion

        //method to delete a selected row from datagridviewbill and deduct deleted value from the subtotal
        #region delete cell and calculate subtotal after
        public void removeCell()
        {
            try
            {
                if (dataGridViewBill.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dataGridViewBill.Rows)
                    {
                        if (row.Selected == true)
                        {
                            txtSubTotal.Text = (Convert.ToDouble(txtSubTotal.Text) - Convert.ToDouble(row.Cells["Column5"].Value)).ToString();

                            dataGridViewBill.Rows.RemoveAt(row.Index);
                            dataGridViewBill.Refresh();
                        }

                    }
                }
            }
            catch (Exception)
            {


            }

        }

        #endregion

        //this function reset the stock at the left datagridview when the item is removed at the right datagrid
        #region reset the 
        private void resetStockBackToProduct()
        {
            try
            {

            foreach (DataGridViewRow row in dataGridViewBill.Rows)
            {

                foreach (DataGridViewRow rows in dataGridViewProduct.Rows)
                {
                    
                    string a = Convert.ToString(row.Cells["Column12"].Value);
                    string b = Convert.ToString(rows.Cells["Column7"].Value);
                    if (a == b)
                    {

                        if (row.Selected == true)
                        {
                            int result = Convert.ToInt32(rows.Cells["Column11"].Value) + Convert.ToInt32(row.Cells["Column3"].Value);

                            rows.Cells["Column11"].Value = result.ToString();
                            //MessageBox.Show("prod: " + b + " bill " + a);
                        }
                    }

                }

            }
            }
            catch (Exception)
            {

               
            }
        }
        #endregion

       

        //call the vat and grandtotal methods here
        #region subtotal event hamdler
        private void txtSubTotal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                vatCalc();
                grandTotal();
            }
            catch (Exception)
            {


            }

        }
        #endregion

        //calculate discount
        #region discount calc
        public void calcDiscount()
        {
            try
            {
                //declare variable for the calc
                double grandTotal, vat, discount, subTotal;

                //convert the various textbox to double
                vat = Convert.ToDouble(txtVat.Text);
                discount = Convert.ToDouble(txtDiscount.Text);
                subTotal = Convert.ToDouble(txtSubTotal.Text);

                //calc the grand total
                grandTotal = (vat + subTotal) - discount;

                txtGrandTotal.Text = grandTotal.ToString();
            }
            catch (Exception)
            {


            }

        }
        #endregion

        //calc the grandtotal
        #region Grandtotal
        public void grandTotal()
        {
            try
            {
                //declare variable for the calc
                double grandTotal, vat, subTotal;

                //convert the various textbox to double
                vat = Convert.ToDouble(txtVat.Text);
                subTotal = Convert.ToDouble(txtSubTotal.Text);

                //calc the grand total
                grandTotal = vat + subTotal;

                txtGrandTotal.Text = grandTotal.ToString("0.00");
            }
            catch (Exception)
            {


            }

        }
        #endregion

        //Calculate the Vat set the value to 13%
        #region Vat calculator
        public void vatCalc()
        {
            try
            {
                order.getTaxValue();
                //set vat percentage to 13
                double dbVat = Convert.ToDouble(order.dbVat);

                double vat = dbVat / 100;

                double subTotal = Convert.ToDouble(txtSubTotal.Text);
                double calcvat = subTotal * vat;

                txtVat.Text = calcvat.ToString("0.00");
            }
            catch (Exception)
            {


            }

        }
        #endregion

        //calc the change
        #region calculate change
        public void calcChange()
        {
            try
            {
                double amountPaid, change, grandTotal;

                amountPaid = Convert.ToDouble(txtAmountPaid.Text);
                grandTotal = Convert.ToDouble(txtGrandTotal.Text);

                change = amountPaid - grandTotal;

                txtChange.Text = change.ToString();
            }
            catch (Exception)
            {


            }

        }
        #endregion


        //the calcDiscount method when a value is enter in the Discount textbox
        #region discount event handler
        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //if the discount txtbox is empty set value to 0
                if (txtDiscount.Text == "")
                {
                    txtDiscount.Text = "0";
                }

                calcDiscount();

            }
            catch (Exception)
            {


            }
        }
        #endregion

        //calculate the change to be given to the customer
        #region Change 
        private void txtAmountPaid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtAmountPaid.Text == "")
                {
                    txtChange.Text = "";
                }

                calcChange();

            }
            catch (Exception)
            {


            }
        }
        #endregion


        //Calculate the Amount
        #region Calculate Amount
        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double rate, amount, qty;

                //convert the value of the various textbox to double
                rate = Convert.ToDouble(txtRate.Text);
                amount = Convert.ToDouble(txtAmount.Text);
                qty = Convert.ToDouble(txtQuantity.Text);

                //formula for getting the total value
                amount = qty * rate;

                
                txtAmount.Text = amount.ToString();
                calcStock();


            }
            catch (Exception)
            {


            }

        }
        #endregion


        //order button clicked event handler
        #region order event 
        private void btnOrder_Click(object sender, EventArgs e)
        {

            if (dataGridViewBill.Rows.Count == 0)
            {
                MessageBox.Show("Select an item");

            }

            if (txtSubTotal.Text == "0" || txtSubTotal.Text == "")
            {
                return;
            }


            DialogResult confirm = MessageBox.Show("Do you want to Make order? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {

                //insert the bill to the orders table in the db
                insertBillDB();

                //insert 
                insertOrderItem();

                //update the stock
                //updateStockProduct();
               
                //print the receipt
                printData();

                //delete all from database when order is placed
                deleteAllfromTempCart();
                //clear the data gridview
                clearDataGridTable();

                //clear the various table after inserting it to the database
                txtSubTotal.Text = "0";
                txtVat.Text = "";
                txtGrandTotal.Text = "";
                txtChange.Text = "";
                txtAmountPaid.Text = "";
                lblBillID.Text = "";

                //set the discount textbox to zero
                txtDiscount.Text = "0";

                //reload the datagrid
                getProductData();

            }

        }
        #endregion

        //Generate random number for each receipt
        #region randomnumber
        public string getRandNum()
        {
            Random rand = new Random();
            string result = "BA" + rand.Next();

            return result;
        }
        #endregion


        //insert the bill to the database
        #region insertBill
        public void insertBillDB()
        {

            if (txtSubTotal.Text == "")
            {
                MessageBox.Show("Select a product");

                return;
            }



            string g = getRandNum();
            lblBillID.Text = g;
            order.username = Form1.Login_username;
            order.billNumber = lblBillID.Text;
            order.grossAmount = txtSubTotal.Text;
            order.vatAmount = txtVat.Text;
            order.discount = txtDiscount.Text;
            order.netAmount = txtGrandTotal.Text;
            order.saveBill();

            //display success message
            MessageBox.Show("Order completed");

        }
        #endregion

        //clear the datagriview at the right
        #region Clear Table
        public void clearDataGridTable()
        {
            dataGridViewBill.DataSource = null;
            dataGridViewBill.Rows.Clear();

        }
        #endregion


        //calculate the stock 
        #region Calculate the stock
        private void calcStock()
        {
            try
            {
                int result = Convert.ToInt32(txtStock.Text) - Convert.ToInt32(txtQuantity.Text);

                txtStockLeft.Text = result.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }      
           
        }
        #endregion calc stock end

        //temporary reduce the stock of selected item in the left datagridview
        #region edit datagrid product
        private void editDataGrid()
        {
            try
            {
            foreach (DataGridViewRow row in dataGridViewProduct.Rows)
            {
                string id = Convert.ToString(row.Cells["Column7"].Value);

                if (txtId.Text == id)
                {
                    if (Convert.ToInt32(txtStockLeft.Text) < 0)
                    {
                        return;
                    }
                    else
                    {
                            row.Cells["Column11"].Value = txtStockLeft.Text;
                    }
                   
                }

            }

            }
            catch (Exception)
            {

               
            }
        }
        #endregion

        //decrease the stock in the database when the add Item button is clicked
        #region Decrease stock
        private void decreaseStockQty()
        {
            order.stock = txtQuantity.Text;
            order.id = txtId.Text;
            order.decreaseStock();
        }
        #endregion

        //increase the stock in db when item is removed from the right datagridview
        #region Increase stock 
        private void increaseStockQty()
        {
            try
            {

                foreach (DataGridViewRow row in dataGridViewBill.Rows)
                {


                    if (row.Selected == true)
                    {

                        order.stock = row.Cells["Column3"].Value.ToString();
                        order.id = row.Cells["Column12"].Value.ToString();
                        order.increaseStock();
                    }

                }
            }
            catch (Exception)
            {

               
            }
        }
        #endregion

        //generate unique ID for tempcart
        #region Tempcart Unique ID
        private void generateUniqueId()
        {
            Random rand = new Random();
            int result = rand.Next();

            lblUniqueId.Text = result.ToString();
        }
        #endregion

        //insert it into tempcart table when item is added to the right datagridview
        #region Insert into Tempcart
        private void insertIntoTempCart()
        {

            order.uniqueId = lblUniqueId.Text;
            order.stock = txtQuantity.Text;
            order.name = txtSelectedProduct.Text;
            order.id = txtId.Text;
            order.insertIntoTempCart();
        }
        #endregion

        //delete from tempcart table when the item is removed from the right datagridview
        #region Delete from Tempcart
        private void deletefromTempCart()
        {
            try
            {

                foreach (DataGridViewRow row in dataGridViewBill.Rows)
                {


                    if (row.Selected == true)
                    {
                        
                        order.uniqueId = row.Cells["Column14"].Value.ToString();
                        order.deleteFromTempCart();
                    }

                }
            }
            catch (Exception)
            {


            }
        }
        #endregion


        //delete all from tempcart table when the order is placed
        #region Delete All from Tempcart
        private void deleteAllfromTempCart()
        {
            try
            {

                foreach (DataGridViewRow row in dataGridViewBill.Rows)
                {
                    order.uniqueId = row.Cells["Column14"].Value.ToString();
                    order.deleteFromTempCart();
                }
            }
            catch (Exception)
            {


            }
        }
        #endregion

        //update stock when order is made
        #region Update the stock
        public void updateStockProduct()
        {

            try
            {

            foreach (DataGridViewRow rows in dataGridViewBill.Rows)
            {

                order.stock = Convert.ToString(rows.Cells["Column3"].Value);
                order.id = Convert.ToString(rows.Cells["Column12"].Value);
                order.decreaseStock();
                     
            }

            }
            catch (Exception)
            {

                
            }

           
        }
        #endregion

        //insert ordered item to db
        #region into bill datagrid
        public void insertOrderItem()
        {

            foreach (DataGridViewRow row in dataGridViewBill.Rows)
            {
                order.productName = Convert.ToString(row.Cells["Column2"].Value);
                order.quantity = Convert.ToString(row.Cells["Column3"].Value);
                order.rate = Convert.ToString(row.Cells["Column4"].Value);
                order.orderAmount = Convert.ToString(row.Cells["Column5"].Value);
                order.desc = Convert.ToString(row.Cells["Column6"].Value);
                order.saveOrderItem();

            }
        }
        #endregion

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            printData();
            //updateStockProduct();
        }


        //the print function
        #region print
        public void printData()
        {
            try
            {
                int datagrid = dataGridViewBill.Rows.Count;
                if (datagrid > 0 && datagrid <= 5)
                {
                    printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
                    if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                    {
                        printDocument1.Print();
                    }

                    return;
                }

                if (datagrid > 5 && datagrid <= 10)
                {
                    printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 900);
                    if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                    {
                        printDocument1.Print();
                    }

                    return;
                }

                if (datagrid > 10 && datagrid <= 18)
                {
                    printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 1200);
                    if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                    {
                        printDocument1.Print();
                    }

                    return;
                }

                if (datagrid > 18 && datagrid <= 30)
                {
                    printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 1200);
                    if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                    {
                        printDocument1.Print();
                    }

                    return;
                }

                if (datagrid > 30 && datagrid <= 50)
                {
                    printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 1500);
                    if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                    {
                        printDocument1.Print();
                    }

                    return;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }


        #endregion

        //receipt designing
        #region Receipt design
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //company info
            CompanyInfo info = new CompanyInfo();
            info.getCompany();
            DateTime now = DateTime.Now;
            int fontSize = 10;
            Font font = new Font("Courierr New", 10, FontStyle.Bold);
            Font regular = new Font("Courierr New", fontSize, FontStyle.Regular);
            Font small = new Font("Courierr New", 8, FontStyle.Regular);

            float fontheight = font.GetHeight();
            int startx = 40;
            int starty = 40;
            int footerx = 5;
            int footery = 30;
            int pos = 160;
            double productQty, product_price, productTotal;

            string product_name, description;


            e.Graphics.DrawString(info.company, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, new Point(startx, 0));

            e.Graphics.DrawString(info.address, regular, Brushes.Black, new Point(100, 20));
            e.Graphics.DrawString(info.phone, regular, Brushes.Black, new Point(100, starty));

            starty = starty + 20;

            e.Graphics.DrawString("Date: ", font, Brushes.Black, new Point(5, starty));
            e.Graphics.DrawString(now.ToString(), regular, Brushes.Black, new Point(70, starty));

            starty = starty + 20;

            e.Graphics.DrawString("Invoice No.: ", font, Brushes.Black, new Point(5, starty));
            e.Graphics.DrawString(lblBillID.Text, regular, Brushes.Black, new Point(100, starty));

            starty = starty + 20;

            e.Graphics.DrawString("Cashier: ", font, Brushes.Black, new Point(5, starty));
            e.Graphics.DrawString(Form1.Login_fname + " " + Form1.Login_lname, regular, Brushes.Black, new Point(100, starty));

            starty = starty + 20;

            e.Graphics.DrawString("**************************************************", font, Brushes.Black, new Point(1, starty));

            starty = starty + 20;

            e.Graphics.DrawString("ITEM", font, Brushes.Black, new Point(5, starty));
            e.Graphics.DrawString("QTY", font, Brushes.Black, new Point(110, starty));
            e.Graphics.DrawString("PRICE", font, Brushes.Black, new Point(160, starty));
            e.Graphics.DrawString("TOTAL", font, Brushes.Black, new Point(225, starty));

            foreach (DataGridViewRow row in dataGridViewBill.Rows)
            {
                product_name = Convert.ToString(row.Cells["Column2"].Value);
                productQty = Convert.ToDouble(row.Cells["Column3"].Value);
                product_price = Convert.ToDouble(row.Cells["Column4"].Value);
                productTotal = Convert.ToDouble(row.Cells["Column5"].Value);
                description = Convert.ToString(row.Cells["Column6"].Value);

                //e.Graphics.DrawString(productID.ToString(), new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(26, pos));
                e.Graphics.DrawString(product_name, regular, Brushes.Black, new Point(5, pos));
                e.Graphics.DrawString(description, regular, Brushes.Black, new Point(5, pos + 20));
                e.Graphics.DrawString(productQty.ToString(), regular, Brushes.Black, new Point(110, pos));
                e.Graphics.DrawString(product_price.ToString(), regular, Brushes.Black, new Point(160, pos));
                e.Graphics.DrawString(productTotal.ToString(), regular, Brushes.Black, new Point(225, pos));

                pos = pos + 40;
            }


            e.Graphics.DrawString("******************************************************", font, Brushes.Black, new Point(0, pos + footery));

            footery = footery + 30;

            e.Graphics.DrawString("SubTotal: ", font, Brushes.Black, new Point(footerx, pos + footery));
            e.Graphics.DrawString("GHS " + txtSubTotal.Text, regular, Brushes.Black, new Point(footerx + 180, pos + footery));

            footery = footery + 20;

            e.Graphics.DrawString("Discount:", font, Brushes.Black, new Point(footerx, pos + footery));

            e.Graphics.DrawString("GHS " + txtDiscount.Text, regular, Brushes.Black, new Point(footerx + 180, pos + footery));

            footery = footery + 20;

            e.Graphics.DrawString(label7.Text, font, Brushes.Black, new Point(footerx, pos + footery));
            e.Graphics.DrawString("GHS " + txtVat.Text, regular, Brushes.Black, new Point(footerx + 180, pos + footery));

            footery = footery + 20;

            e.Graphics.DrawString("Grand Total: ", font, Brushes.Black, new Point(footerx, pos + footery));
            e.Graphics.DrawString("GHS " + txtGrandTotal.Text, regular, Brushes.Black, new Point(footerx + 180, pos + footery));

            footery = footery + 30;

            e.Graphics.DrawString("******************************************************", font, Brushes.Black, new Point(0, pos + footery));

            footery = footery + 20;

            e.Graphics.DrawString("Thank you for visiting", font, Brushes.Black, new Point(80, pos + footery));
            //pos = 100;

            footery = footery + 20;

            e.Graphics.DrawString("Software by Cluster I.T. Solutions - 0242024796", small, Brushes.Black, new Point(10, pos + footery));
            pos = 120;

        }

        #endregion

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            
        }

        private void comboSearchFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchByCategory();
        }
    }
}
