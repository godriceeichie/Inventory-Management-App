using Inventory_Management_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_App.Session
{
    public class UserManager
    {
        private static User currentUser;
        public static User CurrentUser
        {
            get { return currentUser; }
            set { currentUser = value; }

        }
    }
}
