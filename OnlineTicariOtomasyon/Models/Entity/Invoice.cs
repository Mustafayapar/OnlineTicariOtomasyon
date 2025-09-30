using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineTicariOtomasyon.Models.Entity
{
    public class Invoice
    {
        [Key]
        public int InvoiceId { get; set; }


        [Column(TypeName = "Varchar")]
        [StringLength(3)]
        public string SerialNumber { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(7)]
        public string SequenceNumber { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string TaxOffice { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string DeliveredBy { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string ReceivedBy { get; set; }

        public ICollection<InvoiceItem> InvoiceItems { get; set; }

    }
}
