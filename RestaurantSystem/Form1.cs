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
using RestaurantSystem.Controller;
using RestaurantSystem.View;

namespace RestaurantSystem
{
    public partial class Form1 : KryptonForm
    {
        // Instance of the class
        Login user = new Login();

        //transfer to another form
        public static string Login_username { get; set; }
        public static string L_role { get; set; }
        public static string Login_phone { get; set; }
        public static string Login_gender { get; set; }
        public static string Login_fname { get; set; }
        public static string Login_lname { get; set; }
        public static string Login_role { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            try
            {
                //ASSIGN THE VARIABLE TO THE USER INPUT
                user.username = txtUser.Text.Trim();
                user.password = txtPass.Text.Trim();
                bool verify = user.user_verification();

                //Validate if the textbox is empty
                if (user.username == "" || user.password == "")
                {

                    MessageBox.Show("Fill all field");
                }
                else
                {

                    if (verify)
                    {
                        //MessageBox.Show("Successfully login");
                        int role = user.role;
                        Login_role = user.role.ToString();
                        Login_username = user.username;
                        Login_fname = user.fname;
                        Login_lname = user.lname;
                        Login_phone = user.phone;
                        Login_gender = user.gender;

                        #region login logic
                        /*if (role == 1)
                        {
                            Admindasboard admindash = new Admindasboard();
                            admindash.Show();
                            this.Hide();
                            L_role = "Super Admin";
                        }
                        else if (role == 2)
                        {
                            Admindasboard manager = new Admindasboard();
                            manager.Show();
                            this.Hide();
                            L_role = "Manager";
                        }
                        else if (role == 3)
                        {
                            Waiterdashboard waiter = new Waiterdashboard();
                            waiter.Show();
                            this.Hide();
                            L_role = "Cashier";
                        } */
                        #endregion
                        Loadingbar load = new Loadingbar();
                        load.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Username or Password is incorrect");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Connection error");
            }
        }

        private void txtPass_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }

        private void chkBoxSHowPassword_CheckedChanged(object sender, EventArgs e)
        {
            showHidePassword();
        }

        private void showHidePassword()
        {
            if (chkBoxSHowPassword.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
                txtPass.PasswordChar = '\0';
                chkBoxSHowPassword.Text = "Hide Password";
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
                chkBoxSHowPassword.Text = "Show Password";
            }
        }
    }
}
