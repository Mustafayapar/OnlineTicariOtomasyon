using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineTicariOtomasyon.Models.Entity
{
    public class Expense
    {
        [Key]
        public int ExpenseId { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
