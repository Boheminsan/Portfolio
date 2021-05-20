using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Entity
{
    public enum CategoryType
    {
        Lang = 1, Tech = 2
    }
    public class Category
    {
        public int CategoryId { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "20 karakterden uzun bir başlık girdiniz.")]
        public string CategoryName { get; set; }

        [Required]
        public CategoryType CType { get; set; }

        [Required]
        [StringLength(8, ErrorMessage = "Filtre 8 karakterden uzun olamaz.")]
        public string Filter { get; set; }
        public List<Project> Projects { get; set; }

    }
}