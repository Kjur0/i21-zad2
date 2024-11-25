using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace i21_zad2
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<AnimalRecord> AnimalRecords { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            AnimalRecords = new ObservableCollection<AnimalRecord>();
            AnimalDataGrid.ItemsSource = AnimalRecords;

            AnimalRecords.Add(new AnimalRecord("Pies", "Technikum", "TM1", "3TC", 100));
            AnimalRecords.Add(new AnimalRecord("Kot", "Liceum", "LXXX LO", "3LA", 50));
        }

        private void DataGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Delete)
            {
                var selectedItem = AnimalDataGrid.SelectedItem as AnimalRecord;
                if (selectedItem != null) AnimalRecords.Remove(selectedItem);
            }
        }

        private void AddNewRecord(object sender, RoutedEventArgs e)
        {
            AnimalRecords.Add(new AnimalRecord());
        }
    }
}
