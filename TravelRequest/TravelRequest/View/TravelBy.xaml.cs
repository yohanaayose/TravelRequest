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
    /// Interaction logic for TravelBy.xaml
    /// </summary>
    public partial class TravelBy : Window
    {
        static MyContext myContext = new MyContext();
        ITravelBy iTravelBy = new TravelByController();
        TB_M_TravelBy travleBy = new TB_M_TravelBy();
        public TravelBy()
        {
            InitializeComponent();
        }

        private void dataGridTravelBy_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            object selectedItem = dataGridTravelBy.SelectedItem;
            if (selectedItem != null)
            {
                IdTravelBy_Txt.Text = (dataGridTravelBy.SelectedCells[0].Column.GetCellContent(selectedItem) as TextBlock).Text;
                Name_Txt.Text = (dataGridTravelBy.SelectedCells[1].Column.GetCellContent(selectedItem) as TextBlock).Text;
            }
        }

        private void Add_Btn_Click(object sender, RoutedEventArgs e)
        {
            travleBy.Name = Name_Txt.Text;
            var result = iTravelBy.InsertTravelBy(travleBy);
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
            travleBy.Name = Name_Txt.Text;
            int Id = Convert.ToInt16(IdTravelBy_Txt.Text);
            var result = iTravelBy.UpdateTravelBy (Id, travleBy);
            if (result)
            {
                MessageBox.Show("Update Success");
                dataGridTravelBy.ItemsSource = iTravelBy.get();
            }
            else
            {
                MessageBox.Show("Update Failed");
            }
        }

        private void Delete_Btn_Click(object sender, RoutedEventArgs e)
        {
            int Id = Convert.ToInt16(IdTravelBy_Txt.Text);
            var result = iTravelBy.DeleteTravelBy(Id);
            if (result)
            {
                MessageBox.Show("Delete Success");
                dataGridTravelBy.ItemsSource = iTravelBy.get();
            }
            else
            {
                MessageBox.Show("Delete Failed");
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dataGridTravelBy.ItemsSource = iTravelBy.get();
        }
    }
}
