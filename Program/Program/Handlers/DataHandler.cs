using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program.Classes
{
    class DataHandler
    {
        public static int obstacles;
        private DatabaseHandler db = new DatabaseHandler();

        public DataHandler()
        {
            // Initialization code goes here
        }

        public List<Plane> GetPlanes()
        {
            List<Plane> jets = new List<Plane>();
            
            // Build the SQL query
            string query = "SELECT * FROM dbo.Planes";

            // Define SQL command and datareader
            SqlCommand cmd = new SqlCommand(query, db.database);
            SqlDataReader reader = null;

            try
            {
                db.database.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    jets.Add(new Plane(reader[0].ToString(), Convert.ToDouble(reader[1]), 0, Convert.ToDouble(reader[2]), Convert.ToDouble(reader[2]), Convert.ToInt32(reader[3]), reader[4].ToString()));
                }
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }

                if (db.database != null)
                {
                    db.database.Close();
                }
            }

            return jets;
        }

        public List<Obstacle> GetObstacle()
        {
            List<Obstacle> obstacle = new List<Obstacle>();

            // Build the SQL query
            string queryLocations = "SELECT * FROM dbo.ObstacleLocations";
            //string queryTypes = "SELECT * FROM dbo.ObstacleTypes";

            // Define the SQL commands and readers
            SqlCommand cmdLocations = new SqlCommand(queryLocations, db.database);
            //SqlCommand cmdTypes = new SqlCommand(queryTypes, db.database);

            SqlDataReader readerLocations = null;

            try
            {
                db.database.Open();
                readerLocations = cmdLocations.ExecuteReader();
                while (readerLocations.Read())
                {
                    obstacle.Add(new Obstacle(readerLocations[0].ToString(), Convert.ToInt32(readerLocations[1]), Convert.ToInt32(readerLocations[2])));
                }
            }
            finally
            {
                if (readerLocations != null)
                {
                    readerLocations.Close();
                }
                if (db.database != null)
                {
                    db.database.Close();
                }
            }

            return obstacle;
        }

        public void addObstacle(string name, int x, int y)
        {
            // Build the SQL query
            string query = "INSERT INTO dbo.ObstacleLocations VALUES(\'" + name + "\'," + x + "," + y + ")";

            // Add the obstacle to the db
            SqlCommand cmd = new SqlCommand(query, db.database);
            try
            {
                db.database.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (db.database != null)
                {
                    db.database.Close();
                }
            }
        }

        public void removeObstacle(string name)
        {
            // Build the SQl query
            string query = "DELETE FROM dbo.ObstacleLocations WHERE Name = \'" + name + "\'";

            // Remove the obstacle from the db
            SqlCommand cmd = new SqlCommand(query, db.database);
            try
            {
                db.database.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (db.database != null)
                {
                    db.database.Close();
                }
            }
        }

        public void updateLocation(string name, int x, int y)
        {
            // Build the SQL query
            string query = "UPDATE dbo.ObstacleLocations SET X = " + x + ", Y = " + y + "WHERE Name = \'" + name + "\'";

            // Update the db entry
            SqlCommand cmd = new SqlCommand(query, db.database);
            try
            {
                db.database.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (db.database != null)
                {
                    db.database.Close();
                }
            }
        }

        public string getType(string name)
        {
            string[] arr = name.Split(new[] {"-"}, StringSplitOptions.None);
            return arr[1];
        }

        public void addLog(DateTime date, double damage, double success, string targer, string start, string end, string targetname, int avoided, string reason, double fuelbefore, double fuelafter, string invbefore, string invafter)
        {
            // Build the SQL query
            // query = "INSERT INTO dbo.ObstacleLocations VALUES(\'" + name + "\'," + x + "," + y + ")";
        }

        public void clearLocations()
        {
            // Build the SQL query
            string query = "DELETE FROM dbo.ObstacleLocations";

            // Clear all data in the db
            SqlCommand cmd = new SqlCommand(query, db.database);
            try
            {
                db.database.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (db.database != null)
                {
                    db.database.Close();
                }
            }
        }
    }
}
