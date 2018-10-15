using System;
using System.Windows;
using System.Collections.ObjectModel;

namespace UpDownListViewWpfTests
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SetListForUpDownListViewWithWPF();
        }

        /// <summary>
        /// Set the listed items for the UpDownListView in WPF with Prism
        /// </summary>
        private void SetListForUpDownListViewWithWPF()
        {
            // Create a list of items to be displayed in the UpDownListView control.
            ObservableCollection<Object> objects = new ObservableCollection<Object>
                {
                    new DataObjectForTesting("Item 1"),
                    new DataObjectForTesting("Item 2"),
                    new DataObjectForTesting("Item 3"),
                    new DataObjectForTesting("Item 4"),
                    new DataObjectForTesting("Item 5"),
                    new DataObjectForTesting("Item 6"),
                    new DataObjectForTesting("Item 7"),
                    new DataObjectForTesting("Item 8"),
                    new DataObjectForTesting("Item 9"),
                    new DataObjectForTesting("Item 10")
                };

            // Link the DataContext to the view model.
            upDownListViewWPF.ListItems = objects;
            listBoxForWPF.ItemsSource = upDownListViewWPF.ListItems;
        }
    }
}
