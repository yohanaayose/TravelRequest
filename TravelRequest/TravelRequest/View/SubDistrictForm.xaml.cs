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
    /// Interaction logic for SubDistrictForm.xaml
    /// </summary>
    public partial class SubDistrictForm : Window
    {
        static MyContext myContext = new MyContext();
        ISubDistrict iSubDistrict = new SubDistrictController(myContext);
        TB_M_SubDistrict subDistrict = new TB_M_SubDistrict();
        IDistrict iDistrict = new DistrictController();
        public SubDistrictForm()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dataGridSubDistrict.ItemsSource = iSubDistrict.get();
            List<TB_M_District> TB_M_District_Id = iDistrict.get();
            DistrictId_Cmb.ItemsSource = TB_M_District_Id;
        }

        private void Add_Btn_Click(object sender, RoutedEventArgs e)
        {
            subDistrict.Name = Name_Txt.Text;
            int Id = Convert.ToInt32(DistrictId_Cmb.SelectedValue);
            var getSubDistrict = myContext.TB_M_Districts.Find(Id);
            //if(getDistrict != null)
            //{
                subDistrict.TB_M_Districts = getSubDistrict;
            //}
            var result = iSubDistrict.InsertSubDistrict(subDistrict);
            //myContext.TB_M_SubDistricts.Add(subDistrict);
            //var result = myContext.SaveChanges();
            if (result)
            {
                MessageBox.Show("Insert Success");
                Name_Txt.Text = "";
                dataGridSubDistrict.ItemsSource = iSubDistrict.get();
            }
            else
            {
                MessageBox.Show("Failed");
                Name_Txt.Text = "";
            }
        }

        private void Edit_Btn_Click(object sender, RoutedEventArgs e)
        {
            subDistrict.Name = Name_Txt.Text;
            int Id = Convert.ToInt16(IdSubDistrict_Txt.Text);
            var result = iSubDistrict.UpdateSubDistrict(Id, subDistrict);
            if (result)
            {
                MessageBox.Show("Update Success");
                dataGridSubDistrict.ItemsSource = iSubDistrict.get();
            }
            else
            {
                MessageBox.Show("Update Failed");
            }
        }

        private void Delete_Btn_Click(object sender, RoutedEventArgs e)
        {
            int Id = Convert.ToInt16(IdSubDistrict_Txt.Text);
            var result = iSubDistrict.DeleteSubDistrict(Id);
            if (result)
            {
                MessageBox.Show("Delete Success");
                dataGridSubDistrict.ItemsSource = iSubDistrict.get();
            }
            else
            {
                MessageBox.Show("Delete Failed");
            }
        }

        private void dataGridSubDistrict_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            object selectedItem = dataGridSubDistrict.SelectedItem;
            if (selectedItem != null)
            {
                IdSubDistrict_Txt.Text = (dataGridSubDistrict.SelectedCells[0].Column.GetCellContent(selectedItem) as TextBlock).Text;
                Name_Txt.Text = (dataGridSubDistrict.SelectedCells[1].Column.GetCellContent(selectedItem) as TextBlock).Text;
                DistrictId_Cmb.Text = (dataGridSubDistrict.SelectedCells[2].Column.GetCellContent(selectedItem) as TextBlock).Text;
            }
        }
    }
}
