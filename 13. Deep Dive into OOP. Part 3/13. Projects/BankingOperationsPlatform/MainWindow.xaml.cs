using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace BankingOperationsPlatform
{


    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Header of the sorted column in the list view.
        /// </summary>
        private GridViewColumnHeader listViewSortCol = null;

        /// <summary>
        /// Adorner for the sorted column in the list view.
        /// </summary>
        private SortAdorner listViewSortAdorner = null;

        /// <summary>
        /// Core instance for managing the banking system.
        /// </summary>
        private Core core = new Core();

        /// <summary>
        /// Initializes the main window.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            bankList.ItemsSource = core.CreateBank();
            // Populate the bank list with data from the core banking system
        }

        /// <summary>
        /// Event handler for the debug menu item click.
        /// </summary>
        private void MenuItem_OnClick_Debug(object sender, RoutedEventArgs e)
        {
            // Handle debug menu item click
        }

        /// <summary>
        /// Event handler for the exit menu item click.
        /// </summary>
        private void MenuItem_Click_Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Event handler for the about menu item click.
        /// </summary>
        private void MenuItem_Click_About(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("MyBank v.0.1", this.Title, MessageBoxButton.OK, MessageBoxImage.Information); 
        }

        /// <summary>
        /// Handles the right button menu event.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">The MouseButtonEventArgs.</param>
        private void ClientList_OnPreviewMouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            var item = (sender as ListView).SelectedItem;
            if (item != null)
            {
                // Display the context menu
                ContextMenu cm = this.FindResource("CmButton") as ContextMenu;
                cm.PlacementTarget = sender as Button;
                cm.IsOpen = true;
            }
        }

        /// <summary>
        /// Refreshes the client list and client information list.
        /// </summary>
        void RefreshList()
        {
            // Refresh the clients list
            var bankDep = bankList.SelectedItem as BankDep;
            clientList.ItemsSource = (bankDep.Clients).Where(x => x != null);

            // Refresh the clients info list
            clientInfo.ItemsSource = clientList.SelectedItems;
            CollectionViewSource.GetDefaultView(clientList.SelectedItems).Refresh();
        }

        /// <summary>
        /// Enables the popup menu for simple deposit.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">The RoutedEventArgs.</param>
        private void MenuItemSimpleDeposit_OnClick(object sender, RoutedEventArgs e)
        {
            pSimpDep.IsOpen = true;
        }

        /// <summary>
        /// Handles the event when the user clicks on the menu item to make a simple deposit.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">The RoutedEventArgs.</param>
        private void MenuItemSimpDep_OnClick(object sender, RoutedEventArgs e)
        {
            Client currentClient = clientList.SelectedItem as Client;

            bool result = UInt32.TryParse(amountSimpDepTextBox.Text, out uint amountSimpDeposit);
            if (!result)
            {
                MessageBox.Show("Wrong amount", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Check the client have enough money to make deposit
            bool checkFunds = core.CheckSuffAmount(currentClient, UInt32.Parse(amountSimpDepTextBox.Text));
            if (!checkFunds)
            {
                MessageBox.Show("Insufficient funds", "Insufficient funds", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }

            // Make simple deposit
            core.MakeSimpleDeposit(currentClient, amountSimpDeposit);

            // Close the popup menu
            pSimpDep.IsOpen = false;

            // Refresh the client list
            RefreshList();

            // Show success message
            MessageBox.Show("Success", "Simple deposit", MessageBoxButton.OK, MessageBoxImage.Asterisk);
        }

        /// <summary>
        /// Enables the popup menu for capitalized deposit.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">The RoutedEventArgs.</param>
        private void MenuItemCapitalizedDeposit_OnClick(object sender, RoutedEventArgs e)
        {
            pCapDep.IsOpen = true;
        }

        /// <summary>
        /// Handles the event when the user clicks on the menu item to make a capitalized deposit.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">The RoutedEventArgs.</param>
        private void MenuItemCapDep_OnClick(object sender, RoutedEventArgs e)
        {
            Client currentClient = clientList.SelectedItem as Client;

            bool result = UInt32.TryParse(amountCapDepTextBox.Text, out uint amountCapDeposit);
            if (!result)
            {
                MessageBox.Show("Wrong amount", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Check the client have enough money to make deposit
            bool checkFunds = core.CheckSuffAmount(currentClient, UInt32.Parse(amountCapDepTextBox.Text));
            if (!checkFunds)
            {
                MessageBox.Show("Insufficient funds", "Insufficient funds", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }

            // Make capitalized deposit
            core.MakeCapitalizedDeposit(currentClient, amountCapDeposit);

            pCapDep.IsOpen = false;

            RefreshList();

            MessageBox.Show("Success", "Capitalized deposit", MessageBoxButton.OK, MessageBoxImage.Asterisk);
        }

        /// <summary>
        /// Enables the popup menu for taking a loan.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">The RoutedEventArgs.</param>
        private void MenuItemLoan_OnClick(object sender, RoutedEventArgs e)
        {
            pLoan.IsOpen = true;
        }

        /// <summary>
        /// Handles the event when the user clicks on the menu item to get a loan.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">The RoutedEventArgs.</param>
        private void MenuItemGetLoan_OnClick(object sender, RoutedEventArgs e)
        {
            bool result = UInt32.TryParse(amountLoanTextBox.Text, out uint amountLoan);
            if (!result)
            {
                MessageBox.Show("Wrong amount", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            Client currentClient = clientList.SelectedItem as Client;

            // Get loan
            core.GetLoan(currentClient, amountLoan);

            pLoan.IsOpen = false;

            RefreshList();

            MessageBox.Show("Success" ,"Get loan", MessageBoxButton.OK, MessageBoxImage.Asterisk);
        }

        /// <summary>
        /// Enables the popup menu for making a transfer.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">The RoutedEventArgs.</param>
        private void MenuItemTransfer_OnClick(object sender, RoutedEventArgs e)
        {
            pTransfer.IsOpen = true;
            transferTo.ItemsSource = clientList.ItemsSource;
        }

        /// <summary>
        /// Handles the event when the user clicks on the menu item to make a transfer.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">The RoutedEventArgs.</param>
        private void MenuItemMakeTransfer_OnClick(object sender, RoutedEventArgs e)
        {
            Client currentClient = clientList.SelectedItem as Client;
            Client recipient = transferTo.SelectedItem as Client;

            // Check if the sender and recipient are different clients
            if (currentClient == transferTo.SelectedItem)
            {
                MessageBox.Show("You cannot make a transfer to yourself", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Parse the amount to transfer
            bool result = UInt32.TryParse(amountTransferTextBox.Text, out uint amountTransfer);
            if (!result)
            {
                MessageBox.Show("Wrong amount", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Check if the sender has enough funds for the transfer
            bool checkFunds = core.CheckSuffAmount(currentClient, UInt32.Parse(amountTransferTextBox.Text));
            if (!checkFunds)
            {
                MessageBox.Show("Insufficient funds", "Insufficient funds", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }

            // Transfer funds
            core.TransferFunds(currentClient, recipient, amountTransfer);

            pTransfer.IsOpen = false;

            RefreshList();

            MessageBox.Show("Transfer completed", "Funds transfer", MessageBoxButton.OK, MessageBoxImage.Asterisk);
        }

        /// <summary>
        /// Handles the event when the user clicks on the button to show deposit information.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">The RoutedEventArgs.</param>
        private void ButtonDepInfo_OnClick(object sender, RoutedEventArgs e)
        {
            Client currentClient = clientList.SelectedItem as Client;

            // Check if the client has a deposit
            if (currentClient.IsDeposit == Deposit.No)
            {
                MessageBox.Show("No information available", "Deposit information", MessageBoxButton.OK,
                    MessageBoxImage.Exclamation);
                return;
            }

            // Get deposit information for the current client
            double[] months = core.DepositInfo(currentClient);

            // Display deposit information in the popup menu
            month1.Text = months[0].ToString();
            month2.Text = months[1].ToString();
            month3.Text = months[2].ToString();
            month4.Text = months[3].ToString();
            month5.Text = months[4].ToString();
            month6.Text = months[5].ToString();
            month7.Text = months[6].ToString();
            month8.Text = months[7].ToString();
            month9.Text = months[8].ToString();
            month10.Text = months[9].ToString();
            month11.Text = months[10].ToString();
            month12.Text = months[11].ToString();

            // Open the deposit info popup menu
            pDepInfo.IsOpen = true;
        }

        /// <summary>
        /// Handles the event when the user clicks on the menu item to close the deposit information popup.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">The RoutedEventArgs.</param>
        private void MenuItemDepInfo_OnClick(object sender, RoutedEventArgs e)
        {
            pDepInfo.IsOpen = false;
        }

        /// <summary>
        /// Shows the clients in the current bank department.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">The SelectionChangedEventArgs.</param>
        private void BankList_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (bankList.SelectedItems != null)
            {
                var clients = (e.OriginalSource as ListBox).SelectedItem as BankDep;
                clientList.ItemsSource = clients.Clients;
            }
        }

        /// <summary>
        /// Shows the current client info.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">The SelectionChangedEventArgs.</param>
        private void ClientInfo_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (clientList.SelectedItems != null)
            {
                var client = (e.OriginalSource as ListBox).SelectedItems;
                clientInfo.ItemsSource = client;
            }
        }

        /// <summary>
        /// Handles the event when the user clicks on a column header to sort the users list.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">The RoutedEventArgs.</param>
        private void UsersColumnHeader_OnClick(object sender, RoutedEventArgs e)
        {
            GridViewColumnHeader column = (sender as GridViewColumnHeader);
            string sortBy = column.Tag.ToString();
            if (listViewSortCol != null)
            {
                AdornerLayer.GetAdornerLayer(listViewSortCol).Remove(listViewSortAdorner);
                clientList.Items.SortDescriptions.Clear();
            }

            ListSortDirection newDir = ListSortDirection.Ascending;
            if (listViewSortCol == column && listViewSortAdorner.Direction == newDir)
                newDir = ListSortDirection.Descending;

            listViewSortCol = column;
            listViewSortAdorner = new SortAdorner(listViewSortCol, newDir);
            AdornerLayer.GetAdornerLayer(listViewSortCol).Add(listViewSortAdorner);
            clientList.Items.SortDescriptions.Add(new SortDescription(sortBy, newDir));
        }
    }

    /// <summary>
    /// Represents an adorner that indicates the sorting direction of a column in a ListView.
    /// Ascending and descending arrows used to indicate the sorting direction in the column headers.
    /// The ascGeometry represents an upward arrow, while the descGeometry represents a downward arrow. 
    /// These geometries are defined using the Geometry.Parse method, which parses a string representation of a geometry path. 
    /// </summary>
    public class SortAdorner : Adorner
    {
        /// <summary>
        /// Geometry for the ascending arrow.
        /// </summary>
        private static Geometry ascGeometry =
            Geometry.Parse("M 0 4 L 3.5 0 L 7 4 Z");


        /// <summary>
        /// Geometry for the descending arrow.
        /// </summary>
        private static Geometry descGeometry =
            Geometry.Parse("M 0 0 L 3.5 4 L 7 0 Z");


        /// <summary>
        /// Gets the sort direction of the adorner.
        /// </summary>
        public ListSortDirection Direction { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SortAdorner"/> class.
        /// </summary>
        /// <param name="element">The UIElement to adorn.</param>
        /// <param name="dir">The sort direction.</param>
        public SortAdorner(UIElement element, ListSortDirection dir)
            : base(element)
        {
            this.Direction = dir;
        }

        /// <summary>
        /// Overrides the rendering behavior to draw the sorting arrow on the adorned element.
        /// </summary>
        /// <param name="drawingContext">The drawing context to use for rendering.</param>
        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);

            // If the width of the adorned element is too small, do not render the arrow.
            if (AdornedElement.RenderSize.Width < 20)
                return;

            // Calculate the translation transform to position the arrow.
            TranslateTransform transform = new TranslateTransform
            (
                AdornedElement.RenderSize.Width - 15,                     // X-coordinate
                (AdornedElement.RenderSize.Height - 5) / 2                // Y-coordinate
            );
            drawingContext.PushTransform(transform);

            // Select the appropriate geometry based on the sorting direction.
            Geometry geometry = ascGeometry;
            if (this.Direction == ListSortDirection.Descending)
                geometry = descGeometry;

            // Draw the arrow geometry with black color.
            drawingContext.DrawGeometry(Brushes.Black, null, geometry);

            // Pop the transform to restore the previous drawing context.
            drawingContext.Pop();
        }
    }
}
