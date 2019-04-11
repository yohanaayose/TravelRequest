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
    /// Interaction logic for ProvinceForm.xaml
    /// </summary>
    public partial class ProvinceForm : Window
    {
        static MyContext myContext = new MyContext();
        IProvince iProvince = new ProvinceController();
        TB_M_Province province = new TB_M_Province();
        public ProvinceForm()
        {
            InitializeComponent();
        }

        private void Save_Btn_Click(object sender, RoutedEventArgs e)
        {
            province.Name = Name_Txt.Text;
            var result = iProvince.InsertProvince(province);
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dataGridProvince.ItemsSource = iProvince.get();
        }

        private void Edit_Btn_Click(object sender, RoutedEventArgs e)
        {
            province.Name = Name_Txt.Text;
            int Id = Convert.ToInt16(IdProvince_Txt.Text);
            var result = iProvince.UpdateProvince(Id, province);
            if (result)
            {
                MessageBox.Show("Update Success");
                dataGridProvince.ItemsSource = iProvince.get();
            }
            else
            {
                MessageBox.Show("Update Failed");
            }
        }

        private void Delete_Btn_Click(object sender, RoutedEventArgs e)
        {
            int Id = Convert.ToInt16(IdProvince_Txt.Text);
            var result = iProvince.DeleteProvince(Id);
            if (result)
            {
                MessageBox.Show("Delete Success");
                dataGridProvince.ItemsSource = iProvince.get();
            }
            else
            {
                MessageBox.Show("Delete Failed");
            }
        }

        private void dataGridProvince_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            object selectedItem = dataGridProvince.SelectedItem;
            if (selectedItem != null)
            {
                IdProvince_Txt.Text = (dataGridProvince.SelectedCells[0].Column.GetCellContent(selectedItem) as TextBlock).Text;
                Name_Txt.Text = (dataGridProvince.SelectedCells[1].Column.GetCellContent(selectedItem) as TextBlock).Text;
            }
        }
    }
}
