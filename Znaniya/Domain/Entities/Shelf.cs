using System.ComponentModel.DataAnnotations;


namespace Znaniya.Domain.Entities
{
    public class Shelf : EntityBase
    {
        [Required]
        public Guid ShelfID { get; set; }

        [Required(ErrorMessage = "Заполните название полки")]
        [Display(Name = "Название полки")]
        public override string? Title { get; set; }

        [Display(Name = "Полное описание полки")]
        public override string? Text { get; set; }
        
        public ICollection<Book> Books { get; set; }
    }
}
