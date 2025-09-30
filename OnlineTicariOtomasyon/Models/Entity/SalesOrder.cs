using System.ComponentModel.DataAnnotations;

namespace OnlineTicariOtomasyon.Models.Entity
{
    public class SalesOrder
    {
        [Key]
        public int SalesOrderId { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Price { get; set; }
        public decimal TotalAmount { get; set; }

        public ICollection<Product> Products { get; set; }
        public ICollection<Current> Currents { get; set; }
        public ICollection<Employee> Employees { get; set; }

    }
}
