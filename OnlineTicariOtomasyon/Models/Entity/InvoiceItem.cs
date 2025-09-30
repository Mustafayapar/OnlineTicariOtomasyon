using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineTicariOtomasyon.Models.Entity
{
    public class InvoiceItem
    {
        [Key]
        public int InvoiceItemId { get; set; }


        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }

        public Invoice Invoice { get; set; }
    }
}
