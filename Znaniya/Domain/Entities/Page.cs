using System.ComponentModel.DataAnnotations;

namespace Znaniya.Domain.Entities
{
    public class Page : EntityBase
    {
        [Required]
        public Guid PageID { get; set; }
        public Guid ChapterID { get; set; }

        [Required(ErrorMessage = "Заполните название ukfds")]
        [Display(Name = "Название книги")]
        public override string? Title { get; set; }

        [Display(Name = "Полное описание книги")]
        public override string? Text { get; set; }

        public Chapter? Chapter { get; set; }
    }
}
