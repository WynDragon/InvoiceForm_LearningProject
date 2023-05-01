using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Identity;
using Microsoft.Data.SqlClient;

namespace InvoiceForm
{
    /// <summary>
    /// Database connection logic
    /// This class is for database connection strings
    /// and to hold the 
    /// </summary>
    internal class DatabaseConnection
    {
        // TO DO: add Database connection logic
        // database connection string - ADO.NET
        // This is the passwordless connection string, which is safe to commit to source control
        // as it does not contain any usernames or passwords
        private string passwordlessConnectionString = "Server=tcp:learninggroup.database.windows.net,1433;Initial Catalog=Invoices;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;Authentication=\"Active Directory Default\";";

        // this is the connection string WITH the password, because otherwise it looks like
        // there's a lot to do with Active Directory, which I will figure out after we have a working
        // database connection
        // This is not secure or a good practice.
        private string connectionString; 

        /// <summary>
        /// constructor statement for the DatabaseConnection class.
        /// Sets the connection string with a password, which is not secure nor something you should
        /// EVER do.
        /// </summary>
        /// <exception cref="Exception"></exception>
        public DatabaseConnection()
        {
            try
            {
                connectionString = @"Server=tcp:learninggroup.database.windows.net,1433;Initial Catalog=Invoices;Persist Security Info=False;User ID=WynDragon;Password=L3arningGroup;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="iref"></param>
        /// <returns></returns>
        public DataSet ExecuteSQLStatement(string sql, int iref)
        {
            try
            {
                // creates a blank dataset ds
                DataSet ds = new DataSet();

                // sets up the connection statement
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter()) {
                        // opens a connection to the database
                        conn.Open();

                        // builds the query off of what has been passed in
                        adapter.SelectCommand = new SqlCommand(sql, conn);

                        // fills the dataset with the data retrieved
                        adapter.Fill(ds);

                        // closes the connection
                        conn.Close();
                    }

                    return ds;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
