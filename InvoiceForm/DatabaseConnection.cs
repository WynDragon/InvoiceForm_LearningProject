using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace InvoiceForm
{
    /// <summary>
    /// Database connection logic
    /// This class is for database connection strings
    /// </summary>
    internal class DatabaseConnection
    {
        // TO DO: add Database connection logic
        // database connection string - ADO.NET
        // This is the passwordless connection string, which is safe to commit to source control
        // as it does not contain any usernames or passwords
        string passwordlessConnectionString = "Server=tcp:learninggroup.database.windows.net,1433;Initial Catalog=Invoices;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;Authentication=\"Active Directory Default\";";

        // this is the connection string WITH the password, because otherwise it looks like
        // there's a lot to do with Active Directory, which I will figure out after we have a working
        // database connection
        // This is not secure or a good practice.
        string connectionString = "Server=tcp:learninggroup.database.windows.net,1433;Initial Catalog=Invoices;Persist Security Info=False;User ID=WynDragon;Password=L3arningGroup;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        

    }
}
