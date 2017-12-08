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
using Excel = Microsoft.Office.Interop.Excel;

namespace TPvorbereitung
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Data nd = new Data();
        public MainWindow()
        {
            InitializeComponent();
            
        }
  

        private void ExportButton_Click(object sender, RoutedEventArgs e)
        {
            //Export Data from Textboxes into a .xlsx
            
            //Declare variables

            List<string> lst_names = nd.Datanames;
            List<long> lst_data = nd.LongData;

            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.Application();
            xlApp.Visible = true;
            xlWorkBook = xlApp.Workbooks.Add(misValue);

            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            
            for(int x = 1; x < lst_names.Capacity; x++)
            {
                xlWorkSheet.Cells[x, 1] = lst_names[x - 1];
                xlWorkSheet.Cells[x, 2] = lst_data[x - 1];
            }

        }

        private void DisplayButton_Click(object sender, RoutedEventArgs e)
        {
           
           List<string> lst_names = nd.Datanames;
           List<long> lst_data = nd.LongData;
            // DG.ItemsSource = lst_names;

            //Fill a Collection with Data

            ObservableCollection<Item> users = new ObservableCollection<Item>();

            for (int i = 0; i < lst_names.Capacity-1; i++)
            {
                users.Add(new Item { Kostenstelle = lst_names[i], Betrag = lst_data[i] });
            }
            //Display the Data in the Datagrid DG

            DG.ItemsSource = users;


        }
      
        
        
    }
}
