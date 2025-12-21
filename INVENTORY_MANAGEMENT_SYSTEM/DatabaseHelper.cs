using Microsoft.Data.SqlClient;

namespace InventoryManagementSystem
{
    class DatabaseHelper
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(
                @"Data Source=DESKTOP-R6ETUH2\SQLEXPRESS;Initial Catalog=InventoryDB;Integrated Security=True;TrustServerCertificate=True"
            );
        }
    }
}
