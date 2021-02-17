using FinalAppBeforeJS.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FinalAppBeforeJS.ViewModels.Admin
{
    public class CreateNewsViewModel
    {
        [Required(ErrorMessage = "Требуется ввести заголовок новости")]
        [Display(Name = "Заголовок новости")]
        [StringLength(256, ErrorMessage = "Длина строки не соответствует параметрам от {2} до {1}", MinimumLength = 4)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Требуется ввести содержание новости")]
        [Display(Name = "Содержание новости")]
        [StringLength(5000, ErrorMessage = "Длина строки не соответствует параметрам от {2} до {1}", MinimumLength = 4)]
        public string Body { get; set; }
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Выберите категорию")]
        [Display(Name = "Категория новости")]
        public Guid CategoryId { get; set; }

        public SelectList Categories { get; set; }
    }
}
