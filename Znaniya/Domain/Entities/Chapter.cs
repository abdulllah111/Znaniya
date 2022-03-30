﻿using System.ComponentModel.DataAnnotations;

namespace Znaniya.Domain.Entities
{
    public class Chapter : EntityBase
    {
        [Required]
        public Guid ChapterId { get; set; }
        public Guid BookID { get; set; }

        [Required(ErrorMessage = "Заполните название ukfds")]
        [Display(Name = "Название книги")]
        public override string? Title { get; set; }

        [Display(Name = "Полное описание книги")]
        public override string? Text { get; set; }

        public Book? Book { get; set; }
        public ICollection<Page>? Pages { get; set; }
    }
}
