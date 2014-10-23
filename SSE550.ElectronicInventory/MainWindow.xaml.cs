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
using SSE550.ElectronicInventory.Classes;
using SSE550.ElectronicInventory.Interfaces;

namespace SSE550.ElectronicInventory
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>    
    public partial class MainWindow : Window
    {
        List<Electronic> Inventory = new List<Electronic>();
        List<Electronic> Matches = new List<Electronic>();
        
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


            ElectronicGroomer razor = new ElectronicGroomer();
            razor.Brand = "Phillips Norelco Shaver";
            razor.Model = "PT724/41";
            razor.Price = 39.95M;
            razor.Condition = "new";
            Inventory.Add(razor);

            Cellphone metro = new Cellphone();
            metro.Brand = "Samsung Admire";
            metro.Model = "SCH-R720";
            metro.Price = 39.99M;
            metro.Condition = "used";
            metro.service_provider = "Metro PCS";
            Inventory.Add(metro);
            
            
            //Powering On All Devices
            foreach (Electronic device in Inventory)
            ResultsBox.Items.Add(device.powerOn());
            
            //Performing a Phone Call on capable devices
            foreach (Electronic device in Inventory)
            {
                if (device is ICall)
                    ResultsBox.Items.Add((device as ICall).call(7703458888));
            }           

            //Powering Off all Devices
            foreach (Electronic device in Inventory)
            ResultsBox.Items.Add(device.powerOff());
                        
            //Charging devices that are chargeable                        
            foreach (Electronic device in Inventory)
            {
                if(device is ICharge)
                ResultsBox.Items.Add((device as ICharge).charge(3));                
            }
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
            foreach (Electronic device in Inventory)
            {
                
                if ( (BrandBox.Text.CompareTo(device.Brand) == 0)||( ConditionBox.Text.CompareTo(device.Condition)== 0)||( device.findFeature(FeatureBox.Text) ) )
                    Matches.Add(device);                
            }

            foreach (Electronic device in Matches)
                ResultsBox.Items.Add(device.Brand + ":" + device.Model + ":" + device.Price.ToString("c"));

            Matches.Clear();
            
        }
    }
}
