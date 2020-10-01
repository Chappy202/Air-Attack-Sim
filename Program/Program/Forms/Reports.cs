using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Program.Classes;

namespace Program.Forms
{
    public partial class frmReports : Form
    {
        private DatabaseHandler db = new DatabaseHandler();

        public frmReports()
        {
            InitializeComponent();
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            try
            {
                // Open db connection
                db.database.Open();

                // Compile query
                string query = "SELECT * FROM dbo.Log WHERE (DateandTime BETWEEN '" +
                               dtpStart.Value + "' AND '" + dtpEnd.Value + ")";

                // Add the date to the gridview
                SqlCommand cmd = new SqlCommand(query, db.database);
                SqlDataReader reader = cmd.ExecuteReader();
                BindingSource source = new BindingSource();
                source.DataSource = reader;
                dgvOutput.DataSource = source;

                // Close connections
                db.database.Close();
                reader.Close();
            }
            catch (SqlException err)
            {
                MessageBox.Show("Something went wrong with the database. Error: " + err.Message + " | LineNumber: " + err.LineNumber);
            }
        }
    }
}
