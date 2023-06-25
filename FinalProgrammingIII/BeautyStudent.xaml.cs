using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MyClassLibrary;

namespace FinalProgrammingIII
{
    /// <summary>
    /// Interaction logic for BeautyStudent.xaml
    /// </summary>
    public partial class BeautyStudent : Window
    {
        List<Transactions> transaction = new List<Transactions>(); //Declared in Beauty Student Window. 
        Transactions costAction = new Transactions();
        
        

        const string filePath = "Transaction.csv";
        public BeautyStudent()
        {
            InitializeComponent();


        }
        private void CreateNewFile(string filePath)
        {
            FileStream tryout = File.OpenWrite(filePath);
            tryout.Close();
            tryout.Dispose(); 
        }
        public void UpdateListView()
        {
            

            string name = txtUpageName.Text;
            string cost = txtUpagePrice.Text;
            decimal price = decimal.Parse(txtUpagePrice.Text);

            name = costAction.Name;
            price = costAction.Price; 
        
            transaction.Add(new Transactions(name, price));

            LVUser.ItemsSource = transaction;

          


        }
        public void WriteTransaction(string filePath)
        {

        }
        public List<T>ReadTransaction<T>(string filePath)
        {
            List<T> tList = new List<T>(); 

            using (StreamReader sr = new StreamReader(filePath))
            using (CsvReader csv = new CsvReader(sr, CultureInfo.InvariantCulture))
            {

                tList = csv.GetRecords<T>().ToList(); //implementing the Transaciton(generic) into GetRecords which means it grabs all records adn implement into the CSV 
            }

            return tList;   
        }

        private void btnSortName_Click(object sender, RoutedEventArgs e)
        {
            Transactions _transactions = new MyClassLibrary.Transactions(); 
            _transactions.CompareTo(_transactions);
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UpdateListView();
           
            Data.userTransactions();
        }



        //private void CreateNewFile(string filePath) // Used to create a file on load to guarantee a file exists. Use on page load.
        //{
        //    FileStream tryout = File.OpenWrite(filePath);
        //    tryout.Close();
        //    tryout.Dispose();
        //}

        //public void UpdateListView() // Updates the listview

        //public void WriteTransactions(string filePath) // When called saves transaction list to the users csv

        //public void ReadTransactions() // Loads the users specific csv
    }
}
