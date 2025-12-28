//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

namespace INVENTORY_MANAGEMENT_SYSTEM
{
    public partial class Session
    {

        public static int UserId { get; set; }
        public static string Username { get; set; }
        public static string Role { get; set; }

        public static void Clear()
        {
            UserId = 0;
            Username = null;
            Role = null;
        }


    }
}
