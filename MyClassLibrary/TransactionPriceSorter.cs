using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    internal class TransactionPriceSorter : IComparer<Transactions>
    {
        public int Compare(Transactions? x, Transactions? y)
        {
            return x.Price.CompareTo(y.Price);
        }
    }
}
