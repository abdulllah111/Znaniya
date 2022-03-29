using System.ComponentModel.DataAnnotations;

namespace Znaniya.Domain.Entities
{
    public class Book : EntityBase
    {
        [Required]
        public Guid BookID { get; set; }
        public Guid ShelfID { get; set; }

        [Required(ErrorMessage = "Заполните название книги")]
        [Display(Name = "Название книги")]
        public override string? Title { get; set; }

        [Display(Name = "Полное описание книги")]
        public override string? Text { get; set; }

        public Shelf Shelf { get; set; }
        public ICollection<Chapter> Chapters { get; set; }
    }
}
