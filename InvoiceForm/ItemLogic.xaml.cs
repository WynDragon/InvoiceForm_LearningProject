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

namespace InvoiceForm
{
    /// <summary>
    /// Interaction logic for ItemLogic.xaml
    /// ItemLogic is the window for Editing and Deleting items
    /// from the database. Each logic should have its own button.
    /// </summary>
    public partial class ItemLogic : Window
    {
        /// <summary>
        /// Initializes the ItemLogic window
        /// </summary>
        public ItemLogic()
        {
            InitializeComponent();
        }

        //TO DO:
        //-add edit button
        //-add delete button
        //-display a list of items from the database
    }
}
