using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
using Newtonsoft.Json;
using System.IO;
using Microsoft.Win32;
using Newtonsoft.Json.Linq;

namespace HierarchyManagementSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Instance of the Core class responsible for managing the organizational structure and data
        private Core core = new Core();

        public MainWindow()
        {
            InitializeComponent();

            // Adding a tree item for the root organization to the CompanyList
            CompanyList.Items.Add(CreateTreeItem(core.CreateOrg(5)[0]));
        }

        // Event handler for Exit menu item click
        private void MenuItem_Click_Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        // Event handler for Debug menu item click
        private void MenuItem_OnClick_Debug(object sender, RoutedEventArgs e)
        {

        }

        // Event handler for About menu item click
        private void MenuItem_Click_About(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("MyCompany v.0.1", this.Title, MessageBoxButton.OK, MessageBoxImage.Information);
        }

        // ClearData method to reset and clear data
        private void ClearData()
        {
            core.ClearData();
            empList.ItemsSource = null;
            CompanyList.ItemsSource = null;
            empList.Items.Clear();
            CompanyList.Items.Clear();
        }

        // Event handler for Generate menu item click
        private void MenuItem_OnClick_Generate(object sender, RoutedEventArgs e)
        {
            ClearData();
            CompanyList.Items.Add(CreateTreeItem(core.CreateOrg(5)[0]));
        }

        // Event handler for Clear menu item click
        private void MenuItem_OnClick_Clear(object sender, RoutedEventArgs e)
        {
            ClearData();
        }

        // Event handler for Load menu item click
        private void MenuItem_OnClick_Load(object sender, RoutedEventArgs e)
        {
            ClearData();
            CompanyList.Items.Add(CreateTreeItem(core.LoadData()[0]));
        }

        // Event handler for Save menu item click
        private void MenuItem_OnClick_Save(object sender, RoutedEventArgs e)
        {
            core.SaveData();
        }

        // Event handler for expanding a company tree item
        private void CompanyList_OnExpanded(object sender, RoutedEventArgs e)
        {
            TreeViewItem item = e.Source as TreeViewItem;
            if (item.Items[0] != null)
                return;
            item.Items.Clear();
            var d = item.Tag as Organisation;
            var subDepartments = core.GetSubDepts(d.Id);

            foreach (Organisation dep in subDepartments)
                item.Items.Add(CreateTreeItem(dep));
        }

        // CreateTreeItem method to generate a tree item for an organization
        private TreeViewItem CreateTreeItem(Organisation dept)
        {
            TreeViewItem item = new TreeViewItem();
            item.Header = dept.Title;
            item.Tag = dept;
            var subDept = core.GetSubDepts(dept.Id);
            if (subDept.Count > 0)
            {
                item.Items.Add(null);
            }
            item.Selected += Item_Selected;
            return item;
        }

        // Event handler for selecting a tree item
        private void Item_Selected(object sender, RoutedEventArgs e)
        {
            var dep = (e.OriginalSource as TreeViewItem).Tag as Organisation;
            empList.ItemsSource = dep.Employees;
        }
    }

}
