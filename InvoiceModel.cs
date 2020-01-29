using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PivotTable
{
    public class InvoiceModel
    {
        public int InvoiceNumber { get; set; }
        public double Amount { get; set; }
        public string CostCategory { get; set; }

        public string Period { get; set; }
    }
}
