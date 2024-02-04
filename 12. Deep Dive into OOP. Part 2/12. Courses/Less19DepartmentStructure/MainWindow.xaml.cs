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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Less19DepartmentStructure
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Repository data to manage application data.
        private Repository data;

        /// <summary>
        /// Constructor for the MainWindow class.
        /// Initializes the MainWindow and sets up the data repository.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            // Creating or obtaining the data repository.
            data = Repository.CreateRepository();

            // Setting the ComboBox's item source to the Departments from the data repository.
            cbDepartment.ItemsSource = data.DepartmentsDb;
        }

        /// <summary>
        /// Event handler for the Refresh button click.
        /// Refreshes the ComboBox and ListView items.
        /// </summary>
        private void btnRef(object sender, RoutedEventArgs e)
        {
            // Refreshing the ComboBox and ListView items.
            cbDepartment.Items.Refresh();
            lvWorkers.Items.Refresh();
        }

        /// <summary>
        /// Event handler for the ComboBox's SelectionChanged event.
        /// Sets the ListView's item source based on the selected department.
        /// </summary>
        private void CbDepartment_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Setting the ListView's item source to workers filtered by the selected department.
            lvWorkers.ItemsSource = data.WorkersDb.Where(find);
        }

        /// <summary>
        /// Predicate method to filter workers by department.
        /// </summary>
        /// <param name="arg">The worker to check for a matching department.</param>
        /// <returns>True if the worker belongs to the selected department, otherwise false.</returns>
        private bool find(Worker arg)
        {
            return arg.DepartmentId == (cbDepartment.SelectedItem as Department).DepartmentId;
        }
    }
}
