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
    public partial class Totalreport : KryptonForm
    {
        TotalReport report = new TotalReport();
        Dashboard dash = new Dashboard();

        public Totalreport()
        {
            InitializeComponent();
        }

        private void Totalreport_Load(object sender, EventArgs e)
        {
            totalSales();

            getStaffReport();

            getCategory();

            getProduct();
        }
       


        private void totalSales()
        {
            try
            {
                //get the total report
                report.getTotalSalesReport();
                lblTotalSales.Text = Convert.ToString(String.Format("₵ {0:n}", report.totalSales));

                //get the daily sales
                report.getDailySalesReport();
                lblDailySales.Text = String.Format("₵ {0:n}", report.dailySales);

                //get the weekly sales
                report.getWeeklySalesReport();
                lblWeeklySales.Text = String.Format("₵ {0:n}", report.weeklySales);

                //get the monthly sales
                report.getMonthlySalesReport();
                lblMonthlySales.Text = String.Format("₵ {0:n}", report.monthlySales);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
                
            
           
        }

        private void getStaffReport()
        {
            try
            {
                //total number of users
                dash.getUser();
                lblStaff.Text = dash.users;

                double hours = 0.0002777778;
                double staff = Convert.ToDouble(dash.users);

                //avg hours
                report.getAvgHourReport();
                double result = Convert.ToDouble(report.avgHour) * hours / staff;
                lblStaffHour.Text = Math.Ceiling(result).ToString();

                //avg sales
                report.getAvgSalesReport();
                double avgSales = Convert.ToDouble(report.avgSales);
                double avgResult = avgSales / staff;
                lblStaffSales.Text = Math.Ceiling(avgResult).ToString();
            }
            catch (Exception)
            {

               
            }
            
        }

        private void getCategory()
        {
            try
            {
                dash.getCategory();
                lblCategories.Text = dash.category;
            }
            catch (Exception)
            {

                
            }
            
        }
       

        private void getProduct()
        {
            try
            {
                //get the total sales
                dash.getProduct();
                lblItemTotal.Text = dash.id;

                //get the total day report
                report.getDayItemTotalReport();
                lblItemDaySold.Text = report.totalItemDay;

                //get the total item sold
                report.getItemTotalReport();
                lblItemSoldTotal.Text = report.totalItemSold;
            }
            catch (Exception)
            {
                

            }
           
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            Salesreportgraph report = new Salesreportgraph();
            report.ShowDialog();
        }
    }
}
