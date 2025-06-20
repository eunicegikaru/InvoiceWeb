using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace InvoiceApp.Models
{
    public class InvoiceDto
    {
        [Required]
        public string Number { get; set; } = "";
        [Required]
        public string Status { get; set; } = "";
        public DateOnly? IssueDate { get; set; }
        public DateOnly? DueDate { get; set; }

        [Required]
        //Service
        public string Service { get; set; } = "";
        [Precision(16, 2)]
        public decimal UnitPrice { get; set; }
        [Range (1,99)]
        public int Quantity { get; set; }

        [Required(ErrorMessage ="ClientName is Requred")]
        public string ClientName { get; set; } = "";
        [Required,EmailAddress]
        public string Email { get; set; } = "";
        [Phone]
        public string Phone { get; set; } = "";
        public string Address { get; set; } = "";
    }
}
