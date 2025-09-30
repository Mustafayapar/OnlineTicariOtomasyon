using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineTicariOtomasyon.Models.Entity
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string DepartmentName { get; set; }

        public ICollection<Employee> Employees { get; set; }

    }
}
