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

namespace TravelRequest.View
{
    /// <summary>
    /// Interaction logic for UserForm.xaml
    /// </summary>
    public partial class UserForm : Window
    {
        static MyContext myContext = new MyContext();
        IDistrict iDistrict = new DistrictController();
        TB_M_District district = new TB_M_District();
        IProvince iProvince = new ProvinceController();
        public UserForm()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dataGridDistrict.ItemsSource = iDistrict.get();
            List<TB_M_Province> TB_M_Province_Id = iProvince.get();//myContext.TB_M_Provinces.ToList();
            Province_Cmb.ItemsSource = TB_M_Province_Id;
        }

        private void dataUser_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            object selectedItem = dataGridDistrict.SelectedItem;
            if (selectedItem != null)
            {
                IdDistrict_Txt.Text = (dataGridDistrict.SelectedCells[0].Column.GetCellContent(selectedItem) as TextBlock).Text;
                Name_Txt.Text = (dataGridDistrict.SelectedCells[1].Column.GetCellContent(selectedItem) as TextBlock).Text;
                Province_Cmb.Text = (dataGridDistrict.SelectedCells[2].Column.GetCellContent(selectedItem) as TextBlock).Text;
            }
        }

        private void AddUser_btn_Click(object sender, RoutedEventArgs e)
        {
            district.Name = Name_Txt.Text;
            int Id = Convert.ToInt32(Province_Cmb.SelectedValue);
            var getDistrict = myContext.TB_M_Provinces.Find(Id);
            district.TB_M_Provinces = getDistrict;
            /*iDistrict.InsertDistrict*/
            myContext.TB_M_Districts.Add(district);
            var result = myContext.SaveChanges();
            if (result > 0)
            {
                MessageBox.Show("Insert Success");
                Name_Txt.Text = "";
                dataGridDistrict.ItemsSource = iDistrict.get();
            }
            else
            {
                MessageBox.Show("Failed");
                Name_Txt.Text = "";
            }
        }

        private void EditUser_btn_Click(object sender, RoutedEventArgs e)
        {
            district.Name = Name_Txt.Text;
            int Id = Convert.ToInt16(IdDistrict_Txt.Text);
            var result = iDistrict.UpdateDistrict(Id, district);
            if (result)
            {
                MessageBox.Show("Update Success");
                dataGridDistrict.ItemsSource = iDistrict.get();
            }
            else
            {
                MessageBox.Show("Update Failed");
            }
        }

        private void DeleteUser_Click(object sender, RoutedEventArgs e)
        {

            int Id = Convert.ToInt16(IdDistrict_Txt.Text);
            var result = iDistrict.DeleteDistrict(Id);
            if (result)
            {
                MessageBox.Show("Delete Success");
                dataGridDistrict.ItemsSource = iDistrict.get();
            }
            else
            {
                MessageBox.Show("Delete Failed");
            }
        }
    }
}
