using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class CashierSales(string cashierName, double sales)
    {
        public string CashierName { get; set; } = cashierName;
        public double Sales { get; set; } = sales;
    }
}