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
    /// Interaction logic for AdvancePaymentForm.xaml
    /// </summary>
    public partial class AdvancePaymentForm : Window
    {
        static MyContext myContext = new MyContext();
        IAdvancePayment iAdvancePayment = new AdvancePaymentController();
        TB_T_AdvancePayment advancePayment = new TB_T_AdvancePayment();
        public AdvancePaymentForm()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dataGridAdvancePayment.ItemsSource = iAdvancePayment.get();
        }

        private void dataGridAdvancePayment_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            object selectedItem = dataGridAdvancePayment.SelectedItem;
            if (selectedItem != null)
            {
                IdAP_Txt.Text = (dataGridAdvancePayment.SelectedCells[0].Column.GetCellContent(selectedItem) as TextBlock).Text;
                Name_Txt.Text = (dataGridAdvancePayment.SelectedCells[1].Column.GetCellContent(selectedItem) as TextBlock).Text;
            }
        }

        private void Add_Btn_Click(object sender, RoutedEventArgs e)
        {
            advancePayment.Name = Name_Txt.Text;
            var result = iAdvancePayment.InsertAdvancePayment(advancePayment);
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
            advancePayment.Name = Name_Txt.Text;
            int Id = Convert.ToInt16(IdAP_Txt.Text);
            var result = iAdvancePayment.UpdateAdvancePayment(Id, advancePayment);
            if (result)
            {
                MessageBox.Show("Update Success");
                dataGridAdvancePayment.ItemsSource = iAdvancePayment.get();
            }
            else
            {
                MessageBox.Show("Update Failed");
            }
        }

        private void Delete_Btn_Click(object sender, RoutedEventArgs e)
        {
            int Id = Convert.ToInt16(IdAP_Txt.Text);
            var result = iAdvancePayment.DeleteAdvancePayment(Id);
            if (result)
            {
                MessageBox.Show("Delete Success");
                dataGridAdvancePayment.ItemsSource = iAdvancePayment.get();
            }
            else
            {
                MessageBox.Show("Delete Failed");
            }
        }
    }
}
