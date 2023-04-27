using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceForm
{
    /// <summary>
    /// This class is for all SQL queries.
    /// Queries should be organized by type.
    /// Query functions should be named appropriately for what the 
    /// query does. If a Query is to display all items, the query 
    /// should be named something akin to DisplayAllItems.
    /// </summary>
    internal class QueryLogic
    {
        //DatabaseConnection object that will be used when queries are sent off to the database
        DatabaseConnection db;

        /// <summary>
        /// Constructor statement for QueryLogic
        /// </summary>
        public QueryLogic() { 
            //establishes a fresh database connection object
            db = new DatabaseConnection();
        }

        //TO DO:
        //Create strings that hold the SQL statements to be made
        //Create functions that will submit the SQL queries and return the results as DataTables

        //EXAMPLE LOGIC:
        //public DataTable GetAllItems()
        //{
        //    try
        //    {
        //        string getAllItemsSQL = $"SELECT * FROM Items";
        //        int row = 0;
        //        DataSet getAll = new DataSet();
        //        getAll = cda.ExecuteSQLStatement(getAllItemsSQL, ref row);
        //        DataTable getAllItems = getAll.Tables[getAllItemsSQL];
        //
        //        return getAllItems;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}
    }
}
