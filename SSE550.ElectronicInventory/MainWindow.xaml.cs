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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SSE550.ElectronicInventory
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>    
    public partial class MainWindow : Window
    {
        List<Electronics> Inventory = new List<Electronics>();
        List<Electronics> Matches = new List<Electronics>();
        
        public MainWindow()
        {
            InitializeComponent();
            Test1();
        }

        public void Test1()
        {
            
            Television Westinghouse = new Television();
            Westinghouse.Brand = "Westinghouse";
            Westinghouse.Price = 200.00M;
            Westinghouse.Screen_size = 39.5F;
            Westinghouse.Technology = "LED";
            Westinghouse.Condition = "used";
            Westinghouse.Model = "UW40TA2W";
            Inventory.Add(Westinghouse);
            
            
            BluRayPlayer SamsungBD = new BluRayPlayer();
            SamsungBD.Brand = "Samsung";
            SamsungBD.Model = "BD-F5900";
            SamsungBD.Price = 127.99M;
            SamsungBD.Condition = "new";
            SamsungBD.addFeature("Smart");            
            Inventory.Add(SamsungBD);

            
            Laptop Acer = new Laptop();
            Acer.Brand = "Acer";
            Acer.Model = "4730z Aspire";
            Acer.Price = 250.00M;
            Acer.Condition = "new";
            Acer.addFeature("SSD");
            Inventory.Add(Acer);

            //Powering On All Devices
            ResultsBox.Items.Add(Westinghouse.powerOn());
            ResultsBox.Items.Add(SamsungBD.powerOn());
            ResultsBox.Items.Add(Acer.powerOn());
            
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ResultsBox.Items.Clear();            
            foreach (Electronics device in Inventory)
            {
                
                if ( (BrandBox.Text.CompareTo(device.Brand) == 0)||( ConditionBox.Text.CompareTo(device.Condition)== 0)||( device.findFeature(FeatureBox.Text) ) )
                    Matches.Add(device);                
            }

            foreach (Electronics device in Matches)
                ResultsBox.Items.Add(device.Brand + ":" + device.Model + ":" + device.Price.ToString("c"));

            Matches.Clear();
            
        }
    }
}
