using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace PivotTable.Pages
{
    public class IndexModel : PageModel
    {
        private readonly InvoiceService _invoiceService;

        public List<InvoiceModel> InvoiceList;

        public IndexModel(InvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }
        public void OnGet()
        {
            InvoiceList = _invoiceService.GetInvoices();
        }

        public JsonResult OnGetInvoicePivotData()
        {
            InvoiceList = _invoiceService.GetInvoices();

            return new JsonResult(InvoiceList);
        }
    }
}
