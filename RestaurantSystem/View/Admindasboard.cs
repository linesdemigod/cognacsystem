using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using MaterialSkin;
using MaterialSkin.Controls;
using RestaurantSystem.Controller;
using RestaurantSystem.View.user;

namespace RestaurantSystem.View
{
    public partial class Admindasboard : KryptonForm
    {
        Dashboard dasboard = new Dashboard();

        public Admindasboard()
        {
            InitializeComponent();
            
        }

        private void Admindasboard_Load(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized; //Maximized

            //initialize the submenu function
            customizedDesign();
            getProducts();
            getUsers();
            getCategories();

            setupUserAccess();

        }

        //Function to check the user login and also the check the permission he has
        public void setupUserAccess()
        {
            //instances of the permission class
            Permissions permit = new Permissions();

            int userLoggedInRole = Convert.ToInt32(Form1.Login_role); //store role as integer

            permit.getDashboardPriviledge(); //call the method in the permission class

            switch (userLoggedInRole)
            {
                case 2:
                    btnUser.Visible = permit.Users;
                    btnProduct.Visible = permit.Product;
                    btnCategory.Visible = permit.Category;
                    btnOrder.Visible = permit.Order;
                    btnAddUser.Visible = permit.AddUsers;
                    btnAddProduct.Visible = permit.AddProduct;
                    btnAddOrder.Visible = permit.AddOrder;
                    button4.Visible = permit.AddCategory;
                    btnManageUser.Visible = permit.MagUsers;
                    btnManageProduct.Visible = permit.MagProduct;
                    btnMagOrder.Visible = permit.MagOrder;
                    button3.Visible = permit.MagCategory;

                    btnPermissions.Visible = false;
                    break;
                 default:
                    btnOrder.Visible = true;
                     break;
            }

        }

        //HIDE SUBMENU WHEN THE PROGRAM STARTS
        private void customizedDesign()
        {
            panelUserMenu.Visible = false;
            panelCateMenu.Visible = false;
            panelProMenu.Visible = false;
            panelReportMenu.Visible = false;
            panelOrderMenu.Visible = false;
        }


        //FUNCTION TO HIDE THE SUBMENU
        private void hideSubmenu()
        {
            if (panelUserMenu.Visible == true)
            {
                panelUserMenu.Visible = false;
            }

            if (panelCateMenu.Visible == true)
            {
                panelCateMenu.Visible = false;
            }

            if (panelProMenu.Visible == true)
            {
                panelProMenu.Visible = false;
            }

            if (panelReportMenu.Visible == true)
            {
                panelReportMenu.Visible = false;
            }

            if (panelOrderMenu.Visible == true)
            {
                panelOrderMenu.Visible = false;
            }


        }

        //FUNCTION TO SHOW THE SUBMENU
        private void showSubmenu(Panel menu)
        {
            if (menu.Visible == false)
            {
                hideSubmenu();
                menu.Visible = true;
            }
            else
            {
                menu.Visible = false;
            }
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            showSubmenu(panelUserMenu);
        }

        #region UserSubmenu
        private void btnAddUser_Click(object sender, EventArgs e)
        {
             Adduser user = new Adduser();
            //user.ShowDialog();
            user.TopLevel = false;
            //this.WindowState = FormWindowState.Maximized;
            user.FormBorderStyle = FormBorderStyle.None;
            user.Dock = DockStyle.Fill;
            panelMain.Controls.Add(user);
            panelMain.Tag = user;
            user.BringToFront();
            user.Show();
            
            hideSubmenu();
        }

        private void btnManageUser_Click(object sender, EventArgs e)
        {
            Manageuser user = new Manageuser();
            //user.ShowDialog();
            
           user.TopLevel = false;
           //this.WindowState = FormWindowState.Maximized;
           user.FormBorderStyle = FormBorderStyle.None;
           user.Dock = DockStyle.Fill;
           panelMain.Controls.Add(user);
           panelMain.Tag = user;
           user.BringToFront();
           user.Show();
           
            hideSubmenu(); 
       }
       #endregion UserSubmenu

       private void btnCategory_Click(object sender, EventArgs e)
       {
           showSubmenu(panelCateMenu);
       }

       #region CategorySubmenu
       private void button4_Click(object sender, EventArgs e)
       {
           Addcategory user = new Addcategory();
           // user.ShowDialog();
            
           user.TopLevel = false;
           //this.WindowState = FormWindowState.Maximized;
           user.FormBorderStyle = FormBorderStyle.None;
           user.Dock = DockStyle.Fill;
           panelMain.Controls.Add(user);
           panelMain.Tag = user;
           user.BringToFront();
           user.Show();
           
            hideSubmenu(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Managecategory user = new Managecategory();
            //user.ShowDialog();
            
            user.TopLevel = false;
            //this.WindowState = FormWindowState.Maximized;
            user.FormBorderStyle = FormBorderStyle.None;
            user.Dock = DockStyle.Fill;
            panelMain.Controls.Add(user);
            panelMain.Tag = user;
            user.BringToFront();
            user.Show();
            
            hideSubmenu();
        }

        #endregion CategorySubmenu

        private void btnProduct_Click(object sender, EventArgs e)
        {
            showSubmenu(panelProMenu);
        }

        #region ProductSubmenu
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Addproduct user = new Addproduct();
           // user.ShowDialog();
            
           user.TopLevel = false;
           //this.WindowState = FormWindowState.Maximized;
           user.FormBorderStyle = FormBorderStyle.None;
           user.Dock = DockStyle.Fill;
           panelMain.Controls.Add(user);
           panelMain.Tag = user;
           user.BringToFront();
           user.Show();
           
            hideSubmenu(); 
       }

       private void btnManageProduct_Click(object sender, EventArgs e)
       {
           Manageproduct user = new Manageproduct();
           // user.ShowDialog();
            
          user.TopLevel = false;
          //this.WindowState = FormWindowState.Maximized;
          user.FormBorderStyle = FormBorderStyle.None;
          user.Dock = DockStyle.Fill;
          panelMain.Controls.Add(user);
          panelMain.Tag = user;
          user.BringToFront();
          user.Show();
          
            hideSubmenu(); 
       }

       #endregion ProductSubmenu

      private void btnReport_Click(object sender, EventArgs e)
       {

            showSubmenu(panelReportMenu);
       }

       #region ReportSubMenu
       private void btnProductWise_Click(object sender, EventArgs e)
       {
            Productreport user = new Productreport();
            //user.ShowDialog();
            
            user.TopLevel = false;
            //this.WindowState = FormWindowState.Maximized;
            user.FormBorderStyle = FormBorderStyle.None;
            user.Dock = DockStyle.Fill;
            panelMain.Controls.Add(user);
            panelMain.Tag = user;
            user.BringToFront();
            user.Show();
            
            hideSubmenu();
        }

        private void btnTotalWise_Click(object sender, EventArgs e)
        {
            Totalreport user = new Totalreport();
            //user.ShowDialog();
            
            user.TopLevel = false;
            //this.WindowState = FormWindowState.Maximized;
            user.FormBorderStyle = FormBorderStyle.None;
            user.Dock = DockStyle.Fill;
            panelMain.Controls.Add(user);
            panelMain.Tag = user;
            user.BringToFront();
            user.Show();
            
            hideSubmenu(); 
        }
        #endregion
        private void btnOrder_Click(object sender, EventArgs e)
        {
            showSubmenu(panelOrderMenu);
        }
        #region Order Menu
        private void btnAddOrder_Click(object sender, EventArgs e)
        {

            Order user = new Order();
            //user.ShowDialog();
            
            user.TopLevel = false;
            //this.WindowState = FormWindowState.Maximized;
            user.FormBorderStyle = FormBorderStyle.None;
            user.Dock = DockStyle.Fill;
            panelMain.Controls.Add(user);
            panelMain.Tag = user;
            user.BringToFront();
            user.Show();
            
            hideSubmenu(); 
        }

        private void btnMagOrder_Click(object sender, EventArgs e)
        {

            Manageorder user = new Manageorder();
            //user.ShowDialog();
            
            user.TopLevel = false;
            //this.WindowState = FormWindowState.Maximized;
            user.FormBorderStyle = FormBorderStyle.None;
            user.Dock = DockStyle.Fill;
            panelMain.Controls.Add(user);
            panelMain.Tag = user;
            user.BringToFront();
            user.Show();
            
            hideSubmenu(); 
        }

        #endregion
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to logout? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                Form1 form = new Form1();
                form.Show();
                this.Hide();

            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {

            Profile user = new Profile();
            //user.ShowDialog();
            
            user.TopLevel = false;
            //this.WindowState = FormWindowState.Maximized;
            user.FormBorderStyle = FormBorderStyle.None;
            user.Dock = DockStyle.Fill;
            panelMain.Controls.Add(user);
            panelMain.Tag = user;
            user.BringToFront();
            user.Show();

            
            hideSubmenu(); 
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            Backup user = new Backup();
            user.ShowDialog();
            hideSubmenu();
        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            Company user = new Company();
           // user.ShowDialog();
            
            user.TopLevel = false;
            //this.WindowState = FormWindowState.Maximized;
            user.FormBorderStyle = FormBorderStyle.None;
            user.Dock = DockStyle.Fill;
            panelMain.Controls.Add(user);
            panelMain.Tag = user;
            user.BringToFront();
            user.Show();
            
            hideSubmenu(); 
        }


        private void btnPermissions_Click(object sender, EventArgs e)
        {
           Priviledge user = new Priviledge();
            //user.ShowDialog();
            
            user.TopLevel = false;
            //this.WindowState = FormWindowState.Maximized;
            user.FormBorderStyle = FormBorderStyle.None;
            user.Dock = DockStyle.Fill;
            panelMain.Controls.Add(user);
            panelMain.Tag = user;
            user.BringToFront();
            user.Show();
            
            hideSubmenu(); 
        }

        public void getProducts()
        {
            dasboard.getProduct();
            lblProduct.Text = dasboard.id;
            
        }

        public void getUsers()
        {
            dasboard.getUser();
            lblUsers.Text = dasboard.users;
        }

        public void getCategories()
        {
            dasboard.getCategory();
            lblCategory.Text = dasboard.category;
        }
    }
}
