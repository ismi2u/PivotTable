using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PivotTable
{
    public class InvoiceService
    {

        public List<InvoiceModel> GetInvoices ()
        {
            return new List<InvoiceModel>()
            {
                new InvoiceModel() {InvoiceNumber=1, Amount=10, CostCategory="testing", Period="2019_11"},
                new InvoiceModel() {InvoiceNumber=2, Amount=20, CostCategory="sales2", Period="2019_11"},
                new InvoiceModel() {InvoiceNumber=3, Amount=30, CostCategory="testing", Period="2019_12"},
                new InvoiceModel() {InvoiceNumber=4, Amount=40, CostCategory="sales4", Period="2019_12"},
                new InvoiceModel() {InvoiceNumber=5, Amount=10, CostCategory="sales2", Period="2019_11"},
                new InvoiceModel() {InvoiceNumber=6, Amount=20, CostCategory="testing", Period="2019_11"},
                new InvoiceModel() {InvoiceNumber=7, Amount=30, CostCategory="utilitis", Period="2019_12"},
                new InvoiceModel() {InvoiceNumber=8, Amount=40, CostCategory="utilitis", Period="2019_12"}
            };

        }

    }
}
