using System;
using System.Windows;
using System.Windows.Controls;
using System.Collections.ObjectModel;

namespace UpDownListViewWpf
{
    /// <summary>
    /// Interaction logic for UpDownListView.xaml
    /// </summary>
    public partial class UpDownListView : UserControl
    {
        private ObservableCollection<Object> m_ListItems;
        private Object m_SelectedListItem;

        /// <summary>
        /// Default constructor
        /// </summary>
        public UpDownListView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Set/get all items associated with the list view
        /// </summary>
        public ObservableCollection<Object> ListItems //{ set; get; }
        {
            get
            {
                return m_ListItems;
            }

            set
            {
                m_ListItems = value;
                upDownListView.ItemsSource = value;
            }
        }

        /// <summary>
        /// Set/get the selected item associated with the list view
        /// </summary>
        public Object SelectedListItem
        {
            get
            {
                return m_SelectedListItem;
            }

            set
            {
                m_SelectedListItem = value;
                upDownListView.SelectedItem = value;
            }
        }

        /// <summary>
        /// Event handler for clicking the Move Up button
        /// </summary>
        /// <param name="sender">Sender (the Move Up button)</param>
        /// <param name="e">Event arguments</param>
        private void OnMoveUpButtonClick(object sender, RoutedEventArgs e)
        {
            if (ListItems == null || ListItems.Count < 2)
                return;

            var selectedIndex = upDownListView.SelectedIndex;
            if (selectedIndex > 0)
            {
                var itemToMoveUp = ListItems[selectedIndex];
                ListItems.RemoveAt(selectedIndex);
                --selectedIndex;
                ListItems.Insert(selectedIndex, itemToMoveUp);
                SelectedListItem = itemToMoveUp;
            }
        }

        /// <summary>
        /// Event handler for clicking the Move Down button
        /// </summary>
        /// <param name="sender">Sender (the Move Down button)</param>
        /// <param name="e">Event arguments</param>
        private void OnMoveDownButtonClick(object sender, RoutedEventArgs e)
        {
            if (ListItems == null || ListItems.Count < 2)
                return;

            var selectedIndex = upDownListView.SelectedIndex;
            if (selectedIndex > -1 && selectedIndex < ListItems.Count - 1)
            {
                var itemToMoveUp = ListItems[selectedIndex];
                ListItems.RemoveAt(selectedIndex);
                ++selectedIndex;
                ListItems.Insert(selectedIndex, itemToMoveUp);
                SelectedListItem = itemToMoveUp;
            }
        }
    }
}
