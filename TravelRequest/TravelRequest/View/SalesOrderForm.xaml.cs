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
using TravelRequest.Application;
using TravelRequest.Interfaces;
using TravelRequest.Model;

namespace TravelRequest.View
{
    /// <summary>
    /// Interaction logic for ReligionForm.xaml
    /// </summary>
    public partial class ReligionForm : Window
    {
        static MyContext myContext = new MyContext();
        ISalesOrder iSalesOrder = new SalesOrderController();
        TB_M_SalesOrder salesOrder = new TB_M_SalesOrder();
        public ReligionForm()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dataGridSalesOrder.ItemsSource = iSalesOrder.get();
        }

        private void dataGridSalesOrder_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            object selectedItem = dataGridSalesOrder.SelectedItem;
            if (selectedItem != null)
            {
                IdSO_Txt.Text = (dataGridSalesOrder.SelectedCells[0].Column.GetCellContent(selectedItem) as TextBlock).Text;
                Name_Txt.Text = (dataGridSalesOrder.SelectedCells[1].Column.GetCellContent(selectedItem) as TextBlock).Text;
            }
        }

        private void Add_Btn_Click(object sender, RoutedEventArgs e)
        {
            salesOrder.Name = Name_Txt.Text;
            var result = iSalesOrder.InsertSalesOrder(salesOrder);
            if (result)
            {
                MessageBox.Show("Insert Success");
                Name_Txt.Text = "";
            }
            else
            {
                MessageBox.Show("Failed");
                Name_Txt.Text = "";
            }
        }

        private void Edit_Btn_Click(object sender, RoutedEventArgs e)
        {
            salesOrder.Name = Name_Txt.Text;
            int Id = Convert.ToInt16(IdSO_Txt.Text);
            var result = iSalesOrder.UpdateSalesOrder(Id, salesOrder);
            if (result)
            {
                MessageBox.Show("Update Success");
                dataGridSalesOrder.ItemsSource = iSalesOrder.get();
            }
            else
            {
                MessageBox.Show("Update Failed");
            }
        }

        private void Delete_Btn_Click(object sender, RoutedEventArgs e)
        {
            int Id = Convert.ToInt16(IdSO_Txt.Text);
            var result = iSalesOrder.DeleteSalesOrder(Id);
            if (result)
            {
                MessageBox.Show("Delete Success");
                dataGridSalesOrder.ItemsSource = iSalesOrder.get();
            }
            else
            {
                MessageBox.Show("Delete Failed");
            }
        }
    }
}
