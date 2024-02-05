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

namespace HierarchyManagementSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Represents the main window of the application.
        /// </summary>
        private GridViewColumnHeader listViewSortCol = null;

        /// <summary>
        /// Represents the sort adorner for the list view.
        /// </summary>
        private SortAdorner listViewSortAdorner = null;

        /// <summary>
        /// Represents the core functionality of the application.
        /// </summary>
        private Core core = new Core();

        /// <summary>
        /// Represents the input/output functionality of the application.
        /// </summary>
        private InOut inout = new InOut();

        /// <summary>
        /// Initializes a new instance of the MainWindow class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            // Create organization with 5 sub-departments and add it to the CompanyList
            CompanyList.Items.Add(CreateTreeItem(core.CreateOrg(5)[0]));
        }

        /// <summary>
        /// Handles the event when the "Exit" menu item is clicked.
        /// </summary>
        private void MenuItem_Click_Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the event when the "Debug" menu item is clicked.
        /// </summary>
        private void MenuItem_OnClick_Debug(object sender, RoutedEventArgs e) { }

        /// <summary>
        /// Handles the event when the "About" menu item is clicked.
        /// </summary>
        private void MenuItem_Click_About(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("MyCompany v.0.2", this.Title, MessageBoxButton.OK, MessageBoxImage.Information);
        }

        /// <summary>
        /// Clears all data, including the core and UI elements.
        /// </summary>
        private void ClearData()
        {
            core.ClearData();
            empList.ItemsSource = null;
            CompanyList.ItemsSource = null;
            empList.Items.Clear();
            CompanyList.Items.Clear();
        }

        /// <summary>
        /// Handles the event when the "Generate" menu item is clicked.
        /// Clears data and adds a new organization with 5 sub-departments to the CompanyList.
        /// </summary>
        private void MenuItem_OnClick_Generate(object sender, RoutedEventArgs e)
        {
            ClearData();
            CompanyList.Items.Add(CreateTreeItem(core.CreateOrg(5)[0]));
        }

        /// <summary>
        /// Handles the event when the "Clear" menu item is clicked.
        /// Clears all data.
        /// </summary>
        private void MenuItem_OnClick_Clear(object sender, RoutedEventArgs e)
        {
            ClearData();
        }

        /// <summary>
        /// Handles the event when the "Load" menu item is clicked.
        /// Clears data and loads an organization from a file, adding it to the CompanyList.
        /// </summary>
        private void MenuItem_OnClick_Load(object sender, RoutedEventArgs e)
        {
            ClearData();
            CompanyList.Items.Add(CreateTreeItem(inout.LoadData()[0]));
        }

        /// <summary>
        /// Handles the event when the "Save" menu item is clicked.
        /// Saves the current organization data to a file.
        /// </summary>
        private void MenuItem_OnClick_Save(object sender, RoutedEventArgs e)
        {
            inout.SaveData();
        }

        /// <summary>
        /// Handles the event when a TreeViewItem in CompanyList is expanded.
        /// Clears existing items and populates it with sub-departments of the expanded department.
        /// </summary>
        private void CompanyList_OnExpanded(object sender, RoutedEventArgs e)
        {
            TreeViewItem item = e.Source as TreeViewItem;
            if (item.Items.IsEmpty)
                return;
            item.Items.Clear();
            var d = item.Tag as Organisation;
            var subDepartments = core.GetSubDepts(d.Id);

            foreach (Organisation dep in subDepartments)
                item.Items.Add(CreateTreeItem(dep));
        }

        /// <summary>
        /// Creates a TreeViewItem for the given department, including sub-departments if present.
        /// </summary>
        /// <param name="dept">The department for which to create a TreeViewItem.</param>
        /// <returns>TreeViewItem representing the department.</returns>
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

        /// <summary>
        /// Event handler for TreeViewItem selection. Shows workers in the selected department.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event arguments.</param>
        private void Item_Selected(object sender, RoutedEventArgs e)
        {
            var dep = (e.OriginalSource as TreeViewItem).Tag as Organisation;
            empList.ItemsSource = dep.Employees;
        }

        /// <summary>
        /// Event handler for sorting columns in the users list.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event arguments.</param>
        private void UsersColumnHeader_OnClick(object sender, RoutedEventArgs e)
        {
            GridViewColumnHeader column = (sender as GridViewColumnHeader);
            string sortBy = column.Tag.ToString();
            if (listViewSortCol != null)
            {
                AdornerLayer.GetAdornerLayer(listViewSortCol).Remove(listViewSortAdorner);
                empList.Items.SortDescriptions.Clear();
            }

            ListSortDirection newDir = ListSortDirection.Ascending;
            if (listViewSortCol == column && listViewSortAdorner.Direction == newDir)
                newDir = ListSortDirection.Descending;

            listViewSortCol = column;
            listViewSortAdorner = new SortAdorner(listViewSortCol, newDir);
            AdornerLayer.GetAdornerLayer(listViewSortCol).Add(listViewSortAdorner);
            empList.Items.SortDescriptions.Add(new SortDescription(sortBy, newDir));
        }

        /// <summary>
        /// Event handler for the right button menu.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event arguments.</param>
        private void EmpList_OnPreviewMouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            var item = (sender as ListView).SelectedItem;
            if (item != null)
            {
                ContextMenu cm = this.FindResource("cmButton") as ContextMenu;
                cm.PlacementTarget = sender as Button;
                cm.IsOpen = true;
            }
        }

        /// <summary>
        /// Event handler for the Edit menu item. Opens the popup menu.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event arguments.</param>
        private void MenuItemEdit_OnClick(object sender, RoutedEventArgs e)
        {
            pEdit.IsOpen = true;

            Employee currentEmp = empList.SelectedItem as Employee;

            nameTextBox.Text = currentEmp.Name;
            ageTextBox.Text = currentEmp.Age.ToString();
            projectTextBox.Text = currentEmp.Projects.ToString();
        }

        /// <summary>
        /// Event handler for the Delete menu item. Deletes the selected employee entry.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event arguments.</param>
        private void MenuItemDelete_OnClick(object sender, RoutedEventArgs e)
        {
            Employee currentEmp = empList.SelectedItem as Employee;             
            TreeViewItem tviOrg = (TreeViewItem)CompanyList.SelectedItem;     
            Organisation currentOrg = tviOrg.Tag as Organisation;

            if (currentEmp.Position == "Administrator")
            {
                MessageBox.Show("Administrator cannot be deleted", "Error", MessageBoxButton.OK,
                    MessageBoxImage.Information);
            }
            else if (currentEmp.Position == "CEO")
            {
                MessageBox.Show("Boss cannot be deleted", "Error", MessageBoxButton.OK,
                    MessageBoxImage.Information);
            }
            else
            {
                int elementIndex = 0;                                   
                foreach (var emp in currentOrg.Employees)
                {
                    if (currentEmp.Id == emp.Id)
                    {
                        break;
                    }

                    elementIndex++;
                }

                var confirm = MessageBox.Show("Are you sure you want to delete this worker?", "Delete entry", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (confirm == MessageBoxResult.Yes)
                {
                    core.RecalculateSalary(currentOrg.Id - 1, elementIndex);

                    // refresh list of workers
                    empList.ItemsSource = (currentOrg.Employees).Where(x => x != null);
                }
            }
        }

        /// <summary>
        /// Event handler for the Save button. Saves the edited information for the selected employee.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event arguments.</param>
        private void SaveButton_OnClick(object sender, RoutedEventArgs e)
        {
            byte ageNum, projNum;

            Employee currentEmp = empList.SelectedItem as Employee;

            bool rightData = Byte.TryParse(ageTextBox.Text, out ageNum) &
                             Byte.TryParse(projectTextBox.Text, out projNum);
            if (rightData && ageNum > 0 && ageNum < 80 && projNum > 0 && projNum < 255)
            {
                currentEmp.Age = ageNum;
                currentEmp.Projects = projNum;
            }
            else
            {
                MessageBox.Show("Incorrect values", "Input error", MessageBoxButton.OK, MessageBoxImage.Error);
                pEdit.IsOpen = false;
            }

            currentEmp.Name = nameTextBox.Text;

            pEdit.IsOpen = false;       

            TreeViewItem tviOrg = (TreeViewItem)CompanyList.SelectedItem;
            Organisation currentOrg = tviOrg.Tag as Organisation;
            empList.ItemsSource = (currentOrg.Employees).Where(x => x != null);
        }
    }

    /// <summary>
    /// Adorner class for column sorting in the UI.
    /// </summary>
    public class SortAdorner : Adorner
    {
        private static Geometry ascGeometry =
            Geometry.Parse("M 0 4 L 3.5 0 L 7 4 Z");

        private static Geometry descGeometry =
            Geometry.Parse("M 0 0 L 3.5 4 L 7 0 Z");

        /// <summary>
        /// Gets the sorting direction (Ascending or Descending).
        /// </summary>
        public ListSortDirection Direction { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SortAdorner"/> class.
        /// </summary>
        /// <param name="element">The UI element to adorn.</param>
        /// <param name="dir">The sorting direction.</param>
        public SortAdorner(UIElement element, ListSortDirection dir)
            : base(element)
        {
            this.Direction = dir;
        }

        /// <summary>
        /// Renders the adorner.
        /// </summary>
        /// <param name="drawingContext">The drawing context.</param>
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
