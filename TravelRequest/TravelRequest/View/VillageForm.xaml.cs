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
    /// Interaction logic for VillageForm.xaml
    /// </summary>
    public partial class VillageForm : Window
    {
        static MyContext myContext = new MyContext();
        IVillage iVillage = new VillageController();
        TB_M_Village village = new TB_M_Village();
        ISubDistrict iSubDistrict = new SubDistrictController(myContext);
        public VillageForm()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dataGridVillage.ItemsSource = iVillage.get();
            List<TB_M_SubDistrict> TB_M_SubDistrict = iSubDistrict.get();
            SubDistrictId_Cmb.ItemsSource = TB_M_SubDistrict;
        }

        private void dataGridVillage_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            object selectedItem = dataGridVillage.SelectedItem;
            if (selectedItem != null)
            {
                IdVillage_Txt.Text = (dataGridVillage.SelectedCells[0].Column.GetCellContent(selectedItem) as TextBlock).Text;
                Name_Txt.Text = (dataGridVillage.SelectedCells[1].Column.GetCellContent(selectedItem) as TextBlock).Text;
                SubDistrictId_Cmb.Text = (dataGridVillage.SelectedCells[2].Column.GetCellContent(selectedItem) as TextBlock).Text;
            }
        }

        private void Add_Btn_Click(object sender, RoutedEventArgs e)
        {
            village.Name = Name_Txt.Text;
            int Id = Convert.ToInt32(SubDistrictId_Cmb.SelectedValue);
            var getVillage = myContext.TB_M_SubDistricts.Find(Id);
            village.TB_M_SubDistricts = getVillage;
            myContext.TB_M_Villages.Add(village);
            var result = myContext.SaveChanges();
            if (result >0)
            {
                MessageBox.Show("Insert Success");
                Name_Txt.Text = "";
                dataGridVillage.ItemsSource = iVillage.get();
            }
            else
            {
                MessageBox.Show("Failed");
                Name_Txt.Text = "";
            }
        }

        private void Edit_Btn_Click(object sender, RoutedEventArgs e)
        {
            village.Name = Name_Txt.Text;
            int Id = Convert.ToInt16(IdVillage_Txt.Text);
            var result = iVillage.UpdateVillage(Id, village);
            if (result)
            {
                MessageBox.Show("Update Success");
                dataGridVillage.ItemsSource = iVillage.get();
            }
            else
            {
                MessageBox.Show("Update Failed");
            }
        }

        private void Delete_Btn_Click(object sender, RoutedEventArgs e)
        {
            int Id = Convert.ToInt16(IdVillage_Txt.Text);
            var result = iVillage.DeleteVillage(Id);
            if (result)
            {
                MessageBox.Show("Delete Success");
                dataGridVillage.ItemsSource = iVillage.get();
            }
            else
            {
                MessageBox.Show("Delete Failed");
            }
        }
    }
}
