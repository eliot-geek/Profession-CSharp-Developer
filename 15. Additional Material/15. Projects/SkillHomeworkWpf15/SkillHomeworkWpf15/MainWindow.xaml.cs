using ClassLibrary;
using System;
using System.Collections.Generic;
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

namespace SkillHomeworkWpf15
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private GridViewColumnHeader listViewSortCol = null;
        private SortAdorner listViewSortAdorner = null;
        private Core core = new Core();
        private Journal journal = new Journal();

        public MainWindow()
        {
            InitializeComponent();
            core.Information += CoreInformation;
            bankList.ItemsSource = core.CreateBank();
            transList.ItemsSource = journal.journalFile;
        }

        private void CoreInformation(string message)
        {
            journal.AddToJournal(message);
        }

        private void MenuItem_OnClick_Debug(object sender, RoutedEventArgs e) { }

        private void MenuItem_Click_Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MenuItem_Click_About(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bank A", this.Title, MessageBoxButton.OK, MessageBoxImage.Information);
        }

        /// <summary>
        /// Right button menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClientList_OnPreviewMouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            var item = (sender as ListView).SelectedItem;
            if (item != null)
            {
                ContextMenu cm = this.FindResource("CmButton") as ContextMenu;
                cm.PlacementTarget = sender as Button;
                cm.IsOpen = true;
            }
        }

        /// <summary>
        /// Refresh client's data
        /// </summary>
        void RefreshList()
        {
            var bankDep = bankList.SelectedItem as BankDep;
            clientList.ItemsSource = (bankDep.Clients).Where(x => x != null);

            clientInfo.ItemsSource = clientList.SelectedItems;
            CollectionViewSource.GetDefaultView(clientList.SelectedItems).Refresh();
        }

        /// <summary>
        /// Deposit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemDeposit_OnClick(object sender, RoutedEventArgs e)
        {
            pDep.IsOpen = true;
        }

        /// <summary>
        /// Make deposit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemDep_OnClick(object sender, RoutedEventArgs e)
        {
            Client currentClient = clientList.SelectedItem as Client;
            uint amountDeposit;

            try
            {
                bool result = UInt32.TryParse(amountDepTextBox.Text, out amountDeposit);
                core.checkWrongAmount(result);
                bool checkFunds = core.CheckAmount(currentClient, UInt32.Parse(amountDepTextBox.Text));
                core.checkFundsPositive(checkFunds);
            }
            catch (InsufficientFundsException ex)
            {
                MessageBox.Show(ex.Message, "Insufficient funds", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }
            catch (WrongAmountException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            core.MakeDeposit(currentClient, amountDeposit);
            pDep.IsOpen = false;
            RefreshList();
            MessageBox.Show("Success", "Deposit", MessageBoxButton.OK, MessageBoxImage.Asterisk);
        }

        /// <summary>
        /// Non Deposit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemNonDeposit_OnClick(object sender, RoutedEventArgs e)
        {
            pNonDep.IsOpen = true;
        }

        /// <summary>
        /// Deposit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemNonDep_OnClick(object sender, RoutedEventArgs e)
        {
            Client currentClient = clientList.SelectedItem as Client;
            uint amountNonDeposit;

            try
            {
                bool result = UInt32.TryParse(amountNonDepTextBox.Text, out amountNonDeposit);
                core.checkWrongAmount(result);
                bool checkFunds = core.CheckAmount(currentClient, UInt32.Parse(amountNonDepTextBox.Text));
                core.checkFundsPositive(checkFunds);
            }
            catch (InsufficientFundsException ex)
            {
                MessageBox.Show(ex.Message, "Insufficient funds", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }
            catch (WrongAmountException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            core.NonDeposit(currentClient, amountNonDeposit);
            pNonDep.IsOpen = false;
            RefreshList();
            MessageBox.Show("Success", "Non Deposit", MessageBoxButton.OK, MessageBoxImage.Asterisk);
        }

        /// <summary>
        /// Loan Fill
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemLoan_OnClick(object sender, RoutedEventArgs e)
        {
            pLoan.IsOpen = true;
        }

        /// <summary>
        /// Fill Balance
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemFillBalance_OnClick(object sender, RoutedEventArgs e)
        {
            Client currentClient = clientList.SelectedItem as Client;
            uint amountLoan;

            try
            {
                bool result = UInt32.TryParse(amountLoanTextBox.Text, out amountLoan);
                core.checkWrongAmount(result);
            }
            catch (WrongAmountException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            core.FillBalance(currentClient, amountLoan);
            pLoan.IsOpen = false;
            RefreshList();
            MessageBox.Show("Success", "Balance filled in", MessageBoxButton.OK, MessageBoxImage.Asterisk);
        }

        /// <summary>
        /// Transfer 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemTransfer_OnClick(object sender, RoutedEventArgs e)
        {
            pTransfer.IsOpen = true;
            transferTo.ItemsSource = clientList.ItemsSource;
        }

        /// <summary>
        /// Make a transfer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemMakeTransfer_OnClick(object sender, RoutedEventArgs e)
        {
            Client currentClient = clientList.SelectedItem as Client;
            Client recipient = transferTo.SelectedItem as Client;

            if (currentClient == transferTo.SelectedItem)
            {
                MessageBox.Show("You cannot make a transfer to yourself", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            uint amountTransfer;
            try
            {
                bool result = UInt32.TryParse(amountTransferTextBox.Text, out amountTransfer);
                core.checkWrongAmount(result);
                bool checkFunds = core.CheckAmount(currentClient, UInt32.Parse(amountTransferTextBox.Text));
                core.checkFundsPositive(checkFunds);
            }
            catch (InsufficientFundsException ex)
            {
                MessageBox.Show(ex.Message, "Insufficient funds", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }
            catch (WrongAmountException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            core.TransferFunds(currentClient, recipient, amountTransfer);
            pTransfer.IsOpen = false;
            RefreshList();
            MessageBox.Show("Transfer completed", "Done", MessageBoxButton.OK, MessageBoxImage.Asterisk);
        }
        private void MenuItemDepInfo_OnClick(object sender, RoutedEventArgs e)
        {
            pDepInfo.IsOpen = false;
        }

        /// <summary>
        /// Show clients in current bank 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BankList_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (bankList.SelectedItems != null)
            {
                var clients = (e.OriginalSource as ListBox).SelectedItem as BankDep;
                clientList.ItemsSource = clients.Clients;
            }
        }

        /// <summary>
        /// Show current client info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClientInfo_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (clientList.SelectedItems != null)
            {
                var client = (e.OriginalSource as ListBox).SelectedItems;
                clientInfo.ItemsSource = client;
            }
        }

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

    public class SortAdorner : Adorner
    {
        private static readonly Geometry ascGeometry =
            Geometry.Parse("M 0 4 L 3.5 0 L 7 4 Z");

        private static readonly Geometry descGeometry =
            Geometry.Parse("M 0 0 L 3.5 4 L 7 0 Z");

        public ListSortDirection Direction { get; private set; }

        public SortAdorner(UIElement element, ListSortDirection dir)
            : base(element)
        {
            this.Direction = dir;
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);
            if (AdornedElement.RenderSize.Width < 20)
                return;

            TranslateTransform transform = new TranslateTransform
            (
                AdornedElement.RenderSize.Width - 15,
                (AdornedElement.RenderSize.Height - 5) / 2
            );
            drawingContext.PushTransform(transform);

            Geometry geometry = ascGeometry;
            if (this.Direction == ListSortDirection.Descending)
                geometry = descGeometry;
            drawingContext.DrawGeometry(Brushes.Black, null, geometry);

            drawingContext.Pop();
        }
    }
}
