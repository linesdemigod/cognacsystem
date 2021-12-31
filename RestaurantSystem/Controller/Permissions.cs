using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Controller
{
    class Permissions
    {
        public bool Users { get; set; }
        public bool AddUsers { get; set; }
        public bool MagUsers { get; set; }
        public bool DeleteUsers { get; set; }
        public bool UpdateUsers { get; set; }
        public bool Category { get; set; }
        public bool AddCategory { get; set; }
        public bool MagCategory { get; set; }
        public bool DeleteCategory { get; set; }
        public bool UpdateCategory { get; set; }
        public bool Order { get; set; }
        public bool AddOrder { get; set; }
        public bool MagOrder { get; set; }
        public bool DeleteOrder { get; set; }
        public bool Product { get; set; }
        public bool AddProduct { get; set; }
        public bool MagProduct { get; set; }
        public bool DeleteProduct { get; set; }
        public bool UpdateProduct { get; set; }

        public void getDashboardPriviledge()
        {
           Users = Properties.Settings.Default.Users;
           AddUsers = Properties.Settings.Default.AddUsers;
           MagUsers = Properties.Settings.Default.MagUsers ;
           DeleteUsers = Properties.Settings.Default.DeleteUsers ;
           UpdateUsers = Properties.Settings.Default.UpdateUsers ;
           Category = Properties.Settings.Default.Category ;
           AddCategory = Properties.Settings.Default.AddCategory ;
           MagCategory = Properties.Settings.Default.MagCategory ;
           DeleteCategory = Properties.Settings.Default.DeleteCategory ;
           UpdateCategory = Properties.Settings.Default.UpdateCategory ;
           Order = Properties.Settings.Default.Order ;
           AddOrder = Properties.Settings.Default.AddOrder ;
           MagOrder = Properties.Settings.Default.MagOrder ;
           DeleteOrder = Properties.Settings.Default.DeleteOrder ;
           Product = Properties.Settings.Default.Product ;
           AddProduct = Properties.Settings.Default.AddProduct ;
           MagProduct = Properties.Settings.Default.MagProduct ;
           DeleteProduct = Properties.Settings.Default.DeleteProduct ;
           UpdateProduct = Properties.Settings.Default.UpdateProduct ;

        }
    }
}
