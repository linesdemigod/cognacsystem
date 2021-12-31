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

namespace RestaurantSystem.View.waiter
{
    public partial class Manageorder : KryptonForm
    {

        ManageOrder order = new ManageOrder();
        public Manageorder()
        {
            InitializeComponent();

           
        }

        private void Manageorder_Load(object sender, EventArgs e)
        {
            getOrders();

            //hide the print when form loads
            dataGridViewOrder.Columns["Print"].Visible = false;
            
        }

        //method to put the data to the gridviewdata
        public void getOrders()
        {

            order.getFullOrder();
            dataGridViewOrder.DataSource = order.dat;
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
                Orders order = new Orders();
                order.getTaxValue();
                //set vat percentage
                double dbVat = Convert.ToDouble(order.dbVat);

                    DateTime now = DateTime.Now;
                int fontSize = 10;
                Font regular = new Font("Courierr New", fontSize, FontStyle.Regular);
                Font font = new Font("Courierr New", 10, FontStyle.Bold);

                float fontheight = font.GetHeight();
                int startx = 40;
                int starty = 40;
                int footerx = 5;
                int footery = 30;
                int pos = 160;
                double productQty, product_price, productTotal;

                string product_name;


                e.Graphics.DrawString("Banks Cognac Restaurant", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, new Point(startx, 0));

                e.Graphics.DrawString("P.O. Box 66", regular, Brushes.Black, new Point(100, 20));
                e.Graphics.DrawString("024554444 ", regular, Brushes.Black, new Point(100, starty));

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

                e.Graphics.DrawString("SubTotal: " , font, Brushes.Black, new Point(footerx, pos + footery));
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

                e.Graphics.DrawString("******************************************************", font, Brushes.Black, new Point   (0, pos + footery));

                footery = footery + 20;

                e.Graphics.DrawString("Thank you for visiting", font, Brushes.Black, new Point(80, pos + footery));
                 pos = 100;

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
    }
}
