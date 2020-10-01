using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program.Classes
{
    class DatabaseHandler
    {
        // SQL Connection object
        public SqlConnection database;

        // SQL Connection string
        private string SQlConnection = "Server=.; Initial Catalog= air-sim; Integrated Security=SSPI";

        public DatabaseHandler()
        {
            try
            {
                // Initiate the database object
                database = new SqlConnection(SQlConnection);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while initiating the database. Error: " + e.Message,
                    "Database initialization error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
