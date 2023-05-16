using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InvoiceForm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// By default, the Main Window should display all available invoices within the data grid
    /// </summary>
    public partial class MainWindow : Window
    {
        //In order to call upon another window, we need window objects
        ItemLogic itemLogic = new ItemLogic();
        QueryLogic queryLogic = new QueryLogic();

        /// <summary>
        /// Initializes the window upon it being opened
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            //this item creates an empty data set
            DataSet allItems = new DataSet();
            //This following line of code is waiting on a function to be wriiten in the QueryLogic class called InitializeDataGrid;
            //This function should fill the allItems table with all available items from the Items table
            allItems = queryLogic.InitializeDataGrid();    

            //sets data grid to read only - you cannot edit items within the data grid
            DisplayItemsDataGrid.IsReadOnly = true;
            //the item source is where the data grid gets the data from.
            //Data View is a method of enumerating through the table's rows and columns to display data
            DisplayItemsDataGrid.ItemsSource = allItems.Tables[0].AsDataView();

            //string[] itemList = { "One", "Two" };

            //populate combobox
            DefaultCombo.Items.Add("One");
            DefaultCombo.Items.Add("Two");
        }

        /// <summary>
        /// button to switch to Search window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            //this button switches which window is active
            //switch to Search Window
        }

        /// <summary>
        /// Button to switch to ItemsLogic window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditItemsBtn_Click(object sender, RoutedEventArgs e)
        {
            //this button switches which window is active
            //try/catch blocks prevent errors from slipping through and potentially causing
            //unintended memory leaks; good WPF writing formats dictate every function is wrapped
            //in a try/catch block
            try
            {
                //This line hides the current window
                this.Hide();
                //Create a new instance of ItemLogic window
                ItemLogic itemLogic = new ItemLogic();
                //Displays the ItemLogic window
                itemLogic.ShowDialog();
            }
            catch(Exception ex) 
            {
                //will generate an automated message explaining where the error occurred
                throw new Exception(ex.Message);
            }
        }
    }
}
