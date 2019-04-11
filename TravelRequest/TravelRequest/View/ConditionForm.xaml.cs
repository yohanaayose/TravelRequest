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
    /// Interaction logic for ConditionForm.xaml
    /// </summary>
    public partial class ConditionForm : Window
    {
        static MyContext myContext = new MyContext();
        ICondition iCondition = new ConditionController();
        TB_M_Condition condition = new TB_M_Condition();
        IPurpose iPurpose = new PurposeController();
        public ConditionForm()
        {
            InitializeComponent();
        }

        private void dataGridCondition_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            object selectedItem = dataGridCondition.SelectedItem;
            if (selectedItem != null)
            {
                IdC_Txt.Text = (dataGridCondition.SelectedCells[0].Column.GetCellContent(selectedItem) as TextBlock).Text;
                Name_Txt.Text = (dataGridCondition.SelectedCells[1].Column.GetCellContent(selectedItem) as TextBlock).Text;
                Purpose_Cmb.Text = (dataGridCondition.SelectedCells[2].Column.GetCellContent(selectedItem) as TextBlock).Text;
            }
        }

        private void Add_Btn_Click(object sender, RoutedEventArgs e)
        {
            condition.Name = Name_Txt.Text;
            int Id = Convert.ToInt32(Purpose_Cmb.SelectedValue);
            var getCondition = myContext.TB_M_Purposes.Find(Id);
            condition.TB_M_Puposes = getCondition;
            /*iDistrict.InsertDistrict*/
            myContext.TB_M_Conditions.Add(condition);
            var result = myContext.SaveChanges();
            if (result >0 )
            {
                MessageBox.Show("Insert Success");
                Name_Txt.Text = "";
                dataGridCondition.ItemsSource = iCondition.get();
            }
            else
            {
                MessageBox.Show("Failed");
                Name_Txt.Text = "";
            }
        }

        private void Edit_Btn_Click(object sender, RoutedEventArgs e)
        {
            condition.Name = Name_Txt.Text;
            int Id = Convert.ToInt16(IdC_Txt.Text);
            var result = iCondition.UpdateCondition(Id, condition);
            if (result)
            {
                MessageBox.Show("Update Success");
                dataGridCondition.ItemsSource = iCondition.get();
            }
            else
            {
                MessageBox.Show("Update Failed");
            }
        }

        private void Delete_Btn_Click(object sender, RoutedEventArgs e)
        {
            int Id = Convert.ToInt16(IdC_Txt.Text);
            var result = iCondition.DeleteCodition(Id);
            if (result)
            {
                MessageBox.Show("Delete Success");
                dataGridCondition.ItemsSource = iCondition.get();
            }
            else
            {
                MessageBox.Show("Delete Failed");
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dataGridCondition.ItemsSource = iCondition.get();
            List<TB_M_Purpose> TB_M_Purposes_Id = iPurpose.get();//myContext.TB_M_Provinces.ToList();
            Purpose_Cmb.ItemsSource = TB_M_Purposes_Id;
        }
    }
}
