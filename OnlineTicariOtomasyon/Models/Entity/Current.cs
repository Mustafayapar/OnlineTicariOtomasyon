using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineTicariOtomasyon.Models.Entity
{
    public class Current
    {
        [Key]
        public int CurrentId { get; set; }


        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string FirstName { get; set; }


        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string LastName { get; set; }


        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string Email { get; set; }


        [Column(TypeName = "Varchar")]
        [StringLength(15)]
        public string City { get; set; }
        public SalesOrder SalesOrder { get; set; }



    
    }
}
