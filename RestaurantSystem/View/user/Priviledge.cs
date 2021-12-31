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
    public partial class Priviledge : KryptonForm
    {

        Permissions permit = new Permissions();

        public Priviledge()
        {
            InitializeComponent();

            getRadioValues();
        }


        public void getRadioValues()
        {
            #region AdminDashboard
            if (Properties.Settings.Default.Users == true)
            {
                chkBoxUser.Checked = true;
            } else
            {
                chkBoxUser.Checked = false;
            }

            if (Properties.Settings.Default.Category == true)
            {
                chkBoxCat.Checked = true;
            }
            else
            {
                chkBoxCat.Checked = false;
            }

            if (Properties.Settings.Default.Product == true)
            {
                chkBoxPrd.Checked = true;
            }
            else
            {
                chkBoxPrd.Checked = false;
            }

            if (Properties.Settings.Default.Order == true)
            {
                chkBoxOrd.Checked = true;
            }
            else
            {
                chkBoxOrd.Checked = false;
            }

            #endregion

            #region Users
            if (Properties.Settings.Default.AddUsers == true)
            {
                chkBoxUserCreate.Checked = true;
            }
            else
            {
                chkBoxUserCreate.Checked = false;
            }

            if (Properties.Settings.Default.MagUsers == true)
            {
                chkBoxUserMag.Checked = true;
            }
            else
            {
                chkBoxUserMag.Checked = false;
            }

            if (Properties.Settings.Default.UpdateUsers == true)
            {
                chkBoxUserUpdate.Checked = true;
            }
            else
            {
                chkBoxUserUpdate.Checked = false;
            }

            if (Properties.Settings.Default.DeleteUsers == true)
            {
                chkBoxUserDelete.Checked = true;
            }
            else
            {
                chkBoxUserDelete.Checked = false;
            }
            #endregion

            #region Category
            if (Properties.Settings.Default.AddCategory == true)
            {
                chkBoxCatCreate.Checked = true;
            }
            else
            {
                chkBoxCatCreate.Checked = false;
            }

            if (Properties.Settings.Default.MagCategory == true)
            {
                chkBoxCatMag.Checked = true;
            }
            else
            {
                chkBoxCatMag.Checked = false;
            }

            if (Properties.Settings.Default.UpdateCategory == true)
            {
                chkBoxCatUpdate.Checked = true;
            }
            else
            {
                chkBoxCatUpdate.Checked = false;
            }

            if (Properties.Settings.Default.DeleteCategory == true)
            {
                chkBoxCatDelete.Checked = true;
            }
            else
            {
                chkBoxCatDelete.Checked = false;
            }
            #endregion

            #region Order
            if (Properties.Settings.Default.AddOrder == true)
            {
                chkBoxOrdCreate.Checked = true;
            }
            else
            {
                chkBoxOrdCreate.Checked = false;
            }

            if (Properties.Settings.Default.MagOrder == true)
            {
                chkBoxOrdMag.Checked = true;
            }
            else
            {
                chkBoxOrdMag.Checked = false;
            }

            if (Properties.Settings.Default.DeleteOrder == true)
            {
                chkBoxOrdDelete.Checked = true;
            }
            else
            {
                chkBoxOrdDelete.Checked = false;
            }
            #endregion

            #region Product
            if (Properties.Settings.Default.AddProduct == true)
            {
                chkBoxPrdCreate.Checked = true;
            }
            else
            {
                chkBoxPrdCreate.Checked = false;
            }

            if (Properties.Settings.Default.MagProduct == true)
            {
                chkBoxPrdMag.Checked = true;
            }
            else
            {
                chkBoxPrdMag.Checked = false;
            }

            if (Properties.Settings.Default.UpdateProduct == true)
            {
                chkBoxPrdUpdate.Checked = true;
            }
            else
            {
                chkBoxPrdUpdate.Checked = false;
            }

            if (Properties.Settings.Default.DeleteProduct == true)
            {
                chkBoxPrdDelete.Checked = true;
            }
            else
            {
                chkBoxPrdDelete.Checked = false;
            }
            #endregion

        }


        public void saveDefault()
        {

            //check if the various checkbox is checked and give the corresponded value
            #region AdminDashboard
            if (chkBoxUser.Checked)
            {
                Properties.Settings.Default.Users = true;
            } else
            {
                Properties.Settings.Default.Users = false;
            }

            if (chkBoxCat.Checked)
            {
                Properties.Settings.Default.Category = true;
            }
            else
            {
                Properties.Settings.Default.Category = false;
            }

            if (chkBoxPrd.Checked)
            {
                Properties.Settings.Default.Product = true;
            }
            else
            {
                Properties.Settings.Default.Product = false;
            }

            
            if (chkBoxOrd.Checked)
            {
                Properties.Settings.Default.Order = true;
            }
            else
            {
                Properties.Settings.Default.Order = false;
            }

            #endregion

            #region Users
            if (chkBoxUserCreate.Checked)
            {
                Properties.Settings.Default.AddUsers = true;
            }
            else
            {
                Properties.Settings.Default.AddUsers = false;
            }

            if (chkBoxUserMag.Checked)
            {
                Properties.Settings.Default.MagUsers = true;
            }
            else
            {
                Properties.Settings.Default.MagUsers = false;
            }

            if (chkBoxUserUpdate.Checked)
            {
                Properties.Settings.Default.UpdateUsers = true;
            }
            else
            {
                Properties.Settings.Default.UpdateUsers = false;
            }

            if (chkBoxUserDelete.Checked)
            {
                Properties.Settings.Default.DeleteUsers = true;
            }
            else
            {
                Properties.Settings.Default.DeleteUsers = false;
            }
            #endregion

            #region Category
            if (chkBoxCatCreate.Checked)
            {
                Properties.Settings.Default.AddCategory = true;
            }
            else
            {
                Properties.Settings.Default.AddCategory = false;
            }

            if (chkBoxCatMag.Checked)
            {
                Properties.Settings.Default.MagCategory = true;
            }
            else
            {
                Properties.Settings.Default.MagCategory = false;
            }

            if (chkBoxCatUpdate.Checked)
            {
                Properties.Settings.Default.UpdateCategory = true;
            }
            else
            {
                Properties.Settings.Default.UpdateCategory = false;
            }

            if (chkBoxCatDelete.Checked)
            {
                Properties.Settings.Default.DeleteCategory = true;
            }
            else
            {
                Properties.Settings.Default.DeleteCategory = false;
            }
            #endregion

            #region Order

            if (chkBoxOrdCreate.Checked)
            {
                Properties.Settings.Default.AddOrder = true;
            }
            else
            {
                Properties.Settings.Default.AddOrder = false;
            }

            if (chkBoxOrdMag.Checked)
            {
                Properties.Settings.Default.MagOrder = true;
            }
            else
            {
                Properties.Settings.Default.MagOrder = false;
            }

            if (chkBoxOrdDelete.Checked)
            {
                Properties.Settings.Default.DeleteOrder = true;
            }
            else
            {
                Properties.Settings.Default.DeleteOrder = false;
            }

            #endregion

            #region Product
            if (chkBoxPrdCreate.Checked)
            {
                Properties.Settings.Default.AddProduct = true;
            }
            else
            {
                Properties.Settings.Default.AddProduct = false;
            }

            if (chkBoxPrdMag.Checked)
            {
                Properties.Settings.Default.MagProduct = true;
            }
            else
            {
                Properties.Settings.Default.MagProduct = false;
            }

            if (chkBoxPrdUpdate.Checked)
            {
                Properties.Settings.Default.UpdateProduct = true;
            }
            else
            {
                Properties.Settings.Default.UpdateProduct = false;
            }

            if (chkBoxPrdDelete.Checked)
            {
                Properties.Settings.Default.DeleteProduct = true;
            }
            else
            {
                Properties.Settings.Default.DeleteProduct = false;
            }
            #endregion

            Properties.Settings.Default.Save();
            MessageBox.Show("Priviledge Saved");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            saveDefault();
        }

        
    }
}
