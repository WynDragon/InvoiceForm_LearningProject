﻿using System;
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
    /// Interaction logic for Search.xaml
    /// </summary>
    public partial class Search : Window
    {
        /// <summary>
        /// Initializes the Search Window
        /// </summary>
        public Search()
        {
            InitializeComponent();
        }

        //TO DO:
        //Set up combo box for search parameters
        //Search parameters should be by item parameters:
        //-Name, Cost, Vendor, ItemType
        //Set up display to show the results of the database queries
        //all business logic should be in a separate area.
        //All Queries should be in a Query Class.
    }
}
