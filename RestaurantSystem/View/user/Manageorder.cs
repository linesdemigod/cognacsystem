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
    public partial class Manageorder : KryptonForm
    {

        ManageOrder order = new ManageOrder();
        Orders restore = new Orders();

        public Manageorder()
        {
            InitializeComponent();
        }


        private void Manageorder_Load(object sender, EventArgs e)
        {
            getOrders();

            getOrdersData();

            getTempcartData();

            setupUserAccess();

            //hide the print when form loads
            dataGridViewOrder.Columns["Print"].Visible = false;
        }

        private void tabManageOrder_Click(object sender, EventArgs e)
        {
            
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
                    dataGridViewOrders.Columns["DeleteColumn"].Visible = permit.DeleteOrder;

                    break;
                default:

                    break;
            }

        }

        //method to put the data to the gridviewdata
        public void getOrders()
        {
            order.getFullOrder();
            dataGridViewOrder.DataSource = order.dat;
        }


        //method to put the data to the gridviewdata
        public void getOrdersData()
        {
            order.getOrder();

            dataGridViewOrders.DataSource = order.dt;
        }


        //method to put the data to the gridviewdata
        public void getTempcartData()
        {
            order.getTempCart();

            dataGridViewTempCart.DataSource = order.datt;
        }



        //method to the filter the product based on the value entered in the textbox
        #region Search
        public void search()
        {
            try
            {
                DataView dv = order.dat.DefaultView;
                dv.RowFilter = string.Format("ord_bill_number LIKE '%" + txtBillNumber.Text.Trim() + "'");
                dataGridViewOrder.DataSource = dv.ToTable();
            }
            catch (Exception)
            {

                MessageBox.Show("Something went Wrong");
            }

        }
        #endregion

        //search event handler
        private void txtBillNumber_TextChanged(object sender, EventArgs e)
        {
            search();

            //check if search textbox is empty and make print on datagrid invisible
            if (txtBillNumber.Text == "")
            {
                dataGridViewOrder.Columns["Print"].Visible = false;

                return;
            }

            //makes print on datagrid visible when there is a value in the textbox
            dataGridViewOrder.Columns["Print"].Visible = true;

        }


        //the print function
        #region print
        public void printData()
        {

            try
            {
                int datagrid = dataGridViewOrder.Rows.Count;
                if (datagrid > 0 && datagrid <= 5)
                {
                    printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
                    printDocument1.PrinterSettings.Copies = 2;
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
            try
            {
                //company info
                CompanyInfo info = new CompanyInfo();
                info.getCompany();
                Orders order = new Orders();
                order.getTaxValue();
                //set vat percentage
                double dbVat = Convert.ToDouble(order.dbVat);

                DateTime now = DateTime.Now;
                int fontSize = 10;
                Font regular = new Font("Courierr New", fontSize, FontStyle.Regular);
                Font font = new Font("Courierr New", 10, FontStyle.Bold);
                Font small = new Font("Courierr New", 8, FontStyle.Regular);

                float fontheight = font.GetHeight();
                int startx = 40;
                int starty = 40;
                int footerx = 5;
                int footery = 30;
                int pos = 160;
                double productQty, product_price, productTotal;

                string product_name;

               
                e.Graphics.DrawString(info.company, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, new Point(startx, 0));

                e.Graphics.DrawString(info.address, regular, Brushes.Black, new Point(100, 20));
                e.Graphics.DrawString(info.phone, regular, Brushes.Black, new Point(100, starty));

                starty = starty + 20;

                e.Graphics.DrawString("Date: ", font, Brushes.Black, new Point(5, starty));
                e.Graphics.DrawString(now.ToString(), regular, Brushes.Black, new Point(70, starty));

                starty = starty + 20;

                e.Graphics.DrawString("Invoice No.: ", font, Brushes.Black, new Point(5, starty));
                e.Graphics.DrawString(dataGridViewOrder.Rows[0].Cells["ID"].Value.ToString(), regular, Brushes.Black, new Point(100, starty));

                starty = starty + 20;

                e.Graphics.DrawString("Cashier: ", font, Brushes.Black, new Point(5, starty));
                e.Graphics.DrawString(Form1.Login_fname + " " + Form1.Login_lname, regular, Brushes.Black, new Point(100, starty));

                starty = starty + 20;

                e.Graphics.DrawString("**************************************************", font, Brushes.Black, new Point(1, starty));

                starty = starty + 20;

                e.Graphics.DrawString("PRODUCT", font, Brushes.Black, new Point(5, starty));
                e.Graphics.DrawString("QTY", font, Brushes.Black, new Point(110, starty));
                e.Graphics.DrawString("PRICE", font, Brushes.Black, new Point(160, starty));
                e.Graphics.DrawString("TOTAL", font, Brushes.Black, new Point(225, starty));

                foreach (DataGridViewRow row in dataGridViewOrder.Rows)
                {
                    product_name = Convert.ToString(row.Cells["Product"].Value);
                    productQty = Convert.ToDouble(row.Cells["Qty"].Value);
                    product_price = Convert.ToDouble(row.Cells["Price"].Value);
                    productTotal = Convert.ToDouble(row.Cells["SubTotal"].Value);

                    //e.Graphics.DrawString(productID.ToString(), new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(26, pos));
                    e.Graphics.DrawString(product_name.ToString(), regular, Brushes.Black, new Point(5, pos));
                    e.Graphics.DrawString(productQty.ToString(), regular, Brushes.Black, new Point(110, pos));
                    e.Graphics.DrawString(product_price.ToString(), regular, Brushes.Black, new Point(160, pos));
                    e.Graphics.DrawString(productTotal.ToString(), regular, Brushes.Black, new Point(225, pos));

                    pos = pos + 20;
                }


                e.Graphics.DrawString("******************************************************", font, Brushes.Black, new Point(0, pos + footery));

                footery = footery + 30;

                e.Graphics.DrawString("SubTotal: ", font, Brushes.Black, new Point(footerx, pos + footery));
                e.Graphics.DrawString("GHS " + dataGridViewOrder.Rows[0].Cells["Gross"].Value.ToString(), regular, Brushes.Black, new Point(footerx + 180, pos + footery));

                footery = footery + 20;

                e.Graphics.DrawString("Discount: ", font, Brushes.Black, new Point(footerx, pos + footery));
                e.Graphics.DrawString("GHS " + dataGridViewOrder.Rows[0].Cells["Discount"].Value.ToString(), regular, Brushes.Black, new Point(footerx + 180, pos + footery));

                footery = footery + 20;

                e.Graphics.DrawString("VAT(" + order.dbVat + "%): ", font, Brushes.Black, new Point(footerx, pos + footery));
                e.Graphics.DrawString("GHS " + dataGridViewOrder.Rows[0].Cells["Vat"].Value.ToString(), regular, Brushes.Black, new Point(footerx + 180, pos + footery));

                footery = footery + 20;

                e.Graphics.DrawString("Grand Total: ", font, Brushes.Black, new Point(footerx, pos + footery));
                e.Graphics.DrawString("GHS " + dataGridViewOrder.Rows[0].Cells["Net"].Value.ToString(), regular, Brushes.Black, new Point(footerx + 180, pos + footery));


                footery = footery + 30;

                e.Graphics.DrawString("******************************************************", font, Brushes.Black, new Point(0, pos + footery));

                footery = footery + 20;

                e.Graphics.DrawString("Thank you for visiting", font, Brushes.Black, new Point(80, pos + footery));
                //pos = 100;

                footery = footery + 20;

                e.Graphics.DrawString("Software by Cluster I.T. Solutions - 0242024796", small, Brushes.Black, new Point(10, pos + footery));
                pos = 120;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        #endregion

        private void dataGridViewOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == -1) return;

                //code for the update
                if (dataGridViewOrder.Columns[e.ColumnIndex].HeaderText == "Action")
                {
                    printData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //handle the view data delete
        private void dataGridViewOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == -1) return;

                //code the delete
                if (dataGridViewOrders.Columns[e.ColumnIndex].HeaderText == "Action")
                {
                    DialogResult confirm = MessageBox.Show("Are you sure you want to delete? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirm == DialogResult.Yes)
                    {


                        string id;
                        id = Convert.ToString(dataGridViewOrders.Rows[e.RowIndex].Cells["BillColumn"].Value);
                        order.id = id;

                        if (order.id == id)
                        {
                            //call the deleteUser method in the manageuser class
                            order.deleteOrder();
                            MessageBox.Show("Bill deleted");

                        }


                        getOrdersData();

                    }
                    }
                }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        

        //method to the filter the product based on the value entered in the textbox
        #region Search
        public void searchOrderBill()
        {
            try
            {
                DataView dv = order.dt.DefaultView;
                dv.RowFilter = string.Format("ord_bill_number LIKE '%" + txtSearchBillNumber.Text.Trim() + "'");
                dataGridViewOrders.DataSource = dv.ToTable();
            }
            catch (Exception)
            {

                MessageBox.Show("Something went Wrong");
            }

        }
        #endregion

        private void txtSearchBillNumber_TextChanged(object sender, EventArgs e)
        {
            searchOrderBill();
        }

        private void dataGridViewTempCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == -1) return;

                //code the delete
                if (dataGridViewTempCart.Columns[e.ColumnIndex].HeaderText == "Action")
                {
                    DialogResult confirm = MessageBox.Show("Are you sure you want to Restore? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirm == DialogResult.Yes)
                    {
                        string id = Convert.ToString(dataGridViewTempCart.Rows[e.RowIndex].Cells["TempID"].Value);
                        string uniqueId = Convert.ToString(dataGridViewTempCart.Rows[e.RowIndex].Cells["UniqueID"].Value);

                        restore.uniqueId = uniqueId;
                        restore.id = id;
                        if (restore.id == id)
                        {
                            restore.id = Convert.ToString(dataGridViewTempCart.Rows[e.RowIndex].Cells["ProductID"].Value);
                            restore.stock = Convert.ToString(dataGridViewTempCart.Rows[e.RowIndex].Cells["Quantity"].Value);
                            restore.increaseStock();

                            if (restore.uniqueId == uniqueId)
                            {
                                //delete from temp cart
                                restore.deleteFromTempCart();
                                MessageBox.Show("Stock Restored");
                            }
                        }

                        getTempcartData();

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
