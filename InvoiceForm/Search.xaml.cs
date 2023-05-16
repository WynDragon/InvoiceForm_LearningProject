using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using System.Windows.Navigation;

namespace InvoiceForm
{
    /// <summary>
    /// Interaction logic for Search.xaml
    /// </summary>
    public partial class Search : Window
    {
        ItemLogic itemLogic = new ItemLogic();
        MainWindow mainWindow = new MainWindow();
        public Search()
        {
            InitializeComponent();
            DefaultCombo.ItemsSource = new List<string> { "Alice", "Bob", "Charlie" };
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        /// <summary>
        /// Button to switch to Main window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindowBtn_Click(object sender, RoutedEventArgs e)
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
                MainWindow mainWindow = new MainWindow();
                //Displays the ItemLogic window
                mainWindow.ShowDialog();
            }
            catch (Exception ex)
            {
                //will generate an automated message explaining where the error occurred
                throw new Exception(ex.Message);
            }
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
            catch (Exception ex)
            {
                //will generate an automated message explaining where the error occurred
                throw new Exception(ex.Message);
            }
        }
    }
}
