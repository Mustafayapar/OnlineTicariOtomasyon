using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineTicariOtomasyon.Models.Entity
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string FirstName { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string LastName { get; set; }

        //public string Address { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string Image { get; set; }
        public bool Status { get; set; }

        public SalesOrder SalesOrder { get; set; }

        public Department Department { get; set; }
    }
}
   