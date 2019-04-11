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
    /// Interaction logic for TravelRequestForm.xaml
    /// </summary>
    public partial class TravelRequestForm : Window
    {
        static MyContext myContext = new MyContext();
        ITravelRequest iTravelRequest = new TravelRequestController();
        TB_M_TravelRequest travelRequest = new TB_M_TravelRequest();
        public TravelRequestForm()
        {
            InitializeComponent();
        }

        //private void Submit_Btn_Click(object sender, RoutedEventArgs e)
        //{
        //    travelRequest.Notes = NameItem_Txt.Text;
        //    int Id = Convert.ToInt32(Supplier_CB.SelectedValue);
        //    var getSupplier = myContext.TB_M_Suppliers.Find(Id);
        //    item.Price = Convert.ToInt32(Price_Txt.Text);
        //    item.Stock = Convert.ToInt32(Stock_Txt.Text);
        //    item.TB_M_Suppliers = getSupplier;
        //    //item.TB_M_Suppliers = iSupplier.get(Convert.ToInt32(Supplier_CB.SelectedValue));

        //    var result = iTravelRequest.InsertTravelRequest(travelRequest);
        //    if (result)
        //    {
        //        MessageBox.Show("Insert Success");
        //        NameItem_Txt.Text = "";
        //        Price_Txt.Text = "";
        //        Stock_Txt.Text = "";
        //        dataGridItem.ItemsSource = iItem.get();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Failed");
        //        NameItem_Txt.Text = "";
        //    }
        //    //myContext.TB_M_Items.Add(item);
        //    //myContext.SaveChanges();
        //}

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }
    }
}
