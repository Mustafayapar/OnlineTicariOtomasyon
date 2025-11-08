using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineTicariOtomasyon.Models.Entity
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Kategori adı boş bırakılamaz!")]
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string CategoryName { get; set; }

        [ValidateNever]
        public ICollection<Product> Products { get; set; }


    }
}
