using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineTicariOtomasyon.Models.Entity
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(15)]
        public string Username { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Password { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string Role { get; set; }

    }
}
