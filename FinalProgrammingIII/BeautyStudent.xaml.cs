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

namespace FinalProgrammingIII
{
    /// <summary>
    /// Interaction logic for BeautyStudent.xaml
    /// </summary>
    public partial class BeautyStudent : Window
    {
        List<Transaction> transactions = new List<Transaction>(); //Declared in Beauty Student Window. 

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
