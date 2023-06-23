using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    internal class Transactions : IComparable<Transactions>
    {
        // Fields and properties for all

        DateTime _transactionTime;
        string _name;
        decimal _price;
        decimal _tax;
        decimal _total;

        // Constructor

        public Transactions()
        {

        } 

        public Transactions(string name, decimal price)
        {
            _name = name;
            _price = price;
        }

        public DateTime TransactionTime { get => _transactionTime; set => _transactionTime = value; }
        public string Name { get => _name; set => _name = value; }
        public decimal Price { get => _price; set => _price = value; }
        public decimal Tax { get => _tax; set => _tax = value; }
        public decimal Total { get => _total; set => _total = value; }

        public int CompareTo(Transactions other)
        {
            int nameCompare= string.Compare(Name, other.Name); //Aiming to transition our string to an int. .COMPARE compares two string objects & returns it's value into an integer 

            if (nameCompare == 0)
            {
                return 1; 
            }
            return -1; 

        }

        // CompareTo should be for names
    }
}
