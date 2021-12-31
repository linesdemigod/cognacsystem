using ComponentFactory.Krypton.Toolkit;
using RestaurantSystem.View.waiter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem.View
{
    public partial class Waiterdashboard : KryptonForm
    {
        public Waiterdashboard()
        {
            InitializeComponent();
            
        }


        private void Waiterdashboard_Load(object sender, EventArgs e)
        {
            //Maximized
            this.WindowState = FormWindowState.Maximized;

            //initialize the submenu function
            customizedDesign();

            lblName.Text = Form1.Login_lname;
        }

        //HIDE SUBMENU WHEN THE PROGRAM STARTS
        private void customizedDesign()
        {
            panelCateMenu.Visible = false;
            panelProMenu.Visible = false;
        }

        //FUNCTION TO HIDE THE SUBMENU
        private void hideSubmenu()
        {

            if (panelCateMenu.Visible == true)
            {
                panelCateMenu.Visible = false;
            }

            if (panelProMenu.Visible == true)
            {
                panelProMenu.Visible = false;
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

        private void btnCategory_Click(object sender, EventArgs e)
        {
            showSubmenu(panelCateMenu);
        }

        #region CategorySubmenu
        private void button4_Click(object sender, EventArgs e)
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
            
            //user.ShowDialog();
            hideSubmenu(); 
        }

        private void button3_Click(object sender, EventArgs e)
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

        #endregion CategorySubmenu

        private void btnProduct_Click(object sender, EventArgs e)
        {
            showSubmenu(panelProMenu);
        }

        #region ProductSubmenu
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Viewproduct user = new Viewproduct();
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

       
    }
}
