using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    internal class Transaction_Time_Sorter : IComparer<Transactions>
    {
        public int Compare(Transactions? x, Transactions? y )//Comparing transaction times 
        {
            return x.TransactionTime.CompareTo(y.TransactionTime);
        }
    }
}
