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
    /// Interaction logic for PurposeForm.xaml
    /// </summary>
    public partial class PurposeForm : Window
    {
        static MyContext myContext = new MyContext();
        IPurpose iPurpose = new PurposeController();
        TB_M_Purpose purpose = new TB_M_Purpose();
        public PurposeForm()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dataGridPurpose.ItemsSource = iPurpose.get();
        }

        private void dataGridPurpose_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            object selectedItem = dataGridPurpose.SelectedItem;
            if (selectedItem != null)
            {
                IdPurpose_Txt.Text = (dataGridPurpose.SelectedCells[0].Column.GetCellContent(selectedItem) as TextBlock).Text;
                Name_Txt.Text = (dataGridPurpose.SelectedCells[1].Column.GetCellContent(selectedItem) as TextBlock).Text;
            }
        }

        private void Add_Btn_Click(object sender, RoutedEventArgs e)
        {
            purpose.Name = Name_Txt.Text;
            var result = iPurpose.InsertPurpose(purpose);
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
            purpose.Name = Name_Txt.Text;
            int Id = Convert.ToInt16(IdPurpose_Txt.Text);
            var result = iPurpose.UpdatePurpose(Id, purpose);
            if (result)
            {
                MessageBox.Show("Update Success");
                dataGridPurpose.ItemsSource = iPurpose.get();
            }
            else
            {
                MessageBox.Show("Update Failed");
            }
        }

        private void Delete_Btn_Click(object sender, RoutedEventArgs e)
        {
            int Id = Convert.ToInt16(IdPurpose_Txt.Text);
            var result = iPurpose.DeletePurpose(Id);
            if (result)
            {
                MessageBox.Show("Delete Success");
                dataGridPurpose.ItemsSource = iPurpose.get();
            }
            else
            {
                MessageBox.Show("Delete Failed");
            }
        }
    }
}
