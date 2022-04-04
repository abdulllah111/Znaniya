using System.ComponentModel.DataAnnotations;

namespace Znaniya.Domain.Entities
{
    public abstract class EntityBase
    {
        

        [Display(Name = "Название (заголовок)")]
        public virtual string? Title { get; set; }

        [Display(Name = "Полное описание")]
        public virtual string? Text { get; set; }

        [Display(Name = "Краткое описание")]
        public virtual string? SubText { get; set; }

        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }
    }
}
