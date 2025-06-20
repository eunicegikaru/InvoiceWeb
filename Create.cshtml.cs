using InvoiceApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InvoiceApp.Pages.Invoices
{
    [BindProperties]
    public class CreateModel : PageModel
    {
       
        public InvoiceDto InvoiceDto { get; set; } = new();
        public void OnGet()
        {
        }
    }
}
